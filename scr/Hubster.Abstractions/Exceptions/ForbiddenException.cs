// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System;

using System.Diagnostics.CodeAnalysis;

namespace Hubster.Abstractions.Exceptions
{
    /// <summary>
    /// The ForbiddenException is thrown when attempting to retrieve an item that does not exist
    /// </summary>
    [ExcludeFromCodeCoverage]
    public sealed class ForbiddenException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenException"/> class.
        /// </summary>
        public ForbiddenException() : base("Forbidden.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenException"/> class.
        /// </summary>
        /// <param name="message">Exception message</param>
        public ForbiddenException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenException"/> class.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Inner Exception</param>
        public ForbiddenException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
