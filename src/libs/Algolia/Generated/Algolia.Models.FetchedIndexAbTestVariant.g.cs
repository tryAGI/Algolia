
#nullable enable

namespace Algolia
{
    /// <summary>
    /// A/B test variant for an index.
    /// </summary>
    public sealed partial class FetchedIndexAbTestVariant
    {
        /// <summary>
        /// Index name of the variant. Only present for v0/v1 tests; in v2 this moves into `payload`.<br/>
        /// Example: movies
        /// </summary>
        /// <example>movies</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexName")]
        public string? IndexName { get; set; }

        /// <summary>
        /// Percentage of search traffic routed to this variant.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Percentage { get; set; }

        /// <summary>
        /// URL-encoded custom search parameters applied to this variant. Only present for v0/v1 tests; in v2 this moves into `payload`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customSearchParameters")]
        public string? CustomSearchParameters { get; set; }

        /// <summary>
        /// Type-specific configuration. Only present for v2 and later tests. Shape depends on the parent A/B test's `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchedIndexAbTestVariant" /> class.
        /// </summary>
        /// <param name="percentage">
        /// Percentage of search traffic routed to this variant.<br/>
        /// Example: 50
        /// </param>
        /// <param name="indexName">
        /// Index name of the variant. Only present for v0/v1 tests; in v2 this moves into `payload`.<br/>
        /// Example: movies
        /// </param>
        /// <param name="customSearchParameters">
        /// URL-encoded custom search parameters applied to this variant. Only present for v0/v1 tests; in v2 this moves into `payload`.
        /// </param>
        /// <param name="payload">
        /// Type-specific configuration. Only present for v2 and later tests. Shape depends on the parent A/B test's `type`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FetchedIndexAbTestVariant(
            int percentage,
            string? indexName,
            string? customSearchParameters,
            object? payload)
        {
            this.IndexName = indexName;
            this.Percentage = percentage;
            this.CustomSearchParameters = customSearchParameters;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchedIndexAbTestVariant" /> class.
        /// </summary>
        public FetchedIndexAbTestVariant()
        {
        }

    }
}