
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetObjectsResponse
    {
        /// <summary>
        /// An optional status message.<br/>
        /// Example: Index INDEX_NAME does not exist.
        /// </summary>
        /// <example>Index INDEX_NAME does not exist.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Retrieved records.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectsResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// Retrieved records.
        /// </param>
        /// <param name="message">
        /// An optional status message.<br/>
        /// Example: Index INDEX_NAME does not exist.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetObjectsResponse(
            global::System.Collections.Generic.IList<object> results,
            string? message)
        {
            this.Message = message;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectsResponse" /> class.
        /// </summary>
        public GetObjectsResponse()
        {
        }

    }
}