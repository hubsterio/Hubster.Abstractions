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
    public sealed class AbortException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbortException"/> class.
        /// </summary>
        public AbortException() : base(string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortException"/> class.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public AbortException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbortException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public AbortException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
