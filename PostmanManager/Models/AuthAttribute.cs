using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostmanManager.Models
{
    /// <summary>
    /// Represents an attribute for any authorization method 
    /// provided by Postman. For example `username` and `password` 
    /// are set as auth attributes for Basic Authentication method.
    /// </summary>
    public class AuthAttribute
    {
        /// <summary>
        /// No Description Given
        /// </summary>
        [JsonProperty("key"), JsonRequired]
        public string Key { get; set; }

        /// <summary>
        /// No Description Given
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public object Value { get; set; }

        /// <summary>
        /// No Description Given
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
