
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseGetApiKeyResponse
    {
        /// <summary>
        /// API key.<br/>
        /// Example: 13ad45b4d0a2f6ea65ecbddf6aa260f2
        /// </summary>
        /// <example>13ad45b4d0a2f6ea65ecbddf6aa260f2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Timestamp when the object was created, in milliseconds since the Unix epoch.<br/>
        /// Example: 1656345570000
        /// </summary>
        /// <example>1656345570000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseGetApiKeyResponse" /> class.
        /// </summary>
        /// <param name="value">
        /// API key.<br/>
        /// Example: 13ad45b4d0a2f6ea65ecbddf6aa260f2
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the object was created, in milliseconds since the Unix epoch.<br/>
        /// Example: 1656345570000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseGetApiKeyResponse(
            string value,
            long createdAt)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseGetApiKeyResponse" /> class.
        /// </summary>
        public BaseGetApiKeyResponse()
        {
        }
    }
}