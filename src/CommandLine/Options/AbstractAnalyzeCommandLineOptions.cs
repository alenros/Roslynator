﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using CommandLine;
using Microsoft.CodeAnalysis;

namespace Roslynator.CommandLine
{
    public abstract class AbstractAnalyzeCommandLineOptions : MSBuildCommandLineOptions
    {
        [Option(shortName: 'a', longName: "analyzer-assemblies", HelpText = "Define one or more paths to an analyzer assembly or a directory.", MetaValue = "<PATH>")]
        public IEnumerable<string> AnalyzerAssemblies { get; set; }

        [Option(longName: "culture", HelpText = "Defines culture that should be used to display diagnostic message.", MetaValue = "<CULTURE_ID>")]
        public string Culture { get; set; }

        [Option(longName: "ignore-analyzer-references", HelpText = "Indicates whether Roslynator should ignore analyzers that are referenced in projects.")]
        public bool IgnoreAnalyzerReferences { get; set; }

        [Option(longName: "ignored-diagnostics", HelpText = "Defines diagnostics that should not be reported.", MetaValue = "<DIAGNOSTIC_ID>")]
        public IEnumerable<string> IgnoredDiagnostics { get; set; }

        //TODO: MinSeverity
        [Option(longName: "minimal-severity", HelpText = "Defines minimal severity for a diagnostic. Default value is 'info'.", MetaValue = "{hidden|info|warning|error}")]
        public string MinimalSeverity { get; set; }

        [Option(longName: "supported-diagnostics", HelpText = "Defines diagnostics that should be reported.", MetaValue = "<DIAGNOSTIC_ID>")]
        public IEnumerable<string> SupportedDiagnostics { get; set; }

        [Option(longName: "use-roslynator-analyzers", HelpText = "Indicates whether code analysis should use analyzers from nuget package Roslynator.Analyzers.")]
        public bool UseRoslynatorAnalyzers { get; set; }

        internal bool TryGetMinimalSeverity(DiagnosticSeverity defaultValue, out DiagnosticSeverity value)
        {
            if (MinimalSeverity != null)
                return ParseHelpers.TryParseDiagnosticSeverity(MinimalSeverity, out value);

            value = defaultValue;
            return true;
        }
    }
}
