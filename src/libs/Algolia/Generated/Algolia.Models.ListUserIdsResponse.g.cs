
#nullable enable

namespace Algolia
{
    /// <summary>
    /// User ID data.
    /// </summary>
    public sealed partial class ListUserIdsResponse
    {
        /// <summary>
        /// User IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIDs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.UserId> UserIDs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListUserIdsResponse" /> class.
        /// </summary>
        /// <param name="userIDs">
        /// User IDs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListUserIdsResponse(
            global::System.Collections.Generic.IList<global::Algolia.UserId> userIDs)
        {
            this.UserIDs = userIDs ?? throw new global::System.ArgumentNullException(nameof(userIDs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListUserIdsResponse" /> class.
        /// </summary>
        public ListUserIdsResponse()
        {
        }
    }
}