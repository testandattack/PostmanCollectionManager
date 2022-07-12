using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PostmanManager.Models
{
    /// <summary>
    /// Using the Proxy, you can configure your custom proxy into 
    /// the postman for particular url match
    /// </summary>
    public class Proxy
    {
        /// <summary>
        /// The Url match for which the proxy config is defined. Default Value = "http+https://*/*"
        /// </summary>
        [JsonProperty("match", NullValueHandling = NullValueHandling.Ignore)]
        public string Match { get; set; }

        /// <summary>
        /// The proxy server host
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// The proxy server port
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// (Default = false) The tunneling details for the proxy config
        /// </summary>
        [JsonProperty("tunnel", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tunnel { get; set; }

        /// <summary>
        /// (Default = false)When set to true, ignores this proxy configuration entity
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }
    }
}
