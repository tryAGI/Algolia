#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Create or replace a rule<br/>
        /// If a rule with the specified object ID doesn't exist, it's created.<br/>
        /// Otherwise, the existing rule is replaced.<br/>
        /// To create or update more than one rule, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/save-rules).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Unique identifier of a rule object.
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> SaveRuleAsync(
            string indexName,
            string objectID,

            global::Algolia.Rule request,
            bool? forwardToReplicas = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace a rule<br/>
        /// If a rule with the specified object ID doesn't exist, it's created.<br/>
        /// Otherwise, the existing rule is replaced.<br/>
        /// To create or update more than one rule, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/save-rules).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Unique identifier of a rule object.
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="requestObjectID">
        /// Unique identifier of a rule object.
        /// </param>
        /// <param name="conditions">
        /// Conditions that trigger a rule.<br/>
        /// Some consequences require specific conditions or don't require any condition.<br/>
        /// For more information, see [Conditions](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#conditions).
        /// </param>
        /// <param name="consequence">
        /// Effect of the rule.<br/>
        /// For more information, see [Consequences](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#consequences).
        /// </param>
        /// <param name="description">
        /// Description of the rule's purpose to help you distinguish between different rules.<br/>
        /// Example: Display a promotional banner
        /// </param>
        /// <param name="enabled">
        /// Whether the rule is active.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="validity">
        /// Time periods when the rule is active.
        /// </param>
        /// <param name="tags"></param>
        /// <param name="scope"></param>
        /// <param name="condition"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> SaveRuleAsync(
            string indexName,
            string objectID,
            string requestObjectID,
            global::Algolia.Consequence consequence,
            bool? forwardToReplicas = default,
            global::System.Collections.Generic.IList<global::Algolia.Condition>? conditions = default,
            string? description = default,
            bool? enabled = default,
            global::System.Collections.Generic.IList<global::Algolia.TimeRange>? validity = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? scope = default,
            global::Algolia.Condition? condition = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}