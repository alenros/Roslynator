# WorkspaceExtensions\.RemoveNodesAsync\(Document, IEnumerable\<SyntaxNode>, SyntaxRemoveOptions, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.Workspaces\.Core\.dll

## Summary

Creates a new document with the specified nodes removed\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> RemoveNodesAsync(this Microsoft.CodeAnalysis.Document document, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode> nodes, Microsoft.CodeAnalysis.SyntaxRemoveOptions options, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document**

**nodes**

**options**

**cancellationToken**

### Returns

System\.Threading\.Tasks\.[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)>

