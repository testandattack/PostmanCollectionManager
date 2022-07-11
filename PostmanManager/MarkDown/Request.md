#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Request Class

A request represents an HTTP request. If a string, the string is assumed to be the 
request URL and the method is assumed to be 'GET'.

```csharp
public class Request
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Request
### Properties

<a name='PostmanManager.Models.Request.Auth'></a>

## Request.Auth Property

Represents authentication helpers provided by Postman

```csharp
public PostmanManager.Models.Auth Auth { get; set; }
```

#### Property Value
[Auth](Auth.md 'PostmanManager.Models.Auth')

<a name='PostmanManager.Models.Request.Body'></a>

## Request.Body Property

This field contains the data usually contained in the request body.

```csharp
public PostmanManager.Models.Body Body { get; set; }
```

#### Property Value
[Body](Body.md 'PostmanManager.Models.Body')

<a name='PostmanManager.Models.Request.Certificate'></a>

## Request.Certificate Property

A representation of an ssl certificate

```csharp
public PostmanManager.Models.Certificate Certificate { get; set; }
```

#### Property Value
[Certificate](Certificate.md 'PostmanManager.Models.Certificate')

<a name='PostmanManager.Models.Request.Description'></a>

## Request.Description Property

The description of this request.

```csharp
public PostmanManager.Models.Description Description { get; set; }
```

#### Property Value
[Description](Description.md 'PostmanManager.Models.Description')

<a name='PostmanManager.Models.Request.Headers'></a>

## Request.Headers Property

A representation for a list of headers.

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Header> Headers { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Header](Header.md 'PostmanManager.Models.Header')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Request.Method'></a>

## Request.Method Property

The Standard HTTP method associated with this request.

```csharp
public string Method { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Request.Proxy'></a>

## Request.Proxy Property

Using the Proxy, you can configure your custom proxy into the postman for 
particular url match

```csharp
public PostmanManager.Models.Proxy Proxy { get; set; }
```

#### Property Value
[Proxy](Proxy.md 'PostmanManager.Models.Proxy')

<a name='PostmanManager.Models.Request.RawRequest'></a>

## Request.RawRequest Property

This string holds the value of a Postman Request object that was stored as a string value.
If the Request is an object, then this string will be empty.

```csharp
public string RawRequest { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Request.Url'></a>

## Request.Url Property

If object, contains the complete broken-down URL for this request. If 
string, contains the literal request URL.

```csharp
public PostmanManager.Models.Url Url { get; set; }
```

#### Property Value
[Url](Url.md 'PostmanManager.Models.Url')