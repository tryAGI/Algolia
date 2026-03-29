
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Parameters to apply to this search.<br/>
    /// You can use all search parameters, plus special `automaticFacetFilters`, `automaticOptionalFacetFilters`, and `query`.
    /// </summary>
    public sealed partial class Params
    {
        /// <summary>
        /// Replace or edit the search query.<br/>
        /// If `consequenceQuery` is a string, the entire search query is replaced with that string.<br/>
        /// If `consequenceQuery` is an object, it describes incremental edits made to the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.ConsequenceQueryJsonConverter))]
        public global::Algolia.ConsequenceQuery? Query { get; set; }

        /// <summary>
        /// Filter to be applied to the search.<br/>
        /// You can use this to respond to search queries that match a facet value.<br/>
        /// For example, if users search for "comedy", which matches a facet value of the "genre" facet,<br/>
        /// you can filter the results to show the top-ranked comedy movies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticFacetFilters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.AutomaticFacetFiltersJsonConverter))]
        public global::Algolia.AutomaticFacetFilters? AutomaticFacetFilters { get; set; }

        /// <summary>
        /// Filter to be applied to the search.<br/>
        /// You can use this to respond to search queries that match a facet value.<br/>
        /// For example, if users search for "comedy", which matches a facet value of the "genre" facet,<br/>
        /// you can filter the results to show the top-ranked comedy movies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticOptionalFacetFilters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.AutomaticFacetFiltersJsonConverter))]
        public global::Algolia.AutomaticFacetFilters? AutomaticOptionalFacetFilters { get; set; }

        /// <summary>
        /// Extra data that can be used in the search UI.<br/>
        /// You can use this to control aspects of your search UI, such as the order of facet names and values<br/>
        /// without changing your frontend code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renderingContent")]
        public global::Algolia.RenderingContent? RenderingContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Params" /> class.
        /// </summary>
        /// <param name="query">
        /// Replace or edit the search query.<br/>
        /// If `consequenceQuery` is a string, the entire search query is replaced with that string.<br/>
        /// If `consequenceQuery` is an object, it describes incremental edits made to the query.
        /// </param>
        /// <param name="automaticFacetFilters">
        /// Filter to be applied to the search.<br/>
        /// You can use this to respond to search queries that match a facet value.<br/>
        /// For example, if users search for "comedy", which matches a facet value of the "genre" facet,<br/>
        /// you can filter the results to show the top-ranked comedy movies.
        /// </param>
        /// <param name="automaticOptionalFacetFilters">
        /// Filter to be applied to the search.<br/>
        /// You can use this to respond to search queries that match a facet value.<br/>
        /// For example, if users search for "comedy", which matches a facet value of the "genre" facet,<br/>
        /// you can filter the results to show the top-ranked comedy movies.
        /// </param>
        /// <param name="renderingContent">
        /// Extra data that can be used in the search UI.<br/>
        /// You can use this to control aspects of your search UI, such as the order of facet names and values<br/>
        /// without changing your frontend code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Params(
            global::Algolia.ConsequenceQuery? query,
            global::Algolia.AutomaticFacetFilters? automaticFacetFilters,
            global::Algolia.AutomaticFacetFilters? automaticOptionalFacetFilters,
            global::Algolia.RenderingContent? renderingContent)
        {
            this.Query = query;
            this.AutomaticFacetFilters = automaticFacetFilters;
            this.AutomaticOptionalFacetFilters = automaticOptionalFacetFilters;
            this.RenderingContent = renderingContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Params" /> class.
        /// </summary>
        public Params()
        {
        }
    }
}