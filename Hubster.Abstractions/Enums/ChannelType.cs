﻿// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hubster.Abstractions.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChannelType
    {
        // internal 
        Hubster = 0,

        // main
        Direct = 1,
        Bot = 2,
        System = 3,

        // Customers
        Messenger = 101,
        TwilioSMS = 102,
        Line = 103,
        Telegram = 104,
        Kik = 105,
        WebChat = 106,

        // Businesses
        Slack =  1001,        
    }
}
