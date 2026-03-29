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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.GetTaskResponse> GetAppTaskAsync(
            long taskID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}