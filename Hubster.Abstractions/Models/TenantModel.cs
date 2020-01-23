// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models 
{
    public partial class TenantModel
    {
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TenantId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("tenant_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TenantTypeId { get; set; }

        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }
    }
}
