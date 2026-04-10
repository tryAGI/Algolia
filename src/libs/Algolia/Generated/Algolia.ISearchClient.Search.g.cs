#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search multiple indices<br/>
        /// Sends multiple search requests to one or more indices.<br/>
        /// This can be useful in these cases:<br/>
        /// - Different indices for different purposes, such as, one index for products, another one for marketing content.<br/>
        /// - Multiple searches to the same index—for example, with different filters.<br/>
        /// Use the helper `searchForHits` or `searchForFacets` to get the results in a more convenient format, if you already know the return type you want.
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
        /// Search multiple indices<br/>
        /// Sends multiple search requests to one or more indices.<br/>
        /// This can be useful in these cases:<br/>
        /// - Different indices for different purposes, such as, one index for products, another one for marketing content.<br/>
        /// - Multiple searches to the same index—for example, with different filters.<br/>
        /// Use the helper `searchForHits` or `searchForFacets` to get the results in a more convenient format, if you already know the return type you want.
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