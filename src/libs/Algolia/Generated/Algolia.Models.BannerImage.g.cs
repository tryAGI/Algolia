
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Image to show inside a banner.
    /// </summary>
    public sealed partial class BannerImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<global::Algolia.BannerImageUrl>? Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BannerImage" /> class.
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BannerImage(
            global::System.Collections.Generic.IList<global::Algolia.BannerImageUrl>? urls,
            string? title)
        {
            this.Urls = urls;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BannerImage" /> class.
        /// </summary>
        public BannerImage()
        {
        }
    }
}