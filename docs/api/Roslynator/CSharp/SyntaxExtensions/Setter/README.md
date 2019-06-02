# SyntaxExtensions\.Setter Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Setter(AccessorListSyntax)](#Roslynator_CSharp_SyntaxExtensions_Setter_Microsoft_CodeAnalysis_CSharp_Syntax_AccessorListSyntax_) | Returns a set accessor contained in the specified list\. |
| [Setter(IndexerDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_Setter_Microsoft_CodeAnalysis_CSharp_Syntax_IndexerDeclarationSyntax_) | Returns a set accessor that is contained in the specified indexer declaration\. |
| [Setter(PropertyDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_Setter_Microsoft_CodeAnalysis_CSharp_Syntax_PropertyDeclarationSyntax_) | Returns property set accessor, if any\. |

## Setter\(AccessorListSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_Setter_Microsoft_CodeAnalysis_CSharp_Syntax_AccessorListSyntax_"></a>

### Summary

Returns a set accessor contained in the specified list\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax Setter(this Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax accessorList)
```

### Parameters

**accessorList**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[AccessorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.accessordeclarationsyntax)

## Setter\(IndexerDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_Setter_Microsoft_CodeAnalysis_CSharp_Syntax_IndexerDeclarationSyntax_"></a>

### Summary

Returns a set accessor that is contained in the specified indexer declaration\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax Setter(this Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax indexerDeclaration)
```

### Parameters

**indexerDeclaration**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[AccessorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.accessordeclarationsyntax)

## Setter\(PropertyDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_Setter_Microsoft_CodeAnalysis_CSharp_Syntax_PropertyDeclarationSyntax_"></a>

### Summary

Returns property set accessor, if any\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax Setter(this Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax propertyDeclaration)
```

### Parameters

**propertyDeclaration**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[AccessorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.accessordeclarationsyntax)
