﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostmanManager.Models
{
    /// <summary>
    /// One of the primary goals of Postman is to organize the development of APIs. 
    /// To this end, it is necessary to be able to group requests together. This 
    /// can be achived using 'Folders'. A folder just is an ordered set of requests.
    /// </summary>
    //[JsonObject(Title = "item")]
    //[JsonConverter(typeof(PostmanItem_JsonConverter))]
    public class Item : ItemCollection
    {
        /// <summary>
        /// A human readable identifier for the current item.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public Description Description { get; set; }

        /// <summary>
        /// Using variables in your Postman requests eliminates 
        /// the need to duplicate requests, which can save a 
        /// lot of time. Variables can be defined, and referenced 
        /// to from any part of a request.
        /// </summary>
        [JsonProperty("variable", NullValueHandling = NullValueHandling.Ignore)]
        public List<Variable> Variables { get; set; }

        /// <summary>
        /// Defines a script associated with an associated event name
        /// </summary>
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public List<Event> Event { get; set; }

        /// <summary>
        /// Set of configurations used to alter the usual behavior of sending the request.
        /// </summary>
        [JsonProperty("protocolProfileBehavior", NullValueHandling = NullValueHandling.Ignore)]
        public object ProtocolProfileBehavior { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request"), JsonRequired]
        public Request Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public List<Response> Responses { get; set; }
    }
}
