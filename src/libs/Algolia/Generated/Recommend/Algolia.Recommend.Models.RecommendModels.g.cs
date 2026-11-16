
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
        LookingSimilar,
        /// <summary>
        ///
        /// </summary>
        RelatedProducts,
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
                RecommendModels.LookingSimilar => "looking-similar",
                RecommendModels.RelatedProducts => "related-products",
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
                "looking-similar" => RecommendModels.LookingSimilar,
                "related-products" => RecommendModels.RelatedProducts,
                "trending-items" => RecommendModels.TrendingItems,
                _ => null,
            };
        }
    }
}