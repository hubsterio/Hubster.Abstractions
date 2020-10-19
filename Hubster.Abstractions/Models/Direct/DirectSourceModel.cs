// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Enums;
using Newtonsoft.Json;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectSourceModel
    {        
        [JsonProperty("integrationId", NullValueHandling = NullValueHandling.Ignore)]
        public string IntegrationId { get; set; }

        [JsonProperty("integrationType", NullValueHandling = NullValueHandling.Ignore)]
        public IntegrationType? IntegrationType { get; set; }

        [JsonProperty("channelType", NullValueHandling = NullValueHandling.Ignore)]
        public ChannelType? ChannelType { get; set; }

        [JsonProperty("tokenId", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenId { get; set; }

        [JsonProperty("channelData", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelData { get; set; }
    }
}
