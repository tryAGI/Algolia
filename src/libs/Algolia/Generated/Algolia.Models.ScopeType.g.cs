
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScopeType
    {
        /// <summary>
        /// 
        /// </summary>
        Rules,
        /// <summary>
        /// 
        /// </summary>
        Settings,
        /// <summary>
        /// 
        /// </summary>
        Synonyms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScopeType value)
        {
            return value switch
            {
                ScopeType.Rules => "rules",
                ScopeType.Settings => "settings",
                ScopeType.Synonyms => "synonyms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScopeType? ToEnum(string value)
        {
            return value switch
            {
                "rules" => ScopeType.Rules,
                "settings" => ScopeType.Settings,
                "synonyms" => ScopeType.Synonyms,
                _ => null,
            };
        }
    }
}