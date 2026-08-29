#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public class FallbackParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.FallbackParams>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.FallbackParams Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Algolia.Recommend.BaseRecommendSearchParams? baseRecommendSearch = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendSearchParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendSearchParams).Name}");
                baseRecommendSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Recommend.SearchParamsQuery? searchQuery = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SearchParamsQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SearchParamsQuery> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SearchParamsQuery).Name}");
                searchQuery = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Recommend.RecommendIndexSettings? recommendIndexSettings = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendIndexSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendIndexSettings).Name}");
                recommendIndexSettings = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Recommend.FallbackParamsVariant4? fallbackParamsVariant4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.FallbackParamsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.FallbackParamsVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.FallbackParamsVariant4).Name}");
                fallbackParamsVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Algolia.Recommend.FallbackParams(
                baseRecommendSearch,

                searchQuery,

                recommendIndexSettings,

                fallbackParamsVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.FallbackParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBaseRecommendSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendSearchParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendSearchParams).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.BaseRecommendSearch!, typeInfo);
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
            if (value.IsSearchQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SearchParamsQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SearchParamsQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SearchParamsQuery).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.SearchQuery!, typeInfo);
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
            if (value.IsRecommendIndexSettings)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendIndexSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendIndexSettings).Name}");
                var __element2 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.RecommendIndexSettings!.Value, typeInfo);
                if (__element2.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element2.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsFallbackParamsVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.FallbackParamsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.FallbackParamsVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.FallbackParamsVariant4).Name}");
                var __element3 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.FallbackParamsVariant4!, typeInfo);
                if (__element3.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element3.EnumerateObject())
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