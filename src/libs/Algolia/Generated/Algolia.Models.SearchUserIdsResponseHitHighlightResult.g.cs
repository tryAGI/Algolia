
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchUserIdsResponseHitHighlightResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userID")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.HighlightResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.HighlightResult UserID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.HighlightResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.HighlightResult ClusterName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchUserIdsResponseHitHighlightResult" /> class.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="clusterName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchUserIdsResponseHitHighlightResult(
            global::Algolia.HighlightResult userID,
            global::Algolia.HighlightResult clusterName)
        {
            this.UserID = userID;
            this.ClusterName = clusterName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchUserIdsResponseHitHighlightResult" /> class.
        /// </summary>
        public SearchUserIdsResponseHitHighlightResult()
        {
        }

    }
}