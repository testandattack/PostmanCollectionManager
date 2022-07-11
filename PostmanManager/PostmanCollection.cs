using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using PostmanManager.Models;
using System.IO;
using Serilog;
using GTC.Extensions;

namespace PostmanManager
{
    /// <summary>
    /// The root item for postman collections
    /// </summary>
    /// <remarks>
    /// FROM [geoffgr]. The summary documentation is directly from the postman 
    /// schema listed below:
    /// <code>
    /// "$schema": "http://json-schema.org/draft-04/schema#",
    /// "id": "https://schema.getpostman.com/json/collection/v2.1.0/",
    /// </code>
    /// The C# objects created in this package are not guaranteed to be 
    /// identical to the objects in postman, but they should always serialize to 
    /// a json object that can be imported into Postman.
    /// </remarks>
    public class PostmanCollection
    {
        /// <summary>
        /// Detailed description of the info block
        /// </summary>
        [JsonProperty("info")]
        public Info Info { get; set; }

        /// <summary>
        /// Items are the basic unit for a Postman collection. 
        /// You can think of them as corresponding to a single 
        /// API endpoint. Each Item has one request and may have 
        /// multiple API responses associated with it.
        /// </summary>
        [JsonProperty("item")]
        public List<ItemCollection> Items { get; set; }

        /// <summary>
        /// Postman allows you to configure scripts to run when specific events 
        /// occur. These scripts are stored here, and can be referenced in the 
        /// collection by their ID.
        /// </summary>
        [JsonProperty("event")]
        public List<Event> Events { get; set; }

        /// <summary>
        /// Collection variables allow you to define a set of variables, 
        /// that are a *part of the collection*, as opposed to environments, 
        /// which are separate entities.\n*Note: Collection variables must 
        /// not contain any sensitive information.*
        /// </summary>
        [JsonProperty("variable")]
        public List<Variable> Variables { get; set; }

        /// <summary>
        /// Represents authentication helpers provided by Postman
        /// </summary>
        [JsonProperty("auth", NullValueHandling = NullValueHandling.Ignore)]
        public Auth Auth { get; set; }

        /// <summary>
        /// Set of configurations used to alter the usual behavior of sending the request.
        /// </summary>
        [JsonProperty("protocolProfileBehavior")]
        public object ProtocolProfileBehavior { get; set; }

        /// <summary>
        /// Loads an exported Postman Collection json file into the <see cref="PostmanCollection"/> object.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static PostmanCollection LoadCollection(string fileName)
        {
            List<string> errors = new List<string>();
            PostmanCollection source;
            using (StreamReader sr = new StreamReader(fileName))
            {
                var settings = new JsonSerializerSettings
                {
                    Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
                    {
                        errors.Add(args.ErrorContext.Error.Message);
                        args.ErrorContext.Handled = true;
                    },
                    TypeNameHandling = TypeNameHandling.Objects
                };
                source = JsonConvert.DeserializeObject<PostmanCollection>(sr.ReadToEnd(), settings);
            }
            Log.Error($"The following Deserialization errors were detected:\r\n{errors.ToString("\r\n")}");
            return source;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="fileName"></param>
        public static void SaveCollection(PostmanCollection source, string fileName)
        {
            List<string> errors = new List<string>();

            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                var settings = new JsonSerializerSettings
                {
                    Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
                    {
                        errors.Add(args.ErrorContext.Error.Message);
                        args.ErrorContext.Handled = true;
                    },
                    TypeNameHandling = TypeNameHandling.Objects,
                    NullValueHandling = NullValueHandling.Ignore
                };
                sw.Write(JsonConvert.SerializeObject(source, Formatting.Indented));
            }
            Log.Error($"The following Serialization errors were detected:\r\n{errors.ToString("\r\n")}");
        }
    }
}
