// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Roslynator.CSharp.Syntax.SyntaxInfoHelpers;

namespace Roslynator.CSharp.Syntax
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    internal readonly struct IsKindExpressionInfo
    {
        private IsKindExpressionInfo(
            ExpressionSyntax isKindExpression,
            ExpressionSyntax expression,
            ExpressionSyntax kindExpression,
            IsKindExpressionStyle style)
        {
            IsKindExpression = isKindExpression;
            Expression = expression;
            KindExpression = kindExpression;
            Style = style;
        }

        public ExpressionSyntax IsKindExpression { get; }

        public ExpressionSyntax Expression { get; }

        public ExpressionSyntax KindExpression { get; }

        public IsKindExpressionStyle Style { get; }

        public bool Success => Style != IsKindExpressionStyle.None;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get
            {
                return (Success)
                    ? $"{GetType().Name} {Style} {IsKindExpression}"
                    : "Uninitialized";
            }
        }

        internal static IsKindExpressionInfo Create(
            SyntaxNode node,
            SemanticModel semanticModel,
            bool walkDownParentheses = true,
            bool allowMissing = false,
            CancellationToken cancellationToken = default)
        {
            ExpressionSyntax expression = WalkAndCheck(node, walkDownParentheses, allowMissing);

            if (expression == null)
                return default;

            SyntaxKind kind = expression.Kind();

            switch (kind)
            {
                case SyntaxKind.EqualsExpression:
                case SyntaxKind.NotEqualsExpression:
                    {
                        var binaryExpression = (BinaryExpressionSyntax)expression;

                        ExpressionSyntax left = WalkAndCheck(binaryExpression.Left, walkDownParentheses, allowMissing);

                        if (left == null)
                            break;

                        ExpressionSyntax right = WalkAndCheck(binaryExpression.Right, walkDownParentheses, allowMissing);

                        if (right == null)
                            break;

                        IsKindExpressionInfo info = Create(binaryExpression, kind, left, right, semanticModel, cancellationToken);

                        if (info.Success)
                        {
                            return info;
                        }
                        else
                        {
                            return Create(binaryExpression, kind, right, left, semanticModel, cancellationToken);
                        }
                    }
                case SyntaxKind.InvocationExpression:
                    {
                        return Create((InvocationExpressionSyntax)expression, semanticModel, IsKindExpressionStyle.IsKind, cancellationToken);
                    }
                case SyntaxKind.LogicalNotExpression:
                    {
                        var logicalNotExpression = (PrefixUnaryExpressionSyntax)expression;

                        ExpressionSyntax operand = WalkAndCheck(logicalNotExpression.Operand, walkDownParentheses, allowMissing);

                        return Create(operand as InvocationExpressionSyntax, semanticModel, IsKindExpressionStyle.NotIsKind, cancellationToken);
                    }
            }

            return default;
        }

        private static IsKindExpressionInfo Create(
            InvocationExpressionSyntax invocationExpression,
            SemanticModel semanticModel,
            IsKindExpressionStyle style,
            CancellationToken cancellationToken)
        {
            SimpleMemberInvocationExpressionInfo invocationInfo = SyntaxInfo.SimpleMemberInvocationExpressionInfo(invocationExpression);

            if (!invocationInfo.Success)
                return default;

            if (!IsIsKindMethod(invocationInfo.Name, semanticModel, cancellationToken))
                return default;

            return new IsKindExpressionInfo(invocationExpression, invocationInfo.Expression, invocationInfo.Arguments[0].Expression, style);
        }

        private static IsKindExpressionInfo Create(
            BinaryExpressionSyntax binaryExpression,
            SyntaxKind binaryExpressionKind,
            ExpressionSyntax expression1,
            ExpressionSyntax expression2,
            SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            switch (expression1.Kind())
            {
                case SyntaxKind.InvocationExpression:
                    {
                        var invocationExpression = (InvocationExpressionSyntax)expression1;

                        SimpleMemberInvocationExpressionInfo invocationInfo = SyntaxInfo.SimpleMemberInvocationExpressionInfo(invocationExpression);

                        if (!invocationInfo.Success)
                            break;

                        if (!IsKindMethod(invocationInfo.Name, semanticModel, cancellationToken))
                            break;

                        return new IsKindExpressionInfo(binaryExpression, invocationInfo.Expression, expression2, (binaryExpressionKind == SyntaxKind.EqualsExpression) ? IsKindExpressionStyle.Kind : IsKindExpressionStyle.NotKind);
                    }
                case SyntaxKind.ConditionalAccessExpression:
                    {
                        var conditionalAccess = (ConditionalAccessExpressionSyntax)expression1;

                        if (!(conditionalAccess.WhenNotNull is InvocationExpressionSyntax invocationExpression))
                            break;

                        if (!(invocationExpression.Expression is MemberBindingExpressionSyntax memberBindingExpression))
                            break;

                        if (expression2.IsKind(SyntaxKind.TrueLiteralExpression))
                        {
                            if (!IsIsKindMethod(memberBindingExpression.Name, semanticModel, cancellationToken))
                                break;

                            IsKindExpressionStyle style = (binaryExpressionKind == SyntaxKind.EqualsExpression) ? IsKindExpressionStyle.IsKindConditional : IsKindExpressionStyle.NotIsKindConditional;

                            return new IsKindExpressionInfo(binaryExpression, conditionalAccess.Expression, invocationExpression.ArgumentList.Arguments[0].Expression, style);
                        }
                        else
                        {
                            if (!IsKindMethod(memberBindingExpression.Name, semanticModel, cancellationToken))
                                break;

                            IsKindExpressionStyle style = (binaryExpressionKind == SyntaxKind.EqualsExpression) ? IsKindExpressionStyle.KindConditional : IsKindExpressionStyle.NotKindConditional;

                            return new IsKindExpressionInfo(binaryExpression, conditionalAccess.Expression, expression2, style);
                        }
                    }
            }

            return default;
        }

        private static bool IsKindMethod(
            ExpressionSyntax expression,
            SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            if (!(expression is IdentifierNameSyntax identifierName))
                return false;

            if (!string.Equals(identifierName.Identifier.ValueText, "Kind", StringComparison.Ordinal))
                return false;

            ISymbol symbol = semanticModel.GetSymbol(expression, cancellationToken);

            if (symbol?.Kind != SymbolKind.Method)
                return false;

            if (!symbol.ContainingType.HasMetadataName(RoslynMetadataNames.Microsoft_CodeAnalysis_CSharp_CSharpExtensions))
                return false;

            var methodSymbol = (IMethodSymbol)symbol;

            if (methodSymbol.MethodKind != MethodKind.ReducedExtension)
                return false;

            methodSymbol = methodSymbol.ReducedFrom;

            if (!methodSymbol.ReturnType.HasMetadataName(RoslynMetadataNames.Microsoft_CodeAnalysis_CSharp_SyntaxKind))
                return false;

            return methodSymbol
                .Parameters
                .SingleOrDefault(shouldThrow: false)?
                .Type
                .HasMetadataName(RoslynMetadataNames.Microsoft_CodeAnalysis_SyntaxNode) == true;
        }

        private static bool IsIsKindMethod(
            ExpressionSyntax expression,
            SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            if (!(expression is IdentifierNameSyntax identifierName))
                return false;

            if (!string.Equals(identifierName.Identifier.ValueText, "IsKind", StringComparison.Ordinal))
                return false;

            ISymbol symbol = semanticModel.GetSymbol(expression, cancellationToken);

            if (symbol?.Kind != SymbolKind.Method)
                return false;

            if (!symbol.ContainingType.HasMetadataName(RoslynMetadataNames.Microsoft_CodeAnalysis_CSharpExtensions))
                return false;

            var methodSymbol = (IMethodSymbol)symbol;

            if (methodSymbol.MethodKind != MethodKind.ReducedExtension)
                return false;

            methodSymbol = methodSymbol.ReducedFrom;

            if (methodSymbol.ReturnType.SpecialType != SpecialType.System_Boolean)
                return false;

            ImmutableArray<IParameterSymbol> parameters = methodSymbol.Parameters;

            if (parameters.Length != 2)
                return false;

            if (!parameters[0].Type.HasMetadataName(RoslynMetadataNames.Microsoft_CodeAnalysis_SyntaxNode))
                return false;

            if (!parameters[1].Type.HasMetadataName(RoslynMetadataNames.Microsoft_CodeAnalysis_CSharp_SyntaxKind))
                return false;

            return true;
        }
    }
}
