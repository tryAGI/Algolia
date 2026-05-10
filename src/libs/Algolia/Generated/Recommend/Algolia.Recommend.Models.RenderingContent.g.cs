
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Extra data that can be used in the search UI.<br/>
    /// You can use this to control aspects of your search UI, such as the order of facet names and values<br/>
    /// without changing your frontend code.
    /// </summary>
    public sealed partial class RenderingContent
    {
        /// <summary>
        /// Order of facet names and facet values in your UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetOrdering")]
        public global::Algolia.Recommend.FacetOrdering? FacetOrdering { get; set; }

        /// <summary>
        /// The redirect rule container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Algolia.Recommend.RedirectURL? Redirect { get; set; }

        /// <summary>
        /// Widgets returned from any rules that are applied to the current search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widgets")]
        public global::Algolia.Recommend.Widgets? Widgets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderingContent" /> class.
        /// </summary>
        /// <param name="facetOrdering">
        /// Order of facet names and facet values in your UI.
        /// </param>
        /// <param name="redirect">
        /// The redirect rule container.
        /// </param>
        /// <param name="widgets">
        /// Widgets returned from any rules that are applied to the current search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenderingContent(
            global::Algolia.Recommend.FacetOrdering? facetOrdering,
            global::Algolia.Recommend.RedirectURL? redirect,
            global::Algolia.Recommend.Widgets? widgets)
        {
            this.FacetOrdering = facetOrdering;
            this.Redirect = redirect;
            this.Widgets = widgets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderingContent" /> class.
        /// </summary>
        public RenderingContent()
        {
        }

    }
}