using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PostmanManager.Models;
using Version = PostmanManager.Models.Version;

namespace PostmanManager
{
    /// <summary>
    /// Custom Json Converter to handle <see cref="Url"/> objects from Postman
    /// </summary>
    public class PostmanUrl_JsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(System.String))
                return true;
            else
                return typeof(Url).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                if (reader.TokenType == JsonToken.String)
                {
                    Console.WriteLine(" PostmanUrl_JsonConverter string token");
                    Url url = new Url();
                    url.Raw = reader.Value.ToString();
                    url.urlIsInStringFormat = true;
                    return url;
                }
                else
                {
                    Console.WriteLine("PostmanUrl_JsonConverter object token");
                    var result = (JToken)serializer.Deserialize(reader);

                    Url url = new Url();
                    url.urlIsInStringFormat = false;

                    if (result["raw"] != null)
                        url.Raw = result["raw"].ToString();

                    if (result["protocol"] != null)
                        url.Protocol = result["protocol"].ToString();

                    if (result["host"] != null)
                        url.Host = result["host"].ToObject<string[]>();

                    if (result["path"] != null)
                        url.Path = result["path"].ToObject<Path>();

                    if (result["port"] != null)
                        url.Port = result["port"].ToString();

                    if (result["query"] != null)
                        url.QueryParams = result["query"].ToObject<List<Variable>>();

                    if (result["hash"] != null)
                        url.Hash = result["hash"].ToString();

                    if (result["variable"] != null)
                        url.Variables = result["variable"].ToObject<List<Variable>>();

                    return url;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        public override bool CanWrite => true;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var url = (value as Url);

            if (url.urlIsInStringFormat)
            {
                JToken t = JToken.FromObject(url.Raw);
                t.WriteTo(writer);
            }
            else
            {
                var obj = new JObject();

                if (url.Raw != null)
                    obj.Add("raw", url.Raw);

                if (url.Protocol != null)
                    obj.Add("raw", url.Protocol);

                if (url.Host != null)
                    obj.Add("host", JToken.FromObject(url.Host));

                if (url.Path != null)
                    obj.Add("path", JToken.FromObject(url.Path));

                if (url.Port != null)
                    obj.Add("port", url.Port);

                if (url.QueryParams != null)
                    obj.Add("query", JToken.FromObject(url.QueryParams));

                if (url.Hash != null)
                    obj.Add("hash", url.Hash);

                if (url.Variables != null)
                    obj.Add("variable", JToken.FromObject(url.Variables));

                obj.WriteTo(writer);
            }
        }
    }
}
