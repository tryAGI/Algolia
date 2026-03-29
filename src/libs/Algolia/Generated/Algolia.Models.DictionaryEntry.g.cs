
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Dictionary entry.
    /// </summary>
    public sealed partial class DictionaryEntry
    {
        /// <summary>
        /// Unique identifier for the dictionary entry.<br/>
        /// Example: 828afd405e1f4fe950b6b98c2c43c032
        /// </summary>
        /// <example>828afd405e1f4fe950b6b98c2c43c032</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectID { get; set; }

        /// <summary>
        /// ISO code for a supported language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.SupportedLanguageJsonConverter))]
        public global::Algolia.SupportedLanguage? Language { get; set; }

        /// <summary>
        /// Matching dictionary word for `stopwords` and `compounds` dictionaries.<br/>
        /// Example: the
        /// </summary>
        /// <example>the</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// Matching words in the `plurals` dictionary including declensions.<br/>
        /// Example: [cheval, cheveaux]
        /// </summary>
        /// <example>[cheval, cheveaux]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<string>? Words { get; set; }

        /// <summary>
        /// Invividual components of a compound word in the `compounds` dictionary.<br/>
        /// Example: [kopf, schmerz, tablette]
        /// </summary>
        /// <example>[kopf, schmerz, tablette]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("decomposition")]
        public global::System.Collections.Generic.IList<string>? Decomposition { get; set; }

        /// <summary>
        /// Whether a dictionary entry is active.<br/>
        /// Default Value: enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.DictionaryEntryStateJsonConverter))]
        public global::Algolia.DictionaryEntryState? State { get; set; }

        /// <summary>
        /// Whether a dictionary entry is provided by Algolia (standard), or has been added by you (custom).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.DictionaryEntryTypeJsonConverter))]
        public global::Algolia.DictionaryEntryType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DictionaryEntry" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Unique identifier for the dictionary entry.<br/>
        /// Example: 828afd405e1f4fe950b6b98c2c43c032
        /// </param>
        /// <param name="language">
        /// ISO code for a supported language.
        /// </param>
        /// <param name="word">
        /// Matching dictionary word for `stopwords` and `compounds` dictionaries.<br/>
        /// Example: the
        /// </param>
        /// <param name="words">
        /// Matching words in the `plurals` dictionary including declensions.<br/>
        /// Example: [cheval, cheveaux]
        /// </param>
        /// <param name="decomposition">
        /// Invividual components of a compound word in the `compounds` dictionary.<br/>
        /// Example: [kopf, schmerz, tablette]
        /// </param>
        /// <param name="state">
        /// Whether a dictionary entry is active.<br/>
        /// Default Value: enabled
        /// </param>
        /// <param name="type">
        /// Whether a dictionary entry is provided by Algolia (standard), or has been added by you (custom).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DictionaryEntry(
            string objectID,
            global::Algolia.SupportedLanguage? language,
            string? word,
            global::System.Collections.Generic.IList<string>? words,
            global::System.Collections.Generic.IList<string>? decomposition,
            global::Algolia.DictionaryEntryState? state,
            global::Algolia.DictionaryEntryType? type)
        {
            this.ObjectID = objectID ?? throw new global::System.ArgumentNullException(nameof(objectID));
            this.Language = language;
            this.Word = word;
            this.Words = words;
            this.Decomposition = decomposition;
            this.State = state;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DictionaryEntry" /> class.
        /// </summary>
        public DictionaryEntry()
        {
        }
    }
}