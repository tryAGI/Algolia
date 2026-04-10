#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Add or delete dictionary entries<br/>
        /// Adds or deletes multiple entries from your plurals, segmentation, or stop word dictionaries.
        /// </summary>
        /// <param name="dictionaryName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> BatchDictionaryEntriesAsync(
            global::Algolia.DictionaryType dictionaryName,

            global::Algolia.BatchDictionaryEntriesRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add or delete dictionary entries<br/>
        /// Adds or deletes multiple entries from your plurals, segmentation, or stop word dictionaries.
        /// </summary>
        /// <param name="dictionaryName"></param>
        /// <param name="clearExistingDictionaryEntries">
        /// Whether to replace all custom entries in the dictionary with the ones sent with this request.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requests">
        /// List of additions and deletions to your dictionaries.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> BatchDictionaryEntriesAsync(
            global::Algolia.DictionaryType dictionaryName,
            global::System.Collections.Generic.IList<global::Algolia.BatchDictionaryEntriesRequestRequest> requests,
            bool? clearExistingDictionaryEntries = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}