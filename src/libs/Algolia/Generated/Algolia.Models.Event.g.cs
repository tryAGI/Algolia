
#nullable enable

namespace Algolia
{
    /// <summary>
    /// An event describe a step of the task execution flow.
    /// </summary>
    public sealed partial class Event
    {
        /// <summary>
        /// Universally unique identifier (UUID) of an event.<br/>
        /// Example: 6c02aeb1-775e-418e-870b-1faccd4b2c0f
        /// </summary>
        /// <example>6c02aeb1-775e-418e-870b-1faccd4b2c0f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventID { get; set; }

        /// <summary>
        /// Universally unique identifier (UUID) of a task run.<br/>
        /// Example: 6c02aeb1-775e-418e-870b-1faccd4b2c0f
        /// </summary>
        /// <example>6c02aeb1-775e-418e-870b-1faccd4b2c0f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.EventStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.EventStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.EventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.EventType Type { get; set; }

        /// <summary>
        /// The extracted record batch size.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Date and time when the resource was published, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="eventID">
        /// Universally unique identifier (UUID) of an event.<br/>
        /// Example: 6c02aeb1-775e-418e-870b-1faccd4b2c0f
        /// </param>
        /// <param name="runID">
        /// Universally unique identifier (UUID) of a task run.<br/>
        /// Example: 6c02aeb1-775e-418e-870b-1faccd4b2c0f
        /// </param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="batchSize">
        /// The extracted record batch size.<br/>
        /// Example: 10
        /// </param>
        /// <param name="publishedAt">
        /// Date and time when the resource was published, in RFC 3339 format.
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Event(
            string eventID,
            string runID,
            global::Algolia.EventStatus status,
            global::Algolia.EventType type,
            int batchSize,
            string publishedAt,
            object? data)
        {
            this.EventID = eventID ?? throw new global::System.ArgumentNullException(nameof(eventID));
            this.RunID = runID ?? throw new global::System.ArgumentNullException(nameof(runID));
            this.Status = status;
            this.Type = type;
            this.BatchSize = batchSize;
            this.Data = data;
            this.PublishedAt = publishedAt ?? throw new global::System.ArgumentNullException(nameof(publishedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        public Event()
        {
        }
    }
}