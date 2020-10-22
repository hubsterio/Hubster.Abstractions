// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Models.Direct;

namespace Hubster.Abstractions.Models.Engine
{
    public class ConverationSparkModel: IntegrationSparkModel
    {
        public DirectConversationModel Conversation { get; set; }
        public DirectActivityModel Activity { get; set; }        
    }
}
