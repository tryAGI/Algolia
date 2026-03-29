
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeRange
    {
        /// <summary>
        /// Timestamp when the rule should start to be active, measured in seconds since the Unix epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public long? From { get; set; }

        /// <summary>
        /// Timestamp when the rule should stop to be active, measured in seconds since the Unix epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("until")]
        public long? Until { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRange" /> class.
        /// </summary>
        /// <param name="from">
        /// Timestamp when the rule should start to be active, measured in seconds since the Unix epoch.
        /// </param>
        /// <param name="until">
        /// Timestamp when the rule should stop to be active, measured in seconds since the Unix epoch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeRange(
            long? from,
            long? until)
        {
            this.From = from;
            this.Until = until;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRange" /> class.
        /// </summary>
        public TimeRange()
        {
        }
    }
}