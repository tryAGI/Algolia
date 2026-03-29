
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RedirectRuleIndexMetadata
    {
        /// <summary>
        /// Source index for the redirect rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Destination index for the redirect rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dest { get; set; }

        /// <summary>
        /// Reason for the redirect rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Redirect rule status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Succeed { get; set; }

        /// <summary>
        /// Redirect rule data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.Recommend.RedirectRuleIndexMetadataData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectRuleIndexMetadata" /> class.
        /// </summary>
        /// <param name="source">
        /// Source index for the redirect rule.
        /// </param>
        /// <param name="dest">
        /// Destination index for the redirect rule.
        /// </param>
        /// <param name="reason">
        /// Reason for the redirect rule.
        /// </param>
        /// <param name="succeed">
        /// Redirect rule status.
        /// </param>
        /// <param name="data">
        /// Redirect rule data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedirectRuleIndexMetadata(
            string source,
            string dest,
            string reason,
            bool succeed,
            global::Algolia.Recommend.RedirectRuleIndexMetadataData data)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Dest = dest ?? throw new global::System.ArgumentNullException(nameof(dest));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Succeed = succeed;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectRuleIndexMetadata" /> class.
        /// </summary>
        public RedirectRuleIndexMetadata()
        {
        }
    }
}