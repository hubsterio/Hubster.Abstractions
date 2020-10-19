// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Enums;
using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models
{
    public class IntegrationModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? IntegrationId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? HubId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string InboundId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public HubModel Hub { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IntegrationType? IntegrationTypeId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ChannelType? ChannelId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Configuration { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public short? Sequence { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }
    }
}
