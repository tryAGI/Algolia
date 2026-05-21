
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Response, taskID, and deletion timestamp.
    /// </summary>
    public sealed partial class DeleteSynonymResponse
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
        /// Date and time when the object was deleted, in RFC 3339 format.<br/>
        /// Example: 2023-06-27T14:42:38.831Z
        /// </summary>
        /// <example>2023-06-27T14:42:38.831Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSynonymResponse" /> class.
        /// </summary>
        /// <param name="taskID">
        /// Unique identifier of a task.<br/>
        /// A successful API response means that a task was added to a queue.<br/>
        /// It might not run immediately.<br/>
        /// You can check the task's progress with the [`task` operation](https://www.algolia.com/doc/rest-api/search/get-task) and this task ID.<br/>
        /// Example: 1514562690001
        /// </param>
        /// <param name="deletedAt">
        /// Date and time when the object was deleted, in RFC 3339 format.<br/>
        /// Example: 2023-06-27T14:42:38.831Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteSynonymResponse(
            long taskID,
            string deletedAt)
        {
            this.TaskID = taskID;
            this.DeletedAt = deletedAt ?? throw new global::System.ArgumentNullException(nameof(deletedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSynonymResponse" /> class.
        /// </summary>
        public DeleteSynonymResponse()
        {
        }

    }
}