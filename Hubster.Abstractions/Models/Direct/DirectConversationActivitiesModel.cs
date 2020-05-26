﻿// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models.Direct
{

    public class DirectConversationActivitiesModel : DirectConversationModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectActivityModel> Activities { get; set; }
    }
}
