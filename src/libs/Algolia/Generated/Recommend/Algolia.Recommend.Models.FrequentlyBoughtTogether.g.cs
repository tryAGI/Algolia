
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FrequentlyBoughtTogether
    {
        /// <summary>
        /// Frequently bought together model.<br/>
        /// This model recommends items that have been purchased within 1 day with the item with the ID `objectID`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.FbtModelJsonConverter))]
        public global::Algolia.Recommend.FbtModel Model { get; set; }

        /// <summary>
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </summary>
        /// <example>test-record-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackParameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.FallbackParamsJsonConverter))]
        public global::Algolia.Recommend.FallbackParams? FallbackParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FrequentlyBoughtTogether" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="model">
        /// Frequently bought together model.<br/>
        /// This model recommends items that have been purchased within 1 day with the item with the ID `objectID`.
        /// </param>
        /// <param name="fallbackParameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FrequentlyBoughtTogether(
            string objectID,
            global::Algolia.Recommend.FbtModel model,
            global::Algolia.Recommend.FallbackParams? fallbackParameters)
        {
            this.Model = model;
            this.ObjectID = objectID ?? throw new global::System.ArgumentNullException(nameof(objectID));
            this.FallbackParameters = fallbackParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrequentlyBoughtTogether" /> class.
        /// </summary>
        public FrequentlyBoughtTogether()
        {
        }
    }
}