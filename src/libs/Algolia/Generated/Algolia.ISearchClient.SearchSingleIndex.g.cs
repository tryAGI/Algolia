#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search an index<br/>
        /// Searches a single index and returns matching search results as hits.<br/>
        /// This method lets you retrieve up to 1,000 hits.<br/>
        /// If you need more, use the [`browse` operation](https://www.algolia.com/doc/rest-api/search/browse) or increase the `paginatedLimitedTo` index setting.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchResponse> SearchSingleIndexAsync(
            string indexName,

            global::Algolia.SearchParams request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search an index<br/>
        /// Searches a single index and returns matching search results as hits.<br/>
        /// This method lets you retrieve up to 1,000 hits.<br/>
        /// If you need more, use the [`browse` operation](https://www.algolia.com/doc/rest-api/search/browse) or increase the `paginatedLimitedTo` index setting.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.SearchResponse>> SearchSingleIndexAsResponseAsync(
            string indexName,

            global::Algolia.SearchParams request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search an index<br/>
        /// Searches a single index and returns matching search results as hits.<br/>
        /// This method lets you retrieve up to 1,000 hits.<br/>
        /// If you need more, use the [`browse` operation](https://www.algolia.com/doc/rest-api/search/browse) or increase the `paginatedLimitedTo` index setting.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchResponse> SearchSingleIndexAsync(
            string indexName,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}