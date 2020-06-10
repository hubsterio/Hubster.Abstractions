// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models
{
    public class EstablishConversationRequestModel
    {
        public EstablishConversationRequestModel()
        {
            Properties = new ConversationPropertiesModel
            {
                Profile = new Dictionary<string, string>(),
                Additional = new Dictionary<string, string>()
            };
        }

        public string IntegrationId { get; set; }
        public string Binding { get; set; }
        public ConversationPropertiesModel Properties { get; set; }
    }
}
