// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Enums;
using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models
{
    public class IntegrationModel
    {
        [JsonProperty("integration_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? IntegrationId { get; set; }

        [JsonProperty("hub_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? HubId { get; set; }

        [JsonProperty("inbound_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InboundId { get; set; }

        [JsonProperty("hub", NullValueHandling = NullValueHandling.Ignore)]
        public HubModel Hub { get; set; }

        [JsonProperty("integration_type", NullValueHandling = NullValueHandling.Ignore)]
        public IntegrationType? IntegrationTypeId { get; set; }

        [JsonProperty("channel_type", NullValueHandling = NullValueHandling.Ignore)]
        public ChannelType? ChannelId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("configuration", NullValueHandling = NullValueHandling.Ignore)]
        public string Configuration { get; set; }

        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public short? Sequence { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }
    }
}
