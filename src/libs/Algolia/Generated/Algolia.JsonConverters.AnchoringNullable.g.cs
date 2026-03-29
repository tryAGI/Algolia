#nullable enable

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnchoringNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Anchoring?>
    {
        /// <inheritdoc />
        public override global::Algolia.Anchoring? Read(
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
                        return global::Algolia.AnchoringExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Algolia.Anchoring)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Algolia.Anchoring?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Anchoring? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Algolia.AnchoringExtensions.ToValueString(value.Value));
            }
        }
    }
}
