
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Snippets that show the context around a matching search query.
    /// </summary>
    public sealed partial class SnippetResultOption
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.MatchLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.Recommend.MatchLevel MatchLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetResultOption" /> class.
        /// </summary>
        /// <param name="value">
        /// Highlighted attribute value, including HTML tags.<br/>
        /// Example: &lt;em&gt;George&lt;/em&gt; &lt;em&gt;Clo&lt;/em&gt;oney
        /// </param>
        /// <param name="matchLevel">
        /// Whether the whole query string matches or only a part.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnippetResultOption(
            string value,
            global::Algolia.Recommend.MatchLevel matchLevel)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.MatchLevel = matchLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetResultOption" /> class.
        /// </summary>
        public SnippetResultOption()
        {
        }
    }
}