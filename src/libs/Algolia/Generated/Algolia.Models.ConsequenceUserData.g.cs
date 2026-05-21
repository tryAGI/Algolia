
#nullable enable

namespace Algolia
{
    /// <summary>
    /// A JSON object with custom data that will be appended to the `userData` array in the response.<br/>
    /// This object isn't interpreted by the API and is limited to 1&amp;nbsp;kB of minified JSON.<br/>
    /// Example: {"settingID":"f2a7b51e3503acc6a39b3784ffb84300","pluginVersion":"1.6.0"}
    /// </summary>
    public sealed partial class ConsequenceUserData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}