
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Records to promote.
    /// </summary>
    public sealed partial class PromoteObjectIDs
    {
        /// <summary>
        /// Object IDs of the records you want to promote.<br/>
        /// The records are placed as a group at the `position`.<br/>
        /// For example, if you want to promote four records to position `0`,<br/>
        /// they will be the first four search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectIDs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ObjectIDs { get; set; }

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
        /// Initializes a new instance of the <see cref="PromoteObjectIDs" /> class.
        /// </summary>
        /// <param name="objectIDs">
        /// Object IDs of the records you want to promote.<br/>
        /// The records are placed as a group at the `position`.<br/>
        /// For example, if you want to promote four records to position `0`,<br/>
        /// they will be the first four search results.
        /// </param>
        /// <param name="position">
        /// Position in the search results where you want to show the promoted records.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteObjectIDs(
            global::System.Collections.Generic.IList<string> objectIDs,
            int position)
        {
            this.ObjectIDs = objectIDs ?? throw new global::System.ArgumentNullException(nameof(objectIDs));
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteObjectIDs" /> class.
        /// </summary>
        public PromoteObjectIDs()
        {
        }
    }
}