
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Return all records with a valid `_geoloc` attribute. Don't filter by distance.
    /// </summary>
    public enum AroundRadiusAll
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AroundRadiusAllExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AroundRadiusAll value)
        {
            return value switch
            {
                AroundRadiusAll.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AroundRadiusAll? ToEnum(string value)
        {
            return value switch
            {
                "all" => AroundRadiusAll.All,
                _ => null,
            };
        }
    }
}