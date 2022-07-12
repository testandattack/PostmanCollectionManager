#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## ItemGroup Class

Items are entities which contain an actual HTTP request, and sample responses attached to it.

```csharp
public class ItemGroup : PostmanManager.Models.ItemCollection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ItemCollection](ItemCollection.md 'PostmanManager.Models.ItemCollection') &#129106; ItemGroup
### Properties

<a name='PostmanManager.Models.ItemGroup.Auth'></a>

## ItemGroup.Auth Property

Represents authentication helpers provided by Postman.

```csharp
public PostmanManager.Models.Auth Auth { get; set; }
```

#### Property Value
[Auth](Auth.md 'PostmanManager.Models.Auth')

<a name='PostmanManager.Models.ItemGroup.Description'></a>

## ItemGroup.Description Property

```csharp
public PostmanManager.Models.Description Description { get; set; }
```

#### Property Value
[Description](Description.md 'PostmanManager.Models.Description')

<a name='PostmanManager.Models.ItemGroup.Event'></a>

## ItemGroup.Event Property

Defines a script associated with an associated event name

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Event> Event { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Event](Event.md 'PostmanManager.Models.Event')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.ItemGroup.Items'></a>

## ItemGroup.Items Property

Items are entities which contain an actual HTTP request, 
and sample responses attached to it.

```csharp
public System.Collections.Generic.List<PostmanManager.Models.ItemCollection> Items { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ItemCollection](ItemCollection.md 'PostmanManager.Models.ItemCollection')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.ItemGroup.Name'></a>

## ItemGroup.Name Property

A human readable identifier for the current item.

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.ItemGroup.ProtocolProfileBehavior'></a>

## ItemGroup.ProtocolProfileBehavior Property

Set of configurations used to alter the usual behavior of sending the request.

```csharp
public object ProtocolProfileBehavior { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='PostmanManager.Models.ItemGroup.Variables'></a>

## ItemGroup.Variables Property

Using variables in your Postman requests eliminates 
the need to duplicate requests, which can save a 
lot of time. Variables can be defined, and referenced 
to from any part of a request.

```csharp
public System.Collections.Generic.List<PostmanManager.Models.Variable> Variables { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Variable](Variable.md 'PostmanManager.Models.Variable')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')