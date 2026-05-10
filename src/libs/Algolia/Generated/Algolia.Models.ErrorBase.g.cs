
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Error.
    /// </summary>
    public sealed partial class ErrorBase
    {
        /// <summary>
        /// Example: Invalid Application-Id or API-Key
        /// </summary>
        /// <example>Invalid Application-Id or API-Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorBase" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Invalid Application-Id or API-Key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorBase(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorBase" /> class.
        /// </summary>
        public ErrorBase()
        {
        }

    }
}