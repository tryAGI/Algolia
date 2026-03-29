
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public enum RecommendModels
    {
        /// <summary>
        /// 
        /// </summary>
        BoughtTogether,
        /// <summary>
        /// 
        /// </summary>
        RelatedProducts,
        /// <summary>
        /// 
        /// </summary>
        TrendingFacets,
        /// <summary>
        /// 
        /// </summary>
        TrendingItems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecommendModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecommendModels value)
        {
            return value switch
            {
                RecommendModels.BoughtTogether => "bought-together",
                RecommendModels.RelatedProducts => "related-products",
                RecommendModels.TrendingFacets => "trending-facets",
                RecommendModels.TrendingItems => "trending-items",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecommendModels? ToEnum(string value)
        {
            return value switch
            {
                "bought-together" => RecommendModels.BoughtTogether,
                "related-products" => RecommendModels.RelatedProducts,
                "trending-facets" => RecommendModels.TrendingFacets,
                "trending-items" => RecommendModels.TrendingItems,
                _ => null,
            };
        }
    }
}