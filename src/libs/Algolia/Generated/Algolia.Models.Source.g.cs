
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Source.
    /// </summary>
    public sealed partial class Source
    {
        /// <summary>
        /// IP address range of the source.<br/>
        /// Example: 10.0.0.1/32
        /// </summary>
        /// <example>10.0.0.1/32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source1 { get; set; }

        /// <summary>
        /// Source description.<br/>
        /// Example: Server subnet
        /// </summary>
        /// <example>Server subnet</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="source1">
        /// IP address range of the source.<br/>
        /// Example: 10.0.0.1/32
        /// </param>
        /// <param name="description">
        /// Source description.<br/>
        /// Example: Server subnet
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Source(
            string source1,
            string? description)
        {
            this.Source1 = source1 ?? throw new global::System.ArgumentNullException(nameof(source1));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        public Source()
        {
        }
    }
}