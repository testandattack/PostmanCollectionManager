#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Info Class

Detailed description of the info block

```csharp
public class Info
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Info
### Properties

<a name='PostmanManager.Models.Info.Description'></a>

## Info.Description Property

No description given

```csharp
public PostmanManager.Models.Description Description { get; set; }
```

#### Property Value
[Description](Description.md 'PostmanManager.Models.Description')

<a name='PostmanManager.Models.Info.Name'></a>

## Info.Name Property

A collection's friendly name is defined by this field. 
You would want to set this field to a value that would 
allow you to easily identify this collection among a 
bunch of other collections, as such outlining its usage or content.

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Info.PostmanId'></a>

## Info.PostmanId Property

Every collection is identified by the unique value of 
this field. The value of this field is usually easiest 
to generate using a UID generator function. If you already 
have a collection, it is recommended that you maintain the 
same id since changing the id usually implies that is a 
different collection than it was originally.\n *Note: This 
field exists for compatibility reasons with Collection Format V1.*

```csharp
public string PostmanId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Info.Schema'></a>

## Info.Schema Property

This should ideally hold a link to the Postman schema 
that is used to validate this collection. 
E.g: https://schema.getpostman.com/collection/v1

```csharp
public string Schema { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Info.Version'></a>

## Info.Version Property

see the [Version](Info.md#PostmanManager.Models.Info.Version 'PostmanManager.Models.Info.Version') class for info.

```csharp
public PostmanManager.Models.Version Version { get; set; }
```

#### Property Value
[Version](Version.md 'PostmanManager.Models.Version')