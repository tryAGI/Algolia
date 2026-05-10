
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Effect of the rule.
    /// </summary>
    public sealed partial class Consequence
    {
        /// <summary>
        /// Exclude items from recommendations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide")]
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.HideConsequenceObject>? Hide { get; set; }

        /// <summary>
        /// Place items at specific positions in the list of recommendations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promote")]
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.PromoteConsequenceObject>? Promote { get; set; }

        /// <summary>
        /// Filter or boost recommendations matching a facet filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::Algolia.Recommend.ParamsConsequence? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Consequence" /> class.
        /// </summary>
        /// <param name="hide">
        /// Exclude items from recommendations.
        /// </param>
        /// <param name="promote">
        /// Place items at specific positions in the list of recommendations.
        /// </param>
        /// <param name="params">
        /// Filter or boost recommendations matching a facet filter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Consequence(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.HideConsequenceObject>? hide,
            global::System.Collections.Generic.IList<global::Algolia.Recommend.PromoteConsequenceObject>? promote,
            global::Algolia.Recommend.ParamsConsequence? @params)
        {
            this.Hide = hide;
            this.Promote = promote;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Consequence" /> class.
        /// </summary>
        public Consequence()
        {
        }

    }
}