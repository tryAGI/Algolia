
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRulesResponse
    {
        /// <summary>
        /// Rules that matched the search criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.Rule> Hits { get; set; }

        /// <summary>
        /// Number of rules that matched the search criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbHits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbHits { get; set; }

        /// <summary>
        /// Current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Number of pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbPages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRulesResponse" /> class.
        /// </summary>
        /// <param name="hits">
        /// Rules that matched the search criteria.
        /// </param>
        /// <param name="nbHits">
        /// Number of rules that matched the search criteria.
        /// </param>
        /// <param name="page">
        /// Current page.
        /// </param>
        /// <param name="nbPages">
        /// Number of pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRulesResponse(
            global::System.Collections.Generic.IList<global::Algolia.Rule> hits,
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
        /// Initializes a new instance of the <see cref="SearchRulesResponse" /> class.
        /// </summary>
        public SearchRulesResponse()
        {
        }

    }
}