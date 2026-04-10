#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Update index settings<br/>
        /// Update the specified index settings.<br/>
        /// Index settings that you don't specify are left unchanged.<br/>
        /// Specify `null` to reset a setting to its default value.<br/>
        /// For best performance, update the index settings before you add new records to your index.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> SetSettingsAsync(
            string indexName,

            global::Algolia.IndexSettings request,
            bool? forwardToReplicas = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update index settings<br/>
        /// Update the specified index settings.<br/>
        /// Index settings that you don't specify are left unchanged.<br/>
        /// Specify `null` to reset a setting to its default value.<br/>
        /// For best performance, update the index settings before you add new records to your index.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> SetSettingsAsync(
            string indexName,
            bool? forwardToReplicas = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}