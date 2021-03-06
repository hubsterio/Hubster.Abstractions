﻿// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Enums;
using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectActivityModel 
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("eventTrigger", NullValueHandling = NullValueHandling.Ignore)]
        public string EventTrigger { get; set; }

        [JsonProperty("eventId", NullValueHandling = NullValueHandling.Ignore)]
        public long? EventId { get; set; }

        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        [JsonProperty("isEcho", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsEcho { get; set; }

        [JsonProperty("interactionId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? InteractionId { get; set; }

        [JsonProperty("flowProcess", NullValueHandling = NullValueHandling.Ignore)]
        public ActivityFlowProcessType? FlowProcess { get; set; }

        [JsonProperty("sender", NullValueHandling = NullValueHandling.Ignore)]
        public DirectSourceModel Sender { get; set; }

        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public DirectSourceModel Recipient { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public DirectMessageModel Message { get; set; }

        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public DirectEventModel Event { get; set; }
    }
}