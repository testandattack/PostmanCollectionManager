using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostmanManager.Models
{
    /// <summary>
    /// If object, contains the complete broken-down URL for this request. If string, 
    /// contains the literal request URL.
    /// </summary>
    [JsonObject(Title = "url")]
    [JsonConverter(typeof(PostmanUrl_JsonConverter))]
    public class Url
    {
        /// <summary>
        /// This property is added to the object to help with JsonSerialization and 
        /// Postman import/export routines. It is not serialized.
        /// </summary>
        [JsonIgnore]
        public bool urlIsInStringFormat { get; set; }

        /// <summary>
        /// The string representation of the request URL, including the protocol, 
        /// host, path, hash, query parameter(s) and path variable(s).
        /// </summary>
        [JsonProperty("raw", NullValueHandling = NullValueHandling.Ignore)]
        public string Raw { get; set; }

        /// <summary>
        /// The protocol associated with the request, E.g: 'http'
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// The host for the URL, E.g: api.yourdomain.com. 
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringOrStringArrayConverter))]
        public string[]? Host { get; set; }

        /// <summary>
        /// The complete path of the current url, broken down into segments. A segment 
        /// could be a string, or a path variable.
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public Path Path { get; set; }

        /// <summary>
        /// The port number present in this URL. An empty value implies 80/443 depending 
        /// on whether the protocol field contains http/https.
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// An array of QueryParams, which is basically the query string part of the 
        /// URL, parsed into separate variables
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public List<Variable> QueryParams { get; set; }

        /// <summary>
        /// Contains the URL fragment (if any). Usually this is not transmitted over the 
        /// network, but it could be useful to store this in some cases.
        /// </summary>
        [JsonProperty("hash", NullValueHandling = NullValueHandling.Ignore)]
        public string Hash { get; set; }

        /// <summary>
        /// Collection variables allow you to define a set of variables, 
        /// that are a *part of the collection*, as opposed to environments, 
        /// which are separate entities.\n*Note: Collection variables must not 
        /// contain any sensitive information.*
        /// </summary>
        [JsonProperty("variable", NullValueHandling = NullValueHandling.Ignore)]
        public List<Variable> Variables { get; set; }
    }
}
