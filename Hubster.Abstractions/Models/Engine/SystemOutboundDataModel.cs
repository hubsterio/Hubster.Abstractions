// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Models;
using Hubster.Abstractions.Models.Direct;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models.Engine
{
    public class SystemOutboundDataModel
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
        public List<DirectActivityModel> Activities { get; set; }
    }
}
