
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Type-specific configuration. Only present for v2 and later tests. Shape depends on the parent A/B test's `type`.
    /// </summary>
    public sealed partial class FetchedIndexAbTestVariantPayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}