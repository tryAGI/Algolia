#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Restore an API key<br/>
        /// Restores a deleted API key.<br/>
        /// Restoring resets the `validity` attribute to `0`.<br/>
        /// Algolia stores up to 1,000 API keys per application.<br/>
        /// If you create more, the oldest API keys are deleted and can't be restored.
        /// </summary>
        /// <param name="key">
        /// Example: ALGOLIA_API_KEY
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AddApiKeyResponse> RestoreApiKeyAsync(
            string key,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}