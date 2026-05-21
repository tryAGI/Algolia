
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Result of automatic filtering applied by Query Categorization.
    /// </summary>
    public sealed partial class AutoFilteringResult
    {
        /// <summary>
        /// Whether automatic filtering was applied to this query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Maximum category hierarchy depth used for filtering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDepth")]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Facet filters automatically applied to the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetFilters")]
        public global::System.Collections.Generic.IList<global::Algolia.AutoFilteringFilterEntry>? FacetFilters { get; set; }

        /// <summary>
        /// Optional filters automatically applied to boost relevant categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionalFilters")]
        public global::System.Collections.Generic.IList<global::Algolia.AutoFilteringFilterEntry>? OptionalFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoFilteringResult" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether automatic filtering was applied to this query.
        /// </param>
        /// <param name="maxDepth">
        /// Maximum category hierarchy depth used for filtering.
        /// </param>
        /// <param name="facetFilters">
        /// Facet filters automatically applied to the query.
        /// </param>
        /// <param name="optionalFilters">
        /// Optional filters automatically applied to boost relevant categories.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoFilteringResult(
            bool? enabled,
            int? maxDepth,
            global::System.Collections.Generic.IList<global::Algolia.AutoFilteringFilterEntry>? facetFilters,
            global::System.Collections.Generic.IList<global::Algolia.AutoFilteringFilterEntry>? optionalFilters)
        {
            this.Enabled = enabled;
            this.MaxDepth = maxDepth;
            this.FacetFilters = facetFilters;
            this.OptionalFilters = optionalFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoFilteringResult" /> class.
        /// </summary>
        public AutoFilteringResult()
        {
        }

    }
}