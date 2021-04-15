// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models
{
    public partial class HubModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? HubId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TenantId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TenantModel Tenant { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Metadata { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? CloseDormantConversation { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }
    }
}
