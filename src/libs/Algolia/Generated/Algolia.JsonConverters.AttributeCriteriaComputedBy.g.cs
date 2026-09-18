#nullable enable

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public sealed class AttributeCriteriaComputedByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.AttributeCriteriaComputedBy>
    {
        /// <inheritdoc />
        public override global::Algolia.AttributeCriteriaComputedBy Read(
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
                        return global::Algolia.AttributeCriteriaComputedByExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Algolia.AttributeCriteriaComputedBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Algolia.AttributeCriteriaComputedBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.AttributeCriteriaComputedBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Algolia.AttributeCriteriaComputedByExtensions.ToValueString(value));
        }
    }
}
