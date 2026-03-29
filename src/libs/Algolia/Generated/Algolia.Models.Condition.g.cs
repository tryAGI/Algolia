
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Condition
    {
        /// <summary>
        /// Query pattern that triggers the rule.<br/>
        /// You can use either a literal string, or a special pattern `{facet:ATTRIBUTE}`, where `ATTRIBUTE` is a facet name.<br/>
        /// The rule is triggered if the query matches the literal string or a value of the specified facet.<br/>
        /// For example, with `pattern: {facet:genre}`, the rule is triggered when users search for a genre, such as "comedy".<br/>
        /// Example: {facet:genre}
        /// </summary>
        /// <example>{facet:genre}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Which part of the search query the pattern should match:<br/>
        /// - `startsWith`. The pattern must match the beginning of the query.<br/>
        /// - `endsWith`. The pattern must match the end of the query.<br/>
        /// - `is`. The pattern must match the query exactly.<br/>
        /// - `contains`. The pattern must match anywhere in the query.<br/>
        /// Empty queries are only allowed as patterns with `anchoring: is`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchoring")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.AnchoringJsonConverter))]
        public global::Algolia.Anchoring? Anchoring { get; set; }

        /// <summary>
        /// Whether the pattern should match plurals, synonyms, and typos.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alternatives")]
        public bool? Alternatives { get; set; }

        /// <summary>
        /// An additional restriction that only triggers the rule, when the search has the same value as `ruleContexts` parameter.<br/>
        /// For example, if `context: mobile`, the rule is only triggered when the search request has a matching `ruleContexts: mobile`.<br/>
        /// A rule context must only contain alphanumeric characters.<br/>
        /// Example: mobile
        /// </summary>
        /// <example>mobile</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Filters that trigger the rule.<br/>
        /// You can add filters using the syntax `facet:value` so that the rule is triggered, when the specific filter is selected.<br/>
        /// You can use `filters` on its own or combine it with the `pattern` parameter.<br/>
        /// You can't combine multiple filters with `OR` and you can't use numeric filters.<br/>
        /// Example: genre:comedy
        /// </summary>
        /// <example>genre:comedy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public string? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        /// <param name="pattern">
        /// Query pattern that triggers the rule.<br/>
        /// You can use either a literal string, or a special pattern `{facet:ATTRIBUTE}`, where `ATTRIBUTE` is a facet name.<br/>
        /// The rule is triggered if the query matches the literal string or a value of the specified facet.<br/>
        /// For example, with `pattern: {facet:genre}`, the rule is triggered when users search for a genre, such as "comedy".<br/>
        /// Example: {facet:genre}
        /// </param>
        /// <param name="anchoring">
        /// Which part of the search query the pattern should match:<br/>
        /// - `startsWith`. The pattern must match the beginning of the query.<br/>
        /// - `endsWith`. The pattern must match the end of the query.<br/>
        /// - `is`. The pattern must match the query exactly.<br/>
        /// - `contains`. The pattern must match anywhere in the query.<br/>
        /// Empty queries are only allowed as patterns with `anchoring: is`.
        /// </param>
        /// <param name="alternatives">
        /// Whether the pattern should match plurals, synonyms, and typos.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="context">
        /// An additional restriction that only triggers the rule, when the search has the same value as `ruleContexts` parameter.<br/>
        /// For example, if `context: mobile`, the rule is only triggered when the search request has a matching `ruleContexts: mobile`.<br/>
        /// A rule context must only contain alphanumeric characters.<br/>
        /// Example: mobile
        /// </param>
        /// <param name="filters">
        /// Filters that trigger the rule.<br/>
        /// You can add filters using the syntax `facet:value` so that the rule is triggered, when the specific filter is selected.<br/>
        /// You can use `filters` on its own or combine it with the `pattern` parameter.<br/>
        /// You can't combine multiple filters with `OR` and you can't use numeric filters.<br/>
        /// Example: genre:comedy
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Condition(
            string? pattern,
            global::Algolia.Anchoring? anchoring,
            bool? alternatives,
            string? context,
            string? filters)
        {
            this.Pattern = pattern;
            this.Anchoring = anchoring;
            this.Alternatives = alternatives;
            this.Context = context;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        public Condition()
        {
        }
    }
}