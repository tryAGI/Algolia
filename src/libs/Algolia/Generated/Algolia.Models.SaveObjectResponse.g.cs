
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveObjectResponse
    {
        /// <summary>
        /// Date and time when the object was created, in RFC 3339 format.<br/>
        /// Example: 2023-07-04T12:49:15Z
        /// </summary>
        /// <example>2023-07-04T12:49:15Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="SaveObjectResponse" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Date and time when the object was created, in RFC 3339 format.<br/>
        /// Example: 2023-07-04T12:49:15Z
        /// </param>
        /// <param name="taskID">
        /// Unique identifier of a task.<br/>
        /// A successful API response means that a task was added to a queue.<br/>
        /// It might not run immediately.<br/>
        /// You can check the task's progress with the [`task` operation](https://www.algolia.com/doc/rest-api/search/get-task) and this task ID.<br/>
        /// Example: 1514562690001
        /// </param>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveObjectResponse(
            string createdAt,
            long taskID,
            string? objectID)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.TaskID = taskID;
            this.ObjectID = objectID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveObjectResponse" /> class.
        /// </summary>
        public SaveObjectResponse()
        {
        }

    }
}