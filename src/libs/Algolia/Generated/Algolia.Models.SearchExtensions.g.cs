
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Additional parameters for Algolia AI features.<br/>
    /// Used to enable [Query Categorization](https://www.algolia.com/doc/guides/algolia-ai/query-categorization/) and other AI-powered capabilities.
    /// </summary>
    public sealed partial class SearchExtensions
    {
        /// <summary>
        /// Parameters for the [Query Categorization](https://www.algolia.com/doc/guides/algolia-ai/query-categorization/) AI feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryCategorization")]
        public global::Algolia.SearchExtensionsQueryCategorization? QueryCategorization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchExtensions" /> class.
        /// </summary>
        /// <param name="queryCategorization">
        /// Parameters for the [Query Categorization](https://www.algolia.com/doc/guides/algolia-ai/query-categorization/) AI feature.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchExtensions(
            global::Algolia.SearchExtensionsQueryCategorization? queryCategorization)
        {
            this.QueryCategorization = queryCategorization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchExtensions" /> class.
        /// </summary>
        public SearchExtensions()
        {
        }
    }
}