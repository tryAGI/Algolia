#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Replace allowed sources<br/>
        /// Replaces the list of allowed sources.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.ReplaceSourcesResponse> ReplaceSourcesAsync(

            global::System.Collections.Generic.IList<global::Algolia.Source> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}