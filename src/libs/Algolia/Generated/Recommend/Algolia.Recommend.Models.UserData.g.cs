
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// An object with custom data.<br/>
    /// You can store up to 32kB as custom data.<br/>
    /// Default Value: {}<br/>
    /// Example: {"settingID":"f2a7b51e3503acc6a39b3784ffb84300","pluginVersion":"1.6.0"}
    /// </summary>
    public sealed partial class UserData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}