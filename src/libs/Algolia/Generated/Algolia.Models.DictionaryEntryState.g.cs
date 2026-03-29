
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Whether a dictionary entry is active.<br/>
    /// Default Value: enabled
    /// </summary>
    public enum DictionaryEntryState
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DictionaryEntryStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DictionaryEntryState value)
        {
            return value switch
            {
                DictionaryEntryState.Disabled => "disabled",
                DictionaryEntryState.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DictionaryEntryState? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => DictionaryEntryState.Disabled,
                "enabled" => DictionaryEntryState.Enabled,
                _ => null,
            };
        }
    }
}