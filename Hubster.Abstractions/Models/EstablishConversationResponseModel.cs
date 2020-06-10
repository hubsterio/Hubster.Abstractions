﻿// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models
{
    public class EstablishConversationResponseModel
    {
        public EstablishConversationResponseModel()
        {
            Errors = new List<ErrorCodeModel>();
        }

        public ConversationModel Conversation { get; set; }
        public EstablishedConversationModel EstablishedConversation { get; set; }
        public List<ErrorCodeModel> Errors { get; set; }
    }
}
