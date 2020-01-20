// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System;
using System.Net;

namespace Hubster.Abstractions.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.ApplicationException" />
    public class GenericException : ApplicationException
    {
        public object Response { get; private set; }
        public HttpStatusCode StatusCode { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericException"/> class.
        /// </summary>
        /// <param name="statusCode">The status code.</param>
        /// <param name="response">The response.</param>
        /// <param name="message">The message.</param>
        public GenericException(HttpStatusCode statusCode, object response, string message = null) : base(message ?? "Application Error")
        {
            Response = response;
            StatusCode = statusCode;            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericException"/> class.
        /// </summary>
        /// <param name="statusCode">The status code.</param>
        /// <param name="response">The response.</param>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public GenericException(HttpStatusCode statusCode, object response, string message, Exception inner) : base(message, inner)
        {
            Response = response;
            StatusCode = statusCode;
        }
    }
}
