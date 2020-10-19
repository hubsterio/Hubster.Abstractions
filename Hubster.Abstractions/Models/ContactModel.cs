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
            Properties = new List<DirectPropertyValue>();
        }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]        
        public byte[] ImageBlob { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectPropertyValue> Properties { get; set; }
    }
}
