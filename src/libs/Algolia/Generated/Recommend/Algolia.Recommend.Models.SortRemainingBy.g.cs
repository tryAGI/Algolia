
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Order of facet values that aren't explicitly positioned with the `order` setting.<br/>
    /// - `count`.<br/>
    ///   Order remaining facet values by decreasing count.<br/>
    ///   The count is the number of matching records containing this facet value.<br/>
    /// - `alpha`.<br/>
    ///   Sort facet values alphabetically.<br/>
    /// - `hidden`.<br/>
    ///   Don't show facet values that aren't explicitly positioned.
    /// </summary>
    public enum SortRemainingBy
    {
        /// <summary>
        /// 
        /// </summary>
        Alpha,
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        Hidden,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SortRemainingByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SortRemainingBy value)
        {
            return value switch
            {
                SortRemainingBy.Alpha => "alpha",
                SortRemainingBy.Count => "count",
                SortRemainingBy.Hidden => "hidden",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SortRemainingBy? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => SortRemainingBy.Alpha,
                "count" => SortRemainingBy.Count,
                "hidden" => SortRemainingBy.Hidden,
                _ => null,
            };
        }
    }
}