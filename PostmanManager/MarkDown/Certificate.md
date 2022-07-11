#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Certificate Class

A representation of a list of ssl certificates

```csharp
public class Certificate
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Certificate
### Properties

<a name='PostmanManager.Models.Certificate.Cert'></a>

## Certificate.Cert Property

An object containing path to file certificate, on the file system

```csharp
public object Cert { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='PostmanManager.Models.Certificate.Key'></a>

## Certificate.Key Property

An object containing path to file containing private key, on the file system

```csharp
public object Key { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='PostmanManager.Models.Certificate.Matches'></a>

## Certificate.Matches Property

A list of Url match pattern strings, to identify Urls this certificate can be used for.

```csharp
public string[] Matches { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='PostmanManager.Models.Certificate.Name'></a>

## Certificate.Name Property

A name for the certificate for user reference

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Certificate.PassPhrase'></a>

## Certificate.PassPhrase Property

The passphrase for the certificate

```csharp
public string PassPhrase { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')