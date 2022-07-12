using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostmanManager.Models
{
    /// <summary>
    /// A representation of a list of cookies
    /// </summary>
    [JsonObject(Title = "cookie", ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Cookie
    {

        /// <summary>
        /// The domain for which this cookie is valid.
        /// </summary>
        [JsonProperty("domain"), JsonRequired]
        public string Domain { get; set; }

        /// <summary>
        /// When the cookie expires.
        /// NOTE: Type = oneOf: string, number
        /// </summary>
        [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringOrNumberConverter))]
        public StringOrNumber Expires { get; set; }

        /// <summary>
        /// No Description Given
        /// </summary>
        [JsonProperty("maxAge", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxAge { get; set; }

        /// <summary>
        /// True if the cookie is a host-only cookie. (i.e. a request's URL domain must exactly match the domain of the cookie).
        /// </summary>
        [JsonProperty("hostOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HostOnly { get; set; }

        /// <summary>
        /// Indicates if this cookie is HTTP Only. (if True, the cookie is inaccessible to client-side scripts)
        /// </summary>
        [JsonProperty("httpOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HttpOnly { get; set; }

        /// <summary>
        /// This is the name of the Cookie.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The path associated with the Cookie.
        /// </summary>
        [JsonProperty("path"), JsonRequired]
        public string Path { get; set; }

        /// <summary>
        /// Indicates if the 'secure' flag is set on the Cookie, meaning that it is transmitted over secure connections only. (typically HTTPS)
        /// </summary>
        [JsonProperty("secure", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Secure { get; set; }

        /// <summary>
        /// True if the cookie is a session cookie.
        /// </summary>
        [JsonProperty("session", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Session { get; set; }

        /// <summary>
        /// The value of the Cookie.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// Custom attributes for a cookie go here, such as the [Priority Field](https://code.google.com/p/chromium/issues/detail?id=232693)
        /// </summary>
        [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Extensions { get; set; }
    }
}
