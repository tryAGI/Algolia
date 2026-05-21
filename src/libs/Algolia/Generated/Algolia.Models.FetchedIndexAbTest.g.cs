
#nullable enable

namespace Algolia
{
    /// <summary>
    /// A/B test metadata. Only present if the index is part of an active A/B test.
    /// </summary>
    public sealed partial class FetchedIndexAbTest
    {
        /// <summary>
        /// A/B test ID.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// A/B test schema version. Only present for v2 and later tests.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// A/B test type. Only present for v2 and later tests. Currently always `index-configuration`.<br/>
        /// Example: index-configuration
        /// </summary>
        /// <example>index-configuration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A/B test target criteria. Only present for v2 and later tests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::Algolia.FetchedIndexAbTestTarget? Target { get; set; }

        /// <summary>
        /// A/B test variants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.FetchedIndexAbTestVariant> Variants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchedIndexAbTest" /> class.
        /// </summary>
        /// <param name="id">
        /// A/B test ID.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="variants">
        /// A/B test variants.
        /// </param>
        /// <param name="version">
        /// A/B test schema version. Only present for v2 and later tests.<br/>
        /// Example: 2
        /// </param>
        /// <param name="type">
        /// A/B test type. Only present for v2 and later tests. Currently always `index-configuration`.<br/>
        /// Example: index-configuration
        /// </param>
        /// <param name="target">
        /// A/B test target criteria. Only present for v2 and later tests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FetchedIndexAbTest(
            int id,
            global::System.Collections.Generic.IList<global::Algolia.FetchedIndexAbTestVariant> variants,
            int? version,
            string? type,
            global::Algolia.FetchedIndexAbTestTarget? target)
        {
            this.Id = id;
            this.Version = version;
            this.Type = type;
            this.Target = target;
            this.Variants = variants ?? throw new global::System.ArgumentNullException(nameof(variants));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchedIndexAbTest" /> class.
        /// </summary>
        public FetchedIndexAbTest()
        {
        }

    }
}