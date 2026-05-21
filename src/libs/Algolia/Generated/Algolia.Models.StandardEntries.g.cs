
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Key-value pairs of [supported language ISO codes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages) and boolean values.
    /// </summary>
    public sealed partial class StandardEntries
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plurals")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.StandardEntryJsonConverter))]
        public global::Algolia.StandardEntry? Plurals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwords")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.StandardEntryJsonConverter))]
        public global::Algolia.StandardEntry? Stopwords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compounds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.StandardEntryJsonConverter))]
        public global::Algolia.StandardEntry? Compounds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardEntries" /> class.
        /// </summary>
        /// <param name="plurals"></param>
        /// <param name="stopwords"></param>
        /// <param name="compounds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StandardEntries(
            global::Algolia.StandardEntry? plurals,
            global::Algolia.StandardEntry? stopwords,
            global::Algolia.StandardEntry? compounds)
        {
            this.Plurals = plurals;
            this.Stopwords = stopwords;
            this.Compounds = compounds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardEntries" /> class.
        /// </summary>
        public StandardEntries()
        {
        }

    }
}