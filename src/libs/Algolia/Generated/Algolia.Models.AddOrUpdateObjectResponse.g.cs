
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Response, taskID, unique object identifier, and an update timestamp.
    /// </summary>
    public sealed partial class AddOrUpdateObjectResponse
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
        public long? TaskID { get; set; }

        /// <summary>
        /// Date and time when the object was updated, in RFC 3339 format.<br/>
        /// Example: 2023-07-04T12:49:15Z
        /// </summary>
        /// <example>2023-07-04T12:49:15Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </summary>
        /// <example>test-record-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        public string? ObjectID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrUpdateObjectResponse" /> class.
        /// </summary>
        /// <param name="taskID">
        /// Unique identifier of a task.<br/>
        /// A successful API response means that a task was added to a queue.<br/>
        /// It might not run immediately.<br/>
        /// You can check the task's progress with the [`task` operation](https://www.algolia.com/doc/rest-api/search/get-task) and this task ID.<br/>
        /// Example: 1514562690001
        /// </param>
        /// <param name="updatedAt">
        /// Date and time when the object was updated, in RFC 3339 format.<br/>
        /// Example: 2023-07-04T12:49:15Z
        /// </param>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddOrUpdateObjectResponse(
            long? taskID,
            string? updatedAt,
            string? objectID)
        {
            this.TaskID = taskID;
            this.UpdatedAt = updatedAt;
            this.ObjectID = objectID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrUpdateObjectResponse" /> class.
        /// </summary>
        public AddOrUpdateObjectResponse()
        {
        }
    }
}