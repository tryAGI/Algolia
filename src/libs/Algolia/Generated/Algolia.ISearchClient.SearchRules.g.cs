#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search for rules<br/>
        /// Searches for rules in your index.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchRulesResponse> SearchRulesAsync(
            string indexName,

            global::Algolia.SearchRulesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for rules<br/>
        /// Searches for rules in your index.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchRulesResponse> SearchRulesAsync(
            string indexName,
            string? query = default,
            global::Algolia.Anchoring? anchoring = default,
            string? context = default,
            int? page = default,
            int? hitsPerPage = default,
            global::Algolia.OneOf<bool?, object>? enabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}