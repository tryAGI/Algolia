
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Strategy for removing words from the query when it doesn't return any results.<br/>
    /// This helps to avoid returning empty search results.<br/>
    /// - `none`.<br/>
    ///   No words are removed when a query doesn't return results.<br/>
    /// - `lastWords`.<br/>
    ///   Treat the last (then second to last, then third to last) word as optional,<br/>
    ///   until there are results or at most 5 words have been removed.<br/>
    /// - `firstWords`.<br/>
    ///   Treat the first (then second, then third) word as optional,<br/>
    ///   until there are results or at most 5 words have been removed.<br/>
    /// - `allOptional`.<br/>
    ///   Treat all words as optional.<br/>
    /// For more information, see [Remove words to improve results](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/empty-or-insufficient-results/in-depth/why-use-remove-words-if-no-results).<br/>
    /// Default Value: none<br/>
    /// Example: firstWords
    /// </summary>
    public enum RemoveWordsIfNoResults
    {
        /// <summary>
        /// 
        /// </summary>
        AllOptional,
        /// <summary>
        /// 
        /// </summary>
        FirstWords,
        /// <summary>
        /// 
        /// </summary>
        LastWords,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveWordsIfNoResultsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveWordsIfNoResults value)
        {
            return value switch
            {
                RemoveWordsIfNoResults.AllOptional => "allOptional",
                RemoveWordsIfNoResults.FirstWords => "firstWords",
                RemoveWordsIfNoResults.LastWords => "lastWords",
                RemoveWordsIfNoResults.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveWordsIfNoResults? ToEnum(string value)
        {
            return value switch
            {
                "allOptional" => RemoveWordsIfNoResults.AllOptional,
                "firstWords" => RemoveWordsIfNoResults.FirstWords,
                "lastWords" => RemoveWordsIfNoResults.LastWords,
                "none" => RemoveWordsIfNoResults.None,
                _ => null,
            };
        }
    }
}