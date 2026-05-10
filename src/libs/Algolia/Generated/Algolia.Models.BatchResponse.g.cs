
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchResponse
    {
        /// <summary>
        /// Unique identifier of a task.<br/>
        /// A successful API response means that a task was added to a queue.<br/>
        /// It might not run immediately.<br/>
        /// You can check the task's progress with the [`task` operation](https://www.algolia.com/doc/rest-api/search/get-task) and this task ID.<br/>
        /// Example: 1514562690001
        /// </summary>
        /// <example>1514562690001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TaskID { get; set; }

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
        /// Initializes a new instance of the <see cref="BatchResponse" /> class.
        /// </summary>
        /// <param name="taskID">
        /// Unique identifier of a task.<br/>
        /// A successful API response means that a task was added to a queue.<br/>
        /// It might not run immediately.<br/>
        /// You can check the task's progress with the [`task` operation](https://www.algolia.com/doc/rest-api/search/get-task) and this task ID.<br/>
        /// Example: 1514562690001
        /// </param>
        /// <param name="objectIDs">
        /// Unique record identifiers.<br/>
        /// Example: [record-1, record-2]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchResponse(
            long taskID,
            global::System.Collections.Generic.IList<string> objectIDs)
        {
            this.TaskID = taskID;
            this.ObjectIDs = objectIDs ?? throw new global::System.ArgumentNullException(nameof(objectIDs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResponse" /> class.
        /// </summary>
        public BatchResponse()
        {
        }

    }
}