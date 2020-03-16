// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Models
{
    internal static class SearchQueryTypeExtensions
    {
        public static string ToSerialString(this SearchQueryType value) => value switch
        {
            SearchQueryType.Simple => "simple",
            SearchQueryType.Full => "full",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchQueryType value.")
        };

        public static SearchQueryType ToSearchQueryType(this string value)
        {
            if (string.Equals(value, "simple", StringComparison.InvariantCultureIgnoreCase)) return SearchQueryType.Simple;
            if (string.Equals(value, "full", StringComparison.InvariantCultureIgnoreCase)) return SearchQueryType.Full;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchQueryType value.");
        }
    }
}