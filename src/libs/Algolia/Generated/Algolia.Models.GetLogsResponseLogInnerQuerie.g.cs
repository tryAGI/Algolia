
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLogsResponseLogInnerQuerie
    {
        /// <summary>
        /// Index targeted by the query.<br/>
        /// Example: products
        /// </summary>
        /// <example>products</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_name")]
        public string? IndexName { get; set; }

        /// <summary>
        /// A user identifier.<br/>
        /// Example: 93.189.166.128
        /// </summary>
        /// <example>93.189.166.128</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_token")]
        public string? UserToken { get; set; }

        /// <summary>
        /// Unique query identifier.<br/>
        /// Example: 96f59a3145dd9bd8963dc223950507c8
        /// </summary>
        /// <example>96f59a3145dd9bd8963dc223950507c8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_id")]
        public string? QueryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLogsResponseLogInnerQuerie" /> class.
        /// </summary>
        /// <param name="indexName">
        /// Index targeted by the query.<br/>
        /// Example: products
        /// </param>
        /// <param name="userToken">
        /// A user identifier.<br/>
        /// Example: 93.189.166.128
        /// </param>
        /// <param name="queryId">
        /// Unique query identifier.<br/>
        /// Example: 96f59a3145dd9bd8963dc223950507c8
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLogsResponseLogInnerQuerie(
            string? indexName,
            string? userToken,
            string? queryId)
        {
            this.IndexName = indexName;
            this.UserToken = userToken;
            this.QueryId = queryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLogsResponseLogInnerQuerie" /> class.
        /// </summary>
        public GetLogsResponseLogInnerQuerie()
        {
        }

    }
}