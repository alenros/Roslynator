// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using Xunit;

namespace Roslynator.CodeAnalysis.CSharp.Tests
{
    public class ROS0008UseReturnValueTests : AbstractCSharpFixVerifier
    {
        public override DiagnosticDescriptor Descriptor { get; } = DiagnosticDescriptors.UseReturnValue;

        public override DiagnosticAnalyzer Analyzer { get; } = new InvocationExpressionAnalyzer();

        public override CodeFixProvider FixProvider { get; }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseReturnValue)]
        public async Task Test()
        {
            await VerifyDiagnosticAsync(@"
using Microsoft.CodeAnalysis.CSharp.Syntax;

class C
{
    void M()
    {
        IfStatementSyntax ifStatement = null;
        [|ifStatement.WithCondition(null)|];
    }
}
");
        }

        //[Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseReturnValue)]
        public async Task TestNoDiagnostic()
        {
            await VerifyNoDiagnosticAsync(@"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

class C
{
    void M()
    {
    }
}
");
        }
    }
}
