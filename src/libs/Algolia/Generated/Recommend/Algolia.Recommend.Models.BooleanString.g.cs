
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public enum BooleanString
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BooleanStringExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BooleanString value)
        {
            return value switch
            {
                BooleanString.False => "false",
                BooleanString.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BooleanString? ToEnum(string value)
        {
            return value switch
            {
                "false" => BooleanString.False,
                "true" => BooleanString.True,
                _ => null,
            };
        }
    }
}