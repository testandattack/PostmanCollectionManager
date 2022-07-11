﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace PostmanManager.Models
{
    /// <summary>
    /// Postman allows you to version your collections as they grow, 
    /// and this field holds the version number. While optional, 
    /// it is recommended that you use this field to its fullest extent!
    /// </summary>
    [JsonObject(Title = "version")]
    [JsonConverter(typeof(PostmanVersion_JsonConverter))]
    public class Version
    {
        /// <summary>
        /// Increment this number if you make changes to the collection that changes its behaviour. 
        /// E.g: Removing or adding new test scripts. (partly or completely).
        /// </summary>
        [JsonProperty("major")]
        public int Major { get; set; }

        /// <summary>
        /// You should increment this number if you make changes that will not break 
        /// anything that uses the collection. E.g: removing a folder.
        /// </summary>
        [JsonProperty("minor")]
        public int Minor { get; set; }

        /// <summary>
        /// Ideally, minor changes to a collection should result in the increment of this number.
        /// </summary>
        [JsonProperty("patch")]
        public int Patch { get; set; }

        /// <summary>
        /// A human friendly identifier to make sense of the version numbers. E.g: 'beta-3'
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier
        {
            get
            {
                return _identifier;
            }

            set
            {
                if (value.Length > 10)
                    _identifier = value.Remove(10);
                else
                    _identifier = value;
            }
        }
        private string _identifier; 

        /// <summary>
        /// Holds the string representation of a Postman Version if the JSON has
        /// the Version stored as a string instead of an object
        /// </summary>
        public string VersionAsString { get; set; }


        public override string ToString()
        {
            if (Major == 0 && Minor == 0 && Patch == 0 && String.IsNullOrEmpty(Identifier))
                return VersionAsString;
            else
                return $"{Major}.{Minor}.{Patch}-{Identifier}";
        }

        public bool IsString()
        {
            if (Major == 0 && Minor == 0 && Patch == 0 && String.IsNullOrEmpty(Identifier))
                return false;
            else
                return true;
        }
    }
}
