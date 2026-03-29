
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Trending facet values model.<br/>
    /// This model recommends trending facet values for the specified facet attribute.
    /// </summary>
    public enum TrendingFacetsModel
    {
        /// <summary>
        /// 
        /// </summary>
        TrendingFacets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrendingFacetsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrendingFacetsModel value)
        {
            return value switch
            {
                TrendingFacetsModel.TrendingFacets => "trending-facets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrendingFacetsModel? ToEnum(string value)
        {
            return value switch
            {
                "trending-facets" => TrendingFacetsModel.TrendingFacets,
                _ => null,
            };
        }
    }
}