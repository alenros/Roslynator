# SyntaxListSelection\<TNode>\.TryCreate\(SyntaxList\<TNode>, TextSpan, SyntaxListSelection\<TNode>\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxListSelection\<TNode>](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Creates a new [SyntaxListSelection\<TNode>](../README.md) based on the specified list and span\.

```csharp
public static bool TryCreate(Microsoft.CodeAnalysis.SyntaxList<TNode> list, Microsoft.CodeAnalysis.Text.TextSpan span, out Roslynator.SyntaxListSelection<TNode> selection)
```

### Parameters

**list**

**span**

**selection**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

True if the specified span contains at least one node; otherwise, false\.