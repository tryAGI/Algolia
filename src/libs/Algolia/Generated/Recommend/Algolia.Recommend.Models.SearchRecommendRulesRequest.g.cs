
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Recommend rules parameters.
    /// </summary>
    public sealed partial class SearchRecommendRulesRequest
    {
        /// <summary>
        /// Search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Only search for rules with matching context.<br/>
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
        /// Whether to only show rules where the value of their `enabled` property matches this parameter.<br/>
        /// If absent, show all rules, regardless of their `enabled` property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Filter expression. This only searches for rules matching the filter expression.<br/>
        /// Example: objectID:rr-123456
        /// </summary>
        /// <example>objectID:rr-123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public string? Filters { get; set; }

        /// <summary>
        /// Include facets and facet values in the response. Use `['*']` to include all facets.<br/>
        /// Example: [*]
        /// </summary>
        /// <example>[*]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets")]
        public global::System.Collections.Generic.IList<string>? Facets { get; set; }

        /// <summary>
        /// Maximum number of values to return for each facet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxValuesPerFacet")]
        public int? MaxValuesPerFacet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRecommendRulesRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Search query.
        /// </param>
        /// <param name="context">
        /// Only search for rules with matching context.<br/>
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
        /// Whether to only show rules where the value of their `enabled` property matches this parameter.<br/>
        /// If absent, show all rules, regardless of their `enabled` property.
        /// </param>
        /// <param name="filters">
        /// Filter expression. This only searches for rules matching the filter expression.<br/>
        /// Example: objectID:rr-123456
        /// </param>
        /// <param name="facets">
        /// Include facets and facet values in the response. Use `['*']` to include all facets.<br/>
        /// Example: [*]
        /// </param>
        /// <param name="maxValuesPerFacet">
        /// Maximum number of values to return for each facet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRecommendRulesRequest(
            string? query,
            string? context,
            int? page,
            int? hitsPerPage,
            bool? enabled,
            string? filters,
            global::System.Collections.Generic.IList<string>? facets,
            int? maxValuesPerFacet)
        {
            this.Query = query;
            this.Context = context;
            this.Page = page;
            this.HitsPerPage = hitsPerPage;
            this.Enabled = enabled;
            this.Filters = filters;
            this.Facets = facets;
            this.MaxValuesPerFacet = maxValuesPerFacet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRecommendRulesRequest" /> class.
        /// </summary>
        public SearchRecommendRulesRequest()
        {
        }
    }
}