#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Create or replace synonyms<br/>
        /// If a synonym with the `objectID` doesn't exist, Algolia adds a new one.<br/>
        /// Otherwise, existing synonyms are replaced.<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="replaceExistingSynonyms"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> SaveSynonymsAsync(
            string indexName,

            global::System.Collections.Generic.IList<global::Algolia.SynonymHit> request,
            bool? forwardToReplicas = default,
            bool? replaceExistingSynonyms = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}