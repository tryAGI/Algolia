#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Delete a source<br/>
        /// Deletes a source from the list of allowed sources.
        /// </summary>
        /// <param name="source">
        /// Example: 10.0.0.1/32
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.DeleteSourceResponse> DeleteSourceAsync(
            string source,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a source<br/>
        /// Deletes a source from the list of allowed sources.
        /// </summary>
        /// <param name="source">
        /// Example: 10.0.0.1/32
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.DeleteSourceResponse>> DeleteSourceAsResponseAsync(
            string source,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}