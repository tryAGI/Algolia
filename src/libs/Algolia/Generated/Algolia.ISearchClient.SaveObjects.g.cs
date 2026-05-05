#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Saves the given array of objects in the given index<br/>
        /// Helper: Saves the given array of objects in the given index. The `chunkedBatch` helper splits this into `batch` requests with at most 1,000 objects each.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="objects"></param>
        /// <param name="waitForTasks">
        /// Default Value: false
        /// </param>
        /// <param name="batchSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Algolia.BatchResponse>> SaveObjectsAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            bool? waitForTasks = default,
            int? batchSize = default,
            object? requestOptions = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Saves the given array of objects in the given index<br/>
        /// Helper: Saves the given array of objects in the given index. The `chunkedBatch` helper splits this into `batch` requests with at most 1,000 objects each.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="objects"></param>
        /// <param name="waitForTasks">
        /// Default Value: false
        /// </param>
        /// <param name="batchSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Algolia.BatchResponse>>> SaveObjectsAsResponseAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            bool? waitForTasks = default,
            int? batchSize = default,
            object? requestOptions = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}