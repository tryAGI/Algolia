#nullable enable

namespace Algolia.Recommend
{
    public partial interface IRecommendClient
    {
        /// <summary>
        /// Send requests to the Algolia REST API<br/>
        /// This method lets you send requests to the Algolia REST API.
        /// </summary>
        /// <param name="path">
        /// Example: /keys
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CustomDeleteAsync(
            string path,
            object? parameters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}