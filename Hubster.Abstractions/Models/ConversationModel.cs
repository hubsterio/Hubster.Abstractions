// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models
{
    public partial class ConversationModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ConversationId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? IntegrationId {get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TokenId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IntegrationModel Integration { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ConversationPropertiesModel Properties { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? OpenedDateTime { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ClosedDateTime { get; set; }
    }
}
