#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// List API keys<br/>
        /// Lists all API keys associated with your Algolia application, including their permissions and restrictions.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.ListApiKeysResponse> ListApiKeysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}