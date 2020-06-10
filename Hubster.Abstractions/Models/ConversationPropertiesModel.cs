// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models
{
    public class ConversationPropertiesModel
    {
        public Dictionary<string, string> Profile { get; set; }
        public Dictionary<string, string> Additional { get; set; }
    }
}
