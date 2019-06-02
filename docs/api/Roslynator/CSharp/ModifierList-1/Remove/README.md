# ModifierList\.Remove Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[ModifierList\<TNode>](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Remove(TNode, SyntaxKind)](#Roslynator_CSharp_ModifierList_1_Remove__0_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Creates a new node with a modifier of the specified kind removed\. |
| [Remove(TNode, SyntaxToken)](#Roslynator_CSharp_ModifierList_1_Remove__0_Microsoft_CodeAnalysis_SyntaxToken_) | Creates a new node with the specified modifier removed\. |

## Remove\(TNode, SyntaxKind\) <a name="Roslynator_CSharp_ModifierList_1_Remove__0_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Creates a new node with a modifier of the specified kind removed\.

```csharp
public TNode Remove(TNode node, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind)
```

### Parameters

**node**

**kind**

### Returns

TNode

## Remove\(TNode, SyntaxToken\) <a name="Roslynator_CSharp_ModifierList_1_Remove__0_Microsoft_CodeAnalysis_SyntaxToken_"></a>

### Summary

Creates a new node with the specified modifier removed\.

```csharp
public TNode Remove(TNode node, Microsoft.CodeAnalysis.SyntaxToken modifier)
```

### Parameters

**node**

**modifier**

### Returns

TNode
