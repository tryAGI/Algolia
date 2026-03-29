
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.DictionaryLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.DictionaryLanguage Plurals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwords")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.DictionaryLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.DictionaryLanguage Stopwords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compounds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.DictionaryLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.DictionaryLanguage Compounds { get; set; }

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
            global::Algolia.DictionaryLanguage plurals,
            global::Algolia.DictionaryLanguage stopwords,
            global::Algolia.DictionaryLanguage compounds)
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