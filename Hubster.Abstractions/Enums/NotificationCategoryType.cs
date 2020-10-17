// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hubster.Abstractions.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationCategoryType
    {
        Tenant = 1,
        Hub = 2,
        Integration = 3
    }
}
