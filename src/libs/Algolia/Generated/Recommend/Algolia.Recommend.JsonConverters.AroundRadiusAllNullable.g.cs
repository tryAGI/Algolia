#nullable enable

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public sealed class AroundRadiusAllNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.AroundRadiusAll?>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.AroundRadiusAll? Read(
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
                        return global::Algolia.Recommend.AroundRadiusAllExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Algolia.Recommend.AroundRadiusAll)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Algolia.Recommend.AroundRadiusAll?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.AroundRadiusAll? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Algolia.Recommend.AroundRadiusAllExtensions.ToValueString(value.Value));
            }
        }
    }
}
