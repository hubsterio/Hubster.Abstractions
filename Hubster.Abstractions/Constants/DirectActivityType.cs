// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System.Collections.Generic;

namespace Hubster.Abstractions.Constants
{
    public class DirectActivityType
    {
        private static readonly HashSet<string> _Set;

        public const string Message = "message";        
        public const string SenderAction = "senderAction";

        static DirectActivityType()
        {
            _Set = new HashSet<string>(new[]
            {
                Message,                
                SenderAction,
            });
        }

        public static bool IsValid(string value)
        {
            return _Set.Contains(value);
        }
    }
}
