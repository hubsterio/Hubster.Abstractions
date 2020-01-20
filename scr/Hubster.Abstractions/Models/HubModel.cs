// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models
{
    public partial class HubModel
    {
        [JsonProperty("hub_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? HubId { get; set; }

        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TenantId { get; set; }

        [JsonProperty("tenant", NullValueHandling = NullValueHandling.Ignore)]
        public TenantModel Tenant { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public string MetaData { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }
    }
}
