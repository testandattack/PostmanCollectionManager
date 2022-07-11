#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Response Class

A response represents an HTTP response.

```csharp
public class Response
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Response
### Properties

<a name='PostmanManager.Models.Response.Body'></a>

## Response.Body Property

The raw text of the response

```csharp
public string Body { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Response.Code'></a>

## Response.Code Property

The numerical response code, example: 200, 201, 404, etc.

```csharp
public int Code { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='PostmanManager.Models.Response.Cookies'></a>

## Response.Cookies Property

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Cookie> Cookies { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Cookie](Cookie.md 'PostmanManager.Models.Cookie')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Response.Headers'></a>

## Response.Headers Property

No HTTP request is complete without its headers, and the 
same is true for a Postman request. This field is an array 
containing all the headers.

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Header> Headers { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Header](Header.md 'PostmanManager.Models.Header')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Response.Id'></a>

## Response.Id Property

A unique, user defined identifier that can  be used to 
refer to this response from requests.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Response.OriginalRequest'></a>

## Response.OriginalRequest Property

[Request](Request.md 'PostmanManager.Models.Request')

```csharp
public PostmanManager.Models.Request OriginalRequest { get; set; }
```

#### Property Value
[Request](Request.md 'PostmanManager.Models.Request')

<a name='PostmanManager.Models.Response.ResponseTime'></a>

## Response.ResponseTime Property

The time taken by the request to complete. If a number, the '
unit is milliseconds. If the response is manually created, 
this can be set to `null`.

```csharp
public PostmanManager.Models.StringOrNumber ResponseTime { get; set; }
```

#### Property Value
[StringOrNumber](StringOrNumber.md 'PostmanManager.Models.StringOrNumber')

<a name='PostmanManager.Models.Response.Status'></a>

## Response.Status Property

The response status, e.g: '200 OK'

```csharp
public string Status { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Response.Timings'></a>

## Response.Timings Property

Set of timing information related to request and response in milliseconds

```csharp
public object Timings { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')