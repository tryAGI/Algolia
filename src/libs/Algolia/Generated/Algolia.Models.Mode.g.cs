
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Search mode the index will use to query for results.<br/>
    /// This setting only applies to indices, for which Algolia enabled NeuralSearch for you.<br/>
    /// Default Value: keywordSearch
    /// </summary>
    public enum Mode
    {
        /// <summary>
        /// 
        /// </summary>
        KeywordSearch,
        /// <summary>
        /// 
        /// </summary>
        NeuralSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Mode value)
        {
            return value switch
            {
                Mode.KeywordSearch => "keywordSearch",
                Mode.NeuralSearch => "neuralSearch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Mode? ToEnum(string value)
        {
            return value switch
            {
                "keywordSearch" => Mode.KeywordSearch,
                "neuralSearch" => Mode.NeuralSearch,
                _ => null,
            };
        }
    }
}