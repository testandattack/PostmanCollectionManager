﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostmanManager.Models
{
    [JsonObject(Title = "description")]
    [JsonConverter(typeof(PostmanDescription_JsonConverter))]
    public class Description
    {

        /// <summary>
        /// The content of the description goes here, as a raw string.
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// Holds the mime type of the raw description content. 
        /// E.g: 'text/markdown' or 'text/html'.\nThe type is 
        /// used to correctly render the description when generating 
        /// documentation, or in the Postman app.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Description can have versions associated with it, which should be put in this property.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public Version Version { get; set; }
    }
}
