
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Whether certain properties of the search response are calculated exhaustive (exact) or approximated.
    /// </summary>
    public sealed partial class BaseSearchResponseExhaustive
    {
        /// <summary>
        /// Whether the facet count is exhaustive (`true`) or approximate (`false`). See the [related discussion](https://support.algolia.com/hc/articles/4406975248145-Why-are-my-facet-and-hit-counts-not-accurate).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetsCount")]
        public bool? FacetsCount { get; set; }

        /// <summary>
        /// The value is `false` if not all facet values are retrieved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetValues")]
        public bool? FacetValues { get; set; }

        /// <summary>
        /// Whether the `nbHits` is exhaustive (`true`) or approximate (`false`). When the query takes more than 50ms to be processed, the engine makes an approximation. This can happen when using complex filters on millions of records, when typo-tolerance was not exhaustive, or when enough hits have been retrieved (for example, after the engine finds 10,000 exact matches). `nbHits` is reported as non-exhaustive whenever an approximation is made, even if the approximation didn’t, in the end, impact the exhaustivity of the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbHits")]
        public bool? NbHits { get; set; }

        /// <summary>
        /// Rules matching exhaustivity. The value is `false` if rules were enable for this query, and could not be fully processed due a timeout. This is generally caused by the number of alternatives (such as typos) which is too large.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rulesMatch")]
        public bool? RulesMatch { get; set; }

        /// <summary>
        /// Whether the typo search was exhaustive (`true`) or approximate (`false`). An approximation is done when the typo search query part takes more than 10% of the query budget (ie. 5ms by default) to be processed (this can happen when a lot of typo alternatives exist for the query). This field will not be included when typo-tolerance is entirely disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typo")]
        public bool? Typo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchResponseExhaustive" /> class.
        /// </summary>
        /// <param name="facetsCount">
        /// Whether the facet count is exhaustive (`true`) or approximate (`false`). See the [related discussion](https://support.algolia.com/hc/articles/4406975248145-Why-are-my-facet-and-hit-counts-not-accurate).
        /// </param>
        /// <param name="facetValues">
        /// The value is `false` if not all facet values are retrieved.
        /// </param>
        /// <param name="nbHits">
        /// Whether the `nbHits` is exhaustive (`true`) or approximate (`false`). When the query takes more than 50ms to be processed, the engine makes an approximation. This can happen when using complex filters on millions of records, when typo-tolerance was not exhaustive, or when enough hits have been retrieved (for example, after the engine finds 10,000 exact matches). `nbHits` is reported as non-exhaustive whenever an approximation is made, even if the approximation didn’t, in the end, impact the exhaustivity of the query.
        /// </param>
        /// <param name="rulesMatch">
        /// Rules matching exhaustivity. The value is `false` if rules were enable for this query, and could not be fully processed due a timeout. This is generally caused by the number of alternatives (such as typos) which is too large.
        /// </param>
        /// <param name="typo">
        /// Whether the typo search was exhaustive (`true`) or approximate (`false`). An approximation is done when the typo search query part takes more than 10% of the query budget (ie. 5ms by default) to be processed (this can happen when a lot of typo alternatives exist for the query). This field will not be included when typo-tolerance is entirely disabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseSearchResponseExhaustive(
            bool? facetsCount,
            bool? facetValues,
            bool? nbHits,
            bool? rulesMatch,
            bool? typo)
        {
            this.FacetsCount = facetsCount;
            this.FacetValues = facetValues;
            this.NbHits = nbHits;
            this.RulesMatch = rulesMatch;
            this.Typo = typo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchResponseExhaustive" /> class.
        /// </summary>
        public BaseSearchResponseExhaustive()
        {
        }

    }
}