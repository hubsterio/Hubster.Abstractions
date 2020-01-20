// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Newtonsoft.Json;

namespace Hubster.Abstractions.Models
{
    public class NotificationItemModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Caption { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SubDetails { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Tenant { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Hub { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Integration{ get; set; }

        #region HashSet 
        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var test = obj as NotificationItemModel;
            return test.Code == Code;
        }
        #endregion HashSet 
    }
}
