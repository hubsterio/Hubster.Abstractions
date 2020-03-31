// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Models.Direct;
using Newtonsoft.Json;

namespace Hubster.Abstractions.Models 
{
    public class ActivityGroupModel
    {
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        [JsonProperty("activity", NullValueHandling = NullValueHandling.Ignore)]
        public DirectActivityModel Activity { get; set; }
    }
}
