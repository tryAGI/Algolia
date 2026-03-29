
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Example: {"objectID":"blackTShirt","name":"Black T-shirt","color":"#000000"}
    /// </summary>
    public sealed partial class SaveObjectRequest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}