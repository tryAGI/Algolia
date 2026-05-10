
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Record to promote.
    /// </summary>
    public sealed partial class PromoteObjectID
    {
        /// <summary>
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </summary>
        /// <example>test-record-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectID { get; set; }

        /// <summary>
        /// Position in the search results where you want to show the promoted records.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteObjectID" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="position">
        /// Position in the search results where you want to show the promoted records.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteObjectID(
            string objectID,
            int position)
        {
            this.ObjectID = objectID ?? throw new global::System.ArgumentNullException(nameof(objectID));
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteObjectID" /> class.
        /// </summary>
        public PromoteObjectID()
        {
        }

    }
}