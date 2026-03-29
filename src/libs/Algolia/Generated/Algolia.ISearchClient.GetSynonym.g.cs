#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Retrieve a synonym<br/>
        /// Retrieves a synonym by its ID.<br/>
        /// To find the object IDs for your synonyms,<br/>
        /// use the [`search` operation](https://www.algolia.com/doc/rest-api/search/search-synonyms).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Example: synonymID
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SynonymHit> GetSynonymAsync(
            string indexName,
            string objectID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}