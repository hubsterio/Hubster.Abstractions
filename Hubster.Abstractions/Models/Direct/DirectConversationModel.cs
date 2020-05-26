// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectConversationModel
    {        
        public Guid TenantId { get; set; }       
        public Guid HubId { get; set; }        
        public Guid ConversationId { get; set; }        
        public long EventId { get; set; }
    }
}
