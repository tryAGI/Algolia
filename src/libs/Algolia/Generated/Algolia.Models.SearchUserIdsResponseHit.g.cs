
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchUserIdsResponseHit
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
        /// Cluster name.<br/>
        /// Example: c11-test
        /// </summary>
        /// <example>c11-test</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClusterName { get; set; }

        /// <summary>
        /// Number of records in the cluster.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbRecords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbRecords { get; set; }

        /// <summary>
        /// Data size taken by all the users assigned to the cluster.<br/>
        /// Example: 481
        /// </summary>
        /// <example>481</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DataSize { get; set; }

        /// <summary>
        /// userID of the requested user. Same as userID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_highlightResult")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.SearchUserIdsResponseHitHighlightResult HighlightResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchUserIdsResponseHit" /> class.
        /// </summary>
        /// <param name="userID">
        /// Unique identifier of the user who makes the search request.<br/>
        /// Example: user1
        /// </param>
        /// <param name="clusterName">
        /// Cluster name.<br/>
        /// Example: c11-test
        /// </param>
        /// <param name="nbRecords">
        /// Number of records in the cluster.<br/>
        /// Example: 3
        /// </param>
        /// <param name="dataSize">
        /// Data size taken by all the users assigned to the cluster.<br/>
        /// Example: 481
        /// </param>
        /// <param name="objectID">
        /// userID of the requested user. Same as userID.
        /// </param>
        /// <param name="highlightResult"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchUserIdsResponseHit(
            string userID,
            string clusterName,
            int nbRecords,
            int dataSize,
            string objectID,
            global::Algolia.SearchUserIdsResponseHitHighlightResult highlightResult)
        {
            this.UserID = userID ?? throw new global::System.ArgumentNullException(nameof(userID));
            this.ClusterName = clusterName ?? throw new global::System.ArgumentNullException(nameof(clusterName));
            this.NbRecords = nbRecords;
            this.DataSize = dataSize;
            this.ObjectID = objectID ?? throw new global::System.ArgumentNullException(nameof(objectID));
            this.HighlightResult = highlightResult ?? throw new global::System.ArgumentNullException(nameof(highlightResult));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchUserIdsResponseHit" /> class.
        /// </summary>
        public SearchUserIdsResponseHit()
        {
        }

    }
}