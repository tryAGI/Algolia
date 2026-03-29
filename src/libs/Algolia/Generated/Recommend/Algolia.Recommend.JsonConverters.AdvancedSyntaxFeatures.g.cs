#nullable enable

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public sealed class AdvancedSyntaxFeaturesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.AdvancedSyntaxFeatures>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.AdvancedSyntaxFeatures Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Algolia.Recommend.AdvancedSyntaxFeaturesExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Algolia.Recommend.AdvancedSyntaxFeatures)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Algolia.Recommend.AdvancedSyntaxFeatures);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.AdvancedSyntaxFeatures value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Algolia.Recommend.AdvancedSyntaxFeaturesExtensions.ToValueString(value));
        }
    }
}
