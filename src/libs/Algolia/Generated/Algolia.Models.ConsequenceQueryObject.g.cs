
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsequenceQueryObject
    {
        /// <summary>
        /// Words to remove from the search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove")]
        public global::System.Collections.Generic.IList<string>? Remove { get; set; }

        /// <summary>
        /// Changes to make to the search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edits")]
        public global::System.Collections.Generic.IList<global::Algolia.Edit>? Edits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsequenceQueryObject" /> class.
        /// </summary>
        /// <param name="remove">
        /// Words to remove from the search query.
        /// </param>
        /// <param name="edits">
        /// Changes to make to the search query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsequenceQueryObject(
            global::System.Collections.Generic.IList<string>? remove,
            global::System.Collections.Generic.IList<global::Algolia.Edit>? edits)
        {
            this.Remove = remove;
            this.Edits = edits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsequenceQueryObject" /> class.
        /// </summary>
        public ConsequenceQueryObject()
        {
        }

    }
}