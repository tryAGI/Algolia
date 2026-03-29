
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Determines if and how query words are interpreted as prefixes.<br/>
    /// By default, only the last query word is treated as a prefix (`prefixLast`).<br/>
    /// To turn off prefix search, use `prefixNone`.<br/>
    /// Avoid `prefixAll`, which treats all query words as prefixes.<br/>
    /// This might lead to counterintuitive results and makes your search slower.<br/>
    /// For more information, see [Prefix searching](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/prefix-searching).<br/>
    /// Default Value: prefixLast
    /// </summary>
    public enum QueryType
    {
        /// <summary>
        /// 
        /// </summary>
        PrefixAll,
        /// <summary>
        /// 
        /// </summary>
        PrefixLast,
        /// <summary>
        /// 
        /// </summary>
        PrefixNone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryType value)
        {
            return value switch
            {
                QueryType.PrefixAll => "prefixAll",
                QueryType.PrefixLast => "prefixLast",
                QueryType.PrefixNone => "prefixNone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryType? ToEnum(string value)
        {
            return value switch
            {
                "prefixAll" => QueryType.PrefixAll,
                "prefixLast" => QueryType.PrefixLast,
                "prefixNone" => QueryType.PrefixNone,
                _ => null,
            };
        }
    }
}