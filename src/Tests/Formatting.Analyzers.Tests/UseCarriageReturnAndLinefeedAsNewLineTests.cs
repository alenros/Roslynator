﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslynator.Formatting.CodeFixes;
using Xunit;

namespace Roslynator.Formatting.CSharp.Tests
{
    public class UseCarriageReturnAndLinefeedAsNewlineTests : AbstractCSharpFixVerifier
    {
        public override DiagnosticDescriptor Descriptor { get; } = DiagnosticDescriptors.UseCarriageReturnAndLinefeedAsNewline;

        public override DiagnosticAnalyzer Analyzer { get; } = new UseCarriageReturnAndLinefeedAsNewlineAnalyzer();

        public override CodeFixProvider FixProvider { get; } = new NewlineCodeFixProvider();

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseCarriageReturnAndLinefeedAsNewline)]
        public async Task Test()
        {
            await VerifyDiagnosticAndFixAsync("\r\n"
+ "class C[|\n|]"
+ "{[|\n|]"
+ "    /// <summary>[|\n|]"
+ "    /// [|\n|]"
+ "    /// </summary>[|\n|]"
+ "    void M()[|\n|]"
+ "    {[|\n|]"
+ "    }[|\n|]"
+ "}\r\n",
"\r\n"
+ "class C\r\n"
+ "{\r\n"
+ "    /// <summary>\r\n"
+ "    /// \r\n"
+ "    /// </summary>\r\n"
+ "    void M()\r\n"
+ "    {\r\n"
+ "    }\r\n"
+ "}\r\n");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.UseCarriageReturnAndLinefeedAsNewline)]
        public async Task TestNoDiagnostic()
        {
            await VerifyNoDiagnosticAsync("\r\n"
+ "class C\r\n"
+ "{\r\n"
+ "    void M()\r\n"
+ "    {\r\n"
+ "    }\r\n"
+ "}\r\n");
        }
    }
}
