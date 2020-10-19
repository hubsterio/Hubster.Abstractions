// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectConversationModel
    {
        [JsonProperty("tenantId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid TenantId { get; set; }

        [JsonProperty("hubId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid HubId { get; set; }

        [JsonProperty("conversationId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid ConversationId { get; set; }

        [JsonProperty("eventId", NullValueHandling = NullValueHandling.Ignore)]
        public long EventId { get; set; }
    }
}
