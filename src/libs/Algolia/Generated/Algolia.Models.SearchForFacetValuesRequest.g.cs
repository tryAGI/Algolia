
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchForFacetValuesRequest
    {
        /// <summary>
        /// Search parameters as a URL-encoded query string.<br/>
        /// Example: hitsPerPage=2&amp;getRankingInfo=1
        /// </summary>
        /// <example>hitsPerPage=2&amp;getRankingInfo=1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public string? Params { get; set; }

        /// <summary>
        /// Text to search inside the facet's values.<br/>
        /// Example: george
        /// </summary>
        /// <example>george</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetQuery")]
        public string? FacetQuery { get; set; }

        /// <summary>
        /// Maximum number of facet values to return when [searching for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxFacetHits")]
        public int? MaxFacetHits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForFacetValuesRequest" /> class.
        /// </summary>
        /// <param name="params">
        /// Search parameters as a URL-encoded query string.<br/>
        /// Example: hitsPerPage=2&amp;getRankingInfo=1
        /// </param>
        /// <param name="facetQuery">
        /// Text to search inside the facet's values.<br/>
        /// Example: george
        /// </param>
        /// <param name="maxFacetHits">
        /// Maximum number of facet values to return when [searching for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
        /// Default Value: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchForFacetValuesRequest(
            string? @params,
            string? facetQuery,
            int? maxFacetHits)
        {
            this.Params = @params;
            this.FacetQuery = facetQuery;
            this.MaxFacetHits = maxFacetHits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForFacetValuesRequest" /> class.
        /// </summary>
        public SearchForFacetValuesRequest()
        {
        }
    }
}