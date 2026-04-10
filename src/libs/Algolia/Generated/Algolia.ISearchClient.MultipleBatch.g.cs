#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Batch indexing operations on multiple indices<br/>
        /// Adds, updates, or deletes records in multiple indices with a single API request.<br/>
        /// - Actions are applied in the order they are specified.<br/>
        /// - Actions are equivalent to the individual API requests of the same name.<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.MultipleBatchResponse> MultipleBatchAsync(

            global::Algolia.MultipleBatchRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch indexing operations on multiple indices<br/>
        /// Adds, updates, or deletes records in multiple indices with a single API request.<br/>
        /// - Actions are applied in the order they are specified.<br/>
        /// - Actions are equivalent to the individual API requests of the same name.<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="requests"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.MultipleBatchResponse> MultipleBatchAsync(
            global::System.Collections.Generic.IList<global::Algolia.MultipleBatchRequestRequest> requests,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}