// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Enums;

namespace Hubster.Abstractions.Models.Engine
{
    public class IntegrationSparkModel
    {
        public IntegrationModel Integration { get; set; } 
        public EventPackageType EventType { get; set; }
    }
}
