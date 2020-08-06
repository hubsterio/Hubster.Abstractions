using Hubster.Abstractions.Constants;
using Hubster.Abstractions.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectMessagePropertyItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }

    public class DirectChannelMetadata
    {
        public string Type { get; set; }
        public List<DirectMessagePropertyItem> Metadata { get; set; }
    }

    public class DirectListItem
    {
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string UrlType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FallbackImageUrl { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectAction> Actions { get; set; }
    }

    public class DirectAction
    {        
        public string Type { get; set; }

        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string UrlIcon { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string UrlImage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault  { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectChannelMetadata> Channels { get; set; }
}

    public class DirectLinkAction : DirectAction
    {
        public string Url { get; set; }
    }

    public class DirectPostbackAction : DirectAction
    {        
        public string Payload { get; set; }
    }

    public class DirectMessageModel
    {
        public string Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectChannelMetadata> Channels { get; set; }
    }

    public class DirectTextMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectMessageModel> Items { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectAction> Actions { get; set; }

        public DirectTextMessageModel() { Type = DirectActivityMessageType.Text; }
    }

    public class DirectLocationMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude { get; set; }

        public DirectLocationMessageModel() { Type = DirectActivityMessageType.Location; }
    }

    public class DirectContactMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectMessagePropertyItem> Properties { get; set; }

        public DirectContactMessageModel() 
        { 
            Type = DirectActivityMessageType.Contact;
            Properties = new List<DirectMessagePropertyItem>();
        }
    }

    public class DirectCardMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string UrlType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FallbackImageUrl { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        public DirectCardMessageModel() { Type = DirectActivityMessageType.Card; }
    }

    public class DirectAttachmentMessageModel : DirectMessageModel
    {
        public string Url { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string MimeType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        public DirectAttachmentMessageModel() { Type = DirectActivityMessageType.Attachment; }
    }

    public class DirectMediaMessageModel : DirectAttachmentMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FallbackImageUrl { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? Length { get; set; }        
    }

    public class DirectImageMessageModel : DirectMessageModel
    {
        public string Url { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string UrlAnchor { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TitleColor { get; set; }

        public DirectImageMessageModel() { Type = DirectActivityMessageType.Image; }
    }

    public class DirectCarouselMessageModel : DirectMessageModel
    {
        public List<DirectListItem> Items { get; set; }

        public DirectCarouselMessageModel() { Type = DirectActivityMessageType.Carousel; }
    }

    public class DirectListMessageModel : DirectCarouselMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectAction> Actions { get; set; }

        public DirectListMessageModel() { Type = DirectActivityMessageType.List; }
    }

    public class DirectCommandMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectMessagePropertyItem> Properties { get; set; }

        public DirectCommandMessageModel()
        {
            Type = DirectActivityMessageType.Command;
            Properties = new List<DirectMessagePropertyItem>();
        }
    }

}

