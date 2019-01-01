﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslynator.CSharp.CodeFixes;
using Xunit;

namespace Roslynator.CSharp.Analysis.Tests
{
    public class RCS1238OptimizeMethodCallTests : AbstractCSharpCodeFixVerifier
    {
        public override DiagnosticDescriptor Descriptor { get; } = DiagnosticDescriptors.OptimizeMethodCall;

        public override DiagnosticAnalyzer Analyzer { get; } = new InvocationExpressionAnalyzer();

        public override CodeFixProvider FixProvider { get; } = new OptimizeMethodCallCodeFixProvider();

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.OptimizeMethodCall)]
        public async Task Test_CallCompareOrdinalInsteadOfCompare()
        {
            await VerifyDiagnosticAndFixAsync(@"
using System;

class C
{
    void M()
    {
        string x = null;
        string y = null;

        var result = [|string.Compare(x, y, StringComparison.Ordinal)|];
    }
}
", @"
using System;

class C
{
    void M()
    {
        string x = null;
        string y = null;

        var result = string.CompareOrdinal(x, y);
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.OptimizeMethodCall)]
        public async Task Test_CallEqualsInsteadOfCompare()
        {
            await VerifyDiagnosticAndFixAsync(@"
using System;

class C
{
    void M()
    {
        string x = null;
        string y = null;

        if ([|string.Compare(x, y, StringComparison.Ordinal) == 0|])
        {
        }
    }
}
", @"
using System;

class C
{
    void M()
    {
        string x = null;
        string y = null;

        if (string.Equals(x, y, StringComparison.Ordinal))
        {
        }
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.OptimizeMethodCall)]
        public async Task Test_CallStringConcatInsteadOfStringJoin_EmptyStringLiteral()
        {
            await VerifyDiagnosticAndFixAsync(@"
class C
{
    void M()
    {
        string s = string.[|Join|]("""", default(object), default(object));
    }
}
", @"
class C
{
    void M()
    {
        string s = string.Concat(default(object), default(object));
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.OptimizeMethodCall)]
        public async Task Test_CallStringConcatInsteadOfStringJoin_EmptyStringLiteral2()
        {
            await VerifyDiagnosticAndFixAsync(@"
class C
{
    void M()
    {
        string s = string.[|Join|]("""", ""a"", ""b"");
    }
}
", @"
class C
{
    void M()
    {
        string s = string.Concat(""a"", ""b"");
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.OptimizeMethodCall)]
        public async Task Test_CallStringConcatInsteadOfStringJoin_StringEmpty()
        {
            await VerifyDiagnosticAndFixAsync(@"
class C
{
    void M()
    {
        string s = string.[|Join|](string.Empty, new string[] { """" });
    }
}
", @"
class C
{
    void M()
    {
        string s = string.Concat(new string[] { """" });
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.OptimizeMethodCall)]
        public async Task Test_CallStringConcatInsteadOfStringJoin_EmptyStringConstant()
        {
            await VerifyDiagnosticAndFixAsync(@"
class C
{
    const string EmptyString = """";

    void M()
    {
        string s = string.[|Join|](EmptyString, new object[] { """" });
    }
}
", @"
class C
{
    const string EmptyString = """";

    void M()
    {
        string s = string.Concat(new object[] { """" });
    }
}
");
        }

        [Fact, Trait(Traits.Analyzer, DiagnosticIdentifiers.OptimizeMethodCall)]
        public async Task TestNoDiagnostic_CallStringConcatInsteadOfStringJoin()
        {
            await VerifyNoDiagnosticAsync(@"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class C
{
    void M()
    {
        string s = string.Join(""x"", new object[] { """" });
    }
}
");
        }
    }
}
