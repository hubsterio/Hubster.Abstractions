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
    public sealed class NotAvailableException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotAvailableException"/> class.
        /// </summary>
        public NotAvailableException() : base ("Not available.")
        {
        }

        /// <summary>
        /// Construct a new NotAvailableException object
        /// </summary>
        /// <param name="message">Exception message</param>
        public NotAvailableException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotAvailableException"/> class.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Inner Exception</param>
        public NotAvailableException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
