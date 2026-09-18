
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Strategy for computing the Attribute ranking criterion.<br/>
    /// This mainly affects multi-word queries with matches in more than one attribute.<br/>
    /// The `ranking` setting decides whether `best` takes effect.<br/>
    /// When Attribute comes after Proximity, which is the default order, the engine always uses the `minProximity` strategy and ignores `best`.<br/>
    /// To select `best`, move Attribute before Proximity in `ranking`.<br/>
    /// The `sum` strategy applies in both orders.<br/>
    /// - `minProximity`.<br/>
    ///   Pick the best matching attribute from the attributes that form the best proximity score.<br/>
    ///   On an ordered attribute, the match position breaks ties.<br/>
    /// - `best`.<br/>
    ///   Pick the best matching attribute from all attributes that match any query word.<br/>
    ///   On an ordered attribute, the match position breaks ties.<br/>
    /// - `sum`.<br/>
    ///   Add up a score for every query word instead of picking one attribute.<br/>
    ///   Each word's score comes from the attribute it matched, and from its position in that attribute when the attribute is ordered.<br/>
    ///   A query word that matches nothing adds a large penalty.<br/>
    ///   A record with a lower total ranks higher.<br/>
    ///   A record therefore cannot rank high only because one word of a multi-word query matched a top attribute.<br/>
    ///   Use `sum` with short, relevant attributes, and set long-text attributes to unordered.<br/>
    /// Default Value: best
    /// </summary>
    public enum AttributeCriteriaComputedBy
    {
        /// <summary>
        ///
        /// </summary>
        Best,
        /// <summary>
        ///
        /// </summary>
        MinProximity,
        /// <summary>
        ///
        /// </summary>
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AttributeCriteriaComputedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AttributeCriteriaComputedBy value)
        {
            return value switch
            {
                AttributeCriteriaComputedBy.Best => "best",
                AttributeCriteriaComputedBy.MinProximity => "minProximity",
                AttributeCriteriaComputedBy.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AttributeCriteriaComputedBy? ToEnum(string value)
        {
            return value switch
            {
                "best" => AttributeCriteriaComputedBy.Best,
                "minProximity" => AttributeCriteriaComputedBy.MinProximity,
                "sum" => AttributeCriteriaComputedBy.Sum,
                _ => null,
            };
        }
    }
}