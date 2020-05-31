// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System.Collections.Generic;

namespace Hubster.Abstractions.Constants
{
    public class DirectActivityMessageType
    {
        private static readonly HashSet<string> _Set;
        
        public const string TextMessage = "TextMessage";
        public const string CardMessage = "CardMessage";
        public const string ComboMessage = "ComboMessage";
        public const string ImageMessage = "ImageMessage";
        public const string YouTubeVideoMessage = "YouTubeVideoMessage";
        public const string VimeoVideoMessage = "VimeoVideoMessage";
        public const string MP4VideoMessage = "MP4VideoMessage";
        public const string AudioMessage = "AudioMessage";
        public const string ButtonMessage = "ButtonMessage";
        public const string QuickReplyMessage = "QuickReplyMessage";
        public const string ButtonImageMessage = "ButtonImageMessage";
        public const string ListMessage = "ListMessage";
        public const string LinkMessage = "LinkMessage";
        public const string FlashcardMessage = "FlashcardMessage";
        public const string CustomMessage = "CustomMessage";


        static DirectActivityMessageType()
        {
            _Set = new HashSet<string>(new[]
            {
                TextMessage,
                CardMessage,
                ComboMessage,
                ImageMessage,
                YouTubeVideoMessage,
                VimeoVideoMessage,
                MP4VideoMessage,
                AudioMessage,
                ButtonMessage,
                QuickReplyMessage,
                ButtonImageMessage,
                ListMessage,
                LinkMessage,
                FlashcardMessage,
                CustomMessage,
            });
        }

        public static bool IsValid(string value)
        {
            return _Set.Contains(value);
        }
    }
}
