
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRecommendStatusResponse
    {
        /// <summary>
        /// Task status, `published` if the task is completed, `notPublished` otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.TaskStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.Recommend.TaskStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecommendStatusResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Task status, `published` if the task is completed, `notPublished` otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRecommendStatusResponse(
            global::Algolia.Recommend.TaskStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecommendStatusResponse" /> class.
        /// </summary>
        public GetRecommendStatusResponse()
        {
        }

    }
}