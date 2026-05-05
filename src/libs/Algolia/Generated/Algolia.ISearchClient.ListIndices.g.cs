#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// List indices<br/>
        /// Lists all indices in the current Algolia application.<br/>
        /// The request follows any index restrictions of the API key you use to make the request.
        /// </summary>
        /// <param name="page">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hitsPerPage">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.ListIndicesResponse> ListIndicesAsync(
            global::Algolia.OneOf<int?, object>? page = default,
            int? hitsPerPage = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List indices<br/>
        /// Lists all indices in the current Algolia application.<br/>
        /// The request follows any index restrictions of the API key you use to make the request.
        /// </summary>
        /// <param name="page">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hitsPerPage">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.ListIndicesResponse>> ListIndicesAsResponseAsync(
            global::Algolia.OneOf<int?, object>? page = default,
            int? hitsPerPage = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}