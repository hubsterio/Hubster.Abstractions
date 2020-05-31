// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using Hubster.Abstractions.Helpers;
using System.Collections.Generic;

namespace Hubster.Abstractions.Constants
{
    /// <summary>
    /// 
    /// </summary>
    public class MediaType
    {
        private static readonly HashSet<string> _Set;        

        public const string Image = "image";
        public const string Audio = "audio";
        public const string Video = "video";
        public const string File = "file";
        public const string Text = "text";

        static MediaType()
        {
            _Set = new HashSet<string>(new[]
            {
                Image,
                Audio,
                Video,
                File,
                Text
            });
        }

        public static bool Contains(string value)
        {
            return _Set.Contains(value);
        }

        public static string GetTypeFromMimeType(string mimeType)
        {
            var type = UrlHelper.GetTypeFromMimeType(mimeType);

            return Contains(type) ? type : File;
        }
    }
}
