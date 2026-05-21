
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelatedProducts
    {
        /// <summary>
        /// Related products or similar content model.<br/>
        /// This model recommends items that are similar to the item with the ID `objectID`.<br/>
        /// Similarity is determined from the user interactions and attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.RelatedModelJsonConverter))]
        public global::Algolia.Recommend.RelatedModel Model { get; set; }

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
        /// Initializes a new instance of the <see cref="RelatedProducts" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="model">
        /// Related products or similar content model.<br/>
        /// This model recommends items that are similar to the item with the ID `objectID`.<br/>
        /// Similarity is determined from the user interactions and attributes.
        /// </param>
        /// <param name="fallbackParameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelatedProducts(
            string objectID,
            global::Algolia.Recommend.RelatedModel model,
            global::Algolia.Recommend.FallbackParams? fallbackParameters)
        {
            this.Model = model;
            this.ObjectID = objectID ?? throw new global::System.ArgumentNullException(nameof(objectID));
            this.FallbackParameters = fallbackParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedProducts" /> class.
        /// </summary>
        public RelatedProducts()
        {
        }

    }
}