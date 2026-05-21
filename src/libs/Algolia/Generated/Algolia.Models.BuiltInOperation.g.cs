
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Update to perform on the attribute.
    /// </summary>
    public sealed partial class BuiltInOperation
    {
        /// <summary>
        /// How to change the attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.BuiltInOperationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.BuiltInOperationType Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.BuiltInOperationValueJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.BuiltInOperationValue Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInOperation" /> class.
        /// </summary>
        /// <param name="operation">
        /// How to change the attribute.
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuiltInOperation(
            global::Algolia.BuiltInOperationType operation,
            global::Algolia.BuiltInOperationValue value)
        {
            this.Operation = operation;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInOperation" /> class.
        /// </summary>
        public BuiltInOperation()
        {
        }

    }
}