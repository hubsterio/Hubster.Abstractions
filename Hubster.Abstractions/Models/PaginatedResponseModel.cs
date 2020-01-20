// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hubster.Abstractions.Models
{
    [ExcludeFromCodeCoverage]
    public sealed class PaginatedResponseModel<T> where T : class
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }
        public IEnumerable<T> Results { get; set; }

        public PaginatedResponseModel()
        {
            Results = new List<T>();
        }
    }
}
