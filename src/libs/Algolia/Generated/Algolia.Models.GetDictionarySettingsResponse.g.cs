
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDictionarySettingsResponse
    {
        /// <summary>
        /// Key-value pairs of [supported language ISO codes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages) and boolean values.
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
        /// Initializes a new instance of the <see cref="GetDictionarySettingsResponse" /> class.
        /// </summary>
        /// <param name="disableStandardEntries">
        /// Key-value pairs of [supported language ISO codes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages) and boolean values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDictionarySettingsResponse(
            global::Algolia.StandardEntries disableStandardEntries)
        {
            this.DisableStandardEntries = disableStandardEntries ?? throw new global::System.ArgumentNullException(nameof(disableStandardEntries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDictionarySettingsResponse" /> class.
        /// </summary>
        public GetDictionarySettingsResponse()
        {
        }
    }
}