#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## FileUploadObject Class

```csharp
public class FileUploadObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FileUploadObject
### Properties

<a name='PostmanManager.Models.FileUploadObject.Content'></a>

## FileUploadObject.Content Property

No description given

```csharp
public string Content { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.FileUploadObject.Source'></a>

## FileUploadObject.Source Property

Contains the name of the file to upload. _Not the path_.
A null src indicates that no file has been selected as a part of the request body.

```csharp
public string Source { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')