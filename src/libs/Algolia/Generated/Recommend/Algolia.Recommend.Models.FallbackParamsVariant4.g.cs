
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackParamsVariant4
    {
        /// <summary>
        /// Filter the search by facet values, so that only records with the same facet values are retrieved.<br/>
        /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
        /// - `[filter1, filter2]` is interpreted as `filter1 AND filter2`.<br/>
        /// - `[[filter1, filter2], filter3]` is interpreted as `filter1 OR filter2 AND filter3`.<br/>
        /// - `facet:-value` is interpreted as `NOT facet:value`.<br/>
        /// While it's best to avoid attributes that start with a `-`, you can still filter them by escaping with a backslash:<br/>
        /// `facet:\-value`.<br/>
        /// Example: [[category:Book, category:-Movie], author:John Doe]
        /// </summary>
        /// <example>[[category:Book, category:-Movie], author:John Doe]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetFilters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.FacetFiltersJsonConverter))]
        public global::Algolia.Recommend.FacetFilters? FacetFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackParamsVariant4" /> class.
        /// </summary>
        /// <param name="facetFilters">
        /// Filter the search by facet values, so that only records with the same facet values are retrieved.<br/>
        /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
        /// - `[filter1, filter2]` is interpreted as `filter1 AND filter2`.<br/>
        /// - `[[filter1, filter2], filter3]` is interpreted as `filter1 OR filter2 AND filter3`.<br/>
        /// - `facet:-value` is interpreted as `NOT facet:value`.<br/>
        /// While it's best to avoid attributes that start with a `-`, you can still filter them by escaping with a backslash:<br/>
        /// `facet:\-value`.<br/>
        /// Example: [[category:Book, category:-Movie], author:John Doe]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackParamsVariant4(
            global::Algolia.Recommend.FacetFilters? facetFilters)
        {
            this.FacetFilters = facetFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackParamsVariant4" /> class.
        /// </summary>
        public FallbackParamsVariant4()
        {
        }

    }
}