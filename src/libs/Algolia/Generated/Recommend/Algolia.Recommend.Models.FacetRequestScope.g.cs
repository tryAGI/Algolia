
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Apply the rule only to Trending Items requests with the same `facetName` and `facetValue`.
    /// </summary>
    public sealed partial class FacetRequestScope
    {
        /// <summary>
        /// Facet attribute of the Trending Items request.<br/>
        /// Example: brand
        /// </summary>
        /// <example>brand</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FacetName { get; set; }

        /// <summary>
        /// Facet value of the Trending Items request.<br/>
        /// Example: acme
        /// </summary>
        /// <example>acme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FacetValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetRequestScope" /> class.
        /// </summary>
        /// <param name="facetName">
        /// Facet attribute of the Trending Items request.<br/>
        /// Example: brand
        /// </param>
        /// <param name="facetValue">
        /// Facet value of the Trending Items request.<br/>
        /// Example: acme
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FacetRequestScope(
            string facetName,
            string facetValue)
        {
            this.FacetName = facetName ?? throw new global::System.ArgumentNullException(nameof(facetName));
            this.FacetValue = facetValue ?? throw new global::System.ArgumentNullException(nameof(facetValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetRequestScope" /> class.
        /// </summary>
        public FacetRequestScope()
        {
        }

    }
}