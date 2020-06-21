// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System.Collections.Generic;

namespace Hubster.Abstractions.Constants
{
    public class AttachmentType
    {
        private static readonly HashSet<string> _Set;        

        public const string Media = "media";
        public const string Location = "location";
        public const string Contact = "contact";

        static AttachmentType()
        {
            _Set = new HashSet<string>(new[]
            {
                Media,
                Location,
                Contact
            });
        }

        public static bool Contains(string value)
        {
            return _Set.Contains(value);
        }

        public static bool IsMedia(string value)
        {
            return value == Media;
        }

        public static bool IsLocation(string value)
        {
            return value == Location;
        }

        public static bool IsContact(string value)
        {
            return value == Contact;
        }
    }
}
