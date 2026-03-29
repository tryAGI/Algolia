#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Batch indexing operations on one index<br/>
        /// Adds, updates, or deletes records in one index with a single API request.<br/>
        /// Batching index updates reduces latency and increases data integrity.<br/>
        /// - Actions are applied in the order they're specified.<br/>
        /// - Actions are equivalent to the individual API requests of the same name.<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.BatchResponse> BatchAsync(
            string indexName,

            global::Algolia.BatchWriteParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch indexing operations on one index<br/>
        /// Adds, updates, or deletes records in one index with a single API request.<br/>
        /// Batching index updates reduces latency and increases data integrity.<br/>
        /// - Actions are applied in the order they're specified.<br/>
        /// - Actions are equivalent to the individual API requests of the same name.<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="requests"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.BatchResponse> BatchAsync(
            string indexName,
            global::System.Collections.Generic.IList<global::Algolia.BatchWriteParamsRequest> requests,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}