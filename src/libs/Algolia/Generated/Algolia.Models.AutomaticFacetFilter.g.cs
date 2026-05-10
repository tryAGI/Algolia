
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Filter or optional filter to be applied to the search.
    /// </summary>
    public sealed partial class AutomaticFacetFilter
    {
        /// <summary>
        /// Facet name to be applied as filter.<br/>
        /// The name must match placeholders in the `pattern` parameter.<br/>
        /// For example, with `pattern: {facet:genre}`, `automaticFacetFilters` must be `genre`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Facet { get; set; }

        /// <summary>
        /// Filter scores to give different weights to individual filters.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// Whether the filter is disjunctive or conjunctive.<br/>
        /// If true the filter has multiple matches, multiple occurrences are combined with the logical `OR` operation.<br/>
        /// If false, multiple occurrences are combined with the logical `AND` operation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disjunctive")]
        public bool? Disjunctive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticFacetFilter" /> class.
        /// </summary>
        /// <param name="facet">
        /// Facet name to be applied as filter.<br/>
        /// The name must match placeholders in the `pattern` parameter.<br/>
        /// For example, with `pattern: {facet:genre}`, `automaticFacetFilters` must be `genre`.
        /// </param>
        /// <param name="score">
        /// Filter scores to give different weights to individual filters.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="disjunctive">
        /// Whether the filter is disjunctive or conjunctive.<br/>
        /// If true the filter has multiple matches, multiple occurrences are combined with the logical `OR` operation.<br/>
        /// If false, multiple occurrences are combined with the logical `AND` operation.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomaticFacetFilter(
            string facet,
            int? score,
            bool? disjunctive)
        {
            this.Facet = facet ?? throw new global::System.ArgumentNullException(nameof(facet));
            this.Score = score;
            this.Disjunctive = disjunctive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticFacetFilter" /> class.
        /// </summary>
        public AutomaticFacetFilter()
        {
        }

    }
}