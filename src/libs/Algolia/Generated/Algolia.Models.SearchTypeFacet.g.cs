
#nullable enable

namespace Algolia
{
    /// <summary>
    /// - `default`: perform a search query<br/>
    /// - `facet` [searches for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
    /// Default Value: facet
    /// </summary>
    public enum SearchTypeFacet
    {
        /// <summary>
        /// //www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).
        /// </summary>
        Facet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchTypeFacetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchTypeFacet value)
        {
            return value switch
            {
                SearchTypeFacet.Facet => "facet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchTypeFacet? ToEnum(string value)
        {
            return value switch
            {
                "facet" => SearchTypeFacet.Facet,
                _ => null,
            };
        }
    }
}