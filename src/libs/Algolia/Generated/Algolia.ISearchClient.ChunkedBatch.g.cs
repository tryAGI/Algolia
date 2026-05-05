#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Replace all records in an index<br/>
        /// Helper: Chunks the given `objects` list in subset of 1000 elements max in order to make it fit in `batch` requests.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="objects"></param>
        /// <param name="action">
        /// Which indexing operation to perform:<br/>
        /// - `addObject`: adds records to an index.<br/>
        ///    Equivalent to the "Add a new record (with auto-generated object ID)" operation.<br/>
        /// - `updateObject`: adds or replaces records in an index.<br/>
        ///    Equivalent to the "Add or replace a record" operation.<br/>
        /// - `partialUpdateObject`: adds or updates attributes within records.<br/>
        ///    Equivalent to the "Add or update attributes" operation with the `createIfNoExists` parameter set to true.<br/>
        ///    (If a record with the specified `objectID` doesn't exist in the specified index, this action creates adds the record to the index)<br/>
        /// - `partialUpdateObjectNoCreate`: same as `partialUpdateObject`, but with `createIfNoExists` set to false.<br/>
        ///    (A record isn't added to the index if its `objectID` doesn't exist)<br/>
        /// - `deleteObject`: delete records from an index.<br/>
        ///   Equivalent to the "Delete a record" operation.<br/>
        /// - `delete`. Delete an index. Equivalent to the "Delete an index" operation.<br/>
        /// - `clear`: delete all records from an index. Equivalent to the "Delete all records from an index operation".
        /// </param>
        /// <param name="waitForTasks"></param>
        /// <param name="batchSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Algolia.BatchResponse>> ChunkedBatchAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            global::Algolia.Action? action = default,
            bool? waitForTasks = default,
            int? batchSize = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace all records in an index<br/>
        /// Helper: Chunks the given `objects` list in subset of 1000 elements max in order to make it fit in `batch` requests.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="objects"></param>
        /// <param name="action">
        /// Which indexing operation to perform:<br/>
        /// - `addObject`: adds records to an index.<br/>
        ///    Equivalent to the "Add a new record (with auto-generated object ID)" operation.<br/>
        /// - `updateObject`: adds or replaces records in an index.<br/>
        ///    Equivalent to the "Add or replace a record" operation.<br/>
        /// - `partialUpdateObject`: adds or updates attributes within records.<br/>
        ///    Equivalent to the "Add or update attributes" operation with the `createIfNoExists` parameter set to true.<br/>
        ///    (If a record with the specified `objectID` doesn't exist in the specified index, this action creates adds the record to the index)<br/>
        /// - `partialUpdateObjectNoCreate`: same as `partialUpdateObject`, but with `createIfNoExists` set to false.<br/>
        ///    (A record isn't added to the index if its `objectID` doesn't exist)<br/>
        /// - `deleteObject`: delete records from an index.<br/>
        ///   Equivalent to the "Delete a record" operation.<br/>
        /// - `delete`. Delete an index. Equivalent to the "Delete an index" operation.<br/>
        /// - `clear`: delete all records from an index. Equivalent to the "Delete all records from an index operation".
        /// </param>
        /// <param name="waitForTasks"></param>
        /// <param name="batchSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Algolia.BatchResponse>>> ChunkedBatchAsResponseAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            global::Algolia.Action? action = default,
            bool? waitForTasks = default,
            int? batchSize = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}