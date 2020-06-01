// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Hubster.Abstractions.Models
{
    public class ContactModel
    {
        public ContactModel()
        {
            Properties = new List<DirectrPropertyValue>();
        }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectrPropertyValue> Properties { get; set; }
    }
}
