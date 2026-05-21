
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Query Categorization prediction returned by the AI model.<br/>
    /// This field is empty when the model cannot categorize the query.<br/>
    /// See [Query Categorization](https://www.algolia.com/doc/guides/algolia-ai/query-categorization/).
    /// </summary>
    public sealed partial class QueryCategorization
    {
        /// <summary>
        /// Processed and normalized version of the original search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalizedQuery")]
        public string? NormalizedQuery { get; set; }

        /// <summary>
        /// Number of times this normalized query was observed during the training window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Classification of the query scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.QueryCategorizationTypeJsonConverter))]
        public global::Algolia.QueryCategorizationType? Type { get; set; }

        /// <summary>
        /// List of category predictions with confidence levels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<global::Algolia.CategoryPrediction>? Categories { get; set; }

        /// <summary>
        /// Result of automatic filtering applied by Query Categorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autofiltering")]
        public global::Algolia.AutoFilteringResult? Autofiltering { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCategorization" /> class.
        /// </summary>
        /// <param name="normalizedQuery">
        /// Processed and normalized version of the original search query.
        /// </param>
        /// <param name="count">
        /// Number of times this normalized query was observed during the training window.
        /// </param>
        /// <param name="type">
        /// Classification of the query scope.
        /// </param>
        /// <param name="categories">
        /// List of category predictions with confidence levels.
        /// </param>
        /// <param name="autofiltering">
        /// Result of automatic filtering applied by Query Categorization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryCategorization(
            string? normalizedQuery,
            int? count,
            global::Algolia.QueryCategorizationType? type,
            global::System.Collections.Generic.IList<global::Algolia.CategoryPrediction>? categories,
            global::Algolia.AutoFilteringResult? autofiltering)
        {
            this.NormalizedQuery = normalizedQuery;
            this.Count = count;
            this.Type = type;
            this.Categories = categories;
            this.Autofiltering = autofiltering;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCategorization" /> class.
        /// </summary>
        public QueryCategorization()
        {
        }

    }
}