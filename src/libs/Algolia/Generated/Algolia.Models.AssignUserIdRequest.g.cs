
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Assign userID parameters.
    /// </summary>
    public sealed partial class AssignUserIdRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignUserIdRequest" /> class.
        /// </summary>
        /// <param name="cluster">
        /// Cluster name.<br/>
        /// Example: c11-test
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignUserIdRequest(
            string cluster)
        {
            this.Cluster = cluster ?? throw new global::System.ArgumentNullException(nameof(cluster));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignUserIdRequest" /> class.
        /// </summary>
        public AssignUserIdRequest()
        {
        }

    }
}