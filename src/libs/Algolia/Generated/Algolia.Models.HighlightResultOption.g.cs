
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Surround words that match the query with HTML tags for highlighting.
    /// </summary>
    public sealed partial class HighlightResultOption
    {
        /// <summary>
        /// Highlighted attribute value, including HTML tags.<br/>
        /// Example: &lt;em&gt;George&lt;/em&gt; &lt;em&gt;Clo&lt;/em&gt;oney
        /// </summary>
        /// <example>&lt;em&gt;George&lt;/em&gt; &lt;em&gt;Clo&lt;/em&gt;oney</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Whether the whole query string matches or only a part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.MatchLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.MatchLevel MatchLevel { get; set; }

        /// <summary>
        /// List of matched words from the search query.<br/>
        /// Example: [action]
        /// </summary>
        /// <example>[action]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchedWords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MatchedWords { get; set; }

        /// <summary>
        /// Whether the entire attribute value is highlighted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullyHighlighted")]
        public bool? FullyHighlighted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightResultOption" /> class.
        /// </summary>
        /// <param name="value">
        /// Highlighted attribute value, including HTML tags.<br/>
        /// Example: &lt;em&gt;George&lt;/em&gt; &lt;em&gt;Clo&lt;/em&gt;oney
        /// </param>
        /// <param name="matchLevel">
        /// Whether the whole query string matches or only a part.
        /// </param>
        /// <param name="matchedWords">
        /// List of matched words from the search query.<br/>
        /// Example: [action]
        /// </param>
        /// <param name="fullyHighlighted">
        /// Whether the entire attribute value is highlighted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HighlightResultOption(
            string value,
            global::Algolia.MatchLevel matchLevel,
            global::System.Collections.Generic.IList<string> matchedWords,
            bool? fullyHighlighted)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.MatchLevel = matchLevel;
            this.MatchedWords = matchedWords ?? throw new global::System.ArgumentNullException(nameof(matchedWords));
            this.FullyHighlighted = fullyHighlighted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HighlightResultOption" /> class.
        /// </summary>
        public HighlightResultOption()
        {
        }
    }
}