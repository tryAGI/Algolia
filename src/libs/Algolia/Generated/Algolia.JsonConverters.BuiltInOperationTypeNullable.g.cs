#nullable enable

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public sealed class BuiltInOperationTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.BuiltInOperationType?>
    {
        /// <inheritdoc />
        public override global::Algolia.BuiltInOperationType? Read(
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
                        return global::Algolia.BuiltInOperationTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Algolia.BuiltInOperationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Algolia.BuiltInOperationType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.BuiltInOperationType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Algolia.BuiltInOperationTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
