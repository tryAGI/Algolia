
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Object ID and position of the recommendation you want to pin.
    /// </summary>
    public sealed partial class PromoteConsequenceObject
    {
        /// <summary>
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </summary>
        /// <example>test-record-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        public string? ObjectID { get; set; }

        /// <summary>
        /// Index in the list of recommendations where to place this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteConsequenceObject" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="position">
        /// Index in the list of recommendations where to place this item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteConsequenceObject(
            string? objectID,
            int? position)
        {
            this.ObjectID = objectID;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteConsequenceObject" /> class.
        /// </summary>
        public PromoteConsequenceObject()
        {
        }

    }
}