
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLogsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.GetLogsResponseLog> Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLogsResponse" /> class.
        /// </summary>
        /// <param name="logs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLogsResponse(
            global::System.Collections.Generic.IList<global::Algolia.GetLogsResponseLog> logs)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLogsResponse" /> class.
        /// </summary>
        public GetLogsResponse()
        {
        }

    }
}