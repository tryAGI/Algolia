
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Order of facet names and facet values in your UI.
    /// </summary>
    public sealed partial class FacetOrdering
    {
        /// <summary>
        /// Order of facet names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets")]
        public global::Algolia.Recommend.IndexSettingsFacets? Facets { get; set; }

        /// <summary>
        /// Order of facet values. One object for each facet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.Dictionary<string, global::Algolia.Recommend.Value>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetOrdering" /> class.
        /// </summary>
        /// <param name="facets">
        /// Order of facet names.
        /// </param>
        /// <param name="values">
        /// Order of facet values. One object for each facet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FacetOrdering(
            global::Algolia.Recommend.IndexSettingsFacets? facets,
            global::System.Collections.Generic.Dictionary<string, global::Algolia.Recommend.Value>? values)
        {
            this.Facets = facets;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetOrdering" /> class.
        /// </summary>
        public FacetOrdering()
        {
        }
    }
}