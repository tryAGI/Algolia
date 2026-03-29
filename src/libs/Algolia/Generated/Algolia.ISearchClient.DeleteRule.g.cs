#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Delete a rule<br/>
        /// Deletes a rule by its ID.<br/>
        /// To find the object ID for rules,<br/>
        /// use the [`search` operation](https://www.algolia.com/doc/rest-api/search/search-rules).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Unique identifier of a rule object.
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> DeleteRuleAsync(
            string indexName,
            string objectID,
            bool? forwardToReplicas = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}