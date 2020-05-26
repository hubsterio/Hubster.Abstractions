﻿// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Enums;
using Newtonsoft.Json;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectSourceModel
    {        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IntegrationId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IntegrationType? IntegrationType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ChannelType? ChannelType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TokenId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelData { get; set; }
    }
}
