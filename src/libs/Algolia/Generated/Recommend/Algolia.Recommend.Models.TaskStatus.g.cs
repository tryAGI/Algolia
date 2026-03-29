
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Task status, `published` if the task is completed, `notPublished` otherwise.
    /// </summary>
    public enum TaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        NotPublished,
        /// <summary>
        /// 
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskStatus value)
        {
            return value switch
            {
                TaskStatus.NotPublished => "notPublished",
                TaskStatus.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "notPublished" => TaskStatus.NotPublished,
                "published" => TaskStatus.Published,
                _ => null,
            };
        }
    }
}