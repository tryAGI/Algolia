
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Looking similar model.<br/>
    /// This model recommends items that look similar to the item with the ID `objectID` based on image attributes in your index.
    /// </summary>
    public enum LookingSimilarModel
    {
        /// <summary>
        /// 
        /// </summary>
        LookingSimilar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LookingSimilarModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LookingSimilarModel value)
        {
            return value switch
            {
                LookingSimilarModel.LookingSimilar => "looking-similar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LookingSimilarModel? ToEnum(string value)
        {
            return value switch
            {
                "looking-similar" => LookingSimilarModel.LookingSimilar,
                _ => null,
            };
        }
    }
}