#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Variable Class

```csharp
public class Variable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Variable
### Properties

<a name='PostmanManager.Models.Variable.Description'></a>

## Variable.Description Property

The raw text description of the variable. NOTE: currently this class does not saupport the use of
objects to hold the description.

```csharp
public string Description { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Variable.Disabled'></a>

## Variable.Disabled Property

No Description Given

```csharp
public bool Disabled { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='PostmanManager.Models.Variable.Id'></a>

## Variable.Id Property

A variable ID is a unique user-defined value that identifies the variable within a collection. In traditional terms, this would be a variable name.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Variable.Key'></a>

## Variable.Key Property

A variable key is a human friendly value that identifies the variable within a collection. In traditional terms, this would be a variable name.

```csharp
public string Key { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Variable.Name'></a>

## Variable.Name Property

Variable name

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Variable.System'></a>

## Variable.System Property

When set to true, indicates that this variable has been set by Postman

```csharp
public bool System { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='PostmanManager.Models.Variable.Type'></a>

## Variable.Type Property

A variable may have multiple types. This field specifies the type of the variable.

```csharp
public PostmanManager.Models.ItemType_Enum Type { get; set; }
```

#### Property Value
[PostmanManager.Models.ItemType_Enum](https://docs.microsoft.com/en-us/dotnet/api/PostmanManager.Models.ItemType_Enum 'PostmanManager.Models.ItemType_Enum')

<a name='PostmanManager.Models.Variable.Value'></a>

## Variable.Value Property

The value that a variable holds in this collection. Ultimately, the variables will be replaced by this value, when say running a set of requests from a collection

```csharp
public object Value { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')