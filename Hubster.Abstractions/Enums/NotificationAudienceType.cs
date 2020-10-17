// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hubster.Abstractions.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationAudienceType
    {
        Hubster = 1,
        AccountHolder = 2,        
    }
}
