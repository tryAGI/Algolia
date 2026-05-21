
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WithPrimary
    {
        /// <summary>
        /// Replica indices only: the name of the primary index for this replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        public string? Primary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WithPrimary" /> class.
        /// </summary>
        /// <param name="primary">
        /// Replica indices only: the name of the primary index for this replica.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WithPrimary(
            string? primary)
        {
            this.Primary = primary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WithPrimary" /> class.
        /// </summary>
        public WithPrimary()
        {
        }

    }
}