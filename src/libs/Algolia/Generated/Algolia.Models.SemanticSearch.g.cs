
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Settings for the semantic search part of NeuralSearch.<br/>
    /// Only used when `mode` is `neuralSearch`.
    /// </summary>
    public sealed partial class SemanticSearch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventSources")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, object>))]
        public global::Algolia.OneOf<global::System.Collections.Generic.IList<string>, object>? EventSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticSearch" /> class.
        /// </summary>
        /// <param name="eventSources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SemanticSearch(
            global::Algolia.OneOf<global::System.Collections.Generic.IList<string>, object>? eventSources)
        {
            this.EventSources = eventSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticSearch" /> class.
        /// </summary>
        public SemanticSearch()
        {
        }

    }
}