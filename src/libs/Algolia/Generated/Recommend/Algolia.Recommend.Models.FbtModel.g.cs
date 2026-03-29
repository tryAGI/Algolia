
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Frequently bought together model.<br/>
    /// This model recommends items that have been purchased within 1 day with the item with the ID `objectID`.
    /// </summary>
    public enum FbtModel
    {
        /// <summary>
        /// 
        /// </summary>
        BoughtTogether,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FbtModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FbtModel value)
        {
            return value switch
            {
                FbtModel.BoughtTogether => "bought-together",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FbtModel? ToEnum(string value)
        {
            return value switch
            {
                "bought-together" => FbtModel.BoughtTogether,
                _ => null,
            };
        }
    }
}