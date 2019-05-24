# SymbolExtensions\.IsParameterArrayOf Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[SymbolExtensions](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IsParameterArrayOf(IParameterSymbol, SpecialType)](#Roslynator_SymbolExtensions_IsParameterArrayOf_Microsoft_CodeAnalysis_IParameterSymbol_Microsoft_CodeAnalysis_SpecialType_) | Returns true if the parameter was declared as a parameter array that has a specified element type\. |
| [IsParameterArrayOf(IParameterSymbol, SpecialType, SpecialType)](#Roslynator_SymbolExtensions_IsParameterArrayOf_Microsoft_CodeAnalysis_IParameterSymbol_Microsoft_CodeAnalysis_SpecialType_Microsoft_CodeAnalysis_SpecialType_) | Returns true if the parameter was declared as a parameter array that has one of specified element types\. |
| [IsParameterArrayOf(IParameterSymbol, SpecialType, SpecialType, SpecialType)](#Roslynator_SymbolExtensions_IsParameterArrayOf_Microsoft_CodeAnalysis_IParameterSymbol_Microsoft_CodeAnalysis_SpecialType_Microsoft_CodeAnalysis_SpecialType_Microsoft_CodeAnalysis_SpecialType_) | Returns true if the parameter was declared as a parameter array that has one of specified element types\. |

## IsParameterArrayOf\(IParameterSymbol, SpecialType\) <a name="Roslynator_SymbolExtensions_IsParameterArrayOf_Microsoft_CodeAnalysis_IParameterSymbol_Microsoft_CodeAnalysis_SpecialType_"></a>

### Summary

Returns true if the parameter was declared as a parameter array that has a specified element type\.

```csharp
public static bool IsParameterArrayOf(this Microsoft.CodeAnalysis.IParameterSymbol parameterSymbol, Microsoft.CodeAnalysis.SpecialType elementType)
```

### Parameters

**parameterSymbol**

**elementType**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParameterArrayOf\(IParameterSymbol, SpecialType, SpecialType\) <a name="Roslynator_SymbolExtensions_IsParameterArrayOf_Microsoft_CodeAnalysis_IParameterSymbol_Microsoft_CodeAnalysis_SpecialType_Microsoft_CodeAnalysis_SpecialType_"></a>

### Summary

Returns true if the parameter was declared as a parameter array that has one of specified element types\.

```csharp
public static bool IsParameterArrayOf(this Microsoft.CodeAnalysis.IParameterSymbol parameterSymbol, Microsoft.CodeAnalysis.SpecialType elementType1, Microsoft.CodeAnalysis.SpecialType elementType2)
```

### Parameters

**parameterSymbol**

**elementType1**

**elementType2**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParameterArrayOf\(IParameterSymbol, SpecialType, SpecialType, SpecialType\) <a name="Roslynator_SymbolExtensions_IsParameterArrayOf_Microsoft_CodeAnalysis_IParameterSymbol_Microsoft_CodeAnalysis_SpecialType_Microsoft_CodeAnalysis_SpecialType_Microsoft_CodeAnalysis_SpecialType_"></a>

### Summary

Returns true if the parameter was declared as a parameter array that has one of specified element types\.

```csharp
public static bool IsParameterArrayOf(this Microsoft.CodeAnalysis.IParameterSymbol parameterSymbol, Microsoft.CodeAnalysis.SpecialType elementType1, Microsoft.CodeAnalysis.SpecialType elementType2, Microsoft.CodeAnalysis.SpecialType elementType3)
```

### Parameters

**parameterSymbol**

**elementType1**

**elementType2**

**elementType3**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

