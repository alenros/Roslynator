# SyntaxExtensions\.IsEmptyOrWhitespace\(SyntaxTriviaList\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Returns true if the list of either empty or contains only whitespace \([SyntaxKind.WhitespaceTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.whitespacetrivia) or [SyntaxKind.EndOfLineTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxkind.endoflinetrivia)\)\.

```csharp
public static bool IsEmptyOrWhitespace(this Microsoft.CodeAnalysis.SyntaxTriviaList triviaList)
```

### Parameters

**triviaList**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

