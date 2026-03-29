
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Retried,
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventStatusEnum value)
        {
            return value switch
            {
                EventStatusEnum.Created => "created",
                EventStatusEnum.Critical => "critical",
                EventStatusEnum.Failed => "failed",
                EventStatusEnum.Retried => "retried",
                EventStatusEnum.Started => "started",
                EventStatusEnum.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "created" => EventStatusEnum.Created,
                "critical" => EventStatusEnum.Critical,
                "failed" => EventStatusEnum.Failed,
                "retried" => EventStatusEnum.Retried,
                "started" => EventStatusEnum.Started,
                "succeeded" => EventStatusEnum.Succeeded,
                _ => null,
            };
        }
    }
}