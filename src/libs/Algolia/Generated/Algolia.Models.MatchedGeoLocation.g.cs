
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MatchedGeoLocation
    {
        /// <summary>
        /// Latitude of the matched location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lat")]
        public double? Lat { get; set; }

        /// <summary>
        /// Longitude of the matched location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lng")]
        public double? Lng { get; set; }

        /// <summary>
        /// Distance between the matched location and the search location (in meters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public int? Distance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchedGeoLocation" /> class.
        /// </summary>
        /// <param name="lat">
        /// Latitude of the matched location.
        /// </param>
        /// <param name="lng">
        /// Longitude of the matched location.
        /// </param>
        /// <param name="distance">
        /// Distance between the matched location and the search location (in meters).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchedGeoLocation(
            double? lat,
            double? lng,
            int? distance)
        {
            this.Lat = lat;
            this.Lng = lng;
            this.Distance = distance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchedGeoLocation" /> class.
        /// </summary>
        public MatchedGeoLocation()
        {
        }

    }
}