# WorkspaceSyntaxExtensions\.Parenthesize\(ExpressionSyntax, Boolean, Boolean\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[WorkspaceSyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.Workspaces\.dll

## Summary

Creates parenthesized expression that is parenthesizing the specified expression\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax Parenthesize(this Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax expression, bool includeElasticTrivia = true, bool simplifiable = true)
```

### Parameters

**expression**

**includeElasticTrivia**

If true, add elastic trivia\.

**simplifiable**

If true, attach [Simplifier.Annotation](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.simplification.simplifier.annotation) to the parenthesized expression\.

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ParenthesizedExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.parenthesizedexpressionsyntax)

