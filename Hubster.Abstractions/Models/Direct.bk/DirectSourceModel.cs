﻿// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Enums;
using Newtonsoft.Json;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectSourceModel
    {        
        [JsonProperty("integration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IntegrationId { get; set; }

        [JsonProperty("integration_type", NullValueHandling = NullValueHandling.Ignore)]
        public IntegrationType? IntegrationType { get; set; }

        [JsonProperty("channel_type", NullValueHandling = NullValueHandling.Ignore)]
        public ChannelType? ChannelType { get; set; }

        [JsonProperty("token_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenId { get; set; }

        [JsonProperty("channel_data", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelData { get; set; }
    }
}