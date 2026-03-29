#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Add a source<br/>
        /// Adds a source to the list of allowed sources.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AppendSourceResponse> AppendSourceAsync(

            global::Algolia.Source request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a source<br/>
        /// Adds a source to the list of allowed sources.
        /// </summary>
        /// <param name="source1">
        /// IP address range of the source.<br/>
        /// Example: 10.0.0.1/32
        /// </param>
        /// <param name="description">
        /// Source description.<br/>
        /// Example: Server subnet
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AppendSourceResponse> AppendSourceAsync(
            string source1,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}