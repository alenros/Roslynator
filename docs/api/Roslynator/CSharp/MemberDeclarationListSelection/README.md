# MemberDeclarationListSelection Class

[Home](../../../README.md) &#x2022; [Indexers](#indexers) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Structs](#structs)

**Namespace**: [Roslynator.CSharp](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Represents selected member declarations in a [SyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\.

```csharp
public sealed class MemberDeclarationListSelection : Roslynator.SyntaxListSelection<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; SyntaxListSelection\<TNode> &#x2192; MemberDeclarationListSelection

### Implements

* System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[MemberDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.memberdeclarationsyntax)>
* System\.Collections\.Generic\.[IReadOnlyCollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1)\<[MemberDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.memberdeclarationsyntax)>
* System\.Collections\.Generic\.[IReadOnlyList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)\<[MemberDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.memberdeclarationsyntax)>
* Roslynator\.ISelection\<[MemberDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.memberdeclarationsyntax)>

## Indexers

| Indexer | Summary |
| ------- | ------- |
| Item\[Int32\] |  \(Inherited from SyntaxListSelection\<TNode>\) |

## Properties

| Property | Summary |
| -------- | ------- |
| Count |  \(Inherited from SyntaxListSelection\<TNode>\) |
| FirstIndex |  \(Inherited from SyntaxListSelection\<TNode>\) |
| LastIndex |  \(Inherited from SyntaxListSelection\<TNode>\) |
| OriginalSpan |  \(Inherited from SyntaxListSelection\<TNode>\) |
| [Parent](Parent/README.md) | Gets a node that contains selected members\. |
| UnderlyingList |  \(Inherited from SyntaxListSelection\<TNode>\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Create(CompilationUnitSyntax, TextSpan)](Create/README.md#Roslynator_CSharp_MemberDeclarationListSelection_Create_Microsoft_CodeAnalysis_CSharp_Syntax_CompilationUnitSyntax_Microsoft_CodeAnalysis_Text_TextSpan_) | Creates a new [MemberDeclarationListSelection](./README.md) based on the specified compilation unit and span\. |
| [Create(NamespaceDeclarationSyntax, TextSpan)](Create/README.md#Roslynator_CSharp_MemberDeclarationListSelection_Create_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_Microsoft_CodeAnalysis_Text_TextSpan_) | Creates a new [MemberDeclarationListSelection](./README.md) based on the specified namespace declaration and span\. |
| [Create(TypeDeclarationSyntax, TextSpan)](Create/README.md#Roslynator_CSharp_MemberDeclarationListSelection_Create_Microsoft_CodeAnalysis_CSharp_Syntax_TypeDeclarationSyntax_Microsoft_CodeAnalysis_Text_TextSpan_) | Creates a new [MemberDeclarationListSelection](./README.md) based on the specified type declaration and span\. |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| First\(\) |  \(Inherited from SyntaxListSelection\<TNode>\) |
| GetEnumerator\(\) |  \(Inherited from SyntaxListSelection\<TNode>\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| Last\(\) |  \(Inherited from SyntaxListSelection\<TNode>\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [TryCreate(NamespaceDeclarationSyntax, TextSpan, MemberDeclarationListSelection)](TryCreate/README.md#Roslynator_CSharp_MemberDeclarationListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_MemberDeclarationListSelection__) | Creates a new [MemberDeclarationListSelection](./README.md) based on the specified namespace declaration and span\. |
| [TryCreate(TypeDeclarationSyntax, TextSpan, MemberDeclarationListSelection)](TryCreate/README.md#Roslynator_CSharp_MemberDeclarationListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_TypeDeclarationSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_MemberDeclarationListSelection__) | Creates a new [MemberDeclarationListSelection](./README.md) based on the specified type declaration and span\. |

## Structs

| Struct | Summary |
| ------ | ------- |
| Enumerator |  \(Inherited from SyntaxListSelection\<TNode>\) |

