#nullable enable

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiKeyOperationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.ApiKeyOperation>
    {
        /// <inheritdoc />
        public override global::Algolia.ApiKeyOperation Read(
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
                        return global::Algolia.ApiKeyOperationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Algolia.ApiKeyOperation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Algolia.ApiKeyOperation);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.ApiKeyOperation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Algolia.ApiKeyOperationExtensions.ToValueString(value));
        }
    }
}
