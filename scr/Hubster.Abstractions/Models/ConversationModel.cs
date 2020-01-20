// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models
{
    public partial class ConversationModel
    {
        [JsonProperty("conversation_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ConversationId { get; set; }

        [JsonProperty("integration_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? IntegrationId {get; set; }

        [JsonProperty("token_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenId { get; set; }

        [JsonProperty("integration", NullValueHandling = NullValueHandling.Ignore)]
        public IntegrationModel Integration { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public ConversationPropertiesModel Properties { get; set; }
        
        [JsonProperty("opened_date_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? OpenedDateTime { get; set; }

        [JsonProperty("closed_date_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ClosedDateTime { get; set; }
    }
}
