
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Redirect to a virtual replica index.<br/>
    /// This consequence is only valid for rules with `scope: redirect`.
    /// </summary>
    public sealed partial class ConsequenceRedirect
    {
        /// <summary>
        /// Name of the virtual replica index to redirect searches to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsequenceRedirect" /> class.
        /// </summary>
        /// <param name="indexName">
        /// Name of the virtual replica index to redirect searches to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsequenceRedirect(
            string indexName)
        {
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsequenceRedirect" /> class.
        /// </summary>
        public ConsequenceRedirect()
        {
        }

    }
}