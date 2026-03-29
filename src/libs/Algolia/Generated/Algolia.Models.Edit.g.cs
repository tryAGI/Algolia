
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Edit
    {
        /// <summary>
        /// Type of edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.EditTypeJsonConverter))]
        public global::Algolia.EditType? Type { get; set; }

        /// <summary>
        /// Text or patterns to remove from the query string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete")]
        public string? Delete { get; set; }

        /// <summary>
        /// Text to be added in place of the deleted text inside the query string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert")]
        public string? Insert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Edit" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of edit.
        /// </param>
        /// <param name="delete">
        /// Text or patterns to remove from the query string.
        /// </param>
        /// <param name="insert">
        /// Text to be added in place of the deleted text inside the query string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Edit(
            global::Algolia.EditType? type,
            string? delete,
            string? insert)
        {
            this.Type = type;
            this.Delete = delete;
            this.Insert = insert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Edit" /> class.
        /// </summary>
        public Edit()
        {
        }
    }
}