#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Version Class

Postman allows you to version your collections as they grow, 
and this field holds the version number. While optional, 
it is recommended that you use this field to its fullest extent!

```csharp
public class Version
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Version
### Properties

<a name='PostmanManager.Models.Version.Identifier'></a>

## Version.Identifier Property

A human friendly identifier to make sense of the version numbers. E.g: 'beta-3'

```csharp
public string Identifier { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='PostmanManager.Models.Version.Major'></a>

## Version.Major Property

Increment this number if you make changes to the collection that changes its behaviour. 
E.g: Removing or adding new test scripts. (partly or completely).

```csharp
public int Major { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='PostmanManager.Models.Version.Minor'></a>

## Version.Minor Property

You should increment this number if you make changes that will not break 
anything that uses the collection. E.g: removing a folder.

```csharp
public int Minor { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='PostmanManager.Models.Version.Patch'></a>

## Version.Patch Property

Ideally, minor changes to a collection should result in the increment of this number.

```csharp
public int Patch { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='PostmanManager.Models.Version.VersionAsString'></a>

## Version.VersionAsString Property

Holds the string representation of a Postman Version if the JSON has
the Version stored as a string instead of an object

```csharp
public string VersionAsString { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')