#nullable enable

namespace Algolia.Recommend
{
    public partial interface IRecommendClient
    {
        /// <summary>
        /// Search for rules<br/>
        /// Searches for Recommend rules.<br/>
        /// Use an empty query to list all rules for this recommendation scenario.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.Recommend.SearchRecommendRulesResponse> SearchRecommendRulesAsync(
            string indexName,
            global::Algolia.Recommend.RecommendModels model,

            global::Algolia.Recommend.SearchRecommendRulesRequest request,
            global::Algolia.Recommend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for rules<br/>
        /// Searches for Recommend rules.<br/>
        /// Use an empty query to list all rules for this recommendation scenario.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="model"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.Recommend.SearchRecommendRulesResponse> SearchRecommendRulesAsync(
            string indexName,
            global::Algolia.Recommend.RecommendModels model,
            string? query = default,
            string? context = default,
            int? page = default,
            int? hitsPerPage = default,
            bool? enabled = default,
            string? filters = default,
            global::System.Collections.Generic.IList<string>? facets = default,
            int? maxValuesPerFacet = default,
            global::Algolia.Recommend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}