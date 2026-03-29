
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchDictionaryEntriesRequestRequest
    {
        /// <summary>
        /// Actions to perform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.DictionaryActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.DictionaryAction Action { get; set; }

        /// <summary>
        /// Dictionary entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.DictionaryEntry Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDictionaryEntriesRequestRequest" /> class.
        /// </summary>
        /// <param name="action">
        /// Actions to perform.
        /// </param>
        /// <param name="body">
        /// Dictionary entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDictionaryEntriesRequestRequest(
            global::Algolia.DictionaryAction action,
            global::Algolia.DictionaryEntry body)
        {
            this.Action = action;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDictionaryEntriesRequestRequest" /> class.
        /// </summary>
        public BatchDictionaryEntriesRequestRequest()
        {
        }
    }
}