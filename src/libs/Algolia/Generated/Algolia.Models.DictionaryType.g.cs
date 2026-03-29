
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public enum DictionaryType
    {
        /// <summary>
        /// 
        /// </summary>
        Compounds,
        /// <summary>
        /// 
        /// </summary>
        Plurals,
        /// <summary>
        /// 
        /// </summary>
        Stopwords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DictionaryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DictionaryType value)
        {
            return value switch
            {
                DictionaryType.Compounds => "compounds",
                DictionaryType.Plurals => "plurals",
                DictionaryType.Stopwords => "stopwords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DictionaryType? ToEnum(string value)
        {
            return value switch
            {
                "compounds" => DictionaryType.Compounds,
                "plurals" => DictionaryType.Plurals,
                "stopwords" => DictionaryType.Stopwords,
                _ => null,
            };
        }
    }
}