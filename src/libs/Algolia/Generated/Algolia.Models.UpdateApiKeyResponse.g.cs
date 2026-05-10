
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateApiKeyResponse
    {
        /// <summary>
        /// API key.<br/>
        /// Example: 13ad45b4d0a2f6ea65ecbddf6aa260f2
        /// </summary>
        /// <example>13ad45b4d0a2f6ea65ecbddf6aa260f2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Date and time when the object was updated, in RFC 3339 format.<br/>
        /// Example: 2023-07-04T12:49:15Z
        /// </summary>
        /// <example>2023-07-04T12:49:15Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyResponse" /> class.
        /// </summary>
        /// <param name="key">
        /// API key.<br/>
        /// Example: 13ad45b4d0a2f6ea65ecbddf6aa260f2
        /// </param>
        /// <param name="updatedAt">
        /// Date and time when the object was updated, in RFC 3339 format.<br/>
        /// Example: 2023-07-04T12:49:15Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateApiKeyResponse(
            string key,
            string updatedAt)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyResponse" /> class.
        /// </summary>
        public UpdateApiKeyResponse()
        {
        }

    }
}