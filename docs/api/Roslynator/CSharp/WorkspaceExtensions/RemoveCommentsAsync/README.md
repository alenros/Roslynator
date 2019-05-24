# WorkspaceExtensions\.RemoveCommentsAsync Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.Workspaces\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [RemoveCommentsAsync(Document, CommentFilter, CancellationToken)](#Roslynator_CSharp_WorkspaceExtensions_RemoveCommentsAsync_Microsoft_CodeAnalysis_Document_Roslynator_CSharp_CommentFilter_System_Threading_CancellationToken_) | Creates a new document with comments of the specified kind removed\. |
| [RemoveCommentsAsync(Document, TextSpan, CommentFilter, CancellationToken)](#Roslynator_CSharp_WorkspaceExtensions_RemoveCommentsAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_CommentFilter_System_Threading_CancellationToken_) | Creates a new document with comments of the specified kind removed\. |

## RemoveCommentsAsync\(Document, CommentFilter, CancellationToken\) <a name="Roslynator_CSharp_WorkspaceExtensions_RemoveCommentsAsync_Microsoft_CodeAnalysis_Document_Roslynator_CSharp_CommentFilter_System_Threading_CancellationToken_"></a>

### Summary

Creates a new document with comments of the specified kind removed\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> RemoveCommentsAsync(this Microsoft.CodeAnalysis.Document document, Roslynator.CSharp.CommentFilter comments, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document**

**comments**

**cancellationToken**

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

## RemoveCommentsAsync\(Document, TextSpan, CommentFilter, CancellationToken\) <a name="Roslynator_CSharp_WorkspaceExtensions_RemoveCommentsAsync_Microsoft_CodeAnalysis_Document_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_CommentFilter_System_Threading_CancellationToken_"></a>

### Summary

Creates a new document with comments of the specified kind removed\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> RemoveCommentsAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.Text.TextSpan span, Roslynator.CSharp.CommentFilter comments, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document**

**span**

**comments**

**cancellationToken**

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

