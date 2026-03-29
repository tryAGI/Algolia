
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// 
        /// </summary>
        Fetch,
        /// <summary>
        /// 
        /// </summary>
        Log,
        /// <summary>
        /// 
        /// </summary>
        Record,
        /// <summary>
        /// 
        /// </summary>
        Transform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventType value)
        {
            return value switch
            {
                EventType.Fetch => "fetch",
                EventType.Log => "log",
                EventType.Record => "record",
                EventType.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventType? ToEnum(string value)
        {
            return value switch
            {
                "fetch" => EventType.Fetch,
                "log" => EventType.Log,
                "record" => EventType.Record,
                "transform" => EventType.Transform,
                _ => null,
            };
        }
    }
}