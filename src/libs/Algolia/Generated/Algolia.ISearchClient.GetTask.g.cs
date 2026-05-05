#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Check task status<br/>
        /// Checks the status of a given task.<br/>
        /// Indexing tasks are asynchronous.<br/>
        /// When you add, update, or delete records or indices,<br/>
        /// a task is created on a queue and completed depending on the load on the server.<br/>
        /// The indexing tasks' responses include a task ID that you can use to check the status.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="taskID">
        /// Example: 1506303845001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.GetTaskResponse> GetTaskAsync(
            string indexName,
            long taskID,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check task status<br/>
        /// Checks the status of a given task.<br/>
        /// Indexing tasks are asynchronous.<br/>
        /// When you add, update, or delete records or indices,<br/>
        /// a task is created on a queue and completed depending on the load on the server.<br/>
        /// The indexing tasks' responses include a task ID that you can use to check the status.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="taskID">
        /// Example: 1506303845001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.GetTaskResponse>> GetTaskAsResponseAsync(
            string indexName,
            long taskID,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}