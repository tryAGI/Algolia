
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Order of facet names.
    /// </summary>
    public sealed partial class Facets
    {
        /// <summary>
        /// Explicit order of facets or facet values.<br/>
        /// This setting lets you always show specific facets or facet values at the top of the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public global::System.Collections.Generic.IList<string>? Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Facets" /> class.
        /// </summary>
        /// <param name="order">
        /// Explicit order of facets or facet values.<br/>
        /// This setting lets you always show specific facets or facet values at the top of the list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Facets(
            global::System.Collections.Generic.IList<string>? order)
        {
            this.Order = order;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Facets" /> class.
        /// </summary>
        public Facets()
        {
        }

    }
}