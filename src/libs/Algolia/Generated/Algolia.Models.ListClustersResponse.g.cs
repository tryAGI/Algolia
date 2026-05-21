
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Clusters.
    /// </summary>
    public sealed partial class ListClustersResponse
    {
        /// <summary>
        /// Key-value pairs with cluster names as keys and lists of users with the highest number of records per cluster as values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topUsers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TopUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListClustersResponse" /> class.
        /// </summary>
        /// <param name="topUsers">
        /// Key-value pairs with cluster names as keys and lists of users with the highest number of records per cluster as values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListClustersResponse(
            global::System.Collections.Generic.IList<string> topUsers)
        {
            this.TopUsers = topUsers ?? throw new global::System.ArgumentNullException(nameof(topUsers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListClustersResponse" /> class.
        /// </summary>
        public ListClustersResponse()
        {
        }

    }
}