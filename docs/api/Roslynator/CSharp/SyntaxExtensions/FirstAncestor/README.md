# SyntaxExtensions\.FirstAncestor Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [FirstAncestor(SyntaxNode, Func\<SyntaxNode, Boolean>, Boolean)](#Roslynator_CSharp_SyntaxExtensions_FirstAncestor_Microsoft_CodeAnalysis_SyntaxNode_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_) | Gets the first ancestor that matches the predicate\. |
| [FirstAncestor(SyntaxNode, SyntaxKind, Boolean)](#Roslynator_CSharp_SyntaxExtensions_FirstAncestor_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_System_Boolean_) | Gets the first ancestor of the specified kind\. |
| [FirstAncestor(SyntaxNode, SyntaxKind, SyntaxKind, Boolean)](#Roslynator_CSharp_SyntaxExtensions_FirstAncestor_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_System_Boolean_) | Gets the first ancestor of the specified kinds\. |
| [FirstAncestor(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, Boolean)](#Roslynator_CSharp_SyntaxExtensions_FirstAncestor_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_System_Boolean_) | Gets the first ancestor of the specified kinds\. |

## FirstAncestor\(SyntaxNode, Func\<SyntaxNode, Boolean>, Boolean\) <a name="Roslynator_CSharp_SyntaxExtensions_FirstAncestor_Microsoft_CodeAnalysis_SyntaxNode_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_"></a>

### Summary

Gets the first ancestor that matches the predicate\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxNode FirstAncestor(this Microsoft.CodeAnalysis.SyntaxNode node, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool> predicate, bool ascendOutOfTrivia = true)
```

### Parameters

**node**

**predicate**

**ascendOutOfTrivia**

### Returns

Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

## FirstAncestor\(SyntaxNode, SyntaxKind, Boolean\) <a name="Roslynator_CSharp_SyntaxExtensions_FirstAncestor_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_System_Boolean_"></a>

### Summary

Gets the first ancestor of the specified kind\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxNode FirstAncestor(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind, bool ascendOutOfTrivia = true)
```

### Parameters

**node**

**kind**

**ascendOutOfTrivia**

### Returns

Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

## FirstAncestor\(SyntaxNode, SyntaxKind, SyntaxKind, Boolean\) <a name="Roslynator_CSharp_SyntaxExtensions_FirstAncestor_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_System_Boolean_"></a>

### Summary

Gets the first ancestor of the specified kinds\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxNode FirstAncestor(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, bool ascendOutOfTrivia = true)
```

### Parameters

**node**

**kind1**

**kind2**

**ascendOutOfTrivia**

### Returns

Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

## FirstAncestor\(SyntaxNode, SyntaxKind, SyntaxKind, SyntaxKind, Boolean\) <a name="Roslynator_CSharp_SyntaxExtensions_FirstAncestor_Microsoft_CodeAnalysis_SyntaxNode_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_Microsoft_CodeAnalysis_CSharp_SyntaxKind_System_Boolean_"></a>

### Summary

Gets the first ancestor of the specified kinds\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxNode FirstAncestor(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind1, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind2, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind3, bool ascendOutOfTrivia = true)
```

### Parameters

**node**

**kind1**

**kind2**

**kind3**

**ascendOutOfTrivia**

### Returns

Microsoft\.CodeAnalysis\.[SyntaxNode](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnode)

