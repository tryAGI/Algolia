#nullable enable

namespace Algolia.Recommend
{
    public partial interface IRecommendClient
    {
        /// <summary>
        /// Switch the API key used to authenticate requests<br/>
        /// Switch the API key used to authenticate requests.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        global::System.Threading.Tasks.Task SetClientApiKeyAsync(
            string apiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}