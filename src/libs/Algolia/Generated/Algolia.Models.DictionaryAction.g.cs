
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Actions to perform.
    /// </summary>
    public enum DictionaryAction
    {
        /// <summary>
        /// 
        /// </summary>
        AddEntry,
        /// <summary>
        /// 
        /// </summary>
        DeleteEntry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DictionaryActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DictionaryAction value)
        {
            return value switch
            {
                DictionaryAction.AddEntry => "addEntry",
                DictionaryAction.DeleteEntry => "deleteEntry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DictionaryAction? ToEnum(string value)
        {
            return value switch
            {
                "addEntry" => DictionaryAction.AddEntry,
                "deleteEntry" => DictionaryAction.DeleteEntry,
                _ => null,
            };
        }
    }
}