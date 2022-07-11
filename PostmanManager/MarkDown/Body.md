#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Body Class

This field contains the data usually contained in the request body.

```csharp
public class Body
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Body
### Properties

<a name='PostmanManager.Models.Body.Disabled'></a>

## Body.Disabled Property

When set to true, prevents this form data entity from being sent.

```csharp
public bool Disabled { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='PostmanManager.Models.Body.File'></a>

## Body.File Property

No description given

```csharp
public PostmanManager.Models.FileUploadObject File { get; set; }
```

#### Property Value
[FileUploadObject](FileUploadObject.md 'PostmanManager.Models.FileUploadObject')

<a name='PostmanManager.Models.Body.FormData'></a>

## Body.FormData Property

No description given

```csharp
public System.Collections.Generic.List<PostmanManager.Models.FormParameter> FormData { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[FormParameter](FormParameter.md 'PostmanManager.Models.FormParameter')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Body.Graphql'></a>

## Body.Graphql Property

No description given

```csharp
public object Graphql { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='PostmanManager.Models.Body.Mode'></a>

## Body.Mode Property

Postman stores the type of data associated with this request in this field.

```csharp
public PostmanManager.Models.BodyType_Enum Mode { get; set; }
```

#### Property Value
[PostmanManager.Models.BodyType_Enum](https://docs.microsoft.com/en-us/dotnet/api/PostmanManager.Models.BodyType_Enum 'PostmanManager.Models.BodyType_Enum')

<a name='PostmanManager.Models.Body.Options'></a>

## Body.Options Property

Additional configurations and options set for various body modes.

```csharp
public object Options { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='PostmanManager.Models.Body.Raw'></a>

## Body.Raw Property

No description given

```csharp
public string Raw { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Body.UrlEncoded'></a>

## Body.UrlEncoded Property

No description given

```csharp
public System.Collections.Generic.List<PostmanManager.Models.UrlEncodedParameter> UrlEncoded { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[UrlEncodedParameter](UrlEncodedParameter.md 'PostmanManager.Models.UrlEncodedParameter')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')