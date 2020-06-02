using Hubster.Abstractions.Models.Direct;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hubster.Abstractions.Converters
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Newtonsoft.Json.JsonConverter" />
    public class DirectMessageJsonConverter : JsonConverter
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(DirectMessageModel));
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>
        /// The object value.
        /// </returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jo = JObject.Load(reader);            
            var key = string.Empty;

            if (jo.ContainsKey("type"))
            {
                key = "type";
            }
            else if (jo.ContainsKey("Type"))
            {
                key = "Type";
            }

            if (key == string.Empty)
            {
                return null;
            }

            var type = jo[key].Value<string>();
            var message = (DirectMessageModel)null;

            switch (type)
            {
                case "TextMessage": message = jo.ToObject<DirectTextMessageModel>(serializer); break;
                case "ButtonImageMessage": message = jo.ToObject<DirectButtonImageMessageModel>(serializer); break;
                case "ImageMessage": message = jo.ToObject<DirectImageMessageModel>(serializer); break;
                case "CardMessage": message = jo.ToObject<DirectCardMessageModel>(serializer); break;
                case "ComboMessage": message = jo.ToObject<DirectComboMessageModel>(serializer); break;
                case "ListMessage": message = jo.ToObject<DirectListMessageModel>(serializer); break;
                case "LinkMessage": message = jo.ToObject<DirectLinkMessageModel>(serializer); break;
                case "FlashcardMessage": message = jo.ToObject<DirectFlashcardMessageModel>(serializer); break;
                case "CustomMessage": message = jo.ToObject<DirectCustomMessageModel>(serializer); break;
                case "AttachmentMessage": message = jo.ToObject<DirectAttachmentMessageModel>(serializer); break;
                case "ContactMessage": message = jo.ToObject<DirectContactMessageModel>(serializer); break;
                case "LocationMessage": message = jo.ToObject<DirectLocationMessageModel>(serializer); break;

                case "ButtonMessage":
                case "QuickReplyMessage":
                    message = jo.ToObject<DirectButtonMessageModel>(serializer); 
                    break;                

                case "YouTubeMessage":
                case "VimeoVideoMessage":
                case "MP4VideoMessage":
                case "AudioMessage":
                    message = jo.ToObject<DirectMediaMessageModel>(serializer);
                    break;

                default: 
                    message = new DirectMessageModel { Type = type ?? "Unknown" }; 
                    break;
            }

            return message;
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Newtonsoft.Json.JsonConverter" /> can write JSON.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this <see cref="T:Newtonsoft.Json.JsonConverter" /> can write JSON; otherwise, <c>false</c>.
        /// </value>
        public override bool CanWrite
        {
            get { return false; }
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <exception cref="NotImplementedException"></exception>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
