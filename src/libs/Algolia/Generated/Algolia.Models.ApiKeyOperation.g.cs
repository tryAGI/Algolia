
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiKeyOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyOperation value)
        {
            return value switch
            {
                ApiKeyOperation.Add => "add",
                ApiKeyOperation.Delete => "delete",
                ApiKeyOperation.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyOperation? ToEnum(string value)
        {
            return value switch
            {
                "add" => ApiKeyOperation.Add,
                "delete" => ApiKeyOperation.Delete,
                "update" => ApiKeyOperation.Update,
                _ => null,
            };
        }
    }
}