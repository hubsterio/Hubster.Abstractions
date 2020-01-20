// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;

namespace Hubster.Abstractions.Exceptions
{
    /// <summary>
    /// The NotFoundException is thrown when attempting to retrieve an item that does not exist
    /// </summary>
    [ExcludeFromCodeCoverage]
    public sealed class NotFoundException : ApplicationException
    {
        /// <summary>
        /// Construct a new NotFoundException object
        /// </summary>
        public NotFoundException() : base ("The item you where requesting was not found.")
        {
        }

        /// <summary>
        /// Construct a new NotFoundException object
        /// </summary>
        /// <param name="message">Exception message</param>
        public NotFoundException(string message) : base(message)
        {
        }

        /// <summary>
        /// Construct a new NotFoundException object
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Inner Exception</param>
        public NotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
