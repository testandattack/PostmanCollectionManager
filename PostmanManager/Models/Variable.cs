using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostmanManager.Models
{
    public class Variable
    {
        /// <summary>
        /// A variable ID is a unique user-defined value that identifies the variable within a collection. In traditional terms, this would be a variable name.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// A variable key is a human friendly value that identifies the variable within a collection. In traditional terms, this would be a variable name.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// The value that a variable holds in this collection. Ultimately, the variables will be replaced by this value, when say running a set of requests from a collection
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public object Value { get; set; }

        /// <summary>
        /// A variable may have multiple types. This field specifies the type of the variable.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public ItemType_Enum? Type { get; set; }

        /// <summary>
        /// Variable name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The raw text description of the variable. NOTE: currently this class does not saupport the use of
        /// objects to hold the description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// (Default = false) When set to true, indicates that this variable has been set by Postman
        /// </summary>
        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public bool? System { get; set; }

        /// <summary>
        /// No Description Given
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

    }
}
