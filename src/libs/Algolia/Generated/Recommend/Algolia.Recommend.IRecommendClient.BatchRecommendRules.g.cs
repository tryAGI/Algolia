#nullable enable

namespace Algolia.Recommend
{
    public partial interface IRecommendClient
    {
        /// <summary>
        /// Create or update a batch of Recommend Rules<br/>
        /// Create or update a batch of Recommend Rules<br/>
        /// Each Recommend Rule is created or updated, depending on whether a Recommend Rule with the same `objectID` already exists.<br/>
        /// You may also specify `true` for `clearExistingRules`, in which case the batch will atomically replace all the existing Recommend Rules.<br/>
        /// Recommend Rules are similar to Search Rules, except that the conditions and consequences apply to a [source item](/doc/guides/algolia-recommend/overview/#recommend-models) instead of a query. The main differences are the following:<br/>
        /// - Conditions `pattern` and `anchoring` are unavailable.<br/>
        /// - Condition `filters` triggers if the source item matches the specified filters.<br/>
        /// - Condition `filters` accepts numeric filters.<br/>
        /// - Consequence `params` only covers filtering parameters.<br/>
        /// - Consequence `automaticFacetFilters` doesn't require a facet value placeholder (it tries to match the data source item's attributes instead).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.Recommend.RecommendUpdatedAtResponse> BatchRecommendRulesAsync(
            string indexName,
            global::Algolia.Recommend.RecommendModels model,

            global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendRule> request,
            global::Algolia.Recommend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a batch of Recommend Rules<br/>
        /// Create or update a batch of Recommend Rules<br/>
        /// Each Recommend Rule is created or updated, depending on whether a Recommend Rule with the same `objectID` already exists.<br/>
        /// You may also specify `true` for `clearExistingRules`, in which case the batch will atomically replace all the existing Recommend Rules.<br/>
        /// Recommend Rules are similar to Search Rules, except that the conditions and consequences apply to a [source item](/doc/guides/algolia-recommend/overview/#recommend-models) instead of a query. The main differences are the following:<br/>
        /// - Conditions `pattern` and `anchoring` are unavailable.<br/>
        /// - Condition `filters` triggers if the source item matches the specified filters.<br/>
        /// - Condition `filters` accepts numeric filters.<br/>
        /// - Consequence `params` only covers filtering parameters.<br/>
        /// - Consequence `automaticFacetFilters` doesn't require a facet value placeholder (it tries to match the data source item's attributes instead).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.Recommend.AutoSDKHttpResponse<global::Algolia.Recommend.RecommendUpdatedAtResponse>> BatchRecommendRulesAsResponseAsync(
            string indexName,
            global::Algolia.Recommend.RecommendModels model,

            global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendRule> request,
            global::Algolia.Recommend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}