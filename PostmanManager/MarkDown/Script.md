#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Script Class

A script is a snippet of Javascript code that can be 
used to to perform setup or teardown operations on a particular response.

```csharp
public class Script
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Script
### Properties

<a name='PostmanManager.Models.Script.Exec'></a>

## Script.Exec Property

This is an array of strings, where each line 
represents a single line of code. Having lines 
separate makes it possible to easily track 
changes made to scripts.

```csharp
public string[]? Exec { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='PostmanManager.Models.Script.Id'></a>

## Script.Id Property

A unique, user defined identifier that can  
be used to refer to this script from requests.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Script.Name'></a>

## Script.Name Property

script name

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Script.Type'></a>

## Script.Type Property

Type of the script. E.g: 'text/javascript'

```csharp
public string Type { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Script.Url'></a>

## Script.Url Property

No Description Given

```csharp
public PostmanManager.Models.Url Url { get; set; }
```

#### Property Value
[Url](Url.md 'PostmanManager.Models.Url')