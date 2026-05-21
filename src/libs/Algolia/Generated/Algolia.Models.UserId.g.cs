
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Unique user ID.
    /// </summary>
    public sealed partial class UserId
    {
        /// <summary>
        /// Unique identifier of the user who makes the search request.<br/>
        /// Example: user1
        /// </summary>
        /// <example>user1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserID { get; set; }

        /// <summary>
        /// Cluster to which the user is assigned.<br/>
        /// Example: c1-test
        /// </summary>
        /// <example>c1-test</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClusterName { get; set; }

        /// <summary>
        /// Number of records belonging to the user.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbRecords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbRecords { get; set; }

        /// <summary>
        /// Data size used by the user.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DataSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserId" /> class.
        /// </summary>
        /// <param name="userID">
        /// Unique identifier of the user who makes the search request.<br/>
        /// Example: user1
        /// </param>
        /// <param name="clusterName">
        /// Cluster to which the user is assigned.<br/>
        /// Example: c1-test
        /// </param>
        /// <param name="nbRecords">
        /// Number of records belonging to the user.<br/>
        /// Example: 42
        /// </param>
        /// <param name="dataSize">
        /// Data size used by the user.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserId(
            string userID,
            string clusterName,
            int nbRecords,
            int dataSize)
        {
            this.UserID = userID ?? throw new global::System.ArgumentNullException(nameof(userID));
            this.ClusterName = clusterName ?? throw new global::System.ArgumentNullException(nameof(clusterName));
            this.NbRecords = nbRecords;
            this.DataSize = dataSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserId" /> class.
        /// </summary>
        public UserId()
        {
        }

    }
}