#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Proxy Class

Using the Proxy, you can configure your custom proxy into 
the postman for particular url match

```csharp
public class Proxy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Proxy
### Properties

<a name='PostmanManager.Models.Proxy.Disabled'></a>

## Proxy.Disabled Property

When set to true, ignores this proxy configuration entity

```csharp
public bool Disabled { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='PostmanManager.Models.Proxy.Host'></a>

## Proxy.Host Property

The proxy server host

```csharp
public string Host { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Proxy.Match'></a>

## Proxy.Match Property

The Url match for which the proxy config is defined.

```csharp
public string Match { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Proxy.Port'></a>

## Proxy.Port Property

The proxy server port

```csharp
public int Port { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='PostmanManager.Models.Proxy.Tunnel'></a>

## Proxy.Tunnel Property

The tunneling details for the proxy config

```csharp
public bool Tunnel { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')