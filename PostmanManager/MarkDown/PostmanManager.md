#### [PostmanManager](PostmanManager.md 'PostmanManager')

## PostmanManager Assembly
### Namespaces

<a name='PostmanManager'></a>

## PostmanManager Namespace

| Classes | |
| :--- | :--- |
| [PostmanAuth_JsonConverter](PostmanAuth_JsonConverter.md 'PostmanManager.PostmanAuth_JsonConverter') | Custom Json Converter to handle [Auth](Auth.md 'PostmanManager.Models.Auth') objects from Postman |
| [PostmanCollection](PostmanCollection.md 'PostmanManager.PostmanCollection') | The root item for postman collections |
| [PostmanDescription_JsonConverter](PostmanDescription_JsonConverter.md 'PostmanManager.PostmanDescription_JsonConverter') | Custom Json Converter to handle [Description](Description.md 'PostmanManager.Models.Description') objects from Postman |
| [PostmanHeader_JsonConverter](PostmanHeader_JsonConverter.md 'PostmanManager.PostmanHeader_JsonConverter') | Custom Json Converter to handle [Header](Header.md 'PostmanManager.Models.Header') objects from Postman |
| [PostmanItem_JsonConverter](PostmanItem_JsonConverter.md 'PostmanManager.PostmanItem_JsonConverter') | Custom Json Converter to handle [PostmanManager.Models.ItemCollection](https://docs.microsoft.com/en-us/dotnet/api/PostmanManager.Models.ItemCollection 'PostmanManager.Models.ItemCollection') objects from Postman |
| [PostmanPath_JsonConverter](PostmanPath_JsonConverter.md 'PostmanManager.PostmanPath_JsonConverter') | Custom Json Converter to handle [Path](Path.md 'PostmanManager.Models.Path') objects from Postman |
| [PostmanRequest_JsonConverter](PostmanRequest_JsonConverter.md 'PostmanManager.PostmanRequest_JsonConverter') | Custom Json Converter to handle [Request](Request.md 'PostmanManager.Models.Request') objects from Postman |
| [PostmanUrl_JsonConverter](PostmanUrl_JsonConverter.md 'PostmanManager.PostmanUrl_JsonConverter') | Custom Json Converter to handle [Url](Url.md 'PostmanManager.Models.Url') objects from Postman |
| [PostmanVersion_JsonConverter](PostmanVersion_JsonConverter.md 'PostmanManager.PostmanVersion_JsonConverter') | Custom Json Converter to handle [Version](Version.md 'PostmanManager.Models.Version') objects from Postman |

<a name='PostmanManager.Models'></a>

## PostmanManager.Models Namespace

| Classes | |
| :--- | :--- |
| [Auth](Auth.md 'PostmanManager.Models.Auth') | Represents authentication helpers provided by Postman |
| [AuthAttribute](AuthAttribute.md 'PostmanManager.Models.AuthAttribute') | Represents an attribute for any authorization method  provided by Postman. For example `username` and `password`  are set as auth attributes for Basic Authentication method. |
| [Body](Body.md 'PostmanManager.Models.Body') | This field contains the data usually contained in the request body. |
| [Certificate](Certificate.md 'PostmanManager.Models.Certificate') | A representation of a list of ssl certificates |
| [Cookie](Cookie.md 'PostmanManager.Models.Cookie') | A representation of a list of cookies |
| [Description](Description.md 'PostmanManager.Models.Description') | |
| [Event](Event.md 'PostmanManager.Models.Event') | |
| [FileUploadObject](FileUploadObject.md 'PostmanManager.Models.FileUploadObject') | |
| [FormParameter](FormParameter.md 'PostmanManager.Models.FormParameter') | |
| [Header](Header.md 'PostmanManager.Models.Header') | |
| [Info](Info.md 'PostmanManager.Models.Info') | Detailed description of the info block |
| [Item](Item.md 'PostmanManager.Models.Item') | One of the primary goals of Postman is to organize the development of APIs.  To this end, it is necessary to be able to group requests together. This  can be achived using 'Folders'. A folder just is an ordered set of requests. |
| [ItemGroup](ItemGroup.md 'PostmanManager.Models.ItemGroup') | Items are entities which contain an actual HTTP request, and sample responses attached to it. |
| [Path](Path.md 'PostmanManager.Models.Path') | The complete path of the current url, broken down into segments. A segment could be a string, or a path variable. |
| [Proxy](Proxy.md 'PostmanManager.Models.Proxy') | Using the Proxy, you can configure your custom proxy into  the postman for particular url match |
| [Request](Request.md 'PostmanManager.Models.Request') | A request represents an HTTP request. If a string, the string is assumed to be the  request URL and the method is assumed to be 'GET'. |
| [Response](Response.md 'PostmanManager.Models.Response') | A response represents an HTTP response. |
| [Script](Script.md 'PostmanManager.Models.Script') | A script is a snippet of Javascript code that can be  used to to perform setup or teardown operations on a particular response. |
| [StringOrNumber](StringOrNumber.md 'PostmanManager.Models.StringOrNumber') | Generic class to handle Json objects that are of type "oneOf" where the choices are "String", "Integer", or null. |
| [Url](Url.md 'PostmanManager.Models.Url') | If object, contains the complete broken-down URL for this request. If string, contains the literal request URL. |
| [UrlEncodedParameter](UrlEncodedParameter.md 'PostmanManager.Models.UrlEncodedParameter') | |
| [Variable](Variable.md 'PostmanManager.Models.Variable') | |
| [Version](Version.md 'PostmanManager.Models.Version') | Postman allows you to version your collections as they grow,  and this field holds the version number. While optional,  it is recommended that you use this field to its fullest extent! |
