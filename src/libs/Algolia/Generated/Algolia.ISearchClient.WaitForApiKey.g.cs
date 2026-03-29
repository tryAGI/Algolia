#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Wait for an API key operation<br/>
        /// Waits for an API key to be added, updated, or deleted.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="operation"></param>
        /// <param name="apiKey">
        /// API key object.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.GetApiKeyResponse> WaitForApiKeyAsync(
            string key,
            global::Algolia.ApiKeyOperation operation,
            global::Algolia.ApiKey? apiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}