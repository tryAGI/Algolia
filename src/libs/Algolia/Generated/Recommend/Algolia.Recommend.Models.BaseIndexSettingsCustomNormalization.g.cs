
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Characters and their normalized replacements.<br/>
    /// This overrides Algolia's default [normalization](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/normalization).<br/>
    /// Example: {"default":{"\u00E4":"ae","\u00FC":"ue"}}
    /// </summary>
    public sealed partial class BaseIndexSettingsCustomNormalization
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}