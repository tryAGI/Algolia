
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplaceAllObjectsWithTransformationResponse
    {
        /// <summary>
        /// Response, taskID, and update timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyOperationResponse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.UpdatedAtResponse CopyOperationResponse { get; set; }

        /// <summary>
        /// The response of the `push` request(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watchResponses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.WatchResponse> WatchResponses { get; set; }

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
        /// Initializes a new instance of the <see cref="ReplaceAllObjectsWithTransformationResponse" /> class.
        /// </summary>
        /// <param name="copyOperationResponse">
        /// Response, taskID, and update timestamp.
        /// </param>
        /// <param name="watchResponses">
        /// The response of the `push` request(s).
        /// </param>
        /// <param name="moveOperationResponse">
        /// Response, taskID, and update timestamp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceAllObjectsWithTransformationResponse(
            global::Algolia.UpdatedAtResponse copyOperationResponse,
            global::System.Collections.Generic.IList<global::Algolia.WatchResponse> watchResponses,
            global::Algolia.UpdatedAtResponse moveOperationResponse)
        {
            this.CopyOperationResponse = copyOperationResponse ?? throw new global::System.ArgumentNullException(nameof(copyOperationResponse));
            this.WatchResponses = watchResponses ?? throw new global::System.ArgumentNullException(nameof(watchResponses));
            this.MoveOperationResponse = moveOperationResponse ?? throw new global::System.ArgumentNullException(nameof(moveOperationResponse));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAllObjectsWithTransformationResponse" /> class.
        /// </summary>
        public ReplaceAllObjectsWithTransformationResponse()
        {
        }

    }
}