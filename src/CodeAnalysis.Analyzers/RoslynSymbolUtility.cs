// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Roslynator
{
    internal static class RoslynSymbolUtility
    {
        public static bool IsList(INamedTypeSymbol typeSymbol)
        {
            switch (typeSymbol?.MetadataName)
            {
                case "ChildSyntaxList":
                case "SeparatedSyntaxList`1":
                case "SyntaxList`1":
                case "SyntaxNodeOrTokenList":
                case "SyntaxTokenList":
                case "SyntaxTriviaList":
                    {
                        return typeSymbol.ContainingNamespace.HasMetadataName(RoslynMetadataNames.Microsoft_CodeAnalysis);
                    }
            }

            return false;
        }

        public static bool IsRoslynType(ISymbol symbol)
        {
            INamespaceSymbol namespaceSymbol = symbol?.ContainingNamespace;

            while (namespaceSymbol?.IsGlobalNamespace == false)
            {
                if (namespaceSymbol.Name == "CodeAnalysis")
                {
                    INamespaceSymbol containingNamespace = namespaceSymbol.ContainingNamespace;

                    if (containingNamespace?.Name == "Microsoft")
                    {
                        containingNamespace = containingNamespace.ContainingNamespace;

                        if (containingNamespace?.IsGlobalNamespace == true)
                            return true;
                    }
                }

                namespaceSymbol = namespaceSymbol.ContainingNamespace;
            }

            return false;
        }

        public static bool IsKindExtensionMethod(
            ExpressionSyntax expression,
            SemanticModel semanticModel,
            CancellationToken cancellationToken = default)
        {
            ISymbol symbol = semanticModel.GetSymbol(expression, cancellationToken);

            if (symbol?.Kind != SymbolKind.Method)
                return false;

            if (symbol.Name != "Kind")
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

        public static bool IsIsKindExtensionMethod(
            ExpressionSyntax expression,
            SemanticModel semanticModel,
            CancellationToken cancellationToken = default)
        {
            ISymbol symbol = semanticModel.GetSymbol(expression, cancellationToken);

            if (symbol?.Kind != SymbolKind.Method)
                return false;

            if (symbol.Name != "IsKind")
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
