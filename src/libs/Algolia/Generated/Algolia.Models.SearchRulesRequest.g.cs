
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Rules search parameters.
    /// </summary>
    public sealed partial class SearchRulesRequest
    {
        /// <summary>
        /// Search query for rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Which part of the search query the pattern should match:<br/>
        /// - `startsWith`. The pattern must match the beginning of the query.<br/>
        /// - `endsWith`. The pattern must match the end of the query.<br/>
        /// - `is`. The pattern must match the query exactly.<br/>
        /// - `contains`. The pattern must match anywhere in the query.<br/>
        /// Empty queries are only allowed as patterns with `anchoring: is`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchoring")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.AnchoringJsonConverter))]
        public global::Algolia.Anchoring? Anchoring { get; set; }

        /// <summary>
        /// Only return rules that match the context (exact match).<br/>
        /// Example: mobile
        /// </summary>
        /// <example>mobile</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Requested page of the API response.<br/>
        /// Algolia uses `page` and `hitsPerPage` to control how search results are displayed ([paginated](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js)).<br/>
        /// - `hitsPerPage`: sets the number of search results (_hits_) displayed per page.<br/>
        /// - `page`: specifies the page number of the search results you want to retrieve. Page numbering starts at 0, so the first page is `page=0`, the second is `page=1`, and so on.<br/>
        /// For example, to display 10 results per page starting from the third page, set `hitsPerPage` to 10 and `page` to 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Maximum number of hits per page.<br/>
        /// Algolia uses `page` and `hitsPerPage` to control how search results are displayed ([paginated](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js)).<br/>
        /// - `hitsPerPage`: sets the number of search results (_hits_) displayed per page.<br/>
        /// - `page`: specifies the page number of the search results you want to retrieve. Page numbering starts at 0, so the first page is `page=0`, the second is `page=1`, and so on.<br/>
        /// For example, to display 10 results per page starting from the third page, set `hitsPerPage` to 10 and `page` to 2.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hitsPerPage")]
        public int? HitsPerPage { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.OneOfJsonConverter<bool?, object>))]
        public global::Algolia.OneOf<bool?, object>? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRulesRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Search query for rules.
        /// </param>
        /// <param name="anchoring">
        /// Which part of the search query the pattern should match:<br/>
        /// - `startsWith`. The pattern must match the beginning of the query.<br/>
        /// - `endsWith`. The pattern must match the end of the query.<br/>
        /// - `is`. The pattern must match the query exactly.<br/>
        /// - `contains`. The pattern must match anywhere in the query.<br/>
        /// Empty queries are only allowed as patterns with `anchoring: is`.
        /// </param>
        /// <param name="context">
        /// Only return rules that match the context (exact match).<br/>
        /// Example: mobile
        /// </param>
        /// <param name="page">
        /// Requested page of the API response.<br/>
        /// Algolia uses `page` and `hitsPerPage` to control how search results are displayed ([paginated](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js)).<br/>
        /// - `hitsPerPage`: sets the number of search results (_hits_) displayed per page.<br/>
        /// - `page`: specifies the page number of the search results you want to retrieve. Page numbering starts at 0, so the first page is `page=0`, the second is `page=1`, and so on.<br/>
        /// For example, to display 10 results per page starting from the third page, set `hitsPerPage` to 10 and `page` to 2.
        /// </param>
        /// <param name="hitsPerPage">
        /// Maximum number of hits per page.<br/>
        /// Algolia uses `page` and `hitsPerPage` to control how search results are displayed ([paginated](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js)).<br/>
        /// - `hitsPerPage`: sets the number of search results (_hits_) displayed per page.<br/>
        /// - `page`: specifies the page number of the search results you want to retrieve. Page numbering starts at 0, so the first page is `page=0`, the second is `page=1`, and so on.<br/>
        /// For example, to display 10 results per page starting from the third page, set `hitsPerPage` to 10 and `page` to 2.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="enabled">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRulesRequest(
            string? query,
            global::Algolia.Anchoring? anchoring,
            string? context,
            int? page,
            int? hitsPerPage,
            global::Algolia.OneOf<bool?, object>? enabled)
        {
            this.Query = query;
            this.Anchoring = anchoring;
            this.Context = context;
            this.Page = page;
            this.HitsPerPage = hitsPerPage;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRulesRequest" /> class.
        /// </summary>
        public SearchRulesRequest()
        {
        }

    }
}