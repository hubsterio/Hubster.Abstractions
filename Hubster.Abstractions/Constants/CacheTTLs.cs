// Hubster 
// Copyright (c) 2020 Hubster Solutions Inc. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;

namespace Hubster.Abstractions.Constants
{
    [ExcludeFromCodeCoverage]
    public static class CacheTTLs
    {
        public static readonly TimeSpan Expire_1M = TimeSpan.FromMinutes(1);
        public static readonly TimeSpan Expire_5M = TimeSpan.FromMinutes(5);
        public static readonly TimeSpan Expire_10M = TimeSpan.FromMinutes(10);
        public static readonly TimeSpan Expire_15M = TimeSpan.FromMinutes(15);
        public static readonly TimeSpan Expire_20M = TimeSpan.FromMinutes(20);
        public static readonly TimeSpan Expire_1H = TimeSpan.FromHours(1);
        public static readonly TimeSpan Expire_2H = TimeSpan.FromHours(2);
        public static readonly TimeSpan Expire_3H = TimeSpan.FromHours(3);
        public static readonly TimeSpan Expire_4H = TimeSpan.FromHours(4);
        public static readonly TimeSpan Expire_5H = TimeSpan.FromHours(5);
        public static readonly TimeSpan Expire_6H = TimeSpan.FromHours(6);
        public static readonly TimeSpan Expire_1D = TimeSpan.FromDays(1);
        public static readonly TimeSpan Expire_2D = TimeSpan.FromDays(2);
        public static readonly TimeSpan Expire_Never = TimeSpan.Zero;
    }
}
