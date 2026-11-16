
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Apply the rule only to Trending Items requests without `facetName` and `facetValue`.
    /// </summary>
    public sealed partial class GlobalRequestScope
    {
        /// <summary>
        /// Whether the rule applies to requests without a facet. Must be `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Global { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalRequestScope" /> class.
        /// </summary>
        /// <param name="global">
        /// Whether the rule applies to requests without a facet. Must be `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlobalRequestScope(
            bool global)
        {
            this.Global = global;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalRequestScope" /> class.
        /// </summary>
        public GlobalRequestScope()
        {
        }

    }
}