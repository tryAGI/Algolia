#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public class RecommendIndexSettingsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.RecommendIndexSettings>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.RecommendIndexSettings Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Algolia.Recommend.BaseIndexSettings? base1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseIndexSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseIndexSettings).Name}");
                base1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Recommend.BaseRecommendIndexSettings? base2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendIndexSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendIndexSettings).Name}");
                base2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Algolia.Recommend.RecommendIndexSettings(
                base1,

                base2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.RecommendIndexSettings value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBase1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseIndexSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseIndexSettings).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Base1!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsBase2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendIndexSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendIndexSettings).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Base2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}