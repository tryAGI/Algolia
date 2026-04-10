#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Add or update attributes<br/>
        /// Adds new attributes to a record, or updates existing ones.<br/>
        /// - If a record with the specified object ID doesn't exist,<br/>
        ///   a new record is added to the index **if** `createIfNotExists` is true.<br/>
        /// - If the index doesn't exist yet, this method creates a new index.<br/>
        /// - Use first-level attributes only. Nested attributes aren't supported.<br/>
        ///   If you specify a nested attribute, this operation replaces its first-level ancestor.<br/>
        /// To update attributes without replacing the full record, use these built-in operations.<br/>
        /// These operations are useful when the initial data isn't available.<br/>
        /// - `Increment`: increment a numeric attribute.<br/>
        /// - `Decrement`: decrement a numeric attribute.<br/>
        /// - `Add`: append a number or string element to an array attribute.<br/>
        /// - `Remove`: remove all matching number or string elements from an array attribute made of numbers or strings.<br/>
        /// - `AddUnique`: add a number or string element to an array attribute made of numbers or strings only if it's not already present.<br/>
        /// - `IncrementFrom`: increment a numeric integer attribute only if the provided value matches the current value. Otherwise, the update is ignored.<br/>
        ///   Example: If you pass an `IncrementFrom` value of 2 for the `version` attribute but the current value is 1, the API ignores the update.<br/>
        ///   If the object doesn't exist, the API only creates it if you pass an `IncrementFrom` value of 0.<br/>
        /// - `IncrementSet`: increment a numeric integer attribute only if the provided value is greater than the current value. Otherwise, the update is ignored.<br/>
        ///   Example: If you pass an `IncrementSet` value of 2 for the `version` attribute and the current value is 1, the API updates the object.<br/>
        ///   If the object doesn't exist yet, the API only creates it if you pass an `IncrementSet` value greater than 0.<br/>
        /// Specify an operation by providing an object with the attribute to update as the key and its value as an object with these properties:<br/>
        /// - `_operation`: the operation to apply on the attribute.<br/>
        /// - `value`: the right-hand side argument to the operation, for example, increment or decrement step, or a value to add or remove.<br/>
        /// When updating multiple attributes or using multiple operations targeting the same record, use a single partial update for faster processing.<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="createIfNotExists">
        /// Default Value: true
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.PartialUpdateObjectResponse> PartialUpdateObjectAsync(
            string indexName,
            string objectID,

            object request,
            bool? createIfNotExists = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add or update attributes<br/>
        /// Adds new attributes to a record, or updates existing ones.<br/>
        /// - If a record with the specified object ID doesn't exist,<br/>
        ///   a new record is added to the index **if** `createIfNotExists` is true.<br/>
        /// - If the index doesn't exist yet, this method creates a new index.<br/>
        /// - Use first-level attributes only. Nested attributes aren't supported.<br/>
        ///   If you specify a nested attribute, this operation replaces its first-level ancestor.<br/>
        /// To update attributes without replacing the full record, use these built-in operations.<br/>
        /// These operations are useful when the initial data isn't available.<br/>
        /// - `Increment`: increment a numeric attribute.<br/>
        /// - `Decrement`: decrement a numeric attribute.<br/>
        /// - `Add`: append a number or string element to an array attribute.<br/>
        /// - `Remove`: remove all matching number or string elements from an array attribute made of numbers or strings.<br/>
        /// - `AddUnique`: add a number or string element to an array attribute made of numbers or strings only if it's not already present.<br/>
        /// - `IncrementFrom`: increment a numeric integer attribute only if the provided value matches the current value. Otherwise, the update is ignored.<br/>
        ///   Example: If you pass an `IncrementFrom` value of 2 for the `version` attribute but the current value is 1, the API ignores the update.<br/>
        ///   If the object doesn't exist, the API only creates it if you pass an `IncrementFrom` value of 0.<br/>
        /// - `IncrementSet`: increment a numeric integer attribute only if the provided value is greater than the current value. Otherwise, the update is ignored.<br/>
        ///   Example: If you pass an `IncrementSet` value of 2 for the `version` attribute and the current value is 1, the API updates the object.<br/>
        ///   If the object doesn't exist yet, the API only creates it if you pass an `IncrementSet` value greater than 0.<br/>
        /// Specify an operation by providing an object with the attribute to update as the key and its value as an object with these properties:<br/>
        /// - `_operation`: the operation to apply on the attribute.<br/>
        /// - `value`: the right-hand side argument to the operation, for example, increment or decrement step, or a value to add or remove.<br/>
        /// When updating multiple attributes or using multiple operations targeting the same record, use a single partial update for faster processing.<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="createIfNotExists">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.PartialUpdateObjectResponse> PartialUpdateObjectAsync(
            string indexName,
            string objectID,
            bool? createIfNotExists = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}