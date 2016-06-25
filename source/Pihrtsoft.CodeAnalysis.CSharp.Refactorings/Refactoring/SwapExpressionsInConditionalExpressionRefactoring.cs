﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;

namespace Pihrtsoft.CodeAnalysis.CSharp.Refactoring
{
    internal static class SwapExpressionsInConditionalExpressionRefactoring
    {
        public static bool CanRefactor(RefactoringContext context, ConditionalExpressionSyntax conditionalExpression)
        {
            return conditionalExpression.Condition != null
                && conditionalExpression.WhenTrue != null
                && conditionalExpression.WhenFalse != null
                && conditionalExpression.Condition.Span.Contains(context.Span);
        }

        public static async Task<Document> RefactorAsync(
            Document document,
            ConditionalExpressionSyntax conditionalExpression,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            SyntaxNode oldRoot = await document.GetSyntaxRootAsync(cancellationToken);

            ConditionalExpressionSyntax newConditionalExpression = conditionalExpression
                .WithCondition(conditionalExpression.Condition.Negate())
                .WithWhenTrue(conditionalExpression.WhenFalse.WithTriviaFrom(conditionalExpression.WhenTrue))
                .WithWhenFalse(conditionalExpression.WhenTrue.WithTriviaFrom(conditionalExpression.WhenFalse))
                .WithAdditionalAnnotations(Formatter.Annotation);

            SyntaxNode newRoot = oldRoot.ReplaceNode(conditionalExpression, newConditionalExpression);

            return document.WithSyntaxRoot(newRoot);
        }
    }
}
