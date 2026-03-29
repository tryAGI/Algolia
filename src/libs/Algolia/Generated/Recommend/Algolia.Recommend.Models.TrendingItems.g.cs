
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrendingItems
    {
        /// <summary>
        /// Facet attribute. To be used in combination with `facetValue`.<br/>
        /// If specified, only recommendations matching the facet filter will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetName")]
        public string? FacetName { get; set; }

        /// <summary>
        /// Facet value. To be used in combination with `facetName`.<br/>
        /// If specified, only recommendations matching the facet filter will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetValue")]
        public string? FacetValue { get; set; }

        /// <summary>
        /// Trending items model.<br/>
        /// Trending items are determined from the number of conversion events collected on them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.TrendingItemsModelJsonConverter))]
        public global::Algolia.Recommend.TrendingItemsModel Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackParameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.FallbackParamsJsonConverter))]
        public global::Algolia.Recommend.FallbackParams? FallbackParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingItems" /> class.
        /// </summary>
        /// <param name="facetName">
        /// Facet attribute. To be used in combination with `facetValue`.<br/>
        /// If specified, only recommendations matching the facet filter will be returned.
        /// </param>
        /// <param name="facetValue">
        /// Facet value. To be used in combination with `facetName`.<br/>
        /// If specified, only recommendations matching the facet filter will be returned.
        /// </param>
        /// <param name="model">
        /// Trending items model.<br/>
        /// Trending items are determined from the number of conversion events collected on them.
        /// </param>
        /// <param name="fallbackParameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrendingItems(
            string? facetName,
            string? facetValue,
            global::Algolia.Recommend.TrendingItemsModel model,
            global::Algolia.Recommend.FallbackParams? fallbackParameters)
        {
            this.FacetName = facetName;
            this.FacetValue = facetValue;
            this.Model = model;
            this.FallbackParameters = fallbackParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingItems" /> class.
        /// </summary>
        public TrendingItems()
        {
        }
    }
}