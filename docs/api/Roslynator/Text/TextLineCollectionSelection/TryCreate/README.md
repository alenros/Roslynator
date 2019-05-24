# TextLineCollectionSelection\.TryCreate\(TextLineCollection, TextSpan, TextLineCollectionSelection\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.Text\.[TextLineCollectionSelection](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Creates a new [TextLineCollectionSelection](../README.md) based on the specified list and span\.

```csharp
public static bool TryCreate(Microsoft.CodeAnalysis.Text.TextLineCollection lines, Microsoft.CodeAnalysis.Text.TextSpan span, out Roslynator.Text.TextLineCollectionSelection selectedLines)
```

### Parameters

**lines**

**span**

**selectedLines**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

True if the specified span contains at least one line; otherwise, false\.