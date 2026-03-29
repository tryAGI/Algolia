
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Search result.<br/>
    /// A hit is a record from your index, augmented with special attributes for highlighting, snippeting, and ranking.
    /// </summary>
    public sealed partial class Hit
    {
        /// <summary>
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </summary>
        /// <example>test-record-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectID { get; set; }

        /// <summary>
        /// Surround words that match the query with HTML tags for highlighting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_highlightResult")]
        public global::Algolia.HighlightResultMap? HighlightResult { get; set; }

        /// <summary>
        /// Snippets that show the context around a matching search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_snippetResult")]
        public global::Algolia.SnippetResultMap? SnippetResult { get; set; }

        /// <summary>
        /// Object with detailed information about the record's ranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_rankingInfo")]
        public global::Algolia.RankingInfo? RankingInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_distinctSeqID")]
        public int? DistinctSeqID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Hit" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="highlightResult">
        /// Surround words that match the query with HTML tags for highlighting.
        /// </param>
        /// <param name="snippetResult">
        /// Snippets that show the context around a matching search query.
        /// </param>
        /// <param name="rankingInfo">
        /// Object with detailed information about the record's ranking.
        /// </param>
        /// <param name="distinctSeqID"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Hit(
            string objectID,
            global::Algolia.HighlightResultMap? highlightResult,
            global::Algolia.SnippetResultMap? snippetResult,
            global::Algolia.RankingInfo? rankingInfo,
            int? distinctSeqID)
        {
            this.ObjectID = objectID ?? throw new global::System.ArgumentNullException(nameof(objectID));
            this.HighlightResult = highlightResult;
            this.SnippetResult = snippetResult;
            this.RankingInfo = rankingInfo;
            this.DistinctSeqID = distinctSeqID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hit" /> class.
        /// </summary>
        public Hit()
        {
        }
    }
}