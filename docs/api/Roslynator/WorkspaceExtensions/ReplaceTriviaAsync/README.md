# WorkspaceExtensions\.ReplaceTriviaAsync Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.Workspaces\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ReplaceTriviaAsync(Document, SyntaxTrivia, IEnumerable\<SyntaxTrivia>, CancellationToken)](#Roslynator_WorkspaceExtensions_ReplaceTriviaAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_SyntaxTrivia_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_SyntaxTrivia__System_Threading_CancellationToken_) | Creates a new document with the specified old trivia replaced with a new trivia\. |
| [ReplaceTriviaAsync(Document, SyntaxTrivia, SyntaxTrivia, CancellationToken)](#Roslynator_WorkspaceExtensions_ReplaceTriviaAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_SyntaxTrivia_System_Threading_CancellationToken_) | Creates a new document with the specified old trivia replaced with a new trivia\. |

## ReplaceTriviaAsync\(Document, SyntaxTrivia, IEnumerable\<SyntaxTrivia>, CancellationToken\) <a name="Roslynator_WorkspaceExtensions_ReplaceTriviaAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_SyntaxTrivia_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_SyntaxTrivia__System_Threading_CancellationToken_"></a>

### Summary

Creates a new document with the specified old trivia replaced with a new trivia\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> ReplaceTriviaAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.SyntaxTrivia oldTrivia, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia> newTrivia, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document**

**oldTrivia**

**newTrivia**

**cancellationToken**

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

## ReplaceTriviaAsync\(Document, SyntaxTrivia, SyntaxTrivia, CancellationToken\) <a name="Roslynator_WorkspaceExtensions_ReplaceTriviaAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_SyntaxTrivia_Microsoft_CodeAnalysis_SyntaxTrivia_System_Threading_CancellationToken_"></a>

### Summary

Creates a new document with the specified old trivia replaced with a new trivia\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> ReplaceTriviaAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.SyntaxTrivia oldTrivia, Microsoft.CodeAnalysis.SyntaxTrivia newTrivia, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document**

**oldTrivia**

**newTrivia**

**cancellationToken**

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

