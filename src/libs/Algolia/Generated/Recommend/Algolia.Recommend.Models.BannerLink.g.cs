
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Link for a banner defined in the Merchandising Studio.
    /// </summary>
    public sealed partial class BannerLink
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
        /// Initializes a new instance of the <see cref="BannerLink" /> class.
        /// </summary>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BannerLink(
            string? url)
        {
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BannerLink" /> class.
        /// </summary>
        public BannerLink()
        {
        }
    }
}