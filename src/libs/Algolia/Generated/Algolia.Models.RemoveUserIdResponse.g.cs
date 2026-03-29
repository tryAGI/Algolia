
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveUserIdResponse
    {
        /// <summary>
        /// Date and time when the object was deleted, in RFC 3339 format.<br/>
        /// Example: 2023-06-27T14:42:38.831Z
        /// </summary>
        /// <example>2023-06-27T14:42:38.831Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveUserIdResponse" /> class.
        /// </summary>
        /// <param name="deletedAt">
        /// Date and time when the object was deleted, in RFC 3339 format.<br/>
        /// Example: 2023-06-27T14:42:38.831Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveUserIdResponse(
            string deletedAt)
        {
            this.DeletedAt = deletedAt ?? throw new global::System.ArgumentNullException(nameof(deletedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveUserIdResponse" /> class.
        /// </summary>
        public RemoveUserIdResponse()
        {
        }
    }
}