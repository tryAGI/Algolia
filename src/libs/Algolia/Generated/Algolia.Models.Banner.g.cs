
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Banner with image and link to redirect users.
    /// </summary>
    public sealed partial class Banner
    {
        /// <summary>
        /// Image to show inside a banner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::Algolia.BannerImage? Image { get; set; }

        /// <summary>
        /// Link for a banner defined in the Merchandising Studio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public global::Algolia.BannerLink? Link { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Banner" /> class.
        /// </summary>
        /// <param name="image">
        /// Image to show inside a banner.
        /// </param>
        /// <param name="link">
        /// Link for a banner defined in the Merchandising Studio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Banner(
            global::Algolia.BannerImage? image,
            global::Algolia.BannerLink? link)
        {
            this.Image = image;
            this.Link = link;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Banner" /> class.
        /// </summary>
        public Banner()
        {
        }

    }
}