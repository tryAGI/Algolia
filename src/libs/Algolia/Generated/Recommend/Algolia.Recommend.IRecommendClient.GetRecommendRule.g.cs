#nullable enable

namespace Algolia.Recommend
{
    public partial interface IRecommendClient
    {
        /// <summary>
        /// Retrieve a rule<br/>
        /// Retrieves a Recommend rule that you previously created in the Algolia dashboard.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="model"></param>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.Recommend.RecommendRule> GetRecommendRuleAsync(
            string indexName,
            global::Algolia.Recommend.RecommendModels model,
            string objectID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}