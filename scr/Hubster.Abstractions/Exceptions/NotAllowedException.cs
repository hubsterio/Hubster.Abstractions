// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;

namespace Hubster.Abstractions.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.ApplicationException" />
    [ExcludeFromCodeCoverage]
    public sealed class NotAllowedException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotAllowedException"/> class.
        /// </summary>
        public NotAllowedException() : base ("Not allowed.")
        {
        }

        /// <summary>
        /// Construct a new NotAvailableException object
        /// </summary>
        /// <param name="message">Exception message</param>
        public NotAllowedException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotAvailableException"/> class.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Inner Exception</param>
        public NotAllowedException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
