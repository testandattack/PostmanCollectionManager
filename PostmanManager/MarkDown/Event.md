#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Event Class

```csharp
public class Event
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Event
### Properties

<a name='PostmanManager.Models.Event.Disabled'></a>

## Event.Disabled Property

(Default = false) Indicates whether the event is disabled. If absent, the event is assumed to be enabled.

```csharp
public System.Nullable<bool> Disabled { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='PostmanManager.Models.Event.Id'></a>

## Event.Id Property

A unique identifier for the enclosing event.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Event.Listen'></a>

## Event.Listen Property

Can be set to `test` or `prerequest` for test scripts or pre-request scripts respectively.

```csharp
public string Listen { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Event.Script'></a>

## Event.Script Property

"A script is a snippet of Javascript code that can be used to to perform setup or teardown operations on a particular response.

```csharp
public PostmanManager.Models.Script Script { get; set; }
```

#### Property Value
[Script](Script.md 'PostmanManager.Models.Script')