using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models.Direct
{

    public class MessageConverter<T> : JsonConverter<T> where T: Message 
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if(hasExistingValue)
            {
                return existingValue;
            }
            
            var item = JObject.Load(reader);
            var type = item["Type"].Value<string>();

            switch (type)
            {
                case "TextMessage": return item.ToObject<TextMessage>() as T;
                case "ButtonMessage": return item.ToObject<ButtonMessage>() as T;
                default:
                    return existingValue;
            }
        }

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
        }
    }

    public class Style
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColor { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BorderColor { get; set; }
    }


    public class ButtonItem
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Postback { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Style Style { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Style Hover { get; set; }
    }

    public class ButtonImageItem
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

    public class ListItem
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Postback { get; set; }
    }

    public class Link
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    [JsonConverter(typeof(MessageConverter<Message>))]
    public class Message
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }
    }

    [JsonConverter(typeof(MessageConverter<TextMessage>))]
    public class TextMessage : Message
    {
        public string Text { get; set; }
        public Style Style { get; set; }
        
        public List<Message> Widgets { get; set; }
    }

    public class ImageMessage : Message
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }
    }


    public class MediaMessage : Message
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    [JsonConverter(typeof(MessageConverter<ButtonMessage>))]
    public class ButtonMessage : Message
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<ButtonItem> Buttons { get; set; }
    }

    public class ButtonImageMessage : Message
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<ButtonImageItem> Buttons { get; set; }
    }

    public class ListMessage : Message
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<ListItem> List { get; set; }
    }

    public class LinkMessage : Message
    {
        public List<ButtonImageItem> Links { get; set; }
    }

    public class FlashcardMessage : Message
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
    }

    public class CardMessage : Message
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Message> widgets { get; set; }
    }

    public class CustomMessage : Message
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string InnerHTML { get; set; }
    }
}
