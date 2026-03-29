
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Whether the whole query string matches or only a part.
    /// </summary>
    public enum MatchLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Full,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Partial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MatchLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MatchLevel value)
        {
            return value switch
            {
                MatchLevel.Full => "full",
                MatchLevel.None => "none",
                MatchLevel.Partial => "partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MatchLevel? ToEnum(string value)
        {
            return value switch
            {
                "full" => MatchLevel.Full,
                "none" => MatchLevel.None,
                "partial" => MatchLevel.Partial,
                _ => null,
            };
        }
    }
}