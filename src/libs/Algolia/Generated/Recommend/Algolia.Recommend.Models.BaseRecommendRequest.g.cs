
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseRecommendRequest
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
        /// Minimum score a recommendation must have to be included in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        /// Maximum number of recommendations to retrieve.<br/>
        /// By default, all recommendations are returned and no fallback request is made.<br/>
        /// Depending on the available recommendations and the other request parameters,<br/>
        /// the actual number of recommendations may be lower than this value.<br/>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRecommendations")]
        public int? MaxRecommendations { get; set; }

        /// <summary>
        /// Search parameters for filtering the recommendations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryParameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.RecommendSearchParamsJsonConverter))]
        public global::Algolia.Recommend.RecommendSearchParams? QueryParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRecommendRequest" /> class.
        /// </summary>
        /// <param name="indexName">
        /// Index name (case-sensitive).<br/>
        /// Example: products
        /// </param>
        /// <param name="threshold">
        /// Minimum score a recommendation must have to be included in the response.
        /// </param>
        /// <param name="maxRecommendations">
        /// Maximum number of recommendations to retrieve.<br/>
        /// By default, all recommendations are returned and no fallback request is made.<br/>
        /// Depending on the available recommendations and the other request parameters,<br/>
        /// the actual number of recommendations may be lower than this value.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="queryParameters">
        /// Search parameters for filtering the recommendations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseRecommendRequest(
            string indexName,
            double threshold,
            int? maxRecommendations,
            global::Algolia.Recommend.RecommendSearchParams? queryParameters)
        {
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.Threshold = threshold;
            this.MaxRecommendations = maxRecommendations;
            this.QueryParameters = queryParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRecommendRequest" /> class.
        /// </summary>
        public BaseRecommendRequest()
        {
        }
    }
}