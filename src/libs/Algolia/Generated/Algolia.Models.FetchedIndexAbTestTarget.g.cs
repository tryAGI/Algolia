
#nullable enable

namespace Algolia
{
    /// <summary>
    /// A/B test target criteria. Only present for v2 and later tests.
    /// </summary>
    public sealed partial class FetchedIndexAbTestTarget
    {
        /// <summary>
        /// Index name to match. Use `*` to target the entire application.<br/>
        /// Example: movies
        /// </summary>
        /// <example>movies</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchedIndexAbTestTarget" /> class.
        /// </summary>
        /// <param name="indexName">
        /// Index name to match. Use `*` to target the entire application.<br/>
        /// Example: movies
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FetchedIndexAbTestTarget(
            string indexName)
        {
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchedIndexAbTestTarget" /> class.
        /// </summary>
        public FetchedIndexAbTestTarget()
        {
        }

    }
}