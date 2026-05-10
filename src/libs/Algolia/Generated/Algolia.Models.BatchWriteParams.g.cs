
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Batch parameters.<br/>
    /// Example: {"requests":[{"action":"addObject","body":{"name":"Betty Jane McCamey","company":"Vita Foods Inc.","email":"betty@mccamey.com"}},{"action":"addObject","body":{"name":"Gayla geimer","company":"Ortman McCain Co.","email":"gayla@geimer.com"}}]}
    /// </summary>
    public sealed partial class BatchWriteParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.BatchWriteParamsRequest> Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchWriteParams" /> class.
        /// </summary>
        /// <param name="requests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchWriteParams(
            global::System.Collections.Generic.IList<global::Algolia.BatchWriteParamsRequest> requests)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchWriteParams" /> class.
        /// </summary>
        public BatchWriteParams()
        {
        }

    }
}