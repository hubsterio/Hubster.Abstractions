// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Models.Direct;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models.Engine
{
    public class SystemSparkModel : IntegrationSparkModel
    {
        public DirectConversationModel Conversation { get; set; }
        public List<DirectActivityModel> Activities { get; set; }        
    }
}
