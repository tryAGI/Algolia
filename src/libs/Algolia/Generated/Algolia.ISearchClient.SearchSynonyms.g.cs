#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search for synonyms<br/>
        /// Searches for synonyms in your index.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchSynonymsResponse> SearchSynonymsAsync(
            string indexName,

            global::Algolia.SearchSynonymsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for synonyms<br/>
        /// Searches for synonyms in your index.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="query">
        /// Search query.
        /// </param>
        /// <param name="type">
        /// Synonym type.<br/>
        /// Example: onewaysynonym
        /// </param>
        /// <param name="page">
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="hitsPerPage">
        /// Number of hits per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchSynonymsResponse> SearchSynonymsAsync(
            string indexName,
            string? query = default,
            global::Algolia.SynonymType? type = default,
            int? page = default,
            int? hitsPerPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}