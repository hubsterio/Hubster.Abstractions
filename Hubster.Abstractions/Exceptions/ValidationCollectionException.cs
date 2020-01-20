// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Hubster.Abstractions.Models;
using System.Net;

namespace Hubster.Abstractions.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.ApplicationException" />
    [ExcludeFromCodeCoverage]
    public sealed class ValidationCollectionException : ApplicationException
    {
        public HttpStatusCode StatusCode { get; private set; }

        /// <summary>
        /// Gets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        public IEnumerable<ErrorCodeModel> Errors { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationCollectionException" /> class.
        /// </summary>
        /// <param name="errors">The errors.</param>
        /// <param name="StatusCode">The status code.</param>
        public ValidationCollectionException(IEnumerable<ErrorCodeModel> errors, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            StatusCode = statusCode;
            Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationCollectionException" /> class.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="statusCode">The status code.</param>
        public ValidationCollectionException(ErrorCodeModel error, HttpStatusCode statusCode = HttpStatusCode.BadRequest) : this(new[] { error }, statusCode)
        {            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationCollectionException" /> class.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="statusCode">The status code.</param>
        public ValidationCollectionException(string errorMessage, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            StatusCode = statusCode;
            Errors = new[] 
            {
                new ErrorCodeModel {
                    Code = (int)statusCode,
                    Description = errorMessage
                }
            };
        }
    }
}
