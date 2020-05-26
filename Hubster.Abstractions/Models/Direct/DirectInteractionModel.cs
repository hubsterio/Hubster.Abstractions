﻿// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectInteractionModel
    {
        public Guid TenantId { get; set; }
        public Guid HubId { get; set; }
        public Guid ConversationId { get; set; }
        public DirectActivityModel Activity { get; set; }
    }
}
