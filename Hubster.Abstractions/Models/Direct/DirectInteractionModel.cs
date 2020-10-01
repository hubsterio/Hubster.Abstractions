// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectInteractionModel
    {
        [JsonProperty("tenantId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid TenantId { get; set; }

        [JsonProperty("hubId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid HubId { get; set; }

        [JsonProperty("conversationId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid ConversationId { get; set; }

        [JsonProperty("activity", NullValueHandling = NullValueHandling.Ignore)]
        public DirectActivityModel Activity { get; set; }

        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? TTL { get; set; }
    }
}
