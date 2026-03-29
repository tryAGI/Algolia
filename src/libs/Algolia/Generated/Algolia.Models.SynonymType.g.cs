
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Synonym type.<br/>
    /// Example: onewaysynonym
    /// </summary>
    public enum SynonymType
    {
        /// <summary>
        /// 
        /// </summary>
        AltCorrection12,
        /// <summary>
        /// 
        /// </summary>
        AltCorrection22,
        /// <summary>
        /// 
        /// </summary>
        Altcorrection1,
        /// <summary>
        /// 
        /// </summary>
        Altcorrection2,
        /// <summary>
        /// 
        /// </summary>
        OneWaySynonym2,
        /// <summary>
        /// 
        /// </summary>
        Onewaysynonym,
        /// <summary>
        /// 
        /// </summary>
        Placeholder,
        /// <summary>
        /// 
        /// </summary>
        Synonym,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SynonymTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SynonymType value)
        {
            return value switch
            {
                SynonymType.AltCorrection12 => "altCorrection1",
                SynonymType.AltCorrection22 => "altCorrection2",
                SynonymType.Altcorrection1 => "altcorrection1",
                SynonymType.Altcorrection2 => "altcorrection2",
                SynonymType.OneWaySynonym2 => "oneWaySynonym",
                SynonymType.Onewaysynonym => "onewaysynonym",
                SynonymType.Placeholder => "placeholder",
                SynonymType.Synonym => "synonym",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SynonymType? ToEnum(string value)
        {
            return value switch
            {
                "altCorrection1" => SynonymType.AltCorrection12,
                "altCorrection2" => SynonymType.AltCorrection22,
                "altcorrection1" => SynonymType.Altcorrection1,
                "altcorrection2" => SynonymType.Altcorrection2,
                "oneWaySynonym" => SynonymType.OneWaySynonym2,
                "onewaysynonym" => SynonymType.Onewaysynonym,
                "placeholder" => SynonymType.Placeholder,
                "synonym" => SynonymType.Synonym,
                _ => null,
            };
        }
    }
}