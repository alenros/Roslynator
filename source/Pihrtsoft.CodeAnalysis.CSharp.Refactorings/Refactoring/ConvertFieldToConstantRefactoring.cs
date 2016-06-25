﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;

namespace Pihrtsoft.CodeAnalysis.CSharp.Refactoring
{
    internal static class ConvertFieldToConstantRefactoring
    {
        public static async Task<bool> CanRefactorAsync(
            RefactoringContext context,
            FieldDeclarationSyntax declaration)
        {
            TypeSyntax type = declaration.Declaration?.Type;

            if (type != null
                && declaration.Declaration.Variables.All(f => f.Initializer != null))
            {
                SemanticModel semanticModel = await context.GetSemanticModelAsync();

                ITypeSymbol typeSymbol = semanticModel.GetTypeInfo(type, context.CancellationToken).Type;

                return typeSymbol != null
                    && typeSymbol.SpecialType != SpecialType.System_Object
                    && typeSymbol.IsPredefinedType();
            }

            return false;
        }

        public static async Task<Document> RefactorAsync(
            Document document,
            FieldDeclarationSyntax node,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            SyntaxNode oldRoot = await document.GetSyntaxRootAsync(cancellationToken);

            SyntaxTokenList modifiers = node.Modifiers;

            int index = modifiers.IndexOf(SyntaxKind.StaticKeyword);

            if (index != -1)
                modifiers = modifiers.RemoveAt(index);

            index = modifiers.IndexOf(SyntaxKind.ReadOnlyKeyword);

            modifiers = modifiers
                .RemoveAt(index)
                .Insert(index, SyntaxFactory.Token(SyntaxKind.ConstKeyword).WithTriviaFrom(modifiers[index]));

            FieldDeclarationSyntax newNode = node
                .WithModifiers(modifiers)
                .WithAdditionalAnnotations(Formatter.Annotation);

            SyntaxNode newRoot = oldRoot.ReplaceNode(node, newNode);

            return document.WithSyntaxRoot(newRoot);
        }
    }
}
