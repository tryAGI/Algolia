
#nullable enable

namespace Algolia
{
    /// <summary>
    /// OK
    /// </summary>
    public sealed partial class SearchUserIdsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Cluster name.<br/>
        /// Example: c11-test
        /// </summary>
        /// <example>c11-test</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterName")]
        public string? ClusterName { get; set; }

        /// <summary>
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Number of hits per page.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hitsPerPage")]
        public int? HitsPerPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchUserIdsRequest" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="clusterName">
        /// Cluster name.<br/>
        /// Example: c11-test
        /// </param>
        /// <param name="page">
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="hitsPerPage">
        /// Number of hits per page.<br/>
        /// Default Value: 20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchUserIdsRequest(
            string query,
            string? clusterName,
            int? page,
            int? hitsPerPage)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.ClusterName = clusterName;
            this.Page = page;
            this.HitsPerPage = hitsPerPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchUserIdsRequest" /> class.
        /// </summary>
        public SearchUserIdsRequest()
        {
        }

    }
}