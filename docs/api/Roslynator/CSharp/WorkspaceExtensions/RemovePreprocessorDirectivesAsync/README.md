# WorkspaceExtensions\.RemovePreprocessorDirectivesAsync Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.Workspaces\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [RemovePreprocessorDirectivesAsync(Document, PreprocessorDirectiveFilter, CancellationToken)](#Roslynator_CSharp_WorkspaceExtensions_RemovePreprocessorDirectivesAsync_Microsoft_CodeAnalysis_Document_Roslynator_CSharp_PreprocessorDirectiveFilter_System_Threading_CancellationToken_) | Creates a new document with preprocessor directives of the specified kind removed\. |
| [RemovePreprocessorDirectivesAsync(Document, TextSpan, PreprocessorDirectiveFilter, CancellationToken)](#Roslynator_CSharp_WorkspaceExtensions_RemovePreprocessorDirectivesAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_PreprocessorDirectiveFilter_System_Threading_CancellationToken_) | Creates a new document with preprocessor directives of the specified kind removed\. |

## RemovePreprocessorDirectivesAsync\(Document, PreprocessorDirectiveFilter, CancellationToken\) <a name="Roslynator_CSharp_WorkspaceExtensions_RemovePreprocessorDirectivesAsync_Microsoft_CodeAnalysis_Document_Roslynator_CSharp_PreprocessorDirectiveFilter_System_Threading_CancellationToken_"></a>

### Summary

Creates a new document with preprocessor directives of the specified kind removed\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> RemovePreprocessorDirectivesAsync(this Microsoft.CodeAnalysis.Document document, Roslynator.CSharp.PreprocessorDirectiveFilter directiveFilter, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document**

**directiveFilter**

**cancellationToken**

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

## RemovePreprocessorDirectivesAsync\(Document, TextSpan, PreprocessorDirectiveFilter, CancellationToken\) <a name="Roslynator_CSharp_WorkspaceExtensions_RemovePreprocessorDirectivesAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_PreprocessorDirectiveFilter_System_Threading_CancellationToken_"></a>

### Summary

Creates a new document with preprocessor directives of the specified kind removed\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> RemovePreprocessorDirectivesAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.Text.TextSpan span, Roslynator.CSharp.PreprocessorDirectiveFilter directiveFilter, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document**

**span**

**directiveFilter**

**cancellationToken**

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

