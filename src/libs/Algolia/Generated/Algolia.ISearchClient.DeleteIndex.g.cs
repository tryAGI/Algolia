#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Delete an index<br/>
        /// Deletes an index and all its settings.<br/>
        /// - Deleting an index doesn't delete its analytics data.<br/>
        /// - If you try to delete a non-existing index, the operation is ignored without warning.<br/>
        /// - If the index you want to delete has replica indices, the replicas become independent indices.<br/>
        /// - If the index you want to delete is a replica index, you must first unlink it from its primary index before you can delete it.<br/>
        ///   For more information, see [Delete replica indices](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/how-to/deleting-replicas).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.DeleteIndexResponse> DeleteIndexAsync(
            string indexName,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}