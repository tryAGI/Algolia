#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Replace all records in an index<br/>
        /// Replace all records in your index with a new set of records by using the Transformation pipeline in the Push connector (https://www.algolia.com/doc/guides/sending-and-managing-data/send-and-update-your-data/connectors/push).<br/>
        /// This method replaces all records without downtime. It performs these operations:<br/>
        ///   1. Copy settings, synonyms, and rules from your original index to a temporary index.<br/>
        ///   2. Add your new records to the temporary index.<br/>
        ///   3. Replace your original index with the temporary index.<br/>
        /// Notes:<br/>
        /// - Use the `safe` parameter to run these (asynchronous) operations in sequence.<br/>
        /// - If there's an error during one of these steps, the temporary index isn't deleted.<br/>
        /// - This operation is rate-limited.<br/>
        /// - This method creates a temporary index, which temporarily doubles your record count.<br/>
        /// - Algolia doesn't count the three days with the highest number of records toward your monthly usage.<br/>
        /// - If you're on a legacy plan (before July 2020), this method counts two operations toward your usage (in addition to the number of records): `copySettings` and `moveIndex`.<br/>
        /// - The API key you use for this operation must have access to the index `YourIndex` and the temporary index `YourIndex_tmp`.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="objects"></param>
        /// <param name="batchSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="scopes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.ReplaceAllObjectsWithTransformationResponse> ReplaceAllObjectsWithTransformationAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            int? batchSize = default,
            global::System.Collections.Generic.IList<global::Algolia.ScopeType>? scopes = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}