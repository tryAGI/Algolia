
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Agent Studio Result Card to display for a given search.
    /// </summary>
    public sealed partial class ResultCard
    {
        /// <summary>
        /// Whether to show the Result Card for the current search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultCard" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether to show the Result Card for the current search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultCard(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultCard" /> class.
        /// </summary>
        public ResultCard()
        {
        }

    }
}