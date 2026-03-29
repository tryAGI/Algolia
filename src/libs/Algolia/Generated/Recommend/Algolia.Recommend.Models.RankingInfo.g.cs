
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Object with detailed information about the record's ranking.
    /// </summary>
    public sealed partial class RankingInfo
    {
        /// <summary>
        /// Whether a filter matched the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public int? Filters { get; set; }

        /// <summary>
        /// Position of the first matched word in the best matching attribute of the record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstMatchedWord")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FirstMatchedWord { get; set; }

        /// <summary>
        /// Distance between the geo location in the search query and the best matching geo location in the record, divided by the geo precision (in meters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geoDistance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GeoDistance { get; set; }

        /// <summary>
        /// Precision used when computing the geo distance, in meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geoPrecision")]
        public int? GeoPrecision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchedGeoLocation")]
        public global::Algolia.Recommend.MatchedGeoLocation? MatchedGeoLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personalization")]
        public global::Algolia.Recommend.Personalization? Personalization { get; set; }

        /// <summary>
        /// Number of exactly matched words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbExactWords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbExactWords { get; set; }

        /// <summary>
        /// Number of typos encountered when matching the record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbTypos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbTypos { get; set; }

        /// <summary>
        /// Whether the record was promoted by a rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promoted")]
        public bool? Promoted { get; set; }

        /// <summary>
        /// Number of words between multiple matches in the query plus 1. For single word queries, `proximityDistance` is 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proximityDistance")]
        public int? ProximityDistance { get; set; }

        /// <summary>
        /// Overall ranking of the record, expressed as a single integer. This attribute is internal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userScore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserScore { get; set; }

        /// <summary>
        /// Number of matched words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public int? Words { get; set; }

        /// <summary>
        /// Whether the record is re-ranked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotedByReRanking")]
        public bool? PromotedByReRanking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingInfo" /> class.
        /// </summary>
        /// <param name="firstMatchedWord">
        /// Position of the first matched word in the best matching attribute of the record.
        /// </param>
        /// <param name="geoDistance">
        /// Distance between the geo location in the search query and the best matching geo location in the record, divided by the geo precision (in meters).
        /// </param>
        /// <param name="nbExactWords">
        /// Number of exactly matched words.
        /// </param>
        /// <param name="nbTypos">
        /// Number of typos encountered when matching the record.
        /// </param>
        /// <param name="userScore">
        /// Overall ranking of the record, expressed as a single integer. This attribute is internal.
        /// </param>
        /// <param name="filters">
        /// Whether a filter matched the query.
        /// </param>
        /// <param name="geoPrecision">
        /// Precision used when computing the geo distance, in meters.
        /// </param>
        /// <param name="matchedGeoLocation"></param>
        /// <param name="personalization"></param>
        /// <param name="promoted">
        /// Whether the record was promoted by a rule.
        /// </param>
        /// <param name="proximityDistance">
        /// Number of words between multiple matches in the query plus 1. For single word queries, `proximityDistance` is 0.
        /// </param>
        /// <param name="words">
        /// Number of matched words.
        /// </param>
        /// <param name="promotedByReRanking">
        /// Whether the record is re-ranked.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankingInfo(
            int firstMatchedWord,
            int geoDistance,
            int nbExactWords,
            int nbTypos,
            int userScore,
            int? filters,
            int? geoPrecision,
            global::Algolia.Recommend.MatchedGeoLocation? matchedGeoLocation,
            global::Algolia.Recommend.Personalization? personalization,
            bool? promoted,
            int? proximityDistance,
            int? words,
            bool? promotedByReRanking)
        {
            this.Filters = filters;
            this.FirstMatchedWord = firstMatchedWord;
            this.GeoDistance = geoDistance;
            this.GeoPrecision = geoPrecision;
            this.MatchedGeoLocation = matchedGeoLocation;
            this.Personalization = personalization;
            this.NbExactWords = nbExactWords;
            this.NbTypos = nbTypos;
            this.Promoted = promoted;
            this.ProximityDistance = proximityDistance;
            this.UserScore = userScore;
            this.Words = words;
            this.PromotedByReRanking = promotedByReRanking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingInfo" /> class.
        /// </summary>
        public RankingInfo()
        {
        }
    }
}