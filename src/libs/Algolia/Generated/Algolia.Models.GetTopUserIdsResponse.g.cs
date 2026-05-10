
#nullable enable

namespace Algolia
{
    /// <summary>
    /// User IDs and clusters.
    /// </summary>
    public sealed partial class GetTopUserIdsResponse
    {
        /// <summary>
        /// Key-value pairs with cluster names as keys and lists of users with the highest number of records per cluster as values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topUsers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Algolia.UserId>>> TopUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTopUserIdsResponse" /> class.
        /// </summary>
        /// <param name="topUsers">
        /// Key-value pairs with cluster names as keys and lists of users with the highest number of records per cluster as values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTopUserIdsResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Algolia.UserId>>> topUsers)
        {
            this.TopUsers = topUsers ?? throw new global::System.ArgumentNullException(nameof(topUsers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTopUserIdsResponse" /> class.
        /// </summary>
        public GetTopUserIdsResponse()
        {
        }

    }
}