﻿// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectSenderActionModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }
    }
}
