// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Enums;
using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectActivityModel 
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string EventTrigger { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? EventId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Guid? InteractionId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ActivityFlowProcessType? FlowProcess { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DirectSourceModel Sender { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DirectSourceModel Recipient { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DirectMessageModel Message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DirectSenderActionModel SenderAction { get; set; }
    }
}