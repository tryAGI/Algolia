
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WatchResponse
    {
        /// <summary>
        /// Universally unique identifier (UUID) of a task run.<br/>
        /// Example: 6c02aeb1-775e-418e-870b-1faccd4b2c0f
        /// </summary>
        /// <example>6c02aeb1-775e-418e-870b-1faccd4b2c0f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunID { get; set; }

        /// <summary>
        /// Universally unique identifier (UUID) of an event.<br/>
        /// Example: 6c02aeb1-775e-418e-870b-1faccd4b2c0f
        /// </summary>
        /// <example>6c02aeb1-775e-418e-870b-1faccd4b2c0f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventID")]
        public string? EventID { get; set; }

        /// <summary>
        /// This field is always null when used with the Push endpoint.<br/>
        /// When used for a source discover or source validate run, it will include the sampled data of the source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<object>? Data { get; set; }

        /// <summary>
        /// in case of error, observability events will be added to the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Algolia.Event>? Events { get; set; }

        /// <summary>
        /// a message describing the outcome of the operation that has been ran (push, discover or validate) run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Date and time when the resource was created, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatchResponse" /> class.
        /// </summary>
        /// <param name="runID">
        /// Universally unique identifier (UUID) of a task run.<br/>
        /// Example: 6c02aeb1-775e-418e-870b-1faccd4b2c0f
        /// </param>
        /// <param name="eventID">
        /// Universally unique identifier (UUID) of an event.<br/>
        /// Example: 6c02aeb1-775e-418e-870b-1faccd4b2c0f
        /// </param>
        /// <param name="data">
        /// This field is always null when used with the Push endpoint.<br/>
        /// When used for a source discover or source validate run, it will include the sampled data of the source.
        /// </param>
        /// <param name="events">
        /// in case of error, observability events will be added to the response.
        /// </param>
        /// <param name="message">
        /// a message describing the outcome of the operation that has been ran (push, discover or validate) run.
        /// </param>
        /// <param name="createdAt">
        /// Date and time when the resource was created, in RFC 3339 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatchResponse(
            string runID,
            string? eventID,
            global::System.Collections.Generic.IList<object>? data,
            global::System.Collections.Generic.IList<global::Algolia.Event>? events,
            string? message,
            string? createdAt)
        {
            this.RunID = runID ?? throw new global::System.ArgumentNullException(nameof(runID));
            this.EventID = eventID;
            this.Data = data;
            this.Events = events;
            this.Message = message;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatchResponse" /> class.
        /// </summary>
        public WatchResponse()
        {
        }

    }
}