#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Item Class

One of the primary goals of Postman is to organize the development of APIs. 
To this end, it is necessary to be able to group requests together. This 
can be achived using 'Folders'. A folder just is an ordered set of requests.

```csharp
public class Item : PostmanManager.Models.ItemCollection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ItemCollection](ItemCollection.md 'PostmanManager.Models.ItemCollection') &#129106; Item
### Properties

<a name='PostmanManager.Models.Item.Description'></a>

## Item.Description Property

```csharp
public PostmanManager.Models.Description Description { get; set; }
```

#### Property Value
[Description](Description.md 'PostmanManager.Models.Description')

<a name='PostmanManager.Models.Item.Event'></a>

## Item.Event Property

Defines a script associated with an associated event name

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Event> Event { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Event](Event.md 'PostmanManager.Models.Event')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Item.Name'></a>

## Item.Name Property

A human readable identifier for the current item.

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Item.ProtocolProfileBehavior'></a>

## Item.ProtocolProfileBehavior Property

Set of configurations used to alter the usual behavior of sending the request.

```csharp
public object ProtocolProfileBehavior { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='PostmanManager.Models.Item.Request'></a>

## Item.Request Property

```csharp
public PostmanManager.Models.Request Request { get; set; }
```

#### Property Value
[Request](Request.md 'PostmanManager.Models.Request')

<a name='PostmanManager.Models.Item.Responses'></a>

## Item.Responses Property

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Response> Responses { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Response](Response.md 'PostmanManager.Models.Response')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Item.Variables'></a>

## Item.Variables Property

Using variables in your Postman requests eliminates 
the need to duplicate requests, which can save a 
lot of time. Variables can be defined, and referenced 
to from any part of a request.

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Variable> Variables { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Variable](Variable.md 'PostmanManager.Models.Variable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')