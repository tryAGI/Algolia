#nullable enable

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public sealed class RemoveWordsIfNoResultsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.RemoveWordsIfNoResults>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.RemoveWordsIfNoResults Read(
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
                        return global::Algolia.Recommend.RemoveWordsIfNoResultsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Algolia.Recommend.RemoveWordsIfNoResults)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Algolia.Recommend.RemoveWordsIfNoResults);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.RemoveWordsIfNoResults value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Algolia.Recommend.RemoveWordsIfNoResultsExtensions.ToValueString(value));
        }
    }
}
