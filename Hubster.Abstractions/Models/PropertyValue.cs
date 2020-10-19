// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;

namespace Hubster.Abstractions.Models
{
    public class DirectPropertyValue
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        public DirectPropertyValue()
        {
        }                

        public DirectPropertyValue(string key, string value, string type = "")
        {
            Key = key;
            Value = value;
            Type = type;
        }

        public static bool IsEmpty(DirectPropertyValue property)
        {
            return property == null
                || string.IsNullOrWhiteSpace(property.Key) == true
                || string.IsNullOrWhiteSpace(property.Value) == true;
        }
    }
}
