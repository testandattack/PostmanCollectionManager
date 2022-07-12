using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostmanManager.Models
{
    /// <summary>
    /// An empty abstract class used to allow multiple concrete objects to exist at the same level.
    /// </summary>
    /// <remarks>
    /// The <see cref="Item"/> and <see cref="ItemGroup"/> classes are 
    /// both derived from this class.
    /// </remarks>
    [JsonObject(Title = "item")]
    [JsonConverter(typeof(PostmanItem_JsonConverter))]
    public abstract class ItemCollection
    {
    }
}
