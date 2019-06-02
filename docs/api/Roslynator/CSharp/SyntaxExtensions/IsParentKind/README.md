# SyntaxExtensions\.IsParentKind Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [IsParentKind(SyntaxNode, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node parent's kind is the specified kind\. |
| [IsParentKind(SyntaxNode, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node parent's kind is one of the specified kinds\. |
| [IsParentKind(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node parent's kind is one of the specified kinds\. |
| [IsParentKind(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node parent's kind is one of the specified kinds\. |
| [IsParentKind(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node parent's kind is one of the specified kinds\. |
| [IsParentKind(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a node parent's kind is one of the specified kinds\. |
| [IsParentKind(SyntaxToken, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token parent's kind is the specified kind\. |
| [IsParentKind(SyntaxToken, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token parent's kind is one of the specified kinds\. |
| [IsParentKind(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token parent's kind is one of the specified kinds\. |
| [IsParentKind(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token parent's kind is one of the specified kinds\. |
| [IsParentKind(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token parent's kind is one of the specified kinds\. |
| [IsParentKind(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Returns true if a token parent's kind is one of the specified kinds\. |

## IsParentKind\(SyntaxNode, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node parent's kind is the specified kind\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind)
```

### Parameters

**node**

**kind**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxNode, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node parent's kind is one of the specified kinds\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2)
```

### Parameters

**node**

**kind1**

**kind2**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node parent's kind is one of the specified kinds\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3)
```

### Parameters

**node**

**kind1**

**kind2**

**kind3**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node parent's kind is one of the specified kinds\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4)
```

### Parameters

**node**

**kind1**

**kind2**

**kind3**

**kind4**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node parent's kind is one of the specified kinds\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind5)
```

### Parameters

**node**

**kind1**

**kind2**

**kind3**

**kind4**

**kind5**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a node parent's kind is one of the specified kinds\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind5, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind6)
```

### Parameters

**node**

**kind1**

**kind2**

**kind3**

**kind4**

**kind5**

**kind6**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxToken, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token parent's kind is the specified kind\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind)
```

### Parameters

**token**

**kind**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxToken, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token parent's kind is one of the specified kinds\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2)
```

### Parameters

**token**

**kind1**

**kind2**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token parent's kind is one of the specified kinds\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3)
```

### Parameters

**token**

**kind1**

**kind2**

**kind3**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token parent's kind is one of the specified kinds\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4)
```

### Parameters

**token**

**kind1**

**kind2**

**kind3**

**kind4**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token parent's kind is one of the specified kinds\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind5)
```

### Parameters

**token**

**kind1**

**kind2**

**kind3**

**kind4**

**kind5**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## IsParentKind\(SyntaxToken, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_IsParentKind_Microsoft_CodeAnalysis_SyntaxToken_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Returns true if a token parent's kind is one of the specified kinds\.

```csharp
public static bool IsParentKind(this Microsoft.CodeAnalysis.SyntaxToken token, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind4, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind5, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind6)
```

### Parameters

**token**

**kind1**

**kind2**

**kind3**

**kind4**

**kind5**

**kind6**

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)
