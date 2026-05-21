
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchSynonymsResponse
    {
        /// <summary>
        /// Matching synonyms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.SynonymHit> Hits { get; set; }

        /// <summary>
        /// Number of results (hits).<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbHits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbHits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynonymsResponse" /> class.
        /// </summary>
        /// <param name="hits">
        /// Matching synonyms.
        /// </param>
        /// <param name="nbHits">
        /// Number of results (hits).<br/>
        /// Example: 20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchSynonymsResponse(
            global::System.Collections.Generic.IList<global::Algolia.SynonymHit> hits,
            int nbHits)
        {
            this.Hits = hits ?? throw new global::System.ArgumentNullException(nameof(hits));
            this.NbHits = nbHits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynonymsResponse" /> class.
        /// </summary>
        public SearchSynonymsResponse()
        {
        }

    }
}