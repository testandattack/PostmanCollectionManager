#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Description Class

```csharp
public class Description
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Description
### Properties

<a name='PostmanManager.Models.Description.Content'></a>

## Description.Content Property

The content of the description goes here, as a raw string.

```csharp
public string Content { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Description.Type'></a>

## Description.Type Property

Holds the mime type of the raw description content. 
E.g: 'text/markdown' or 'text/html'.\nThe type is 
used to correctly render the description when generating 
documentation, or in the Postman app.

```csharp
public string Type { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Description.Version'></a>

## Description.Version Property

Description can have versions associated with it, which should be put in this property.

```csharp
public PostmanManager.Models.Version Version { get; set; }
```

#### Property Value
[Version](Version.md 'PostmanManager.Models.Version')