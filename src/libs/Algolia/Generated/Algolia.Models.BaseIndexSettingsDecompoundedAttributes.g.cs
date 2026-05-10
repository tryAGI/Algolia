
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Searchable attributes to which Algolia should apply [word segmentation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/how-to/customize-segmentation) (decompounding).<br/>
    /// Attribute names are case-sensitive.<br/>
    /// Compound words are formed by combining two or more individual words,<br/>
    /// and are particularly prevalent in Germanic languages—for example, "firefighter".<br/>
    /// With decompounding, the individual components are indexed separately.<br/>
    /// You can specify different lists for different languages.<br/>
    /// Decompounding is supported for these languages:<br/>
    /// Dutch (`nl`), German (`de`), Finnish (`fi`), Danish (`da`), Swedish (`sv`), and Norwegian (`no`).<br/>
    /// Decompounding doesn't work for words with [non-spacing mark Unicode characters](https://www.charactercodes.net/category/non-spacing_mark).<br/>
    /// For example, `Gartenstühle` won't be decompounded if the `ü` consists of `u` (U+0075) and `◌̈` (U+0308).<br/>
    /// Default Value: {}<br/>
    /// Example: {"de":["name"]}
    /// </summary>
    public sealed partial class BaseIndexSettingsDecompoundedAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}