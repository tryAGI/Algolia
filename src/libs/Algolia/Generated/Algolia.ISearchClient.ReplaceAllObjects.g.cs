#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Replace all records in an index<br/>
        /// This method replaces all records in an index without interrupting ongoing searches.<br/>
        /// It combines [batch](https://www.algolia.com/doc/rest-api/search/batch) and [copy/move](https://www.algolia.com/doc/rest-api/search/operation-index) index operations:<br/>
        /// 1. Copy settings, synonyms, and rules to a temporary index.<br/>
        /// 2. Add the records from the `objects` parameter to the temporary index.<br/>
        /// 3. Replace the original index with the temporary one.<br/>
        /// Notes:<br/>
        /// - If there's an error during one of these steps, the temporary index is deleted if your API key has the `deleteIndex` ACL.<br/>
        /// - If your API key restricts access to specific indices, make sure it also grants access to the temporary index `INDEX_NAME_tmp_*` (replace `INDEX_NAME` with the name of your original index).<br/>
        /// - This method is subject to [indexing rate limits](https://support.algolia.com/hc/en-us/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).<br/>
        /// - The response includes the results of the individual API requests.<br/>
        /// - This method creates a temporary index, which temporarily doubles your record count.<br/>
        /// - Algolia doesn't count the three days with the highest number of records toward your monthly usage.
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
        global::System.Threading.Tasks.Task<global::Algolia.ReplaceAllObjectsResponse> ReplaceAllObjectsAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            int? batchSize = default,
            global::System.Collections.Generic.IList<global::Algolia.ScopeType>? scopes = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}