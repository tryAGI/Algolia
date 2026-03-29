#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Retrieve records<br/>
        /// Retrieves one or more records, potentially from different indices.<br/>
        /// Records are returned in the same order as the requests.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.GetObjectsResponse> GetObjectsAsync(

            global::Algolia.GetObjectsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve records<br/>
        /// Retrieves one or more records, potentially from different indices.<br/>
        /// Records are returned in the same order as the requests.
        /// </summary>
        /// <param name="requests"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.GetObjectsResponse> GetObjectsAsync(
            global::System.Collections.Generic.IList<global::Algolia.GetObjectsRequestRequest> requests,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}