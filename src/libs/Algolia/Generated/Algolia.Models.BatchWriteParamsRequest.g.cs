
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchWriteParamsRequest
    {
        /// <summary>
        /// Which indexing operation to perform:<br/>
        /// - `addObject`: adds records to an index.<br/>
        ///    Equivalent to the "Add a new record (with auto-generated object ID)" operation.<br/>
        /// - `updateObject`: adds or replaces records in an index.<br/>
        ///    Equivalent to the "Add or replace a record" operation.<br/>
        /// - `partialUpdateObject`: adds or updates attributes within records.<br/>
        ///    Equivalent to the "Add or update attributes" operation with the `createIfNoExists` parameter set to true.<br/>
        ///    (If a record with the specified `objectID` doesn't exist in the specified index, this action creates adds the record to the index)<br/>
        /// - `partialUpdateObjectNoCreate`: same as `partialUpdateObject`, but with `createIfNoExists` set to false.<br/>
        ///    (A record isn't added to the index if its `objectID` doesn't exist)<br/>
        /// - `deleteObject`: delete records from an index.<br/>
        ///   Equivalent to the "Delete a record" operation.<br/>
        /// - `delete`. Delete an index. Equivalent to the "Delete an index" operation.<br/>
        /// - `clear`: delete all records from an index. Equivalent to the "Delete all records from an index operation".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.ActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.Action Action { get; set; }

        /// <summary>
        /// Operation arguments (varies with specified `action`).<br/>
        /// Example: {"name":"Betty Jane McCamey","company":"Vita Foods Inc.","email":"betty@mccamey.com"}
        /// </summary>
        /// <example>{"name":"Betty Jane McCamey","company":"Vita Foods Inc.","email":"betty@mccamey.com"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchWriteParamsRequest" /> class.
        /// </summary>
        /// <param name="action">
        /// Which indexing operation to perform:<br/>
        /// - `addObject`: adds records to an index.<br/>
        ///    Equivalent to the "Add a new record (with auto-generated object ID)" operation.<br/>
        /// - `updateObject`: adds or replaces records in an index.<br/>
        ///    Equivalent to the "Add or replace a record" operation.<br/>
        /// - `partialUpdateObject`: adds or updates attributes within records.<br/>
        ///    Equivalent to the "Add or update attributes" operation with the `createIfNoExists` parameter set to true.<br/>
        ///    (If a record with the specified `objectID` doesn't exist in the specified index, this action creates adds the record to the index)<br/>
        /// - `partialUpdateObjectNoCreate`: same as `partialUpdateObject`, but with `createIfNoExists` set to false.<br/>
        ///    (A record isn't added to the index if its `objectID` doesn't exist)<br/>
        /// - `deleteObject`: delete records from an index.<br/>
        ///   Equivalent to the "Delete a record" operation.<br/>
        /// - `delete`. Delete an index. Equivalent to the "Delete an index" operation.<br/>
        /// - `clear`: delete all records from an index. Equivalent to the "Delete all records from an index operation".
        /// </param>
        /// <param name="body">
        /// Operation arguments (varies with specified `action`).<br/>
        /// Example: {"name":"Betty Jane McCamey","company":"Vita Foods Inc.","email":"betty@mccamey.com"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchWriteParamsRequest(
            global::Algolia.Action action,
            object body)
        {
            this.Action = action;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchWriteParamsRequest" /> class.
        /// </summary>
        public BatchWriteParamsRequest()
        {
        }

    }
}