
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchHits
    {
        /// <summary>
        /// Search results (hits).<br/>
        /// Hits are records from your index that match the search criteria, augmented with additional attributes, such as, for highlighting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.Hit> Hits { get; set; }

        /// <summary>
        /// Search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// URL-encoded string of all search parameters.<br/>
        /// Example: query=a&amp;hitsPerPage=20
        /// </summary>
        /// <example>query=a&amp;hitsPerPage=20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public string? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHits" /> class.
        /// </summary>
        /// <param name="hits">
        /// Search results (hits).<br/>
        /// Hits are records from your index that match the search criteria, augmented with additional attributes, such as, for highlighting.
        /// </param>
        /// <param name="query">
        /// Search query.
        /// </param>
        /// <param name="params">
        /// URL-encoded string of all search parameters.<br/>
        /// Example: query=a&amp;hitsPerPage=20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchHits(
            global::System.Collections.Generic.IList<global::Algolia.Hit> hits,
            string? query,
            string? @params)
        {
            this.Hits = hits ?? throw new global::System.ArgumentNullException(nameof(hits));
            this.Query = query;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHits" /> class.
        /// </summary>
        public SearchHits()
        {
        }
    }
}