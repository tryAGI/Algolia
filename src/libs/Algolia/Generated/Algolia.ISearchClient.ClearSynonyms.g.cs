#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Delete all synonyms<br/>
        /// Deletes all synonyms from the index.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> ClearSynonymsAsync(
            string indexName,
            bool? forwardToReplicas = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}