using System;
using System.Collections.Generic;
using System.Text;

namespace Hubster.Abstractions.Constants
{
    public class DirectActivityActionType
    {
        private static readonly HashSet<string> _Set;

        public const string Link = "link";
        public const string Postback = "postback";
        public const string Reply = "reply";

        static DirectActivityActionType()
        {
            _Set = new HashSet<string>(new[]
            {
                Link,
                Postback,
                Reply,
            });
        }

        public static bool IsValid(string value)
        {
            return _Set.Contains(value);
        }
    }
}
