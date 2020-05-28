using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models.Direct
{
    public class DirectStyleModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BorderColor { get; set; }
    }

    public class DirectButtonItemModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Postback { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DirectStyleModel Style { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DirectStyleModel Hover { get; set; }
    }

    public class DirectButtonImageItemModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Postback { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Style { get; set; }
    }

    public class DirectListItemModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Postback { get; set; }
    }

    public class DirectLinkItemModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }
    }

    public class DirectTextMessageModel : DirectMessageModel
    {
        public string Text { get; set; }
        public DirectStyleModel Style { get; set; }
        
        public List<DirectMessageModel> Widgets { get; set; }

        public DirectTextMessageModel() { Type = "TextMessage"; }
    }

    public class DirectImageMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }
        public string UrlAnchor { get; set; }

        public DirectImageMessageModel() { Type = "ImageMessage"; }
    }


    public class DirectMediaMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class DirectButtonMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectButtonItemModel> Buttons { get; set; }
    }

    public class DirectButtonImageMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectButtonImageItemModel> Buttons { get; set; }

        public DirectButtonImageMessageModel() { Type = "ButtonImageMessage"; }
    }

    public class DirectListMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectListItemModel> List { get; set; }

        public DirectListMessageModel() { Type = "ListMessage"; }
    }

    public class DirectLinkMessageModel : DirectMessageModel
    {
        public List<DirectLinkItemModel> Links { get; set; }

        public DirectLinkMessageModel() { Type = "LinkMessage"; }
    }

    public class DirectFlashcardMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        public DirectFlashcardMessageModel() { Type = "FlashcardMessage"; }
    }

    public class DirectCardMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<DirectMessageModel> Widgets { get; set; }
    }

    public class DirectCustomMessageModel : DirectMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string InnerHTML { get; set; }

        public DirectCustomMessageModel() { Type = "CustomMessage"; }
    }
}
