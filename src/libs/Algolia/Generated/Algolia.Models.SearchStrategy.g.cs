
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Strategy for multiple search queries:<br/>
    /// - `none`. Run all queries.<br/>
    /// - `stopIfEnoughMatches`. Run the queries one by one, stopping as soon as a query matches at least the `hitsPerPage` number of results.
    /// </summary>
    public enum SearchStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        StopIfEnoughMatches,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchStrategy value)
        {
            return value switch
            {
                SearchStrategy.None => "none",
                SearchStrategy.StopIfEnoughMatches => "stopIfEnoughMatches",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchStrategy? ToEnum(string value)
        {
            return value switch
            {
                "none" => SearchStrategy.None,
                "stopIfEnoughMatches" => SearchStrategy.StopIfEnoughMatches,
                _ => null,
            };
        }
    }
}