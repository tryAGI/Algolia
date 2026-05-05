#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Delete a synonym<br/>
        /// Deletes a synonym by its ID.<br/>
        /// To find the object IDs of your synonyms, use the [`search` operation](https://www.algolia.com/doc/rest-api/search/search-synonyms).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Example: synonymID
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.DeleteSynonymResponse> DeleteSynonymAsync(
            string indexName,
            string objectID,
            bool? forwardToReplicas = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a synonym<br/>
        /// Deletes a synonym by its ID.<br/>
        /// To find the object IDs of your synonyms, use the [`search` operation](https://www.algolia.com/doc/rest-api/search/search-synonyms).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Example: synonymID
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.DeleteSynonymResponse>> DeleteSynonymAsResponseAsync(
            string indexName,
            string objectID,
            bool? forwardToReplicas = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}