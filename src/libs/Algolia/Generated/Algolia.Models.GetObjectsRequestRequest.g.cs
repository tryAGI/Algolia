
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Request body for retrieving records.
    /// </summary>
    public sealed partial class GetObjectsRequestRequest
    {
        /// <summary>
        /// Attributes to retrieve.<br/>
        /// If not specified, all retrievable attributes are returned.<br/>
        /// Example: [author, title, content]
        /// </summary>
        /// <example>[author, title, content]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributesToRetrieve")]
        public global::System.Collections.Generic.IList<string>? AttributesToRetrieve { get; set; }

        /// <summary>
        /// Object ID for the record to retrieve.<br/>
        /// Example: product-1
        /// </summary>
        /// <example>product-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectID { get; set; }

        /// <summary>
        /// Index from which to retrieve the records.<br/>
        /// Example: books
        /// </summary>
        /// <example>books</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectsRequestRequest" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Object ID for the record to retrieve.<br/>
        /// Example: product-1
        /// </param>
        /// <param name="indexName">
        /// Index from which to retrieve the records.<br/>
        /// Example: books
        /// </param>
        /// <param name="attributesToRetrieve">
        /// Attributes to retrieve.<br/>
        /// If not specified, all retrievable attributes are returned.<br/>
        /// Example: [author, title, content]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetObjectsRequestRequest(
            string objectID,
            string indexName,
            global::System.Collections.Generic.IList<string>? attributesToRetrieve)
        {
            this.AttributesToRetrieve = attributesToRetrieve;
            this.ObjectID = objectID ?? throw new global::System.ArgumentNullException(nameof(objectID));
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObjectsRequestRequest" /> class.
        /// </summary>
        public GetObjectsRequestRequest()
        {
        }
    }
}