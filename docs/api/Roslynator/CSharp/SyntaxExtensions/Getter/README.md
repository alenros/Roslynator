# SyntaxExtensions\.Getter Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Getter(AccessorListSyntax)](#Roslynator_CSharp_SyntaxExtensions_Getter_Microsoft_CodeAnalysis_CSharp_Syntax_AccessorListSyntax_) | Returns a get accessor contained in the specified list\. |
| [Getter(IndexerDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_Getter_Microsoft_CodeAnalysis_CSharp_Syntax_IndexerDeclarationSyntax_) | Returns a get accessor that is contained in the specified indexer declaration\. |
| [Getter(PropertyDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_Getter_Microsoft_CodeAnalysis_CSharp_Syntax_PropertyDeclarationSyntax_) | Returns property get accessor, if any\. |

## Getter\(AccessorListSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_Getter_Microsoft_CodeAnalysis_CSharp_Syntax_AccessorListSyntax_"></a>

### Summary

Returns a get accessor contained in the specified list\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax Getter(this Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax accessorList)
```

### Parameters

**accessorList**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[AccessorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.accessordeclarationsyntax)

## Getter\(IndexerDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_Getter_Microsoft_CodeAnalysis_CSharp_Syntax_IndexerDeclarationSyntax_"></a>

### Summary

Returns a get accessor that is contained in the specified indexer declaration\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax Getter(this Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax indexerDeclaration)
```

### Parameters

**indexerDeclaration**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[AccessorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.accessordeclarationsyntax)

## Getter\(PropertyDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_Getter_Microsoft_CodeAnalysis_CSharp_Syntax_PropertyDeclarationSyntax_"></a>

### Summary

Returns property get accessor, if any\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax Getter(this Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax propertyDeclaration)
```

### Parameters

**propertyDeclaration**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[AccessorDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.accessordeclarationsyntax)
