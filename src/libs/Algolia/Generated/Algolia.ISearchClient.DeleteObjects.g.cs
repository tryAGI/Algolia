#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Deletes every records for the given objectIDs<br/>
        /// Helper: Deletes every records for the given objectIDs. The `chunkedBatch` helper splits this into `batch` requests with at most 1,000 objectIDs each.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="objectIDs"></param>
        /// <param name="waitForTasks"></param>
        /// <param name="batchSize"></param>
        /// <param name="requestOptions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Algolia.BatchResponse>> DeleteObjectsAsync(
            string indexName,
            global::System.Collections.Generic.IList<string> objectIDs,
            bool? waitForTasks = default,
            int? batchSize = default,
            object? requestOptions = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}