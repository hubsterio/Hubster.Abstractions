using Hubster.Abstractions.Constants;
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
            return objectType == typeof(DirectMessageModel)
                || objectType == typeof(DirectAction);
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

            if (objectType == typeof(DirectMessageModel))
            {
                var message = (DirectMessageModel)null;

                switch (type)
                {
                    // message types
                    case DirectActivityMessageType.Text: message = jo.ToObject<DirectTextMessageModel>(serializer); break;
                    case DirectActivityMessageType.Contact: message = jo.ToObject<DirectContactMessageModel>(serializer); break;
                    case DirectActivityMessageType.Card: message = jo.ToObject<DirectCardMessageModel>(serializer); break;
                    case DirectActivityMessageType.Location: message = jo.ToObject<DirectLocationMessageModel>(serializer); break;
                    case DirectActivityMessageType.Attachment: message = jo.ToObject<DirectAttachmentMessageModel>(serializer); break;
                    case DirectActivityMessageType.Image: message = jo.ToObject<DirectImageMessageModel>(serializer); break;
                    case DirectActivityMessageType.Carousel: message = jo.ToObject<DirectCarouselMessageModel>(serializer); break;
                    case DirectActivityMessageType.List: message = jo.ToObject<DirectListMessageModel>(serializer); break;
                    case DirectActivityMessageType.Youtube:
                    case DirectActivityMessageType.Vimeo:
                    case DirectActivityMessageType.Video:
                    case DirectActivityMessageType.Audio:
                        message = jo.ToObject<DirectMediaMessageModel>(serializer);
                        break;

                    default:
                        message = new DirectMessageModel { Type = type };
                        break;
                }

                return message;
            }

            if (objectType == typeof(DirectAction))
            {
                var action = (DirectAction)null;

                switch (type)
                {
                    case DirectActivityActionType.Link: action = jo.ToObject<DirectLinkAction>(serializer); break;
                    case DirectActivityActionType.Postback:
                    case DirectActivityActionType.Reply:
                        action = jo.ToObject<DirectPostbackAction>(serializer); 
                        break;

                    default:
                        action = new DirectAction { Type = type };
                        break;
                }

                return action;
            }

            return null;
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
