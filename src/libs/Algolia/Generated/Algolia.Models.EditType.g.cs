
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Type of edit.
    /// </summary>
    public enum EditType
    {
        /// <summary>
        /// 
        /// </summary>
        Remove,
        /// <summary>
        /// 
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditType value)
        {
            return value switch
            {
                EditType.Remove => "remove",
                EditType.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditType? ToEnum(string value)
        {
            return value switch
            {
                "remove" => EditType.Remove,
                "replace" => EditType.Replace,
                _ => null,
            };
        }
    }
}