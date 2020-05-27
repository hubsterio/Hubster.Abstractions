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

            var type = jo[key].Value<string>()?.ToUpper();
            var message = (DirectMessageModel)null;

            switch (type)
            {
                case "TEXTMESSAGE": message = jo.ToObject<DirectTextMessageModel>(serializer); break;
                case "BUTTONIMAGEMESSAGE": message = jo.ToObject<DirectButtonImageMessageModel>(serializer); break;
                case "IMAGEMESSAGE": message = jo.ToObject<DirectImageMessageModel>(serializer); break;
                case "CARDMESSAGE": message = jo.ToObject<DirectCardMessageModel>(serializer); break;
                case "LISTMESSAGE": message = jo.ToObject<DirectListMessageModel>(serializer); break;
                case "LINKMESSAGE": message = jo.ToObject<DirectLinkMessageModel>(serializer); break;
                case "FLASHCARDMESSAGE": message = jo.ToObject<DirectFlashcardMessageModel>(serializer); break;
                case "CUSTOMMESSAGE": message = jo.ToObject<DirectCustomMessageModel>(serializer); break;

                case "BUTTONMESSAGE":
                case "QUICKREPLYMESSAGE":
                    message = jo.ToObject<DirectButtonMessageModel>(serializer); 
                    break;                

                case "YOUTUBEVIDEOMESSAGE":
                case "VIMEOVIDEOMESSAGE":
                case "MP4VIDEOMESSAGE":
                case "AUDIOMESSAGE":
                    message = jo.ToObject<DirectMediaMessageModel>(serializer);
                    break;

                default: 
                    message = new DirectMessageModel { Type = type }; 
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
