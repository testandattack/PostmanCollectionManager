#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Cookie Class

A representation of a list of cookies

```csharp
public class Cookie
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Cookie
### Properties

<a name='PostmanManager.Models.Cookie.Domain'></a>

## Cookie.Domain Property

The domain for which this cookie is valid.

```csharp
public string Domain { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Cookie.Expires'></a>

## Cookie.Expires Property

When the cookie expires.
NOTE: Type = oneOf: string, number

```csharp
public PostmanManager.Models.StringOrNumber Expires { get; set; }
```

#### Property Value
[StringOrNumber](StringOrNumber.md 'PostmanManager.Models.StringOrNumber')

<a name='PostmanManager.Models.Cookie.Extensions'></a>

## Cookie.Extensions Property

Custom attributes for a cookie go here, such as the [Priority Field](https://code.google.com/p/chromium/issues/detail?id=232693)

```csharp
public System.Collections.Generic.List<object> Extensions { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Cookie.HostOnly'></a>

## Cookie.HostOnly Property

True if the cookie is a host-only cookie. (i.e. a request's URL domain must exactly match the domain of the cookie).

```csharp
public System.Nullable<bool> HostOnly { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='PostmanManager.Models.Cookie.HttpOnly'></a>

## Cookie.HttpOnly Property

Indicates if this cookie is HTTP Only. (if True, the cookie is inaccessible to client-side scripts)

```csharp
public System.Nullable<bool> HttpOnly { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='PostmanManager.Models.Cookie.MaxAge'></a>

## Cookie.MaxAge Property

No Description Given

```csharp
public string MaxAge { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Cookie.Name'></a>

## Cookie.Name Property

This is the name of the Cookie.

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Cookie.Path'></a>

## Cookie.Path Property

The path associated with the Cookie.

```csharp
public string Path { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Cookie.Secure'></a>

## Cookie.Secure Property

Indicates if the 'secure' flag is set on the Cookie, meaning that it is transmitted over secure connections only. (typically HTTPS)

```csharp
public System.Nullable<bool> Secure { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='PostmanManager.Models.Cookie.Session'></a>

## Cookie.Session Property

True if the cookie is a session cookie.

```csharp
public System.Nullable<bool> Session { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='PostmanManager.Models.Cookie.Value'></a>

## Cookie.Value Property

The value of the Cookie.

```csharp
public string Value { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')