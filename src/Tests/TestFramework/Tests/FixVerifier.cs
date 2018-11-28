﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Text;
using Roslynator.Tests.Text;
using Xunit;
using static Roslynator.Tests.CodeVerifierHelpers;

namespace Roslynator.Tests
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public abstract class FixVerifier : DiagnosticVerifier
    {
        public abstract CodeFixProvider FixProvider { get; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get { return $"{Descriptor.Id} {Analyzer.GetType().Name} {FixProvider.GetType().Name}"; }
        }

        public async Task VerifyDiagnosticAndFixAsync(
            string source,
            string expected,
            IEnumerable<(string source, string expected)> additionalData = null,
            string equivalenceKey = null,
            CodeVerificationOptions options = null,
            CancellationToken cancellationToken = default)
        {
            TextParserResult result = TextParser.GetSpans(source);

            IEnumerable<Diagnostic> diagnostics = result.Spans.Select(f => CreateDiagnostic(f.Span, f.LineSpan));

            string[] additionalSources = additionalData?.Select(f => f.source).ToArray() ?? Array.Empty<string>();

            await VerifyDiagnosticAsync(
                result.Text,
                diagnostics,
                additionalSources: additionalSources,
                options: options,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            await VerifyFixAsync(
                result.Text,
                expected,
                additionalData,
                equivalenceKey,
                options,
                cancellationToken).ConfigureAwait(false);
        }

        public async Task VerifyDiagnosticAndFixAsync(
            string theory,
            string fromData,
            string toData,
            string equivalenceKey = null,
            CodeVerificationOptions options = null,
            CancellationToken cancellationToken = default)
        {
            (TextSpan span, string source, string expected) = TextParser.ReplaceEmptySpan(theory, fromData, toData);

            TextParserResult result = TextParser.GetSpans(source);

            if (result.Spans.Any())
            {
                IEnumerable<Diagnostic> diagnostics = result.Spans.Select(f => CreateDiagnostic(f.Span, f.LineSpan));

                await VerifyDiagnosticAsync(result.Text, diagnostics, additionalSources: null, options: options, cancellationToken).ConfigureAwait(false);

                await VerifyFixAsync(result.Text, expected, additionalData: null, equivalenceKey: equivalenceKey, options: options, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                await VerifyDiagnosticAsync(source, span, options, cancellationToken).ConfigureAwait(false);

                await VerifyFixAsync(source, expected, additionalData: null, equivalenceKey: equivalenceKey, options: options, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        public async Task VerifyFixAsync(
            string theory,
            string fromData,
            string toData,
            string equivalenceKey = null,
            CodeVerificationOptions options = null,
            CancellationToken cancellationToken = default)
        {
            (TextSpan span, string source, string expected) = TextParser.ReplaceEmptySpan(theory, fromData, toData);

            await VerifyFixAsync(
                source: source,
                expected: expected,
                equivalenceKey: equivalenceKey,
                options: options,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        public async Task VerifyFixAsync(
            string source,
            string expected,
            IEnumerable<(string source, string expected)> additionalData = null,
            string equivalenceKey = null,
            CodeVerificationOptions options = null,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (!FixProvider.CanFixAny(Analyzer.SupportedDiagnostics))
                Assert.True(false, $"Code fix provider '{FixProvider.GetType().Name}' cannot fix any diagnostic supported by analyzer '{Analyzer}'.");

            using (Workspace workspace = new AdhocWorkspace())
            {
                Project project = WorkspaceFactory.AddProject(workspace.CurrentSolution);

                Document document = WorkspaceFactory.AddDocument(project, source);

                project = document.Project;

                ImmutableArray<ExpectedDocument> expectedDocuments = (additionalData != null)
                    ? WorkspaceFactory.AddAdditionalDocuments(additionalData, ref project)
                    : ImmutableArray<ExpectedDocument>.Empty;

                document = project.GetDocument(document.Id);

                Compilation compilation = await project.GetCompilationAsync(cancellationToken).ConfigureAwait(false);

                ImmutableArray<Diagnostic> compilerDiagnostics = compilation.GetDiagnostics(cancellationToken);

                if (options == null)
                    options = Options;

                VerifyCompilerDiagnostics(compilerDiagnostics, options);

                if (options.EnableDiagnosticsDisabledByDefault)
                    compilation = compilation.EnableDiagnosticsDisabledByDefault(Analyzer);

                ImmutableArray<Diagnostic> diagnostics = await compilation.GetAnalyzerDiagnosticsAsync(Analyzer, DiagnosticComparer.SpanStart, cancellationToken).ConfigureAwait(false);

                ImmutableArray<string> fixableDiagnosticIds = FixProvider.FixableDiagnosticIds;

                bool fixRegistered = false;

                while (diagnostics.Length > 0)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    Diagnostic diagnostic = FindFirstFixableDiagnostic(diagnostics, fixableDiagnosticIds);

                    if (diagnostic == null)
                        break;

                    CodeAction action = null;

                    var context = new CodeFixContext(
                        document,
                        diagnostic,
                        (a, d) =>
                        {
                            if (action == null
                                && (equivalenceKey == null || string.Equals(a.EquivalenceKey, equivalenceKey, StringComparison.Ordinal))
                                && d.Contains(diagnostic))
                            {
                                action = a;
                            }
                        },
                        CancellationToken.None);

                    await FixProvider.RegisterCodeFixesAsync(context).ConfigureAwait(false);

                    if (action == null)
                        break;

                    fixRegistered = true;

                    document = await document.ApplyCodeActionAsync(action).ConfigureAwait(false);

                    compilation = await document.Project.GetCompilationAsync(cancellationToken).ConfigureAwait(false);

                    ImmutableArray<Diagnostic> newCompilerDiagnostics = compilation.GetDiagnostics(cancellationToken);

                    VerifyCompilerDiagnostics(newCompilerDiagnostics, options);

                    if (!options.AllowNewCompilerDiagnostics)
                        VerifyNoNewCompilerDiagnostics(compilerDiagnostics, newCompilerDiagnostics, options);

                    if (options.EnableDiagnosticsDisabledByDefault)
                        compilation = compilation.EnableDiagnosticsDisabledByDefault(Analyzer);

                    diagnostics = await compilation.GetAnalyzerDiagnosticsAsync(Analyzer, DiagnosticComparer.SpanStart, cancellationToken).ConfigureAwait(false);
                }

                Assert.True(fixRegistered, "No code fix has been registered.");

                string actual = await document.ToFullStringAsync(simplify: true, format: true).ConfigureAwait(false);

                Assert.Equal(expected, actual);

                if (expectedDocuments.Any())
                    await VerifyAdditionalDocumentsAsync(document.Project, expectedDocuments).ConfigureAwait(false);
            }

            Diagnostic FindFirstFixableDiagnostic(ImmutableArray<Diagnostic> diagnostics, ImmutableArray<string> fixableDiagnosticIds)
            {
                foreach (Diagnostic diagnostic in diagnostics)
                {
                    if (fixableDiagnosticIds.Contains(diagnostic.Id))
                        return diagnostic;
                }

                return null;
            }
        }

        public async Task VerifyNoFixAsync(
            string source,
            string[] additionalSources = null,
            string equivalenceKey = null,
            CodeVerificationOptions options = null,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (Workspace workspace = new AdhocWorkspace())
            {
                Project project = WorkspaceFactory.AddProject(workspace.CurrentSolution);

                Document document = WorkspaceFactory.AddDocument(project, source, additionalSources ?? Array.Empty<string>());

                Compilation compilation = await document.Project.GetCompilationAsync(cancellationToken).ConfigureAwait(false);

                ImmutableArray<Diagnostic> compilerDiagnostics = compilation.GetDiagnostics(cancellationToken);

                if (options == null)
                    options = Options;

                VerifyCompilerDiagnostics(compilerDiagnostics, options);

                if (options.EnableDiagnosticsDisabledByDefault)
                    compilation = compilation.EnableDiagnosticsDisabledByDefault(Analyzer);

                ImmutableArray<Diagnostic> diagnostics = await compilation.GetAnalyzerDiagnosticsAsync(Analyzer, DiagnosticComparer.SpanStart, cancellationToken).ConfigureAwait(false);

                ImmutableArray<string> fixableDiagnosticIds = FixProvider.FixableDiagnosticIds;

                foreach (Diagnostic diagnostic in diagnostics)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    if (!string.Equals(diagnostic.Id, Descriptor.Id, StringComparison.Ordinal))
                        continue;

                    if (!fixableDiagnosticIds.Contains(diagnostic.Id))
                        continue;

                    var context = new CodeFixContext(
                        document,
                        diagnostic,
                        (a, d) =>
                        {
                            if ((equivalenceKey == null || string.Equals(a.EquivalenceKey, equivalenceKey, StringComparison.Ordinal))
                                && d.Contains(diagnostic))
                            {
                                Assert.True(false, "No code fix expected.");
                            }
                        },
                        CancellationToken.None);

                    await FixProvider.RegisterCodeFixesAsync(context).ConfigureAwait(false);
                }
            }
        }
    }
}