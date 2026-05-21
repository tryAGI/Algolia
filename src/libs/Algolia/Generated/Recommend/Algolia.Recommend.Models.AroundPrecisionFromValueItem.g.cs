
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Range object with lower and upper values in meters to define custom ranges.
    /// </summary>
    public sealed partial class AroundPrecisionFromValueItem
    {
        /// <summary>
        /// Lower boundary of a range in meters. The Geo ranking criterion considers all records within the range to be equal.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public int? From { get; set; }

        /// <summary>
        /// Upper boundary of a range in meters. The Geo ranking criterion considers all records within the range to be equal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AroundPrecisionFromValueItem" /> class.
        /// </summary>
        /// <param name="from">
        /// Lower boundary of a range in meters. The Geo ranking criterion considers all records within the range to be equal.<br/>
        /// Example: 20
        /// </param>
        /// <param name="value">
        /// Upper boundary of a range in meters. The Geo ranking criterion considers all records within the range to be equal.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AroundPrecisionFromValueItem(
            int? from,
            int? value)
        {
            this.From = from;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AroundPrecisionFromValueItem" /> class.
        /// </summary>
        public AroundPrecisionFromValueItem()
        {
        }

    }
}