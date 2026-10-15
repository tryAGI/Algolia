
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Turn on or off the built-in Algolia stop words for a specific language.
    /// </summary>
    public sealed partial class SetDictionarySettingsRequest
    {
        /// <summary>
        /// Turn off the built-in Algolia stop words for specific languages.<br/>
        /// Only `stopwords` is supported.<br/>
        /// The keys of the `stopwords` object are [language ISO codes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages) of languages with a built-in stop-word dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableStandardEntries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.StandardEntries DisableStandardEntries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDictionarySettingsRequest" /> class.
        /// </summary>
        /// <param name="disableStandardEntries">
        /// Turn off the built-in Algolia stop words for specific languages.<br/>
        /// Only `stopwords` is supported.<br/>
        /// The keys of the `stopwords` object are [language ISO codes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages) of languages with a built-in stop-word dictionary.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetDictionarySettingsRequest(
            global::Algolia.StandardEntries disableStandardEntries)
        {
            this.DisableStandardEntries = disableStandardEntries ?? throw new global::System.ArgumentNullException(nameof(disableStandardEntries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDictionarySettingsRequest" /> class.
        /// </summary>
        public SetDictionarySettingsRequest()
        {
        }

    }
}