
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HasPendingMappingsResponse
    {
        /// <summary>
        /// Whether there are clusters undergoing migration, creation, or deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pending { get; set; }

        /// <summary>
        /// Cluster pending mapping state: migrating, creating, deleting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusters")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Clusters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HasPendingMappingsResponse" /> class.
        /// </summary>
        /// <param name="pending">
        /// Whether there are clusters undergoing migration, creation, or deletion.
        /// </param>
        /// <param name="clusters">
        /// Cluster pending mapping state: migrating, creating, deleting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HasPendingMappingsResponse(
            bool pending,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? clusters)
        {
            this.Pending = pending;
            this.Clusters = clusters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HasPendingMappingsResponse" /> class.
        /// </summary>
        public HasPendingMappingsResponse()
        {
        }

    }
}