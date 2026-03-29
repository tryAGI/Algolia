
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchParamsQuery
    {
        /// <summary>
        /// Search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParamsQuery" /> class.
        /// </summary>
        /// <param name="query">
        /// Search query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchParamsQuery(
            string? query)
        {
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParamsQuery" /> class.
        /// </summary>
        public SearchParamsQuery()
        {
        }
    }
}