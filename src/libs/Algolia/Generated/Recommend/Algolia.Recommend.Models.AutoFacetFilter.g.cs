
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Facet attribute. Only recommendations with the same value (or only recommendations with a different value) as the original viewed item are included.
    /// </summary>
    public sealed partial class AutoFacetFilter
    {
        /// <summary>
        /// Facet attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facet")]
        public string? Facet { get; set; }

        /// <summary>
        /// Whether the filter is negative.<br/>
        /// If true, recommendations must not have the same value for the `facet` attribute.<br/>
        /// If false, recommendations must have the same value for the `facet` attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative")]
        public bool? Negative { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoFacetFilter" /> class.
        /// </summary>
        /// <param name="facet">
        /// Facet attribute.
        /// </param>
        /// <param name="negative">
        /// Whether the filter is negative.<br/>
        /// If true, recommendations must not have the same value for the `facet` attribute.<br/>
        /// If false, recommendations must have the same value for the `facet` attribute.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoFacetFilter(
            string? facet,
            bool? negative)
        {
            this.Facet = facet;
            this.Negative = negative;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoFacetFilter" /> class.
        /// </summary>
        public AutoFacetFilter()
        {
        }

    }
}