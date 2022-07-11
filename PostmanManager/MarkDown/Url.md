#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Url Class

If object, contains the complete broken-down URL for this request. If string, contains the literal request URL.

```csharp
public class Url
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Url
### Properties

<a name='PostmanManager.Models.Url.Hash'></a>

## Url.Hash Property

Contains the URL fragment (if any). Usually this is not transmitted over the network, but it could be useful to store this in some cases.

```csharp
public string Hash { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Url.Host'></a>

## Url.Host Property

The host for the URL, E.g: api.yourdomain.com.

```csharp
public string[] Host { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='PostmanManager.Models.Url.Path'></a>

## Url.Path Property

The complete path of the current url, broken down into segments. A segment could be a string, or a path variable.

```csharp
public PostmanManager.Models.Path Path { get; set; }
```

#### Property Value
[Path](Path.md 'PostmanManager.Models.Path')

<a name='PostmanManager.Models.Url.Port'></a>

## Url.Port Property

The port number present in this URL. An empty value implies 80/443 depending on whether the protocol field contains http/https.

```csharp
public string Port { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Url.Protocol'></a>

## Url.Protocol Property

The protocol associated with the request, E.g: 'http'

```csharp
public string Protocol { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Url.QueryParams'></a>

## Url.QueryParams Property

An array of QueryParams, which is basically the query string part of the URL, parsed into separate variables

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Variable> QueryParams { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Variable](Variable.md 'PostmanManager.Models.Variable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Url.Raw'></a>

## Url.Raw Property

The string representation of the request URL, including the protocol, host, path, hash, query parameter(s) and path variable(s).

```csharp
public string Raw { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')