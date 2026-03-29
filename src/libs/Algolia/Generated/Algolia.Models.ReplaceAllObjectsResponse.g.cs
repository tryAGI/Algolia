
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplaceAllObjectsResponse
    {
        /// <summary>
        /// Response, taskID, and update timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyOperationResponse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.UpdatedAtResponse CopyOperationResponse { get; set; }

        /// <summary>
        /// The response of the `batch` request(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchResponses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.BatchResponse> BatchResponses { get; set; }

        /// <summary>
        /// Response, taskID, and update timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moveOperationResponse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.UpdatedAtResponse MoveOperationResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAllObjectsResponse" /> class.
        /// </summary>
        /// <param name="copyOperationResponse">
        /// Response, taskID, and update timestamp.
        /// </param>
        /// <param name="batchResponses">
        /// The response of the `batch` request(s).
        /// </param>
        /// <param name="moveOperationResponse">
        /// Response, taskID, and update timestamp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceAllObjectsResponse(
            global::Algolia.UpdatedAtResponse copyOperationResponse,
            global::System.Collections.Generic.IList<global::Algolia.BatchResponse> batchResponses,
            global::Algolia.UpdatedAtResponse moveOperationResponse)
        {
            this.CopyOperationResponse = copyOperationResponse ?? throw new global::System.ArgumentNullException(nameof(copyOperationResponse));
            this.BatchResponses = batchResponses ?? throw new global::System.ArgumentNullException(nameof(batchResponses));
            this.MoveOperationResponse = moveOperationResponse ?? throw new global::System.ArgumentNullException(nameof(moveOperationResponse));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAllObjectsResponse" /> class.
        /// </summary>
        public ReplaceAllObjectsResponse()
        {
        }
    }
}