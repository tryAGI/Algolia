
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Redirect rule data.
    /// </summary>
    public sealed partial class RedirectRuleIndexMetadataData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleObjectID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RuleObjectID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectRuleIndexMetadataData" /> class.
        /// </summary>
        /// <param name="ruleObjectID"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedirectRuleIndexMetadataData(
            string ruleObjectID)
        {
            this.RuleObjectID = ruleObjectID ?? throw new global::System.ArgumentNullException(nameof(ruleObjectID));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectRuleIndexMetadataData" /> class.
        /// </summary>
        public RedirectRuleIndexMetadataData()
        {
        }
    }
}