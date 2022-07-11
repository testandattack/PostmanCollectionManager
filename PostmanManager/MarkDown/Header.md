#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Header Class

```csharp
public class Header
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Header
### Properties

<a name='PostmanManager.Models.Header.Description'></a>

## Header.Description Property

A description of the header

```csharp
public PostmanManager.Models.Description Description { get; set; }
```

#### Property Value
[Description](Description.md 'PostmanManager.Models.Description')

<a name='PostmanManager.Models.Header.Disabled'></a>

## Header.Disabled Property

If set to true, the current header will not be sent with requests.

```csharp
public bool Disabled { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='PostmanManager.Models.Header.Key'></a>

## Header.Key Property

This holds the LHS of the HTTP Header, e.g ``Content-Type`` or ``X-Custom-Header``

```csharp
public string Key { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Header.Value'></a>

## Header.Value Property

The value (or the RHS) of the Header is stored in this field.

```csharp
public string Value { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')