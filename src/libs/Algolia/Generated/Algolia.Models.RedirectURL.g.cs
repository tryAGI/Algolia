
#nullable enable

namespace Algolia
{
    /// <summary>
    /// The redirect rule container.
    /// </summary>
    public sealed partial class RedirectURL
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
        /// Initializes a new instance of the <see cref="RedirectURL" /> class.
        /// </summary>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedirectURL(
            string? url)
        {
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectURL" /> class.
        /// </summary>
        public RedirectURL()
        {
        }
    }
}