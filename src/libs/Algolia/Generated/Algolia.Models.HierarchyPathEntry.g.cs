
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HierarchyPathEntry
    {
        /// <summary>
        /// Facet attribute name at this hierarchy level, for example, `categories.lvl0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetName")]
        public string? FacetName { get; set; }

        /// <summary>
        /// Facet value at this level of the category hierarchy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetValue")]
        public string? FacetValue { get; set; }

        /// <summary>
        /// Depth level in the category hierarchy, starting at 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchyPathEntry" /> class.
        /// </summary>
        /// <param name="facetName">
        /// Facet attribute name at this hierarchy level, for example, `categories.lvl0`.
        /// </param>
        /// <param name="facetValue">
        /// Facet value at this level of the category hierarchy.
        /// </param>
        /// <param name="depth">
        /// Depth level in the category hierarchy, starting at 0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HierarchyPathEntry(
            string? facetName,
            string? facetValue,
            int? depth)
        {
            this.FacetName = facetName;
            this.FacetValue = facetValue;
            this.Depth = depth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchyPathEntry" /> class.
        /// </summary>
        public HierarchyPathEntry()
        {
        }

    }
}