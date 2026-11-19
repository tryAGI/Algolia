
#nullable enable

namespace Algolia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchParamsAllowReRanking
    {
        /// <summary>
        /// Whether [Dynamic Re-Ranking](https://www.algolia.com/doc/guides/algolia-ai/re-ranking) runs concurrently with Personalization.<br/>
        /// Dynamic Re-Ranking isn't applied when `distinct` &gt; 1, even if `allowReRankingOnPersonalization` is `true`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowReRankingOnPersonalization")]
        public bool? AllowReRankingOnPersonalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParamsAllowReRanking" /> class.
        /// </summary>
        /// <param name="allowReRankingOnPersonalization">
        /// Whether [Dynamic Re-Ranking](https://www.algolia.com/doc/guides/algolia-ai/re-ranking) runs concurrently with Personalization.<br/>
        /// Dynamic Re-Ranking isn't applied when `distinct` &gt; 1, even if `allowReRankingOnPersonalization` is `true`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchParamsAllowReRanking(
            bool? allowReRankingOnPersonalization)
        {
            this.AllowReRankingOnPersonalization = allowReRankingOnPersonalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParamsAllowReRanking" /> class.
        /// </summary>
        public SearchParamsAllowReRanking()
        {
        }

    }
}