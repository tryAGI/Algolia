
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Classification of the query scope.
    /// </summary>
    public enum QueryCategorizationType
    {
        /// <summary>
        /// 
        /// </summary>
        Ambiguous,
        /// <summary>
        /// 
        /// </summary>
        Broad,
        /// <summary>
        /// 
        /// </summary>
        Narrow,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryCategorizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryCategorizationType value)
        {
            return value switch
            {
                QueryCategorizationType.Ambiguous => "ambiguous",
                QueryCategorizationType.Broad => "broad",
                QueryCategorizationType.Narrow => "narrow",
                QueryCategorizationType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryCategorizationType? ToEnum(string value)
        {
            return value switch
            {
                "ambiguous" => QueryCategorizationType.Ambiguous,
                "broad" => QueryCategorizationType.Broad,
                "narrow" => QueryCategorizationType.Narrow,
                "none" => QueryCategorizationType.None,
                _ => null,
            };
        }
    }
}