
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Related products or similar content model.<br/>
    /// This model recommends items that are similar to the item with the ID `objectID`.<br/>
    /// Similarity is determined from the user interactions and attributes.
    /// </summary>
    public enum RelatedModel
    {
        /// <summary>
        /// 
        /// </summary>
        RelatedProducts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RelatedModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RelatedModel value)
        {
            return value switch
            {
                RelatedModel.RelatedProducts => "related-products",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RelatedModel? ToEnum(string value)
        {
            return value switch
            {
                "related-products" => RelatedModel.RelatedProducts,
                _ => null,
            };
        }
    }
}