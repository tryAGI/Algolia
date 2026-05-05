#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Retrieve API key permissions<br/>
        /// Gets the permissions and restrictions of an API key.<br/>
        /// When authenticating with the admin API key, you can request information for any of your application's keys.<br/>
        /// When authenticating with other API keys, you can only retrieve information for that key,<br/>
        /// with the description replaced by `&lt;redacted&gt;`.
        /// </summary>
        /// <param name="key">
        /// Example: ALGOLIA_API_KEY
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.GetApiKeyResponse> GetApiKeyAsync(
            string key,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve API key permissions<br/>
        /// Gets the permissions and restrictions of an API key.<br/>
        /// When authenticating with the admin API key, you can request information for any of your application's keys.<br/>
        /// When authenticating with other API keys, you can only retrieve information for that key,<br/>
        /// with the description replaced by `&lt;redacted&gt;`.
        /// </summary>
        /// <param name="key">
        /// Example: ALGOLIA_API_KEY
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.GetApiKeyResponse>> GetApiKeyAsResponseAsync(
            string key,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}