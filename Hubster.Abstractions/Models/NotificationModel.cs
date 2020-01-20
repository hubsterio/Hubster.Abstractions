// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Enums;
using System;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models
{
    public class NotificationModel
    {
        public NotificationModel()
        {
            Items = new List<NotificationItemModel>();
        }

        public NotificationAudienceType Audience { get; set; }
        public NotificationCategoryType Category { get; set; }
        public NotificationLevelType Level { get; set; }        
        public List<NotificationItemModel> Items { get; set; }
    }
}
