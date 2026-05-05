#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Copy or move an index<br/>
        /// Copies or moves (renames) an index within the same Algolia application.<br/>
        /// Notes:<br/>
        /// - Existing destination indices are overwritten, except for their analytics data.<br/>
        /// - If the destination index doesn't exist yet, it's created.<br/>
        /// - This operation is resource-intensive.<br/>
        /// **Copy**<br/>
        /// - If the source index doesn't exist, copying creates a new index with 0 records and default settings.<br/>
        /// - API keys from the source index are merged with the existing keys in the destination index.<br/>
        /// - You can't copy the `enableReRanking`, `mode`, and `replicas` settings.<br/>
        /// - You can't copy to a destination index that already has replicas.<br/>
        /// - Be aware of the [size limits](https://www.algolia.com/doc/guides/scaling/algolia-service-limits/#application-record-and-index-limits).<br/>
        /// - For more information, see [Copy indices](https://www.algolia.com/doc/guides/sending-and-managing-data/manage-indices-and-apps/manage-indices/how-to/copy-indices).<br/>
        /// **Move**<br/>
        /// - If the source index doesn't exist, moving is ignored without returning an error.<br/>
        /// - When moving an index, the analytics data keeps its original name, and a new set of analytics data is started for the new name.<br/>
        ///   To access the original analytics in the dashboard, create an index with the original name.<br/>
        /// - If the destination index has replicas, moving will overwrite the existing index and copy the data to the replica indices.<br/>
        /// - For more information, see [Move indices](https://www.algolia.com/doc/guides/sending-and-managing-data/manage-indices-and-apps/manage-indices/how-to/move-indices).<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> OperationIndexAsync(
            string indexName,

            global::Algolia.OperationIndexRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Copy or move an index<br/>
        /// Copies or moves (renames) an index within the same Algolia application.<br/>
        /// Notes:<br/>
        /// - Existing destination indices are overwritten, except for their analytics data.<br/>
        /// - If the destination index doesn't exist yet, it's created.<br/>
        /// - This operation is resource-intensive.<br/>
        /// **Copy**<br/>
        /// - If the source index doesn't exist, copying creates a new index with 0 records and default settings.<br/>
        /// - API keys from the source index are merged with the existing keys in the destination index.<br/>
        /// - You can't copy the `enableReRanking`, `mode`, and `replicas` settings.<br/>
        /// - You can't copy to a destination index that already has replicas.<br/>
        /// - Be aware of the [size limits](https://www.algolia.com/doc/guides/scaling/algolia-service-limits/#application-record-and-index-limits).<br/>
        /// - For more information, see [Copy indices](https://www.algolia.com/doc/guides/sending-and-managing-data/manage-indices-and-apps/manage-indices/how-to/copy-indices).<br/>
        /// **Move**<br/>
        /// - If the source index doesn't exist, moving is ignored without returning an error.<br/>
        /// - When moving an index, the analytics data keeps its original name, and a new set of analytics data is started for the new name.<br/>
        ///   To access the original analytics in the dashboard, create an index with the original name.<br/>
        /// - If the destination index has replicas, moving will overwrite the existing index and copy the data to the replica indices.<br/>
        /// - For more information, see [Move indices](https://www.algolia.com/doc/guides/sending-and-managing-data/manage-indices-and-apps/manage-indices/how-to/move-indices).<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.UpdatedAtResponse>> OperationIndexAsResponseAsync(
            string indexName,

            global::Algolia.OperationIndexRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Copy or move an index<br/>
        /// Copies or moves (renames) an index within the same Algolia application.<br/>
        /// Notes:<br/>
        /// - Existing destination indices are overwritten, except for their analytics data.<br/>
        /// - If the destination index doesn't exist yet, it's created.<br/>
        /// - This operation is resource-intensive.<br/>
        /// **Copy**<br/>
        /// - If the source index doesn't exist, copying creates a new index with 0 records and default settings.<br/>
        /// - API keys from the source index are merged with the existing keys in the destination index.<br/>
        /// - You can't copy the `enableReRanking`, `mode`, and `replicas` settings.<br/>
        /// - You can't copy to a destination index that already has replicas.<br/>
        /// - Be aware of the [size limits](https://www.algolia.com/doc/guides/scaling/algolia-service-limits/#application-record-and-index-limits).<br/>
        /// - For more information, see [Copy indices](https://www.algolia.com/doc/guides/sending-and-managing-data/manage-indices-and-apps/manage-indices/how-to/copy-indices).<br/>
        /// **Move**<br/>
        /// - If the source index doesn't exist, moving is ignored without returning an error.<br/>
        /// - When moving an index, the analytics data keeps its original name, and a new set of analytics data is started for the new name.<br/>
        ///   To access the original analytics in the dashboard, create an index with the original name.<br/>
        /// - If the destination index has replicas, moving will overwrite the existing index and copy the data to the replica indices.<br/>
        /// - For more information, see [Move indices](https://www.algolia.com/doc/guides/sending-and-managing-data/manage-indices-and-apps/manage-indices/how-to/move-indices).<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="operation">
        /// Operation to perform on the index.<br/>
        /// Example: copy
        /// </param>
        /// <param name="destination">
        /// Index name (case-sensitive).<br/>
        /// Example: products
        /// </param>
        /// <param name="scope">
        /// **Only for copying.**<br/>
        /// If you specify a scope, only the selected scopes are copied. Records and the other scopes are left unchanged.<br/>
        /// If you omit the `scope` parameter, everything is copied: records, settings, synonyms, and rules.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> OperationIndexAsync(
            string indexName,
            global::Algolia.OperationType operation,
            string destination,
            global::System.Collections.Generic.IList<global::Algolia.ScopeType>? scope = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}