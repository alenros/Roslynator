# SymbolExtensions\.GetAttribute Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GetAttribute(ISymbol, INamedTypeSymbol)](#Roslynator_SymbolExtensions_GetAttribute_Microsoft_CodeAnalysis_ISymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_) | Returns the attribute for the symbol that matches the specified attribute class, or null if the symbol does not have the specified attribute\. |
| [GetAttribute(ISymbol, MetadataName)](#Roslynator_SymbolExtensions_GetAttribute_Microsoft_CodeAnalysis_ISymbol_Roslynator_MetadataName__) | Returns the attribute for the symbol that matches the specified name, or null if the symbol does not have the specified attribute\. |

## GetAttribute\(ISymbol, INamedTypeSymbol\) <a name="Roslynator_SymbolExtensions_GetAttribute_Microsoft_CodeAnalysis_ISymbol_Microsoft_CodeAnalysis_INamedTypeSymbol_"></a>

### Summary

Returns the attribute for the symbol that matches the specified attribute class, or null if the symbol does not have the specified attribute\.

```csharp
public static Microsoft.CodeAnalysis.AttributeData GetAttribute(this Microsoft.CodeAnalysis.ISymbol symbol, Microsoft.CodeAnalysis.INamedTypeSymbol attributeClass)
```

### Parameters

**symbol**

**attributeClass**

### Returns

Microsoft\.CodeAnalysis\.[AttributeData](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.attributedata)

## GetAttribute\(ISymbol, MetadataName\) <a name="Roslynator_SymbolExtensions_GetAttribute_Microsoft_CodeAnalysis_ISymbol_Roslynator_MetadataName__"></a>

### Summary

Returns the attribute for the symbol that matches the specified name, or null if the symbol does not have the specified attribute\.

```csharp
public static Microsoft.CodeAnalysis.AttributeData GetAttribute(this Microsoft.CodeAnalysis.ISymbol symbol, in Roslynator.MetadataName attributeName)
```

### Parameters

**symbol**

**attributeName**

### Returns

Microsoft\.CodeAnalysis\.[AttributeData](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.attributedata)

