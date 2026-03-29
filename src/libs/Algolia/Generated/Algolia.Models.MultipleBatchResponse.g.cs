
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipleBatchResponse
    {
        /// <summary>
        /// Task IDs. One for each index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, long> TaskID { get; set; }

        /// <summary>
        /// Unique record identifiers.<br/>
        /// Example: [record-1, record-2]
        /// </summary>
        /// <example>[record-1, record-2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectIDs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ObjectIDs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleBatchResponse" /> class.
        /// </summary>
        /// <param name="taskID">
        /// Task IDs. One for each index.
        /// </param>
        /// <param name="objectIDs">
        /// Unique record identifiers.<br/>
        /// Example: [record-1, record-2]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultipleBatchResponse(
            global::System.Collections.Generic.Dictionary<string, long> taskID,
            global::System.Collections.Generic.IList<string> objectIDs)
        {
            this.TaskID = taskID ?? throw new global::System.ArgumentNullException(nameof(taskID));
            this.ObjectIDs = objectIDs ?? throw new global::System.ArgumentNullException(nameof(objectIDs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleBatchResponse" /> class.
        /// </summary>
        public MultipleBatchResponse()
        {
        }
    }
}