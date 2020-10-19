// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectActionModel
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("payloadType", NullValueHandling = NullValueHandling.Ignore)]
        public string PayloadType { get; set; }

        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public JObject Payload { get; set; }
    }
}
