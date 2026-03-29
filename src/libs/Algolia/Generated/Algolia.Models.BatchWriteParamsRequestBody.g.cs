
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Operation arguments (varies with specified `action`).<br/>
    /// Example: {"name":"Betty Jane McCamey","company":"Vita Foods Inc.","email":"betty@mccamey.com"}
    /// </summary>
    public sealed partial class BatchWriteParamsRequestBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}