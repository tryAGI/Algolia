
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Trending facet hit.
    /// </summary>
    public sealed partial class TrendingFacetHit
    {
        /// <summary>
        /// Recommendation score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_score")]
        public double? Score { get; set; }

        /// <summary>
        /// Facet attribute. To be used in combination with `facetValue`.<br/>
        /// If specified, only recommendations matching the facet filter will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FacetName { get; set; }

        /// <summary>
        /// Facet value. To be used in combination with `facetName`.<br/>
        /// If specified, only recommendations matching the facet filter will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FacetValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingFacetHit" /> class.
        /// </summary>
        /// <param name="facetName">
        /// Facet attribute. To be used in combination with `facetValue`.<br/>
        /// If specified, only recommendations matching the facet filter will be returned.
        /// </param>
        /// <param name="facetValue">
        /// Facet value. To be used in combination with `facetName`.<br/>
        /// If specified, only recommendations matching the facet filter will be returned.
        /// </param>
        /// <param name="score">
        /// Recommendation score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrendingFacetHit(
            string facetName,
            string facetValue,
            double? score)
        {
            this.Score = score;
            this.FacetName = facetName ?? throw new global::System.ArgumentNullException(nameof(facetName));
            this.FacetValue = facetValue ?? throw new global::System.ArgumentNullException(nameof(facetValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingFacetHit" /> class.
        /// </summary>
        public TrendingFacetHit()
        {
        }

    }
}