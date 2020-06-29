using System.Collections.Generic;

namespace Hubster.Abstractions.Models
{
    /// <summary>
    /// </summary>
    public class QueryValueModel
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
        public QueryValueModel Add(string name, object value)
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
            if(_values.ContainsKey(name))
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
        public QueryValueModel Clear()
        {
            _values.Clear();
            return this;
        }

        /// <summary>
        /// Copies this instance.
        /// </summary>
        /// <returns></returns>
        public QueryValueModel Copy()
        {
            var copy = new QueryValueModel();

            foreach(var item in _values)
            {
                copy.Add(item.Key, item.Value);
            }

            return copy;
        }

        /// <summary>
        /// From the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public QueryValueModel From(QueryValueModel value)
        {
            Clear();

            foreach (var item in value._values)
            {
                Add(item.Key, item.Value);
            }

            return this;
        }
    }
}
