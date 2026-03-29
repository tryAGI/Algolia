#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// List allowed sources<br/>
        /// Retrieves all allowed IP addresses with access to your application.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Algolia.Source>> GetSourcesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}