
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Parameters for the [Query Categorization](https://www.algolia.com/doc/guides/algolia-ai/query-categorization/) AI feature.
    /// </summary>
    public sealed partial class SearchExtensionsQueryCategorization
    {
        /// <summary>
        /// Whether to retrieve category predictions in the response `extensions.queryCategorization` field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableCategoriesRetrieval")]
        public bool? EnableCategoriesRetrieval { get; set; }

        /// <summary>
        /// Whether to automatically apply category-based filters and boosts to search results.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableAutoFiltering")]
        public bool? EnableAutoFiltering { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchExtensionsQueryCategorization" /> class.
        /// </summary>
        /// <param name="enableCategoriesRetrieval">
        /// Whether to retrieve category predictions in the response `extensions.queryCategorization` field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableAutoFiltering">
        /// Whether to automatically apply category-based filters and boosts to search results.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchExtensionsQueryCategorization(
            bool? enableCategoriesRetrieval,
            bool? enableAutoFiltering)
        {
            this.EnableCategoriesRetrieval = enableCategoriesRetrieval;
            this.EnableAutoFiltering = enableAutoFiltering;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchExtensionsQueryCategorization" /> class.
        /// </summary>
        public SearchExtensionsQueryCategorization()
        {
        }
    }
}