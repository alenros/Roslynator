﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Pihrtsoft.CodeAnalysis;
using Pihrtsoft.CodeAnalysis.CSharp.Analysis;

namespace Pihrtsoft.CodeAnalysis.CSharp.Refactoring
{
    internal static class VariableDeclarationRefactoring
    {
        public static async Task ComputeRefactoringsAsync(RefactoringContext context, VariableDeclarationSyntax variableDeclaration)
        {
            if (context.SupportsSemanticModel)
            {
                await RenameVariableAccordingToTypeNameAsync(context, variableDeclaration);

                if (variableDeclaration.Type?.Span.Contains(context.Span) == true)
                {
                    await ChangeTypeAccordingToExpressionAsync(context, variableDeclaration);
                    await ChangeTypeAsync(context, variableDeclaration);
                }

                await AddCastToExpressionAsync(context, variableDeclaration);
            }
        }

        private static async Task ChangeTypeAsync(
            RefactoringContext context,
            VariableDeclarationSyntax variableDeclaration)
        {
            SemanticModel semanticModel = await context.GetSemanticModelAsync();

            TypeAnalysisResult result = VariableDeclarationAnalysis.AnalyzeType(
                variableDeclaration,
                semanticModel,
                context.CancellationToken);

            if (result == TypeAnalysisResult.Explicit || result == TypeAnalysisResult.ExplicitButShouldBeImplicit)
            {
                context.RegisterRefactoring(
                    "Change type to 'var'",
                    cancellationToken => TypeSyntaxRefactoring.ChangeTypeToImplicitAsync(context.Document, variableDeclaration.Type, cancellationToken));
            }
            else if (result == TypeAnalysisResult.Implicit || result == TypeAnalysisResult.ImplicitButShouldBeExplicit)
            {
                ITypeSymbol typeSymbol = semanticModel.GetTypeInfo(variableDeclaration.Type, context.CancellationToken).Type;

                context.RegisterRefactoring(
                    $"Change type to '{typeSymbol.ToDisplayString(TypeSyntaxRefactoring.SymbolDisplayFormat)}'",
                    cancellationToken => TypeSyntaxRefactoring.ChangeTypeToExplicitAsync(context.Document, variableDeclaration.Type, typeSymbol, cancellationToken));
            }
        }

        private static async Task RenameVariableAccordingToTypeNameAsync(
            RefactoringContext context,
            VariableDeclarationSyntax variableDeclaration)
        {
            if (variableDeclaration.Type != null
                && variableDeclaration.Parent?.IsKind(SyntaxKind.EventFieldDeclaration) == false
                && variableDeclaration.Variables.Count == 1
                && variableDeclaration.Variables[0].Identifier.Span.Contains(context.Span))
            {
                SemanticModel semanticModel = await context.GetSemanticModelAsync();

                ISymbol symbol = semanticModel.GetDeclaredSymbol(variableDeclaration.Variables[0], context.CancellationToken);

                if (symbol != null)
                {
                    string newName = NamingHelper.CreateIdentifierName(
                        variableDeclaration.Type,
                        semanticModel,
                        FirstCharToLower(symbol));

                    if (!string.IsNullOrEmpty(newName))
                    {
                        if (symbol.IsKind(SymbolKind.Field)
                            && symbol.DeclaredAccessibility == Accessibility.Private
                            && !((IFieldSymbol)symbol).IsConst)
                        {
                            newName = NamingHelper.ToCamelCaseWithUnderscore(newName);
                        }

                        if (!string.Equals(variableDeclaration.Variables[0].Identifier.ValueText, newName, StringComparison.Ordinal))
                        {
                            context.RegisterRefactoring(
                                $"Rename {GetName(symbol)} to '{newName}'",
                                cancellationToken => symbol.RenameAsync(newName, context.Document, cancellationToken));
                        }
                    }
                }
            }
        }

        private static string GetName(ISymbol symbol)
        {
            if (symbol.IsKind(SymbolKind.Field))
            {
                if (((IFieldSymbol)symbol).IsConst)
                    return "constant";
                else
                    return "field";
            }

            return "local";
        }

        private static bool FirstCharToLower(ISymbol symbol)
        {
            if (symbol.IsKind(SymbolKind.Field))
            {
                if (((IFieldSymbol)symbol).IsConst)
                    return false;

                if (symbol.DeclaredAccessibility != Accessibility.Private)
                    return false;
            }

            return true;
        }

        private static async Task ChangeTypeAccordingToExpressionAsync(
            RefactoringContext context,
            VariableDeclarationSyntax variableDeclaration)
        {
            if (variableDeclaration.Parent?.IsKind(SyntaxKind.FieldDeclaration) == false
                && variableDeclaration.Type?.IsVar == false
                && variableDeclaration.Variables.Count == 1)
            {
                ExpressionSyntax initializerValue = variableDeclaration.Variables[0].Initializer?.Value;

                if (initializerValue != null)
                {
                    SemanticModel semanticModel = await context.GetSemanticModelAsync();

                    ITypeSymbol initializerTypeSymbol = semanticModel.GetTypeInfo(initializerValue).Type;

                    if (initializerTypeSymbol?.IsKind(SymbolKind.ErrorType) == false)
                    {
                        ITypeSymbol typeSymbol = semanticModel.GetTypeInfo(variableDeclaration.Type).ConvertedType;

                        if (!initializerTypeSymbol.Equals(typeSymbol))
                        {
                            context.RegisterRefactoring(
                                $"Change type to '{initializerTypeSymbol.ToDisplayString(TypeSyntaxRefactoring.SymbolDisplayFormat)}'",
                                cancellationToken =>
                                {
                                    return TypeSyntaxRefactoring.ChangeTypeToExplicitAsync(
                                        context.Document,
                                        variableDeclaration.Type,
                                        initializerTypeSymbol,
                                        cancellationToken);
                                });
                        }
                    }
                }
            }
        }

        private static async Task AddCastToExpressionAsync(
            RefactoringContext context,
            VariableDeclarationSyntax variableDeclaration)
        {
            if (variableDeclaration.Type?.IsVar == false)
            {
                VariableDeclaratorSyntax declarator = variableDeclaration.Variables
                    .FirstOrDefault(f => f.Initializer?.Value?.Span.Contains(context.Span) == true);

                if (declarator != null)
                {
                    SemanticModel semanticModel = await context.GetSemanticModelAsync();

                    ITypeSymbol declarationType = semanticModel
                        .GetTypeInfo(variableDeclaration.Type, context.CancellationToken)
                        .Type;

                    if (declarationType != null)
                    {
                        ITypeSymbol expressionType = semanticModel
                            .GetTypeInfo(declarator.Initializer.Value, context.CancellationToken)
                            .Type;

                        if (!declarationType.Equals(expressionType))
                            AddCastRefactoring.RegisterRefactoring(context, declarator.Initializer.Value, declarationType);
                    }
                }
            }
        }
    }
}