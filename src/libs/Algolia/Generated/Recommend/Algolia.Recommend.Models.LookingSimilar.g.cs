
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LookingSimilar
    {
        /// <summary>
        /// Looking similar model.<br/>
        /// This model recommends items that look similar to the item with the ID `objectID` based on image attributes in your index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.LookingSimilarModelJsonConverter))]
        public global::Algolia.Recommend.LookingSimilarModel Model { get; set; }

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
        /// Initializes a new instance of the <see cref="LookingSimilar" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="model">
        /// Looking similar model.<br/>
        /// This model recommends items that look similar to the item with the ID `objectID` based on image attributes in your index.
        /// </param>
        /// <param name="fallbackParameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LookingSimilar(
            string objectID,
            global::Algolia.Recommend.LookingSimilarModel model,
            global::Algolia.Recommend.FallbackParams? fallbackParameters)
        {
            this.Model = model;
            this.ObjectID = objectID ?? throw new global::System.ArgumentNullException(nameof(objectID));
            this.FallbackParameters = fallbackParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LookingSimilar" /> class.
        /// </summary>
        public LookingSimilar()
        {
        }

    }
}