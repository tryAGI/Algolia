
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.SearchQuery> Requests { get; set; }

        /// <summary>
        /// Strategy for multiple search queries:<br/>
        /// - `none`. Run all queries.<br/>
        /// - `stopIfEnoughMatches`. Run the queries one by one, stopping as soon as a query matches at least the `hitsPerPage` number of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.SearchStrategyJsonConverter))]
        public global::Algolia.SearchStrategy? Strategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="requests"></param>
        /// <param name="strategy">
        /// Strategy for multiple search queries:<br/>
        /// - `none`. Run all queries.<br/>
        /// - `stopIfEnoughMatches`. Run the queries one by one, stopping as soon as a query matches at least the `hitsPerPage` number of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequest(
            global::System.Collections.Generic.IList<global::Algolia.SearchQuery> requests,
            global::Algolia.SearchStrategy? strategy)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.Strategy = strategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        public SearchRequest()
        {
        }
    }
}