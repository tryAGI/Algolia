
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// - `min`. Return matches with the lowest number of typos.<br/>
    ///   For example, if you have matches without typos, only include those.<br/>
    ///   But if there are no matches without typos (with 1 typo), include matches with 1 typo (2 typos).<br/>
    /// - `strict`. Return matches with the two lowest numbers of typos.<br/>
    ///   With `strict`, the Typo ranking criterion is applied first in the `ranking` setting.
    /// </summary>
    public enum TypoToleranceEnum
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        Min,
        /// <summary>
        /// 
        /// </summary>
        Strict,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TypoToleranceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypoToleranceEnum value)
        {
            return value switch
            {
                TypoToleranceEnum.False => "false",
                TypoToleranceEnum.Min => "min",
                TypoToleranceEnum.Strict => "strict",
                TypoToleranceEnum.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypoToleranceEnum? ToEnum(string value)
        {
            return value switch
            {
                "false" => TypoToleranceEnum.False,
                "min" => TypoToleranceEnum.Min,
                "strict" => TypoToleranceEnum.Strict,
                "true" => TypoToleranceEnum.True,
                _ => null,
            };
        }
    }
}