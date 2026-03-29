
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchSynonymsRequest
    {
        /// <summary>
        /// Search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Synonym type.<br/>
        /// Example: onewaysynonym
        /// </summary>
        /// <example>onewaysynonym</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.SynonymTypeJsonConverter))]
        public global::Algolia.SynonymType? Type { get; set; }

        /// <summary>
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Number of hits per page.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hitsPerPage")]
        public int? HitsPerPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynonymsRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Search query.
        /// </param>
        /// <param name="type">
        /// Synonym type.<br/>
        /// Example: onewaysynonym
        /// </param>
        /// <param name="page">
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="hitsPerPage">
        /// Number of hits per page.<br/>
        /// Default Value: 20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchSynonymsRequest(
            string? query,
            global::Algolia.SynonymType? type,
            int? page,
            int? hitsPerPage)
        {
            this.Query = query;
            this.Type = type;
            this.Page = page;
            this.HitsPerPage = hitsPerPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynonymsRequest" /> class.
        /// </summary>
        public SearchSynonymsRequest()
        {
        }
    }
}