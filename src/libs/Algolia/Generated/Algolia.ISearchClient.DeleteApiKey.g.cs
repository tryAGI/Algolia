#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Delete an API key<br/>
        /// Deletes the API key.
        /// </summary>
        /// <param name="key">
        /// Example: ALGOLIA_API_KEY
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.DeleteApiKeyResponse> DeleteApiKeyAsync(
            string key,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}