
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Operation to perform on the index.<br/>
    /// Example: copy
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// 
        /// </summary>
        Copy,
        /// <summary>
        /// 
        /// </summary>
        Move,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OperationType value)
        {
            return value switch
            {
                OperationType.Copy => "copy",
                OperationType.Move => "move",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OperationType? ToEnum(string value)
        {
            return value switch
            {
                "copy" => OperationType.Copy,
                "move" => OperationType.Move,
                _ => null,
            };
        }
    }
}