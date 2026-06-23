
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendSearchParamsVariant4
    {
        /// <summary>
        /// Whether to enable rules.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableRules")]
        public bool? EnableRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendSearchParamsVariant4" /> class.
        /// </summary>
        /// <param name="enableRules">
        /// Whether to enable rules.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendSearchParamsVariant4(
            bool? enableRules)
        {
            this.EnableRules = enableRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendSearchParamsVariant4" /> class.
        /// </summary>
        public RecommendSearchParamsVariant4()
        {
        }

    }
}