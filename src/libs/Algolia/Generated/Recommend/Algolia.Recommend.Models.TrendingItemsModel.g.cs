
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Trending items model.<br/>
    /// Trending items are determined from the number of conversion events collected on them.
    /// </summary>
    public enum TrendingItemsModel
    {
        /// <summary>
        /// 
        /// </summary>
        TrendingItems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrendingItemsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrendingItemsModel value)
        {
            return value switch
            {
                TrendingItemsModel.TrendingItems => "trending-items",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrendingItemsModel? ToEnum(string value)
        {
            return value switch
            {
                "trending-items" => TrendingItemsModel.TrendingItems,
                _ => null,
            };
        }
    }
}