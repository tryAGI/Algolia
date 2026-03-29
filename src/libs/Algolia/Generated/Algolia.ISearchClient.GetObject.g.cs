#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Retrieve a record<br/>
        /// Retrieves one record by its object ID.<br/>
        /// To retrieve more than one record, use the [`objects` operation](https://www.algolia.com/doc/rest-api/search/get-objects).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="attributesToRetrieve"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetObjectAsync(
            string indexName,
            string objectID,
            global::System.Collections.Generic.IList<string>? attributesToRetrieve = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}