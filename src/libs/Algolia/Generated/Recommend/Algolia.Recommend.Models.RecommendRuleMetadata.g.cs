
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Rule metadata.
    /// </summary>
    public sealed partial class RecommendRuleMetadata
    {
        /// <summary>
        /// Date and time when the object was updated, in RFC 3339 format.<br/>
        /// Example: 2023-07-04T12:49:15Z
        /// </summary>
        /// <example>2023-07-04T12:49:15Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdate")]
        public string? LastUpdate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendRuleMetadata" /> class.
        /// </summary>
        /// <param name="lastUpdate">
        /// Date and time when the object was updated, in RFC 3339 format.<br/>
        /// Example: 2023-07-04T12:49:15Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendRuleMetadata(
            string? lastUpdate)
        {
            this.LastUpdate = lastUpdate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendRuleMetadata" /> class.
        /// </summary>
        public RecommendRuleMetadata()
        {
        }

    }
}