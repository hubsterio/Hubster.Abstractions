// Hubster 
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

        [JsonProperty("conversation")]
        public ConversationModel Conversation { get; set; }

        [JsonProperty("conversation_response")]
        public EstablishedConversationModel EstablishedConversation { get; set; }

        [JsonProperty("errors")]
        public List<ErrorCodeModel> Errors { get; set; }
    }
}
