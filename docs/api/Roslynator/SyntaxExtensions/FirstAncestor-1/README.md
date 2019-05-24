# SyntaxExtensions\.FirstAncestor\<TNode>\(SyntaxNode, Func\<TNode, Boolean>, Boolean\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Returns the first node of type **TNode** that matches the predicate\.

```csharp
public static TNode FirstAncestor<TNode>(this Microsoft.CodeAnalysis.SyntaxNode node, System.Func<TNode, bool> predicate = null, bool ascendOutOfTrivia = true) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**node**

**predicate**

**ascendOutOfTrivia**

### Returns

TNode

