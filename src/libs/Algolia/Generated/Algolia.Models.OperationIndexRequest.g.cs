
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OperationIndexRequest
    {
        /// <summary>
        /// Operation to perform on the index.<br/>
        /// Example: copy
        /// </summary>
        /// <example>copy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.OperationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.OperationType Operation { get; set; }

        /// <summary>
        /// Index name (case-sensitive).<br/>
        /// Example: products
        /// </summary>
        /// <example>products</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        /// **Only for copying.**<br/>
        /// If you specify a scope, only the selected scopes are copied. Records and the other scopes are left unchanged.<br/>
        /// If you omit the `scope` parameter, everything is copied: records, settings, synonyms, and rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::System.Collections.Generic.IList<global::Algolia.ScopeType>? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationIndexRequest" /> class.
        /// </summary>
        /// <param name="operation">
        /// Operation to perform on the index.<br/>
        /// Example: copy
        /// </param>
        /// <param name="destination">
        /// Index name (case-sensitive).<br/>
        /// Example: products
        /// </param>
        /// <param name="scope">
        /// **Only for copying.**<br/>
        /// If you specify a scope, only the selected scopes are copied. Records and the other scopes are left unchanged.<br/>
        /// If you omit the `scope` parameter, everything is copied: records, settings, synonyms, and rules.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OperationIndexRequest(
            global::Algolia.OperationType operation,
            string destination,
            global::System.Collections.Generic.IList<global::Algolia.ScopeType>? scope)
        {
            this.Operation = operation;
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationIndexRequest" /> class.
        /// </summary>
        public OperationIndexRequest()
        {
        }
    }
}