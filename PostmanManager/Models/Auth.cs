﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostmanManager.Models
{
    /// <summary>
    /// Represents authentication helpers provided by Postman
    /// </summary>
    [JsonObject(Title = "auth")]
    [JsonConverter(typeof(PostmanAuth_JsonConverter))]
    public class Auth
    {
        [JsonProperty("type"), JsonRequired]
        [JsonConverter(typeof(StringEnumConverter))]
        public AuthType_Enum Type { get; set; }
        
        /// <summary>
        /// No Description Given
        /// </summary>
        [JsonProperty("noauth", NullValueHandling = NullValueHandling.Ignore)]
        public object NoAuth { get; set; }

        /// <summary>
        /// The attributes for API Key Authentication.
        /// </summary>
        [JsonProperty("apikey", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthAttribute> ApiKey { get; set; }

        /// <summary>
        /// The attributes for [AWS Auth](http://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html).
        /// </summary>
        [JsonProperty("awsv4", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthAttribute> AwsV4 { get; set; }

        /// <summary>
        /// The attributes for [Basic Authentication](https://en.wikipedia.org/wiki/Basic_access_authentication).
        /// </summary>
        [JsonProperty("basic", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthAttribute> Basic { get; set; }

        /// <summary>
        /// The helper attributes for [Bearer Token Authentication](https://tools.ietf.org/html/rfc6750)
        /// </summary>
        [JsonProperty("bearer", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthAttribute> Bearer { get; set; }

        /// <summary>
        /// The attributes for [Digest Authentication](https://en.wikipedia.org/wiki/Digest_access_authentication).
        /// </summary>
        [JsonProperty("digest", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthAttribute> Digest { get; set; }

        /// <summary>
        /// The attributes for [Akamai EdgeGrid Authentication](https://developer.akamai.com/legacy/introduction/Client_Auth.html).
        /// </summary>
        [JsonProperty("edgegrid", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthAttribute> EdgeGrid { get; set; }

        /// <summary>
        /// The attributes for [Hawk Authentication](https://github.com/hueniverse/hawk)
        /// </summary>
        [JsonProperty("hawk", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthAttribute> Hawk { get; set; }

        /// <summary>
        /// The attributes for [NTLM Authentication](https://msdn.microsoft.com/en-us/library/cc237488.aspx)
        /// </summary>
        [JsonProperty("ntlm", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthAttribute> Ntlm { get; set; }

        /// <summary>
        /// "The attributes for [OAuth1](https://oauth.net/1/)
        /// </summary>
        [JsonProperty("oauth1", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthAttribute> OAuth1 { get; set; }

        /// <summary>
        /// Helper attributes for [OAuth2](https://oauth.net/2/)
        /// </summary>
        [JsonProperty("oauth2", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthAttribute> OAuth2 { get; set; }
    }
}
