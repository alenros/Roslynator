// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Composition;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslynator.CSharp;
using Roslynator.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using static Roslynator.CSharp.CSharpFactory;

namespace Roslynator.CodeAnalysis.CSharp
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(InvocationExpressionCodeFixProvider))]
    [Shared]
    public class InvocationExpressionCodeFixProvider : BaseCodeFixProvider
    {
        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(DiagnosticIdentifiers.UseElementAccess); }
        }

        public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            SyntaxNode root = await context.GetSyntaxRootAsync().ConfigureAwait(false);

            if (!TryFindFirstAncestorOrSelf(root, context.Span, out InvocationExpressionSyntax invocationExpression))
                return;

            Document document = context.Document;

            Diagnostic diagnostic = context.Diagnostics[0];

            CodeAction codeAction = CodeAction.Create(
                "Use [] instead of calling 'First'",
                ct => UseElementAccessinsteadOfCallingFirst(document, invocationExpression, ct),
                GetEquivalenceKey(diagnostic));

            context.RegisterCodeFix(codeAction, diagnostic);
        }

        private static Task<Document> UseElementAccessinsteadOfCallingFirst(
            Document document,
            InvocationExpressionSyntax invocationExpression,
            CancellationToken cancellationToken)
        {
            SimpleMemberInvocationExpressionInfo invocationInfo = SyntaxInfo.SimpleMemberInvocationExpressionInfo(invocationExpression);

            MemberAccessExpressionSyntax memberAccessExpression = invocationInfo.MemberAccessExpression;

            ArgumentListSyntax argumentList = invocationInfo.ArgumentList;

            SyntaxToken openParenToken = argumentList.OpenParenToken;
            SyntaxToken closeParenToken = argumentList.CloseParenToken;

            ElementAccessExpressionSyntax elementAccessExpression = ElementAccessExpression(
                invocationInfo.Expression.WithoutTrailingTrivia(),
                BracketedArgumentList(
                    Token(SyntaxTriviaList.Empty, SyntaxKind.OpenBracketToken, openParenToken.TrailingTrivia),
                    SingletonSeparatedList(Argument(NumericLiteralExpression(0))),
                    Token(closeParenToken.LeadingTrivia, SyntaxKind.CloseBracketToken, closeParenToken.TrailingTrivia)));

            return document.ReplaceNodeAsync(invocationExpression, elementAccessExpression, cancellationToken);
        }
    }
}
