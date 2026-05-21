
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Request body for updating dictionary entries.
    /// </summary>
    public sealed partial class BatchDictionaryEntriesRequest
    {
        /// <summary>
        /// Whether to replace all custom entries in the dictionary with the ones sent with this request.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clearExistingDictionaryEntries")]
        public bool? ClearExistingDictionaryEntries { get; set; }

        /// <summary>
        /// List of additions and deletions to your dictionaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.BatchDictionaryEntriesRequestRequest> Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDictionaryEntriesRequest" /> class.
        /// </summary>
        /// <param name="requests">
        /// List of additions and deletions to your dictionaries.
        /// </param>
        /// <param name="clearExistingDictionaryEntries">
        /// Whether to replace all custom entries in the dictionary with the ones sent with this request.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDictionaryEntriesRequest(
            global::System.Collections.Generic.IList<global::Algolia.BatchDictionaryEntriesRequestRequest> requests,
            bool? clearExistingDictionaryEntries)
        {
            this.ClearExistingDictionaryEntries = clearExistingDictionaryEntries;
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDictionaryEntriesRequest" /> class.
        /// </summary>
        public BatchDictionaryEntriesRequest()
        {
        }

    }
}