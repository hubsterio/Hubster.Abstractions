﻿// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hubster.Abstractions.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IntegrationType
    {
        None = 0,
        Hubster = 1,
        Customer = 2,
        Agent = 3,
        Bot = 4,        
        System = 5
    }
}
