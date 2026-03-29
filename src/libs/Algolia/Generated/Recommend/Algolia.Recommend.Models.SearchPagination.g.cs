
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchPagination
    {
        /// <summary>
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Number of results (hits).<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbHits")]
        public int? NbHits { get; set; }

        /// <summary>
        /// Number of pages of results.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbPages")]
        public int? NbPages { get; set; }

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
        /// Initializes a new instance of the <see cref="SearchPagination" /> class.
        /// </summary>
        /// <param name="page">
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="nbHits">
        /// Number of results (hits).<br/>
        /// Example: 20
        /// </param>
        /// <param name="nbPages">
        /// Number of pages of results.<br/>
        /// Example: 1
        /// </param>
        /// <param name="hitsPerPage">
        /// Number of hits per page.<br/>
        /// Default Value: 20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPagination(
            int? page,
            int? nbHits,
            int? nbPages,
            int? hitsPerPage)
        {
            this.Page = page;
            this.NbHits = nbHits;
            this.NbPages = nbPages;
            this.HitsPerPage = hitsPerPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPagination" /> class.
        /// </summary>
        public SearchPagination()
        {
        }
    }
}