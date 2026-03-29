
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlternativesAsExact
    {
        /// <summary>
        /// 
        /// </summary>
        IgnoreConjugations,
        /// <summary>
        /// 
        /// </summary>
        IgnorePlurals,
        /// <summary>
        /// 
        /// </summary>
        MultiWordsSynonym,
        /// <summary>
        /// 
        /// </summary>
        SingleWordSynonym,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlternativesAsExactExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlternativesAsExact value)
        {
            return value switch
            {
                AlternativesAsExact.IgnoreConjugations => "ignoreConjugations",
                AlternativesAsExact.IgnorePlurals => "ignorePlurals",
                AlternativesAsExact.MultiWordsSynonym => "multiWordsSynonym",
                AlternativesAsExact.SingleWordSynonym => "singleWordSynonym",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlternativesAsExact? ToEnum(string value)
        {
            return value switch
            {
                "ignoreConjugations" => AlternativesAsExact.IgnoreConjugations,
                "ignorePlurals" => AlternativesAsExact.IgnorePlurals,
                "multiWordsSynonym" => AlternativesAsExact.MultiWordsSynonym,
                "singleWordSynonym" => AlternativesAsExact.SingleWordSynonym,
                _ => null,
            };
        }
    }
}