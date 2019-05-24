# SymbolExtensions\.InheritsFrom Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [InheritsFrom(ITypeSymbol, ITypeSymbol, Boolean)](#Roslynator_SymbolExtensions_InheritsFrom_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_System_Boolean_) | Returns true if the type inherits from a specified base type\. |
| [InheritsFrom(ITypeSymbol, MetadataName, Boolean)](#Roslynator_SymbolExtensions_InheritsFrom_Microsoft_CodeAnalysis_ITypeSymbol_Roslynator_MetadataName__System_Boolean_) | Returns true if the type inherits from a type with the specified name\. |

## InheritsFrom\(ITypeSymbol, ITypeSymbol, Boolean\) <a name="Roslynator_SymbolExtensions_InheritsFrom_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_ITypeSymbol_System_Boolean_"></a>

### Summary

Returns true if the type inherits from a specified base type\.

```csharp
public static bool InheritsFrom(this Microsoft.CodeAnalysis.ITypeSymbol type, Microsoft.CodeAnalysis.ITypeSymbol baseType, bool includeInterfaces = false)
```

### Parameters

**type**

**baseType**

**includeInterfaces**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## InheritsFrom\(ITypeSymbol, MetadataName, Boolean\) <a name="Roslynator_SymbolExtensions_InheritsFrom_Microsoft_CodeAnalysis_ITypeSymbol_Roslynator_MetadataName__System_Boolean_"></a>

### Summary

Returns true if the type inherits from a type with the specified name\.

```csharp
public static bool InheritsFrom(this Microsoft.CodeAnalysis.ITypeSymbol type, in Roslynator.MetadataName baseTypeName, bool includeInterfaces = false)
```

### Parameters

**type**

**baseTypeName**

**includeInterfaces**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

