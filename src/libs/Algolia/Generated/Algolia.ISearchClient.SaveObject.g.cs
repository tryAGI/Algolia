#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Add a new record (with auto-generated object ID)<br/>
        /// Adds a record to an index or replaces it.<br/>
        /// - If the record doesn't have an object ID, a new record with an auto-generated object ID is added to your index.<br/>
        /// - If a record with the specified object ID exists, the existing record is replaced.<br/>
        /// - If a record with the specified object ID doesn't exist, a new record is added to your index.<br/>
        /// - If you add a record to an index that doesn't exist yet, a new index is created.<br/>
        /// To update _some_ attributes of a record, use the [`partial` operation](https://www.algolia.com/doc/rest-api/search/partial-update-object).<br/>
        /// To add, update, or replace multiple records, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/batch).<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SaveObjectResponse> SaveObjectAsync(
            string indexName,

            object request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a new record (with auto-generated object ID)<br/>
        /// Adds a record to an index or replaces it.<br/>
        /// - If the record doesn't have an object ID, a new record with an auto-generated object ID is added to your index.<br/>
        /// - If a record with the specified object ID exists, the existing record is replaced.<br/>
        /// - If a record with the specified object ID doesn't exist, a new record is added to your index.<br/>
        /// - If you add a record to an index that doesn't exist yet, a new index is created.<br/>
        /// To update _some_ attributes of a record, use the [`partial` operation](https://www.algolia.com/doc/rest-api/search/partial-update-object).<br/>
        /// To add, update, or replace multiple records, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/batch).<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.SaveObjectResponse>> SaveObjectAsResponseAsync(
            string indexName,

            object request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a new record (with auto-generated object ID)<br/>
        /// Adds a record to an index or replaces it.<br/>
        /// - If the record doesn't have an object ID, a new record with an auto-generated object ID is added to your index.<br/>
        /// - If a record with the specified object ID exists, the existing record is replaced.<br/>
        /// - If a record with the specified object ID doesn't exist, a new record is added to your index.<br/>
        /// - If you add a record to an index that doesn't exist yet, a new index is created.<br/>
        /// To update _some_ attributes of a record, use the [`partial` operation](https://www.algolia.com/doc/rest-api/search/partial-update-object).<br/>
        /// To add, update, or replace multiple records, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/batch).<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SaveObjectResponse> SaveObjectAsync(
            string indexName,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}