# MetadataName\.Parse\(String\) Method

[Home](../../../README.md)

**Containing Type**: Roslynator\.[MetadataName](../README.md)

**Assembly**: Roslynator\.Core\.dll

## Summary

Converts the string representation of a fully qualified metadata name to its MetadataName equivalent\.

```csharp
public static Roslynator.MetadataName Parse(string name)
```

### Parameters

**name**

### Returns

Roslynator\.[MetadataName](../README.md)

### Exceptions

System\.[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)

**name** is empty or invalid\.

System\.[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**name** is `null`\.

