# SyntaxExtensions\.WithMembers Method

[Home](../../../../README.md)

**Containing Type**: Roslynator\.CSharp\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WithMembers(ClassDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__) | Creates a new [ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax) with the members updated\. |
| [WithMembers(ClassDeclarationSyntax, MemberDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | Creates a new [ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax) with the members updated\. |
| [WithMembers(CompilationUnitSyntax, IEnumerable\<MemberDeclarationSyntax>)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_CompilationUnitSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__) | Creates a new [CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax) with the members updated\. |
| [WithMembers(CompilationUnitSyntax, MemberDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_CompilationUnitSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | Creates a new [CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax) with the members updated\. |
| [WithMembers(InterfaceDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__) | Creates a new [InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax) with the members updated\. |
| [WithMembers(InterfaceDeclarationSyntax, MemberDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | Creates a new [InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax) with the members updated\. |
| [WithMembers(NamespaceDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__) | Creates a new [NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax) with the members updated\. |
| [WithMembers(NamespaceDeclarationSyntax, MemberDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | Creates a new [NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax) with the members updated\. |
| [WithMembers(StructDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__) | Creates a new [StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax) with the members updated\. |
| [WithMembers(StructDeclarationSyntax, MemberDeclarationSyntax)](#Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_) | Creates a new [StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax) with the members updated\. |

## WithMembers\(ClassDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>\) <a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__"></a>

### Summary

Creates a new [ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax) with the members updated\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax WithMembers(this Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax classDeclaration, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax> members)
```

### Parameters

**classDeclaration**

**members**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

## WithMembers\(ClassDeclarationSyntax, MemberDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

Creates a new [ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax) with the members updated\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax WithMembers(this Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax classDeclaration, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax member)
```

### Parameters

**classDeclaration**

**member**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[ClassDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

## WithMembers\(CompilationUnitSyntax, IEnumerable\<MemberDeclarationSyntax>\) <a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_CompilationUnitSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__"></a>

### Summary

Creates a new [CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax) with the members updated\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax WithMembers(this Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax compilationUnit, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax> members)
```

### Parameters

**compilationUnit**

**members**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax)

## WithMembers\(CompilationUnitSyntax, MemberDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_CompilationUnitSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

Creates a new [CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax) with the members updated\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax WithMembers(this Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax compilationUnit, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax member)
```

### Parameters

**compilationUnit**

**member**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[CompilationUnitSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.compilationunitsyntax)

## WithMembers\(InterfaceDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>\) <a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__"></a>

### Summary

Creates a new [InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax) with the members updated\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax WithMembers(this Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax interfaceDeclaration, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax> members)
```

### Parameters

**interfaceDeclaration**

**members**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax)

## WithMembers\(InterfaceDeclarationSyntax, MemberDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_InterfaceDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

Creates a new [InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax) with the members updated\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax WithMembers(this Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax interfaceDeclaration, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax member)
```

### Parameters

**interfaceDeclaration**

**member**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[InterfaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.interfacedeclarationsyntax)

## WithMembers\(NamespaceDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>\) <a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__"></a>

### Summary

Creates a new [NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax) with the members updated\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax WithMembers(this Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax namespaceDeclaration, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax> members)
```

### Parameters

**namespaceDeclaration**

**members**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax)

## WithMembers\(NamespaceDeclarationSyntax, MemberDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_NamespaceDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

Creates a new [NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax) with the members updated\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax WithMembers(this Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax namespaceDeclaration, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax member)
```

### Parameters

**namespaceDeclaration**

**member**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[NamespaceDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.namespacedeclarationsyntax)

## WithMembers\(StructDeclarationSyntax, IEnumerable\<MemberDeclarationSyntax>\) <a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_System_Collections_Generic_IEnumerable_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax__"></a>

### Summary

Creates a new [StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax) with the members updated\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax WithMembers(this Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax structDeclaration, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax> members)
```

### Parameters

**structDeclaration**

**members**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax)

## WithMembers\(StructDeclarationSyntax, MemberDeclarationSyntax\) <a name="Roslynator_CSharp_SyntaxExtensions_WithMembers_Microsoft_CodeAnalysis_CSharp_Syntax_StructDeclarationSyntax_Microsoft_CodeAnalysis_CSharp_Syntax_MemberDeclarationSyntax_"></a>

### Summary

Creates a new [StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax) with the members updated\.

```csharp
public static Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax WithMembers(this Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax structDeclaration, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax member)
```

### Parameters

**structDeclaration**

**member**

### Returns

Microsoft\.CodeAnalysis\.CSharp\.Syntax\.[StructDeclarationSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.structdeclarationsyntax)

