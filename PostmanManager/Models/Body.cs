using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PostmanManager.Models
{
    /// <summary>
    /// This field contains the data usually contained in the request body.
    /// </summary>
    [JsonObject(Title = "body", ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Body
    {
        /// <summary>
        /// Postman stores the type of data associated with this request in this field.
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public BodyType_Enum Mode { get; set; }

        /// <summary>
        /// No description given 
        /// </summary>
        [JsonProperty("raw", NullValueHandling = NullValueHandling.Ignore)]
        public string Raw { get; set; }

        /// <summary>
        /// No description given 
        /// </summary>
        [JsonProperty("urlencoded", NullValueHandling = NullValueHandling.Ignore)]
        public List<UrlEncodedParameter> UrlEncoded { get; set; }

        /// <summary>
        /// No description given 
        /// </summary>
        [JsonProperty("formdata", NullValueHandling = NullValueHandling.Ignore)]
        public List<FormParameter> FormData { get; set; }

        /// <summary>
        /// No description given 
        /// </summary>
        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public FileUploadObject File { get; set; }

        /// <summary>
        /// No description given 
        /// </summary>
        [JsonProperty("graphql", NullValueHandling = NullValueHandling.Ignore)]
        public object Graphql { get; set; }

        /// <summary>
        /// Additional configurations and options set for various body modes.
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public object Options { get; set; }

        /// <summary>
        /// (Default = false) When set to true, prevents this form data entity from being sent.
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }
    }
}
