# SyntaxInfo\.ConditionalExpressionInfo Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxInfo](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ConditionalExpressionInfo(ConditionalExpressionSyntax, Boolean, Boolean)](#Roslynator_CSharp_SyntaxInfo_ConditionalExpressionInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ConditionalExpressionSyntax_System_Boolean_System_Boolean_) | Creates a new [ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md) from the specified conditional expression\. |
| [ConditionalExpressionInfo(SyntaxNode, Boolean, Boolean)](#Roslynator_CSharp_SyntaxInfo_ConditionalExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_System_Boolean_) | Creates a new [ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md) from the specified node\. |

## ConditionalExpressionInfo\(ConditionalExpressionSyntax, Boolean, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_ConditionalExpressionInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ConditionalExpressionSyntax_System_Boolean_System_Boolean_"></a>

### Summary

Creates a new [ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md) from the specified conditional expression\.

```csharp
public static Roslynator.CSharp.Syntax.ConditionalExpressionInfo ConditionalExpressionInfo(Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax conditionalExpression, bool walkDownParentheses = true, bool allowMissing = false)
```

### Parameters

**conditionalExpression**

**walkDownParentheses**

**allowMissing**

### Returns

Roslynator\.CSharp\.Syntax\.[ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md)

## ConditionalExpressionInfo\(SyntaxNode, Boolean, Boolean\) <a name="Roslynator_CSharp_SyntaxInfo_ConditionalExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_System_Boolean_"></a>

### Summary

Creates a new [ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md) from the specified node\.

```csharp
public static Roslynator.CSharp.Syntax.ConditionalExpressionInfo ConditionalExpressionInfo(Microsoft.CodeAnalysis.SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false)
```

### Parameters

**node**

**walkDownParentheses**

**allowMissing**

### Returns

Roslynator\.CSharp\.Syntax\.[ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md)
