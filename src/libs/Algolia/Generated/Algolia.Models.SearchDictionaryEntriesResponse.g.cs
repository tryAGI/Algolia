
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchDictionaryEntriesResponse
    {
        /// <summary>
        /// Dictionary entries matching the search criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.DictionaryEntry> Hits { get; set; }

        /// <summary>
        /// Requested page of the API response.<br/>
        /// Algolia uses `page` and `hitsPerPage` to control how search results are displayed ([paginated](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js)).<br/>
        /// - `hitsPerPage`: sets the number of search results (_hits_) displayed per page.<br/>
        /// - `page`: specifies the page number of the search results you want to retrieve. Page numbering starts at 0, so the first page is `page=0`, the second is `page=1`, and so on.<br/>
        /// For example, to display 10 results per page starting from the third page, set `hitsPerPage` to 10 and `page` to 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Number of results (hits).<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbHits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbHits { get; set; }

        /// <summary>
        /// Number of pages of results.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbPages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDictionaryEntriesResponse" /> class.
        /// </summary>
        /// <param name="hits">
        /// Dictionary entries matching the search criteria.
        /// </param>
        /// <param name="page">
        /// Requested page of the API response.<br/>
        /// Algolia uses `page` and `hitsPerPage` to control how search results are displayed ([paginated](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js)).<br/>
        /// - `hitsPerPage`: sets the number of search results (_hits_) displayed per page.<br/>
        /// - `page`: specifies the page number of the search results you want to retrieve. Page numbering starts at 0, so the first page is `page=0`, the second is `page=1`, and so on.<br/>
        /// For example, to display 10 results per page starting from the third page, set `hitsPerPage` to 10 and `page` to 2.
        /// </param>
        /// <param name="nbHits">
        /// Number of results (hits).<br/>
        /// Example: 20
        /// </param>
        /// <param name="nbPages">
        /// Number of pages of results.<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchDictionaryEntriesResponse(
            global::System.Collections.Generic.IList<global::Algolia.DictionaryEntry> hits,
            int page,
            int nbHits,
            int nbPages)
        {
            this.Hits = hits ?? throw new global::System.ArgumentNullException(nameof(hits));
            this.Page = page;
            this.NbHits = nbHits;
            this.NbPages = nbPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDictionaryEntriesResponse" /> class.
        /// </summary>
        public SearchDictionaryEntriesResponse()
        {
        }

    }
}