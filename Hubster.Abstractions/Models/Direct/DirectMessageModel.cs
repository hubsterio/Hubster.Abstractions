// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using Plato.Extensions;
using System;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? InteractionId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Message Message { get; set; }
    }
}
