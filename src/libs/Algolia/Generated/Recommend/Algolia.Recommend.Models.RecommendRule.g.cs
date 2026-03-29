
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Recommend rule.
    /// </summary>
    public sealed partial class RecommendRule
    {
        /// <summary>
        /// Rule metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_metadata")]
        public global::Algolia.Recommend.RecommendRuleMetadata? Metadata { get; set; }

        /// <summary>
        /// Unique identifier of a rule object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        public string? ObjectID { get; set; }

        /// <summary>
        /// Condition that triggers the rule.<br/>
        /// If not specified, the rule is triggered for all recommendations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::Algolia.Recommend.Condition? Condition { get; set; }

        /// <summary>
        /// Effect of the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consequence")]
        public global::Algolia.Recommend.Consequence? Consequence { get; set; }

        /// <summary>
        /// Description of the rule's purpose. This can be helpful for display in the Algolia dashboard.<br/>
        /// Example: Boost on-sale items
        /// </summary>
        /// <example>Boost on-sale items</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether to enable the rule. If it isn't enabled, it isn't applied at query time.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Time periods when the rule is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validity")]
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.TimeRange>? Validity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendRule" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Rule metadata.
        /// </param>
        /// <param name="objectID">
        /// Unique identifier of a rule object.
        /// </param>
        /// <param name="condition">
        /// Condition that triggers the rule.<br/>
        /// If not specified, the rule is triggered for all recommendations.
        /// </param>
        /// <param name="consequence">
        /// Effect of the rule.
        /// </param>
        /// <param name="description">
        /// Description of the rule's purpose. This can be helpful for display in the Algolia dashboard.<br/>
        /// Example: Boost on-sale items
        /// </param>
        /// <param name="enabled">
        /// Indicates whether to enable the rule. If it isn't enabled, it isn't applied at query time.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="validity">
        /// Time periods when the rule is active.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendRule(
            global::Algolia.Recommend.RecommendRuleMetadata? metadata,
            string? objectID,
            global::Algolia.Recommend.Condition? condition,
            global::Algolia.Recommend.Consequence? consequence,
            string? description,
            bool? enabled,
            global::System.Collections.Generic.IList<global::Algolia.Recommend.TimeRange>? validity)
        {
            this.Metadata = metadata;
            this.ObjectID = objectID;
            this.Condition = condition;
            this.Consequence = consequence;
            this.Description = description;
            this.Enabled = enabled;
            this.Validity = validity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendRule" /> class.
        /// </summary>
        public RecommendRule()
        {
        }
    }
}