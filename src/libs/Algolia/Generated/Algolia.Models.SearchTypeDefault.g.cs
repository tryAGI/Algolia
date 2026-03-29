
#nullable enable

namespace Algolia
{
    /// <summary>
    /// - `default`: perform a search query<br/>
    /// - `facet` [searches for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
    /// Default Value: default
    /// </summary>
    public enum SearchTypeDefault
    {
        /// <summary>
        /// perform a search query
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchTypeDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchTypeDefault value)
        {
            return value switch
            {
                SearchTypeDefault.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchTypeDefault? ToEnum(string value)
        {
            return value switch
            {
                "default" => SearchTypeDefault.Default,
                _ => null,
            };
        }
    }
}