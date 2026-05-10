
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Personalization
    {
        /// <summary>
        /// The score of the filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filtersScore")]
        public int? FiltersScore { get; set; }

        /// <summary>
        /// The score of the ranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankingScore")]
        public int? RankingScore { get; set; }

        /// <summary>
        /// The score of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Personalization" /> class.
        /// </summary>
        /// <param name="filtersScore">
        /// The score of the filters.
        /// </param>
        /// <param name="rankingScore">
        /// The score of the ranking.
        /// </param>
        /// <param name="score">
        /// The score of the event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Personalization(
            int? filtersScore,
            int? rankingScore,
            int? score)
        {
            this.FiltersScore = filtersScore;
            this.RankingScore = rankingScore;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Personalization" /> class.
        /// </summary>
        public Personalization()
        {
        }

    }
}