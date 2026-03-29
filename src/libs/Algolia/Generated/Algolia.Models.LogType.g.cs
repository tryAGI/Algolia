
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum LogType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Build,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogType value)
        {
            return value switch
            {
                LogType.All => "all",
                LogType.Build => "build",
                LogType.Error => "error",
                LogType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogType? ToEnum(string value)
        {
            return value switch
            {
                "all" => LogType.All,
                "build" => LogType.Build,
                "error" => LogType.Error,
                "query" => LogType.Query,
                _ => null,
            };
        }
    }
}