
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRecommendRulesResponse
    {
        /// <summary>
        /// Recommend rules that match the search criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendRule> Hits { get; set; }

        /// <summary>
        /// Number of results (hits).<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbHits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbHits { get; set; }

        /// <summary>
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Number of pages of results.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbPages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRecommendRulesResponse" /> class.
        /// </summary>
        /// <param name="hits">
        /// Recommend rules that match the search criteria.
        /// </param>
        /// <param name="nbHits">
        /// Number of results (hits).<br/>
        /// Example: 20
        /// </param>
        /// <param name="page">
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="nbPages">
        /// Number of pages of results.<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRecommendRulesResponse(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendRule> hits,
            int nbHits,
            int page,
            int nbPages)
        {
            this.Hits = hits ?? throw new global::System.ArgumentNullException(nameof(hits));
            this.NbHits = nbHits;
            this.Page = page;
            this.NbPages = nbPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRecommendRulesResponse" /> class.
        /// </summary>
        public SearchRecommendRulesResponse()
        {
        }

    }
}