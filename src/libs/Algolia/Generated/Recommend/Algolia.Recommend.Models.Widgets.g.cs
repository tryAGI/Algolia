
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Widgets returned from any rules that are applied to the current search.
    /// </summary>
    public sealed partial class Widgets
    {
        /// <summary>
        /// Banners defined in the Merchandising Studio for a given search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("banners")]
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.Banner>? Banners { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Widgets" /> class.
        /// </summary>
        /// <param name="banners">
        /// Banners defined in the Merchandising Studio for a given search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Widgets(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.Banner>? banners)
        {
            this.Banners = banners;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Widgets" /> class.
        /// </summary>
        public Widgets()
        {
        }
    }
}