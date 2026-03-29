
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdvancedSyntaxFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        ExactPhrase,
        /// <summary>
        /// 
        /// </summary>
        ExcludeWords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdvancedSyntaxFeaturesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdvancedSyntaxFeatures value)
        {
            return value switch
            {
                AdvancedSyntaxFeatures.ExactPhrase => "exactPhrase",
                AdvancedSyntaxFeatures.ExcludeWords => "excludeWords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdvancedSyntaxFeatures? ToEnum(string value)
        {
            return value switch
            {
                "exactPhrase" => AdvancedSyntaxFeatures.ExactPhrase,
                "excludeWords" => AdvancedSyntaxFeatures.ExcludeWords,
                _ => null,
            };
        }
    }
}