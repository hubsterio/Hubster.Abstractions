// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Hubster.Abstractions.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    internal static class UrlHelper
    {
        private static readonly HashSet<string> _AllowedMimeParts;

        /// <summary>
        /// Initializes the <see cref="UrlHelper"/> class.
        /// </summary>
        static UrlHelper()
        {
            _AllowedMimeParts = new HashSet<string>
            {
                "text",
                "multipart",
                "message",
                "image",
                "audio",
                "video",
                "application",
            };
        }

        /// <summary>
        /// Decodes the specified URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static string Decode(string url)
        {
            return WebUtility.UrlDecode(url);
        }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static string GetFileName(string url)
        {
            var fileName = Decode(Path.GetFileName(url));

            var idx = fileName.IndexOf("?");
            if (idx >= 0)
            {
                fileName = fileName.Remove(idx);
            }

            return fileName;
        }

        /// <summary>
        /// Gets the file name without extension.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static string GetFileNameWithoutExtension(string url)
        {
            var fileName = Path.GetFileNameWithoutExtension(GetFileName(url));
            return fileName;
        }

        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public static string GetExtension(string url)
        {
            var ext = Path.GetExtension(GetFileName(url));
            return ext;
        }

        /// <summary>
        /// Determines whether [is MIME type valid] [the specified MIME type].
        /// </summary>
        /// <param name="mimeType">Type of the MIME.</param>
        /// <returns>
        ///   <c>true</c> if [is MIME type valid] [the specified MIME type]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsMimeTypeValid(string mimeType)
        {
            if (string.IsNullOrWhiteSpace(mimeType) == true)
            {
                return false;
            }

            if (mimeType.IndexOf(' ') >= 0)
            {
                return false;
            }

            var parts = mimeType.Split(new char[] { '/' });
            if (parts.Length != 2)
            {
                return false;
            }

            if (_AllowedMimeParts.Contains(parts[0]) == false)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the type of the extension from MIME.
        /// </summary>
        /// <param name="mimeType">Type of the MIME.</param>
        /// <returns></returns>
        public static string GetExtensionFromMimeType(string mimeType)
        {
            var ext = string.Empty;
            if(IsMimeTypeValid(mimeType) == true)
            {                
                var parts = mimeType.Split(new char[] { '/' });
                ext = $".{parts[1]}";
            }            

            if(ext == ".octet-stream")
            {
                ext = string.Empty;
            }

            if(ext == ".plain")
            {
                ext = ".txt";
            }

            return ext;
        }

        /// <summary>
        /// Gets the type of the type from MIME.
        /// </summary>
        /// <param name="mimeType">Type of the MIME.</param>
        /// <returns></returns>
        public static string GetTypeFromMimeType(string mimeType)
        {
            var type = string.Empty;
            if (IsMimeTypeValid(mimeType) == true)
            {
                var parts = mimeType.Split(new char[] { '/' });
                type = parts[0];
            }

            return type;
        }
    }
}
