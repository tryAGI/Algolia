
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Search parameter.
    /// </summary>
    public sealed partial class SearchDictionaryEntriesRequest
    {
        /// <summary>
        /// Search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

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
        /// ISO code for a supported language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.SupportedLanguageJsonConverter))]
        public global::Algolia.SupportedLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDictionaryEntriesRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Search query.
        /// </param>
        /// <param name="page">
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="hitsPerPage">
        /// Number of hits per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="language">
        /// ISO code for a supported language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchDictionaryEntriesRequest(
            string query,
            int? page,
            int? hitsPerPage,
            global::Algolia.SupportedLanguage? language)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Page = page;
            this.HitsPerPage = hitsPerPage;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDictionaryEntriesRequest" /> class.
        /// </summary>
        public SearchDictionaryEntriesRequest()
        {
        }
    }
}