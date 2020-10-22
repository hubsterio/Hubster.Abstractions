// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Models;
using Hubster.Abstractions.Models.Direct;
using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models.Engine
{
    public class DirectOutboundDataModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? HubId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TenantId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? IntegrationId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ConversationId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ConversationPropertiesModel ConversationProperties { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DirectActivityModel Activity { get; set; }
    }
}
