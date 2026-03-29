
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Which part of the search query the pattern should match:<br/>
    /// - `startsWith`. The pattern must match the beginning of the query.<br/>
    /// - `endsWith`. The pattern must match the end of the query.<br/>
    /// - `is`. The pattern must match the query exactly.<br/>
    /// - `contains`. The pattern must match anywhere in the query.<br/>
    /// Empty queries are only allowed as patterns with `anchoring: is`.
    /// </summary>
    public enum Anchoring
    {
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// is`.
        /// </summary>
        Is,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnchoringExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Anchoring value)
        {
            return value switch
            {
                Anchoring.Contains => "contains",
                Anchoring.EndsWith => "endsWith",
                Anchoring.Is => "is",
                Anchoring.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Anchoring? ToEnum(string value)
        {
            return value switch
            {
                "contains" => Anchoring.Contains,
                "endsWith" => Anchoring.EndsWith,
                "is" => Anchoring.Is,
                "startsWith" => Anchoring.StartsWith,
                _ => null,
            };
        }
    }
}