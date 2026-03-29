
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchForHitsSettings
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
        /// - `default`: perform a search query<br/>
        /// - `facet` [searches for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.SearchTypeDefaultJsonConverter))]
        public global::Algolia.SearchTypeDefault? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForHitsSettings" /> class.
        /// </summary>
        /// <param name="indexName">
        /// Index name (case-sensitive).<br/>
        /// Example: products
        /// </param>
        /// <param name="type">
        /// - `default`: perform a search query<br/>
        /// - `facet` [searches for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
        /// Default Value: default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchForHitsSettings(
            string indexName,
            global::Algolia.SearchTypeDefault? type)
        {
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForHitsSettings" /> class.
        /// </summary>
        public SearchForHitsSettings()
        {
        }
    }
}