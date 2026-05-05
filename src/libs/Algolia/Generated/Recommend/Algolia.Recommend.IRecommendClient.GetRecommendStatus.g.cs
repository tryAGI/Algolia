#nullable enable

namespace Algolia.Recommend
{
    public partial interface IRecommendClient
    {
        /// <summary>
        /// Check task status<br/>
        /// Checks the status of a given task.<br/>
        /// Deleting a Recommend rule is asynchronous.<br/>
        /// When you delete a rule, a task is created on a queue and completed depending on the load on the server.<br/>
        /// The API response includes a task ID that you can use to check the status.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="model"></param>
        /// <param name="taskID">
        /// Unique identifier of a task.<br/>
        /// A successful API response means that a task was added to a queue.<br/>
        /// It might not run immediately.<br/>
        /// You can check the task's progress with the [`task` operation](https://www.algolia.com/doc/rest-api/search/get-task) and this task ID.<br/>
        /// Example: 1514562690001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.Recommend.GetRecommendStatusResponse> GetRecommendStatusAsync(
            string indexName,
            global::Algolia.Recommend.RecommendModels model,
            long taskID,
            global::Algolia.Recommend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check task status<br/>
        /// Checks the status of a given task.<br/>
        /// Deleting a Recommend rule is asynchronous.<br/>
        /// When you delete a rule, a task is created on a queue and completed depending on the load on the server.<br/>
        /// The API response includes a task ID that you can use to check the status.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="model"></param>
        /// <param name="taskID">
        /// Unique identifier of a task.<br/>
        /// A successful API response means that a task was added to a queue.<br/>
        /// It might not run immediately.<br/>
        /// You can check the task's progress with the [`task` operation](https://www.algolia.com/doc/rest-api/search/get-task) and this task ID.<br/>
        /// Example: 1514562690001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.Recommend.AutoSDKHttpResponse<global::Algolia.Recommend.GetRecommendStatusResponse>> GetRecommendStatusAsResponseAsync(
            string indexName,
            global::Algolia.Recommend.RecommendModels model,
            long taskID,
            global::Algolia.Recommend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}