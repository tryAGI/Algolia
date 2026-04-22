
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Confidence level of the category prediction.
    /// </summary>
    public enum CategoryPredictionBin
    {
        /// <summary>
        /// 
        /// </summary>
        Certain,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        VeryHigh,
        /// <summary>
        /// 
        /// </summary>
        VeryLow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CategoryPredictionBinExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CategoryPredictionBin value)
        {
            return value switch
            {
                CategoryPredictionBin.Certain => "certain",
                CategoryPredictionBin.High => "high",
                CategoryPredictionBin.Low => "low",
                CategoryPredictionBin.VeryHigh => "very high",
                CategoryPredictionBin.VeryLow => "very low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CategoryPredictionBin? ToEnum(string value)
        {
            return value switch
            {
                "certain" => CategoryPredictionBin.Certain,
                "high" => CategoryPredictionBin.High,
                "low" => CategoryPredictionBin.Low,
                "very high" => CategoryPredictionBin.VeryHigh,
                "very low" => CategoryPredictionBin.VeryLow,
                _ => null,
            };
        }
    }
}