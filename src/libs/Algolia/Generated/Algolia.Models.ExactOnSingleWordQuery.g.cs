
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Determines how the [Exact ranking criterion](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes) is computed when the search query has only one word.<br/>
    /// - `attribute`.<br/>
    ///   The Exact ranking criterion is 1 if the query word and attribute value are the same.<br/>
    ///   For example, a search for "road" will match the value "road", but not "road trip".<br/>
    /// - `none`.<br/>
    ///   The Exact ranking criterion is ignored on single-word searches.<br/>
    /// - `word`.<br/>
    ///   The Exact ranking criterion is 1 if the query word is found in the attribute value.<br/>
    ///   The query word must have at least 3 characters and must not be a stop word.<br/>
    ///   Only exact matches will be highlighted,<br/>
    ///   partial and prefix matches won't.<br/>
    /// Default Value: attribute
    /// </summary>
    public enum ExactOnSingleWordQuery
    {
        /// <summary>
        /// //www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes) is computed when the search query has only one word.
        /// </summary>
        Attribute,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// //www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes) is computed when the search query has only one word.
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExactOnSingleWordQueryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExactOnSingleWordQuery value)
        {
            return value switch
            {
                ExactOnSingleWordQuery.Attribute => "attribute",
                ExactOnSingleWordQuery.None => "none",
                ExactOnSingleWordQuery.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExactOnSingleWordQuery? ToEnum(string value)
        {
            return value switch
            {
                "attribute" => ExactOnSingleWordQuery.Attribute,
                "none" => ExactOnSingleWordQuery.None,
                "word" => ExactOnSingleWordQuery.Word,
                _ => null,
            };
        }
    }
}