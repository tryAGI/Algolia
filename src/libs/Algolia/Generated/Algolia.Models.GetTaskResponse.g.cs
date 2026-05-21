
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTaskResponse
    {
        /// <summary>
        /// Task status, `published` if the task is completed, `notPublished` otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.TaskStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.TaskStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTaskResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Task status, `published` if the task is completed, `notPublished` otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTaskResponse(
            global::Algolia.TaskStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTaskResponse" /> class.
        /// </summary>
        public GetTaskResponse()
        {
        }

    }
}