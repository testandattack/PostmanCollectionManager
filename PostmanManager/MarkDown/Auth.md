#### [PostmanManager](PostmanManager.md 'PostmanManager')
### [PostmanManager.Models](PostmanManager.md#PostmanManager.Models 'PostmanManager.Models')

## Auth Class

Represents authentication helpers provided by Postman

```csharp
public class Auth
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Auth
### Properties

<a name='PostmanManager.Models.Auth.ApiKey'></a>

## Auth.ApiKey Property

The attributes for API Key Authentication.

```csharp
public System.Collections.Generic.List<PostmanManager.Models.AuthAttribute> ApiKey { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Auth.AwsV4'></a>

## Auth.AwsV4 Property

The attributes for [AWS Auth](http://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html).

```csharp
public System.Collections.Generic.List<PostmanManager.Models.AuthAttribute> AwsV4 { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Auth.Basic'></a>

## Auth.Basic Property

The attributes for [Basic Authentication](https://en.wikipedia.org/wiki/Basic_access_authentication).

```csharp
public System.Collections.Generic.List<PostmanManager.Models.AuthAttribute> Basic { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Auth.Bearer'></a>

## Auth.Bearer Property

The helper attributes for [Bearer Token Authentication](https://tools.ietf.org/html/rfc6750)

```csharp
public System.Collections.Generic.List<PostmanManager.Models.AuthAttribute> Bearer { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Auth.Digest'></a>

## Auth.Digest Property

The attributes for [Digest Authentication](https://en.wikipedia.org/wiki/Digest_access_authentication).

```csharp
public System.Collections.Generic.List<PostmanManager.Models.AuthAttribute> Digest { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Auth.EdgeGrid'></a>

## Auth.EdgeGrid Property

The attributes for [Akamai EdgeGrid Authentication](https://developer.akamai.com/legacy/introduction/Client_Auth.html).

```csharp
public System.Collections.Generic.List<PostmanManager.Models.AuthAttribute> EdgeGrid { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Auth.Hawk'></a>

## Auth.Hawk Property

The attributes for [Hawk Authentication](https://github.com/hueniverse/hawk)

```csharp
public System.Collections.Generic.List<PostmanManager.Models.AuthAttribute> Hawk { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Auth.Ntlm'></a>

## Auth.Ntlm Property

The attributes for [NTLM Authentication](https://msdn.microsoft.com/en-us/library/cc237488.aspx)

```csharp
public System.Collections.Generic.List<PostmanManager.Models.AuthAttribute> Ntlm { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Auth.OAuth1'></a>

## Auth.OAuth1 Property

"The attributes for [OAuth2](https://oauth.net/1/)

```csharp
public System.Collections.Generic.List<PostmanManager.Models.AuthAttribute> OAuth1 { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='PostmanManager.Models.Auth.OAuth2'></a>

## Auth.OAuth2 Property

Helper attributes for [OAuth2](https://oauth.net/2/)

```csharp
public System.Collections.Generic.List<PostmanManager.Models.AuthAttribute> OAuth2 { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')