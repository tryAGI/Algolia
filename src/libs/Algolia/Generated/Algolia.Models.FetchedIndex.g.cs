
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FetchedIndex
    {
        /// <summary>
        /// Index name.<br/>
        /// Example: movies
        /// </summary>
        /// <example>movies</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Index creation date. An empty string means that the index has no records.<br/>
        /// Example: 2022-09-19T16:36:44.471Z
        /// </summary>
        /// <example>2022-09-19T16:36:44.471Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Date and time when the object was updated, in RFC 3339 format.<br/>
        /// Example: 2023-07-04T12:49:15Z
        /// </summary>
        /// <example>2023-07-04T12:49:15Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Number of records contained in the index.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Entries { get; set; }

        /// <summary>
        /// Number of bytes of the index in minified format.<br/>
        /// Example: 48450
        /// </summary>
        /// <example>48450</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DataSize { get; set; }

        /// <summary>
        /// Number of bytes of the index binary file.<br/>
        /// Example: 112927
        /// </summary>
        /// <example>112927</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FileSize { get; set; }

        /// <summary>
        /// Last build time.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastBuildTimeS")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastBuildTimeS { get; set; }

        /// <summary>
        /// Number of pending indexing operations. This value is deprecated and should not be used.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfPendingTasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfPendingTasks { get; set; }

        /// <summary>
        /// A boolean which says whether the index has pending tasks. This value is deprecated and should not be used.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingTask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PendingTask { get; set; }

        /// <summary>
        /// Only present if the index is a replica. Contains the name of the related primary index.<br/>
        /// Example: T02
        /// </summary>
        /// <example>T02</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public string? Primary { get; set; }

        /// <summary>
        /// Only present if the index is a primary index with replicas. Contains the names of all linked replicas.<br/>
        /// Example: [T02_push, T2replica]
        /// </summary>
        /// <example>[T02_push, T2replica]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public global::System.Collections.Generic.IList<string>? Replicas { get; set; }

        /// <summary>
        /// Only present if the index is a [virtual replica](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/how-to/sort-an-index-alphabetically/#virtual-replicas).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtual")]
        public bool? Virtual { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchedIndex" /> class.
        /// </summary>
        /// <param name="name">
        /// Index name.<br/>
        /// Example: movies
        /// </param>
        /// <param name="createdAt">
        /// Index creation date. An empty string means that the index has no records.<br/>
        /// Example: 2022-09-19T16:36:44.471Z
        /// </param>
        /// <param name="updatedAt">
        /// Date and time when the object was updated, in RFC 3339 format.<br/>
        /// Example: 2023-07-04T12:49:15Z
        /// </param>
        /// <param name="entries">
        /// Number of records contained in the index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="dataSize">
        /// Number of bytes of the index in minified format.<br/>
        /// Example: 48450
        /// </param>
        /// <param name="fileSize">
        /// Number of bytes of the index binary file.<br/>
        /// Example: 112927
        /// </param>
        /// <param name="lastBuildTimeS">
        /// Last build time.<br/>
        /// Example: 3
        /// </param>
        /// <param name="numberOfPendingTasks">
        /// Number of pending indexing operations. This value is deprecated and should not be used.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="pendingTask">
        /// A boolean which says whether the index has pending tasks. This value is deprecated and should not be used.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="primary">
        /// Only present if the index is a replica. Contains the name of the related primary index.<br/>
        /// Example: T02
        /// </param>
        /// <param name="replicas">
        /// Only present if the index is a primary index with replicas. Contains the names of all linked replicas.<br/>
        /// Example: [T02_push, T2replica]
        /// </param>
        /// <param name="virtual">
        /// Only present if the index is a [virtual replica](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/how-to/sort-an-index-alphabetically/#virtual-replicas).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FetchedIndex(
            string name,
            string createdAt,
            string updatedAt,
            int entries,
            long dataSize,
            long fileSize,
            int lastBuildTimeS,
            int numberOfPendingTasks,
            bool pendingTask,
            string? primary,
            global::System.Collections.Generic.IList<string>? replicas,
            bool? @virtual)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Entries = entries;
            this.DataSize = dataSize;
            this.FileSize = fileSize;
            this.LastBuildTimeS = lastBuildTimeS;
            this.NumberOfPendingTasks = numberOfPendingTasks;
            this.PendingTask = pendingTask;
            this.Primary = primary;
            this.Replicas = replicas;
            this.Virtual = @virtual;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchedIndex" /> class.
        /// </summary>
        public FetchedIndex()
        {
        }

    }
}