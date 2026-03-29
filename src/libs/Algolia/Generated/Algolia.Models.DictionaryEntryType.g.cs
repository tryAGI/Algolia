
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Whether a dictionary entry is provided by Algolia (standard), or has been added by you (custom).
    /// </summary>
    public enum DictionaryEntryType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DictionaryEntryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DictionaryEntryType value)
        {
            return value switch
            {
                DictionaryEntryType.Custom => "custom",
                DictionaryEntryType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DictionaryEntryType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => DictionaryEntryType.Custom,
                "standard" => DictionaryEntryType.Standard,
                _ => null,
            };
        }
    }
}