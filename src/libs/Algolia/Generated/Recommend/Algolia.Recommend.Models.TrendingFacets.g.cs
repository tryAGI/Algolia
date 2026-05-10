
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrendingFacets
    {
        /// <summary>
        /// Index name (case-sensitive).<br/>
        /// Example: products
        /// </summary>
        /// <example>products</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// Minimum score a recommendation must have to be included in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        /// Maximum number of recommendations to retrieve.<br/>
        /// By default, all recommendations are returned and no fallback request is made.<br/>
        /// Depending on the available recommendations and the other request parameters,<br/>
        /// the actual number of recommendations may be lower than this value.<br/>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRecommendations")]
        public int? MaxRecommendations { get; set; }

        /// <summary>
        /// Facet attribute for which to retrieve trending facet values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FacetName { get; set; }

        /// <summary>
        /// Trending facet values model.<br/>
        /// This model recommends trending facet values for the specified facet attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.TrendingFacetsModelJsonConverter))]
        public global::Algolia.Recommend.TrendingFacetsModel Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingFacets" /> class.
        /// </summary>
        /// <param name="indexName">
        /// Index name (case-sensitive).<br/>
        /// Example: products
        /// </param>
        /// <param name="threshold">
        /// Minimum score a recommendation must have to be included in the response.
        /// </param>
        /// <param name="facetName">
        /// Facet attribute for which to retrieve trending facet values.
        /// </param>
        /// <param name="maxRecommendations">
        /// Maximum number of recommendations to retrieve.<br/>
        /// By default, all recommendations are returned and no fallback request is made.<br/>
        /// Depending on the available recommendations and the other request parameters,<br/>
        /// the actual number of recommendations may be lower than this value.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="model">
        /// Trending facet values model.<br/>
        /// This model recommends trending facet values for the specified facet attribute.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrendingFacets(
            string indexName,
            double threshold,
            string facetName,
            int? maxRecommendations,
            global::Algolia.Recommend.TrendingFacetsModel model)
        {
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.Threshold = threshold;
            this.MaxRecommendations = maxRecommendations;
            this.FacetName = facetName ?? throw new global::System.ArgumentNullException(nameof(facetName));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingFacets" /> class.
        /// </summary>
        public TrendingFacets()
        {
        }

    }
}