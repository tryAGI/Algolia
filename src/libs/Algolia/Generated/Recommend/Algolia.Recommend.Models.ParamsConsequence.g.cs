
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Filter or boost recommendations matching a facet filter.
    /// </summary>
    public sealed partial class ParamsConsequence
    {
        /// <summary>
        /// Filter recommendations that match or don't match the same `facet:facet_value` combination as the viewed item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticFacetFilters")]
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.AutoFacetFilter>? AutomaticFacetFilters { get; set; }

        /// <summary>
        /// Filter expression to only include items that match the filter criteria in the response.<br/>
        /// You can use these filter expressions:<br/>
        /// - **Numeric filters.** `&lt;facet&gt; &lt;op&gt; &lt;number&gt;`, where `&lt;op&gt;` is one of `&lt;`, `&lt;=`, `=`, `!=`, `&gt;`, `&gt;=`.<br/>
        /// - **Ranges.** `&lt;facet&gt;:&lt;lower&gt; TO &lt;upper&gt;`, where `&lt;lower&gt;` and `&lt;upper&gt;` are the lower and upper limits of the range (inclusive).<br/>
        /// - **Facet filters.** `&lt;facet&gt;:&lt;value&gt;`, where `&lt;facet&gt;` is a facet attribute (case-sensitive) and `&lt;value&gt;` a facet value.<br/>
        /// - **Tag filters.** `_tags:&lt;value&gt;` or just `&lt;value&gt;` (case-sensitive).<br/>
        /// - **Boolean filters.** `&lt;facet&gt;: true | false`.<br/>
        /// You can combine filters with `AND`, `OR`, and `NOT` operators with the following restrictions:<br/>
        /// - You can only combine filters of the same type with `OR`.<br/>
        ///   **Not supported:** `facet:value OR num &gt; 3`.<br/>
        /// - You can't use `NOT` with combinations of filters.<br/>
        ///   **Not supported:** `NOT(facet:value OR facet:value)`<br/>
        /// - You can't combine conjunctions (`AND`) with `OR`.<br/>
        ///   **Not supported:** `facet:value OR (facet:value AND facet:value)`<br/>
        /// Use quotes if the facet attribute name or facet value contains spaces, keywords (`OR`, `AND`, `NOT`), or quotes.<br/>
        /// If a facet attribute is an array, the filter matches if it matches at least one element of the array.<br/>
        /// For more information, see [Filters](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering).<br/>
        /// Example: (category:Book OR category:Ebook) AND _tags:published
        /// </summary>
        /// <example>(category:Book OR category:Ebook) AND _tags:published</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public string? Filters { get; set; }

        /// <summary>
        /// Filters to promote or demote records in the search results.<br/>
        /// Optional filters work like facet filters, but they don't exclude records from the search results.<br/>
        /// Records that match the optional filter rank before records that don't match.<br/>
        /// Matches with higher weights (`&lt;score=N&gt;`) rank before matches with lower weights.<br/>
        /// If you're using a negative filter `facet:-value`, matching records rank after records that don't match.<br/>
        /// Example: [category:books&lt;score=1&gt;, category:-movies&lt;score=1&gt;]
        /// </summary>
        /// <example>[category:books&lt;score=1&gt;, category:-movies&lt;score=1&gt;]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionalFilters")]
        public global::System.Collections.Generic.IList<string>? OptionalFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParamsConsequence" /> class.
        /// </summary>
        /// <param name="automaticFacetFilters">
        /// Filter recommendations that match or don't match the same `facet:facet_value` combination as the viewed item.
        /// </param>
        /// <param name="filters">
        /// Filter expression to only include items that match the filter criteria in the response.<br/>
        /// You can use these filter expressions:<br/>
        /// - **Numeric filters.** `&lt;facet&gt; &lt;op&gt; &lt;number&gt;`, where `&lt;op&gt;` is one of `&lt;`, `&lt;=`, `=`, `!=`, `&gt;`, `&gt;=`.<br/>
        /// - **Ranges.** `&lt;facet&gt;:&lt;lower&gt; TO &lt;upper&gt;`, where `&lt;lower&gt;` and `&lt;upper&gt;` are the lower and upper limits of the range (inclusive).<br/>
        /// - **Facet filters.** `&lt;facet&gt;:&lt;value&gt;`, where `&lt;facet&gt;` is a facet attribute (case-sensitive) and `&lt;value&gt;` a facet value.<br/>
        /// - **Tag filters.** `_tags:&lt;value&gt;` or just `&lt;value&gt;` (case-sensitive).<br/>
        /// - **Boolean filters.** `&lt;facet&gt;: true | false`.<br/>
        /// You can combine filters with `AND`, `OR`, and `NOT` operators with the following restrictions:<br/>
        /// - You can only combine filters of the same type with `OR`.<br/>
        ///   **Not supported:** `facet:value OR num &gt; 3`.<br/>
        /// - You can't use `NOT` with combinations of filters.<br/>
        ///   **Not supported:** `NOT(facet:value OR facet:value)`<br/>
        /// - You can't combine conjunctions (`AND`) with `OR`.<br/>
        ///   **Not supported:** `facet:value OR (facet:value AND facet:value)`<br/>
        /// Use quotes if the facet attribute name or facet value contains spaces, keywords (`OR`, `AND`, `NOT`), or quotes.<br/>
        /// If a facet attribute is an array, the filter matches if it matches at least one element of the array.<br/>
        /// For more information, see [Filters](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering).<br/>
        /// Example: (category:Book OR category:Ebook) AND _tags:published
        /// </param>
        /// <param name="optionalFilters">
        /// Filters to promote or demote records in the search results.<br/>
        /// Optional filters work like facet filters, but they don't exclude records from the search results.<br/>
        /// Records that match the optional filter rank before records that don't match.<br/>
        /// Matches with higher weights (`&lt;score=N&gt;`) rank before matches with lower weights.<br/>
        /// If you're using a negative filter `facet:-value`, matching records rank after records that don't match.<br/>
        /// Example: [category:books&lt;score=1&gt;, category:-movies&lt;score=1&gt;]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParamsConsequence(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.AutoFacetFilter>? automaticFacetFilters,
            string? filters,
            global::System.Collections.Generic.IList<string>? optionalFilters)
        {
            this.AutomaticFacetFilters = automaticFacetFilters;
            this.Filters = filters;
            this.OptionalFilters = optionalFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParamsConsequence" /> class.
        /// </summary>
        public ParamsConsequence()
        {
        }

    }
}