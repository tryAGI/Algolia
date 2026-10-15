
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Turn off the built-in Algolia stop words for specific languages.<br/>
    /// Only `stopwords` is supported.<br/>
    /// The keys of the `stopwords` object are [language ISO codes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages) of languages with a built-in stop-word dictionary.
    /// </summary>
    public sealed partial class StandardEntries
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plurals")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Plurals { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwords")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Stopwords { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compounds")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Compounds { get; set; }

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
            global::System.Collections.Generic.Dictionary<string, bool>? plurals,
            global::System.Collections.Generic.Dictionary<string, bool>? stopwords,
            global::System.Collections.Generic.Dictionary<string, bool>? compounds)
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