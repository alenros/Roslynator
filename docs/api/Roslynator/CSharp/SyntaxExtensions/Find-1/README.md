# SyntaxExtensions\.Find Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Find(SyntaxTokenList, SyntaxKind)](../Find/README.md#Roslynator_CSharp_SyntaxExtensions_Find_Microsoft_CodeAnalysis_SyntaxTokenList_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Searches for a token of the specified kind and returns the first occurrence within the entire [SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)\. |
| [Find(SyntaxTriviaList, SyntaxKind)](../Find/README.md#Roslynator_CSharp_SyntaxExtensions_Find_Microsoft_CodeAnalysis_SyntaxTriviaList_Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Searches for a trivia of the specified kind and returns the first occurrence within the entire [SyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\. |
| [Find\<TNode>(SeparatedSyntaxList\<TNode>, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_Find__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Searches for a node of the specified kind and returns the first occurrence within the entire [SeparatedSyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\. |
| [Find\<TNode>(SyntaxList\<TNode>, SyntaxKind)](#Roslynator_CSharp_SyntaxExtensions_Find__1_Microsoft_CodeAnalysis_SyntaxList___0__Microsoft_CodeAnalysis_CSharp_SyntaxKind_) | Searches for a node of the specified kind and returns the first occurrence within the entire [SyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\. |

## Find\(SyntaxTokenList, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_Find_Microsoft_CodeAnalysis_SyntaxTokenList_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Searches for a token of the specified kind and returns the first occurrence within the entire [SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxToken Find(this Microsoft.CodeAnalysis.SyntaxTokenList tokenList, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind)
```

### Parameters

**tokenList**

**kind**

### Returns

Microsoft\.CodeAnalysis\.[SyntaxToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtoken)

## Find\(SyntaxTriviaList, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_Find_Microsoft_CodeAnalysis_SyntaxTriviaList_Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Searches for a trivia of the specified kind and returns the first occurrence within the entire [SyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\.

```csharp
public static Microsoft.CodeAnalysis.SyntaxTrivia Find(this Microsoft.CodeAnalysis.SyntaxTriviaList triviaList, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind)
```

### Parameters

**triviaList**

**kind**

### Returns

Microsoft\.CodeAnalysis\.[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

## Find\<TNode>\(SeparatedSyntaxList\<TNode>, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_Find__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Searches for a node of the specified kind and returns the first occurrence within the entire [SeparatedSyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\.

```csharp
public static TNode Find<TNode>(this Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> list, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list**

**kind**

### Returns

TNode

## Find\<TNode>\(SyntaxList\<TNode>, SyntaxKind\) <a name="Roslynator_CSharp_SyntaxExtensions_Find__1_Microsoft_CodeAnalysis_SyntaxList___0__Microsoft_CodeAnalysis_CSharp_SyntaxKind_"></a>

### Summary

Searches for a node of the specified kind and returns the first occurrence within the entire [SyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)\.

```csharp
public static TNode Find<TNode>(this Microsoft.CodeAnalysis.SyntaxList<TNode> list, Microsoft.CodeAnalysis.CSharp.SyntaxKind kind) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**list**

**kind**

### Returns

TNode
