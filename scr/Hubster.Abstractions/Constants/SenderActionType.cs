// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System.Collections.Generic;

namespace Hubster.Abstractions.Constants
{
    public class SenderActionType
    {
        private static readonly HashSet<string> _Set;

        public const string Seen = "seen";
        public const string TypingOn = "typing_on";
        public const string TypingOff = "typing_off";
        
        static SenderActionType()
        {
            _Set = new HashSet<string>(new[]
            {
                Seen,
                TypingOn,
                TypingOff,
            });
        }

        public static bool Validator(string value)
        {
            return _Set.Contains(value);
        }
    }
}
