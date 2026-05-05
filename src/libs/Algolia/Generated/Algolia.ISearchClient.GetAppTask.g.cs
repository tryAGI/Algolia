#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Check application task status<br/>
        /// Checks the status of a given application task.
        /// </summary>
        /// <param name="taskID">
        /// Example: 1506303845001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.GetTaskResponse> GetAppTaskAsync(
            long taskID,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check application task status<br/>
        /// Checks the status of a given application task.
        /// </summary>
        /// <param name="taskID">
        /// Example: 1506303845001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.GetTaskResponse>> GetAppTaskAsResponseAsync(
            long taskID,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}