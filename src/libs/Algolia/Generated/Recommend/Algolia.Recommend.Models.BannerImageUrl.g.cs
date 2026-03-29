
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// URL for an image to show inside a banner.
    /// </summary>
    public sealed partial class BannerImageUrl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BannerImageUrl" /> class.
        /// </summary>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BannerImageUrl(
            string? url)
        {
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BannerImageUrl" /> class.
        /// </summary>
        public BannerImageUrl()
        {
        }
    }
}