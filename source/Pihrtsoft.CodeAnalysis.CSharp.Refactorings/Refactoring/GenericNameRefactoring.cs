﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Pihrtsoft.CodeAnalysis.CSharp.Refactoring
{
    internal static class GenericNameRefactoring
    {
        public static void ComputeRefactorings(RefactoringContext context, GenericNameSyntax genericName)
        {
            if (ExtractGenericTypeRefactoring.CanRefactor(context, genericName))
            {
                context.RegisterRefactoring(
                    "Extract generic type",
                    cancellationToken => ExtractGenericTypeRefactoring.RefactorAsync(context.Document, genericName, cancellationToken));
            }
        }
    }
}
