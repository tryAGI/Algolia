
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Dictionary language.
    /// </summary>
    public sealed partial class Languages
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plurals")]
        public global::Algolia.DictionaryLanguageVariant1? Plurals { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwords")]
        public global::Algolia.DictionaryLanguageVariant1? Stopwords { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compounds")]
        public global::Algolia.DictionaryLanguageVariant1? Compounds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Languages" /> class.
        /// </summary>
        /// <param name="plurals"></param>
        /// <param name="stopwords"></param>
        /// <param name="compounds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Languages(
            global::Algolia.DictionaryLanguageVariant1? plurals,
            global::Algolia.DictionaryLanguageVariant1? stopwords,
            global::Algolia.DictionaryLanguageVariant1? compounds)
        {
            this.Plurals = plurals;
            this.Stopwords = stopwords;
            this.Compounds = compounds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Languages" /> class.
        /// </summary>
        public Languages()
        {
        }

    }
}