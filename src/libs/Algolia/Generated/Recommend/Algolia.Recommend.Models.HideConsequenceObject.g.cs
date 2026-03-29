
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Object ID of the recommendation you want to exclude.
    /// </summary>
    public sealed partial class HideConsequenceObject
    {
        /// <summary>
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </summary>
        /// <example>test-record-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        public string? ObjectID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HideConsequenceObject" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HideConsequenceObject(
            string? objectID)
        {
            this.ObjectID = objectID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HideConsequenceObject" /> class.
        /// </summary>
        public HideConsequenceObject()
        {
        }
    }
}