#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Create or update rules<br/>
        /// Create or update multiple rules.<br/>
        /// If a rule with the specified object ID doesn't exist, Algolia creates a new one.<br/>
        /// Otherwise, existing rules are replaced.<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="clearExistingRules"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> SaveRulesAsync(
            string indexName,

            global::System.Collections.Generic.IList<global::Algolia.Rule> request,
            bool? forwardToReplicas = default,
            bool? clearExistingRules = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}