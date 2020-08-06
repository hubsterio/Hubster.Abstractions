// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System.Collections.Generic;

namespace Hubster.Abstractions.Constants
{
    public class DirectActivityMessageType
    {
        private static readonly HashSet<string> _Set;

        public const string Text = "text";
        public const string Contact = "contact";
        public const string Card = "card";
        public const string Location = "location";
        public const string Attachment = "attachment";
        public const string Video = "video";
        public const string Audio = "audio";
        public const string Youtube = "youtube";
        public const string Vimeo = "vimeo";
        public const string Image = "image";
        public const string List = "list";
        public const string Carousel = "carousel";
        public const string Command = "command";

        static DirectActivityMessageType()
        {
            _Set = new HashSet<string>(new[]
            {
                Text,
                Contact,
                Card,
                Location,
                Attachment,
                Video,
                Audio,
                Youtube,
                Vimeo,
                Image,
                List,
                Carousel,
                Command,
            });
        }

        public static bool IsValid(string value)
        {
            return _Set.Contains(value);
        }
    }
}
