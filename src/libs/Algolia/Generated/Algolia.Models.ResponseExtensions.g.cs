
#nullable enable

namespace Algolia
{
    /// <summary>
    /// AI-generated metadata returned alongside search results.<br/>
    /// Present when Algolia AI features such as [Query Categorization](https://www.algolia.com/doc/guides/algolia-ai/query-categorization/) are enabled.
    /// </summary>
    public sealed partial class ResponseExtensions
    {
        /// <summary>
        /// Query Categorization prediction returned by the AI model.<br/>
        /// This field is empty when the model cannot categorize the query.<br/>
        /// See [Query Categorization](https://www.algolia.com/doc/guides/algolia-ai/query-categorization/).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryCategorization")]
        public global::Algolia.QueryCategorization? QueryCategorization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseExtensions" /> class.
        /// </summary>
        /// <param name="queryCategorization">
        /// Query Categorization prediction returned by the AI model.<br/>
        /// This field is empty when the model cannot categorize the query.<br/>
        /// See [Query Categorization](https://www.algolia.com/doc/guides/algolia-ai/query-categorization/).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseExtensions(
            global::Algolia.QueryCategorization? queryCategorization)
        {
            this.QueryCategorization = queryCategorization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseExtensions" /> class.
        /// </summary>
        public ResponseExtensions()
        {
        }
    }
}