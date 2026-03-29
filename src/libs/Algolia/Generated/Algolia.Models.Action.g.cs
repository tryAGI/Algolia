
#nullable enable

namespace Algolia
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
    public enum Action
    {
        /// <summary>
        /// adds records to an index.
        /// </summary>
        AddObject,
        /// <summary>
        /// delete all records from an index. Equivalent to the "Delete all records from an index operation".
        /// </summary>
        Clear,
        /// <summary>
        /// delete records from an index.
        /// </summary>
        Delete,
        /// <summary>
        /// delete records from an index.
        /// </summary>
        DeleteObject,
        /// <summary>
        /// adds or updates attributes within records.
        /// </summary>
        PartialUpdateObject,
        /// <summary>
        /// same as `partialUpdateObject`, but with `createIfNoExists` set to false.
        /// </summary>
        PartialUpdateObjectNoCreate,
        /// <summary>
        /// adds or replaces records in an index.
        /// </summary>
        UpdateObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Action value)
        {
            return value switch
            {
                Action.AddObject => "addObject",
                Action.Clear => "clear",
                Action.Delete => "delete",
                Action.DeleteObject => "deleteObject",
                Action.PartialUpdateObject => "partialUpdateObject",
                Action.PartialUpdateObjectNoCreate => "partialUpdateObjectNoCreate",
                Action.UpdateObject => "updateObject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Action? ToEnum(string value)
        {
            return value switch
            {
                "addObject" => Action.AddObject,
                "clear" => Action.Clear,
                "delete" => Action.Delete,
                "deleteObject" => Action.DeleteObject,
                "partialUpdateObject" => Action.PartialUpdateObject,
                "partialUpdateObjectNoCreate" => Action.PartialUpdateObjectNoCreate,
                "updateObject" => Action.UpdateObject,
                _ => null,
            };
        }
    }
}