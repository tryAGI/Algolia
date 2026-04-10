#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Create secured API keys<br/>
        /// Generates a secured API key without any requests to Algolia's servers.<br/>
        /// Secured API keys are API keys that you generate on your server without any API request to Algolia.<br/>
        /// Use secured API keys when you can't update client-side code, such as in mobile apps,<br/>
        /// or when you need to restrict access to part of an index for each user.<br/>
        /// When users start searching, your app requests a short-lived secured API key from your server instead of using the Search API key.<br/>
        /// Your server uses this method to generate the secured API key with restrictions such as filters, index access restrictions,<br/>
        /// or expiration times, and returns it to your app. The API key gets longer as you add restrictions.<br/>
        /// You can't create secured API keys from other secured API keys or from your Admin API key.<br/>
        /// The generated API key can have the same restrictions as the parent API key, or be more restrictive.
        /// </summary>
        /// <param name="parentApiKey"></param>
        /// <param name="restrictions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GenerateSecuredApiKeyAsync(
            string parentApiKey,
            global::Algolia.SecuredApiKeyRestrictions restrictions,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}