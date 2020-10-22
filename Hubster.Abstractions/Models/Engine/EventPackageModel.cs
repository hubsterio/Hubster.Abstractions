// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models.Engine
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class EventPackageModel
    {
        /// <summary>
        /// Gets or sets the type of the event activity.
        /// </summary>
        /// <value>
        /// The type of the event activity.
        /// </value>
        public EventPackageType EventType { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>
        /// The properties.
        /// </value>
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventPackageModel" /> class.
        /// </summary>
        /// <param name="eventType">Type of the event activity.</param>
        /// <param name="properties">The properties.</param>
        public EventPackageModel(EventPackageType eventType, Dictionary<string, string> properties = null)
        {
            EventType = eventType;
            Properties = properties ?? new Dictionary<string, string>();
        }

        /// <summary>
        /// Gets the property.
        /// </summary>        
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public string GetProperty(string key, string defaultValue = null)
        {
            var result = defaultValue;
            if (Properties.ContainsKey(key))
            {
                result = Properties[key];
            }

            return result;
        }

        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="data">The data.</param>
        public void SetProperty(string key, string data)
        {
            Properties[key] = data;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EventPackageModel<T> : EventPackageModel
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public T Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventPackageModel{T}" /> class.
        /// </summary>
        /// <param name="eventType">Type of the event activity.</param>
        /// <param name="data">The data.</param>
        /// <param name="properties">The properties.</param>
        public EventPackageModel(EventPackageType eventType, T data, Dictionary<string, string> properties = null) : base(eventType, properties)
        {
            Data = data;
        }

        /// <summary>
        /// Gets the business activity data.
        /// </summary>
        /// <typeparam name="TData">The type of the data.</typeparam>
        /// <param name="jsonSerializer">The json serializer.</param>
        /// <returns></returns>
        public TData GetData<TData>(JsonSerializer jsonSerializer = null)
        {
            return jsonSerializer != null 
                ? JToken.FromObject(Data).ToObject<TData>(jsonSerializer)
                : JToken.FromObject(Data).ToObject<TData>();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Hubster.Engine.Abstractions.Models.EventPackageModel{System.Object}" />
    public class EventPackageDataModel : EventPackageModel<object>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventPackageDataModel" /> class.
        /// </summary>
        /// <param name="eventType">Type of the event activity.</param>
        /// <param name="data">The data.</param>
        /// <param name="properties">The properties.</param>
        public EventPackageDataModel(EventPackageType eventType, object data, Dictionary<string, string> properties = null) : base(eventType, data, properties)
        {
        }
    }
}
