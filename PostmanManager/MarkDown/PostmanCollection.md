#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager](PostmanManager.md#PostmanManager 'PostmanManager')

## PostmanCollection Class

The root item for postman collections

```csharp
public class PostmanCollection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PostmanCollection

### Remarks
FROM [geoffgr]. The summary documentation is directly from the postman 
schema listed below:

```csharp
"$schema": "http://json-schema.org/draft-04/schema#",
"id": "https://schema.getpostman.com/json/collection/v2.1.0/",
```
The C# objects created in this package are not guaranteed to be 
identical to the objects in postman, but they should always serialize to 
a json object that can be imported into Postman.
### Properties

<a name='PostmanManager.PostmanCollection.Auth'></a>

## PostmanCollection.Auth Property

Represents authentication helpers provided by Postman

```csharp
public PostmanManager.Models.Auth Auth { get; set; }
```

#### Property Value
[Auth](Auth.md 'PostmanManager.Models.Auth')

<a name='PostmanManager.PostmanCollection.Events'></a>

## PostmanCollection.Events Property

Postman allows you to configure scripts to run when specific events 
occur. These scripts are stored here, and can be referenced in the 
collection by their ID.

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Event> Events { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Event](Event.md 'PostmanManager.Models.Event')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.PostmanCollection.Info'></a>

## PostmanCollection.Info Property

Detailed description of the info block

```csharp
public PostmanManager.Models.Info Info { get; set; }
```

#### Property Value
[Info](Info.md 'PostmanManager.Models.Info')

<a name='PostmanManager.PostmanCollection.Items'></a>

## PostmanCollection.Items Property

Items are the basic unit for a Postman collection. 
You can think of them as corresponding to a single 
API endpoint. Each Item has one request and may have 
multiple API responses associated with it.

```csharp
public System.Collections.Generic.List<PostmanManager.Models.ItemCollection> Items { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ItemCollection](ItemCollection.md 'PostmanManager.Models.ItemCollection')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.PostmanCollection.ProtocolProfileBehavior'></a>

## PostmanCollection.ProtocolProfileBehavior Property

Set of configurations used to alter the usual behavior of sending the request.

```csharp
public object ProtocolProfileBehavior { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='PostmanManager.PostmanCollection.Variables'></a>

## PostmanCollection.Variables Property

Collection variables allow you to define a set of variables, 
that are a *part of the collection*, as opposed to environments, 
which are separate entities.\n*Note: Collection variables must 
not contain any sensitive information.*

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Variable> Variables { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Variable](Variable.md 'PostmanManager.Models.Variable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Methods

<a name='PostmanManager.PostmanCollection.LoadCollection(string)'></a>

## PostmanCollection.LoadCollection(string) Method

Loads an exported Postman Collection json file into the [PostmanCollection](PostmanCollection.md 'PostmanManager.PostmanCollection') object.

```csharp
public static PostmanManager.PostmanCollection LoadCollection(string fileName);
```
#### Parameters

<a name='PostmanManager.PostmanCollection.LoadCollection(string).fileName'></a>

`fileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[PostmanCollection](PostmanCollection.md 'PostmanManager.PostmanCollection')

<a name='PostmanManager.PostmanCollection.SaveCollection(PostmanManager.PostmanCollection,string)'></a>

## PostmanCollection.SaveCollection(PostmanCollection, string) Method

```csharp
public static void SaveCollection(PostmanManager.PostmanCollection source, string fileName);
```
#### Parameters

<a name='PostmanManager.PostmanCollection.SaveCollection(PostmanManager.PostmanCollection,string).source'></a>

`source` [PostmanCollection](PostmanCollection.md 'PostmanManager.PostmanCollection')

<a name='PostmanManager.PostmanCollection.SaveCollection(PostmanManager.PostmanCollection,string).fileName'></a>

`fileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')