# SyntaxExtensions\.GetFirstDirective\(SyntaxNode, TextSpan, Func\<DirectiveTriviaSyntax, Boolean>\) Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Gets the first directive of the tree rooted by this node\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax GetFirstDirective(this Microsoft.CodeAnalysis.SyntaxNode node, Microsoft.CodeAnalysis.Text.TextSpan span, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool> predicate = null)
```

### Parameters

**node**

**span**

**predicate**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[DirectiveTriviaSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.directivetriviasyntax)

