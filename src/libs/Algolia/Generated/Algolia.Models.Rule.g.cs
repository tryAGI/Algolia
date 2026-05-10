
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Rule object.
    /// </summary>
    public sealed partial class Rule
    {
        /// <summary>
        /// Unique identifier of a rule object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectID { get; set; }

        /// <summary>
        /// Conditions that trigger a rule.<br/>
        /// Some consequences require specific conditions or don't require any condition.<br/>
        /// For more information, see [Conditions](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#conditions).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Algolia.Condition>? Conditions { get; set; }

        /// <summary>
        /// Effect of the rule.<br/>
        /// For more information, see [Consequences](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#consequences).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consequence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.Consequence Consequence { get; set; }

        /// <summary>
        /// Description of the rule's purpose to help you distinguish between different rules.<br/>
        /// Example: Display a promotional banner
        /// </summary>
        /// <example>Display a promotional banner</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the rule is active.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Time periods when the rule is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validity")]
        public global::System.Collections.Generic.IList<global::Algolia.TimeRange>? Validity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::Algolia.Condition? Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Rule" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Unique identifier of a rule object.
        /// </param>
        /// <param name="consequence">
        /// Effect of the rule.<br/>
        /// For more information, see [Consequences](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#consequences).
        /// </param>
        /// <param name="conditions">
        /// Conditions that trigger a rule.<br/>
        /// Some consequences require specific conditions or don't require any condition.<br/>
        /// For more information, see [Conditions](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#conditions).
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Rule(
            string objectID,
            global::Algolia.Consequence consequence,
            global::System.Collections.Generic.IList<global::Algolia.Condition>? conditions,
            string? description,
            bool? enabled,
            global::System.Collections.Generic.IList<global::Algolia.TimeRange>? validity,
            global::System.Collections.Generic.IList<string>? tags,
            string? scope,
            global::Algolia.Condition? condition)
        {
            this.ObjectID = objectID ?? throw new global::System.ArgumentNullException(nameof(objectID));
            this.Conditions = conditions;
            this.Consequence = consequence ?? throw new global::System.ArgumentNullException(nameof(consequence));
            this.Description = description;
            this.Enabled = enabled;
            this.Validity = validity;
            this.Tags = tags;
            this.Scope = scope;
            this.Condition = condition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rule" /> class.
        /// </summary>
        public Rule()
        {
        }

    }
}