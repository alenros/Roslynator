# StatementListSelection Class

[Home](../../../README.md) &#x2022; [Indexers](#indexers) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Structs](#structs)

**Namespace**: [Roslynator.CSharp](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Represents selected statements in a [SyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\.

```csharp
public sealed class StatementListSelection : Roslynator.SyntaxListSelection<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; SyntaxListSelection\<TNode> &#x2192; StatementListSelection

### Implements

* System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[StatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)>
* System\.Collections\.Generic\.[IReadOnlyCollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1)\<[StatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)>
* System\.Collections\.Generic\.[IReadOnlyList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)\<[StatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)>
* Roslynator\.ISelection\<[StatementSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)>

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
| UnderlyingList |  \(Inherited from SyntaxListSelection\<TNode>\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Create(BlockSyntax, TextSpan)](Create/README.md#Roslynator_CSharp_StatementListSelection_Create_Microsoft_CodeAnalysis_CSharp_Syntax_BlockSyntax_Microsoft_CodeAnalysis_Text_TextSpan_) | Creates a new [StatementListSelection](./README.md) based on the specified block and span\. |
| [Create(StatementListInfo, TextSpan)](Create/README.md#Roslynator_CSharp_StatementListSelection_Create_Roslynator_CSharp_Syntax_StatementListInfo__Microsoft_CodeAnalysis_Text_TextSpan_) | Creates a new [StatementListSelection](./README.md) based on the specified [StatementListInfo](../Syntax/StatementListInfo/README.md) and span\. |
| [Create(SwitchSectionSyntax, TextSpan)](Create/README.md#Roslynator_CSharp_StatementListSelection_Create_Microsoft_CodeAnalysis_CSharp_Syntax_SwitchSectionSyntax_Microsoft_CodeAnalysis_Text_TextSpan_) | Creates a new [StatementListSelection](./README.md) based on the specified switch section and span\. |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| First\(\) |  \(Inherited from SyntaxListSelection\<TNode>\) |
| GetEnumerator\(\) |  \(Inherited from SyntaxListSelection\<TNode>\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| Last\(\) |  \(Inherited from SyntaxListSelection\<TNode>\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [TryCreate(BlockSyntax, TextSpan, StatementListSelection)](TryCreate/README.md#Roslynator_CSharp_StatementListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_BlockSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_StatementListSelection__) | Creates a new [StatementListSelection](./README.md) based on the specified block and span\. |
| [TryCreate(SwitchSectionSyntax, TextSpan, StatementListSelection)](TryCreate/README.md#Roslynator_CSharp_StatementListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_SwitchSectionSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_StatementListSelection__) | Creates a new [StatementListSelection](./README.md) based on the specified switch section and span\. |

## Structs

| Struct | Summary |
| ------ | ------- |
| Enumerator |  \(Inherited from SyntaxListSelection\<TNode>\) |

