using Hubster.Abstractions.Interfaces;
using System.Collections.Generic;

namespace Hubster.Abstractions.Models
{
    /// <summary>
    /// </summary>
    public class QueryValueModel : IQueryValueModel
    {
        private readonly Dictionary<string, object> _values;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryValueModel"/> class.
        /// </summary>
        public QueryValueModel()
        {
            _values = new Dictionary<string, object>();
        }

        /// <summary>
        /// Adds the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public IQueryValueModel Add(string name, object value)
        {
            _values[name] = value;
            return this;
        }

        /// <summary>
        /// Gets the specified name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public T Get<T>(string name, T defaultValue = default(T))
        {
            var value = defaultValue;
            if (_values.ContainsKey(name))
            {
                var _value = _values[name];
                value = _value != null ? (T)_values[name] : defaultValue;
            }

            return value;
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        /// <returns></returns>
        public IQueryValueModel Clear()
        {
            _values.Clear();
            return this;
        }

        /// <summary>
        /// Copies this instance.
        /// </summary>
        /// <returns></returns>
        public IQueryValueModel Copy()
        {
            var copy = new QueryValueModel();

            foreach (var item in _values)
            {
                copy.Add(item.Key, item.Value);
            }

            return copy;
        }

        /// <summary>
        /// Merges the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public IQueryValueModel Merge(IQueryValueModel value)
        {
            foreach (var item in (value as QueryValueModel)._values)
            {
                _values[item.Key] = item.Value;
            }

            return this;
        }

        /// <summary>
        /// From the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public IQueryValueModel From(IQueryValueModel value)
        {
            Clear();
            Merge(value);

            return this;
        }
    }
}
