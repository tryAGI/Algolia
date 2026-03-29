
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Recommend request body.
    /// </summary>
    public sealed partial class GetRecommendationsRequest
    {
        /// <summary>
        /// Recommendation request with parameters depending on the requested model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendationsRequest> Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecommendationsRequest" /> class.
        /// </summary>
        /// <param name="requests">
        /// Recommendation request with parameters depending on the requested model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRecommendationsRequest(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendationsRequest> requests)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecommendationsRequest" /> class.
        /// </summary>
        public GetRecommendationsRequest()
        {
        }
    }
}