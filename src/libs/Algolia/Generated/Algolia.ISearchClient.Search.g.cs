#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search multiple queries<br/>
        /// Runs multiple search queries against one or more indices in a single API request.<br/>
        /// Use cases include:<br/>
        /// - Searching different indices, such as products and marketing content.<br/>
        /// - Run multiple queries on the same index with different parameters or filters.<br/>
        /// If you know the expected result type, use the `searchForHits` or `searchForFacets` helper to simplify the response format.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchResponse2> SearchAsync(

            global::Algolia.SearchRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search multiple queries<br/>
        /// Runs multiple search queries against one or more indices in a single API request.<br/>
        /// Use cases include:<br/>
        /// - Searching different indices, such as products and marketing content.<br/>
        /// - Run multiple queries on the same index with different parameters or filters.<br/>
        /// If you know the expected result type, use the `searchForHits` or `searchForFacets` helper to simplify the response format.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.SearchResponse2>> SearchAsResponseAsync(

            global::Algolia.SearchRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search multiple queries<br/>
        /// Runs multiple search queries against one or more indices in a single API request.<br/>
        /// Use cases include:<br/>
        /// - Searching different indices, such as products and marketing content.<br/>
        /// - Run multiple queries on the same index with different parameters or filters.<br/>
        /// If you know the expected result type, use the `searchForHits` or `searchForFacets` helper to simplify the response format.
        /// </summary>
        /// <param name="requests"></param>
        /// <param name="strategy">
        /// Strategy for multiple search queries:<br/>
        /// - `none`. Run all queries.<br/>
        /// - `stopIfEnoughMatches`. Run the queries one by one, stopping as soon as a query matches at least the `hitsPerPage` number of results.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchResponse2> SearchAsync(
            global::System.Collections.Generic.IList<global::Algolia.SearchQuery> requests,
            global::Algolia.SearchStrategy? strategy = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}