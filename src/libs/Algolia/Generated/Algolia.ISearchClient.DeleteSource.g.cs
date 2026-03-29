#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Delete a source<br/>
        /// Deletes a source from the list of allowed sources.
        /// </summary>
        /// <param name="source">
        /// Example: 10.0.0.1/32
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.DeleteSourceResponse> DeleteSourceAsync(
            string source,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}