# SemanticModelExtensions\.GetEnclosingSymbol\<TSymbol>\(SemanticModel, Int32, CancellationToken\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SemanticModelExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Returns the innermost symbol of type **TSymbol** that the specified position is considered inside of\.

```csharp
public static TSymbol GetEnclosingSymbol<TSymbol>(this Microsoft.CodeAnalysis.SemanticModel semanticModel, int position, System.Threading.CancellationToken cancellationToken = default) where TSymbol : Microsoft.CodeAnalysis.ISymbol
```

### Type Parameters

**TSymbol**

### Parameters

**semanticModel**

**position**

**cancellationToken**

### Returns

TSymbol

