
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseSearchResponseFacetsStats2
    {
        /// <summary>
        /// Minimum value in the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// Maximum value in the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// Average facet value in the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg")]
        public double? Avg { get; set; }

        /// <summary>
        /// Sum of all values in the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sum")]
        public double? Sum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchResponseFacetsStats2" /> class.
        /// </summary>
        /// <param name="min">
        /// Minimum value in the results.
        /// </param>
        /// <param name="max">
        /// Maximum value in the results.
        /// </param>
        /// <param name="avg">
        /// Average facet value in the results.
        /// </param>
        /// <param name="sum">
        /// Sum of all values in the results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseSearchResponseFacetsStats2(
            double? min,
            double? max,
            double? avg,
            double? sum)
        {
            this.Min = min;
            this.Max = max;
            this.Avg = avg;
            this.Sum = sum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchResponseFacetsStats2" /> class.
        /// </summary>
        public BaseSearchResponseFacetsStats2()
        {
        }

    }
}