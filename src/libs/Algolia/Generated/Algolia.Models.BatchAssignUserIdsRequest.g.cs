
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Assign userID parameters.
    /// </summary>
    public sealed partial class BatchAssignUserIdsRequest
    {
        /// <summary>
        /// Cluster name.<br/>
        /// Example: c11-test
        /// </summary>
        /// <example>c11-test</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cluster { get; set; }

        /// <summary>
        /// User IDs to assign.<br/>
        /// Example: [einstein, bohr, feynman]
        /// </summary>
        /// <example>[einstein, bohr, feynman]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchAssignUserIdsRequest" /> class.
        /// </summary>
        /// <param name="cluster">
        /// Cluster name.<br/>
        /// Example: c11-test
        /// </param>
        /// <param name="users">
        /// User IDs to assign.<br/>
        /// Example: [einstein, bohr, feynman]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchAssignUserIdsRequest(
            string cluster,
            global::System.Collections.Generic.IList<string> users)
        {
            this.Cluster = cluster ?? throw new global::System.ArgumentNullException(nameof(cluster));
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchAssignUserIdsRequest" /> class.
        /// </summary>
        public BatchAssignUserIdsRequest()
        {
        }

    }
}