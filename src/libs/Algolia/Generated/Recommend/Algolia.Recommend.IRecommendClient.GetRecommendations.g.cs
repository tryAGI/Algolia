#nullable enable

namespace Algolia.Recommend
{
    public partial interface IRecommendClient
    {
        /// <summary>
        /// Retrieve recommendations<br/>
        /// Retrieves recommendations from selected AI models.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.Recommend.GetRecommendationsResponse> GetRecommendationsAsync(

            global::Algolia.Recommend.GetRecommendationsRequest request,
            global::Algolia.Recommend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve recommendations<br/>
        /// Retrieves recommendations from selected AI models.
        /// </summary>
        /// <param name="requests">
        /// Recommendation request with parameters depending on the requested model.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.Recommend.GetRecommendationsResponse> GetRecommendationsAsync(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendationsRequest> requests,
            global::Algolia.Recommend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}