
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchForFacetsSettings
    {
        /// <summary>
        /// Facet name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Facet { get; set; }

        /// <summary>
        /// Index name (case-sensitive).<br/>
        /// Example: products
        /// </summary>
        /// <example>products</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

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
        /// - `default`: perform a search query<br/>
        /// - `facet` [searches for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
        /// Default Value: facet
        /// </summary>
        /// <default>global::Algolia.SearchTypeFacet.Facet</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.SearchTypeFacetJsonConverter))]
        public global::Algolia.SearchTypeFacet Type { get; set; } = global::Algolia.SearchTypeFacet.Facet;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForFacetsSettings" /> class.
        /// </summary>
        /// <param name="facet">
        /// Facet name.
        /// </param>
        /// <param name="indexName">
        /// Index name (case-sensitive).<br/>
        /// Example: products
        /// </param>
        /// <param name="facetQuery">
        /// Text to search inside the facet's values.<br/>
        /// Example: george
        /// </param>
        /// <param name="maxFacetHits">
        /// Maximum number of facet values to return when [searching for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="type">
        /// - `default`: perform a search query<br/>
        /// - `facet` [searches for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
        /// Default Value: facet
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchForFacetsSettings(
            string facet,
            string indexName,
            string? facetQuery,
            int? maxFacetHits,
            global::Algolia.SearchTypeFacet type = global::Algolia.SearchTypeFacet.Facet)
        {
            this.Facet = facet ?? throw new global::System.ArgumentNullException(nameof(facet));
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.FacetQuery = facetQuery;
            this.MaxFacetHits = maxFacetHits;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForFacetsSettings" /> class.
        /// </summary>
        public SearchForFacetsSettings()
        {
        }

    }
}