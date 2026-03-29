
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchForFacetValuesResponse
    {
        /// <summary>
        /// Matching facet values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetHits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.SearchForFacetValuesResponseFacetHit> FacetHits { get; set; }

        /// <summary>
        /// Whether the facet count is exhaustive (true) or approximate (false).<br/>
        /// For more information, see [Why are my facet and hit counts not accurate](https://support.algolia.com/hc/articles/4406975248145-Why-are-my-facet-and-hit-counts-not-accurate).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exhaustiveFacetsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExhaustiveFacetsCount { get; set; }

        /// <summary>
        /// Time the server took to process the request, in milliseconds.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("processingTimeMS")]
        public int? ProcessingTimeMS { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForFacetValuesResponse" /> class.
        /// </summary>
        /// <param name="facetHits">
        /// Matching facet values.
        /// </param>
        /// <param name="exhaustiveFacetsCount">
        /// Whether the facet count is exhaustive (true) or approximate (false).<br/>
        /// For more information, see [Why are my facet and hit counts not accurate](https://support.algolia.com/hc/articles/4406975248145-Why-are-my-facet-and-hit-counts-not-accurate).
        /// </param>
        /// <param name="processingTimeMS">
        /// Time the server took to process the request, in milliseconds.<br/>
        /// Example: 20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchForFacetValuesResponse(
            global::System.Collections.Generic.IList<global::Algolia.SearchForFacetValuesResponseFacetHit> facetHits,
            bool exhaustiveFacetsCount,
            int? processingTimeMS)
        {
            this.FacetHits = facetHits ?? throw new global::System.ArgumentNullException(nameof(facetHits));
            this.ExhaustiveFacetsCount = exhaustiveFacetsCount;
            this.ProcessingTimeMS = processingTimeMS;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForFacetValuesResponse" /> class.
        /// </summary>
        public SearchForFacetValuesResponse()
        {
        }
    }
}