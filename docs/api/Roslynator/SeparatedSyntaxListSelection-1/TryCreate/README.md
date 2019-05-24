# SeparatedSyntaxListSelection\<TNode>\.TryCreate\(SeparatedSyntaxList\<TNode>, TextSpan, SeparatedSyntaxListSelection\<TNode>\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SeparatedSyntaxListSelection\<TNode>](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Creates a new [SeparatedSyntaxListSelection\<TNode>](../README.md) based on the specified list and span\.

```csharp
public static bool TryCreate(Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> list, Microsoft.CodeAnalysis.Text.TextSpan span, out Roslynator.SeparatedSyntaxListSelection<TNode> selection)
```

### Parameters

**list**

**span**

**selection**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

True if the specified span contains at least one node; otherwise, false\.