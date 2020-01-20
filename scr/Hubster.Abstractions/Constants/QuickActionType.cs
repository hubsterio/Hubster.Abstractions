// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System.Collections.Generic;

namespace Hubster.Abstractions.Constants
{
    public class QuickActionType
    {
        private static readonly HashSet<string> _Set;

        public const string Text = "text";
        public const string Location = "location";

        static QuickActionType()
        {
            _Set = new HashSet<string>(new[]
            {
                Text,
                Location,
            });
        }

        public static bool Validator(string value)
        {
            return _Set.Contains(value);
        }
    }
}
