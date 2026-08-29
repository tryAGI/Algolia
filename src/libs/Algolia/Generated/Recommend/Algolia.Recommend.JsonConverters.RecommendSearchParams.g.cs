#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public class RecommendSearchParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.RecommendSearchParams>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.RecommendSearchParams Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Algolia.Recommend.BaseRecommendSearchParams? @base = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendSearchParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendSearchParams).Name}");
                @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Recommend.SearchParamsQuery? query = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SearchParamsQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SearchParamsQuery> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SearchParamsQuery).Name}");
                query = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Recommend.RecommendIndexSettings? indexSettings = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendIndexSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendIndexSettings).Name}");
                indexSettings = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Recommend.RecommendSearchParamsVariant4? recommendSearchParamsVariant4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendSearchParamsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendSearchParamsVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendSearchParamsVariant4).Name}");
                recommendSearchParamsVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Algolia.Recommend.RecommendSearchParams(
                @base,

                query,

                indexSettings,

                recommendSearchParamsVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.RecommendSearchParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendSearchParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendSearchParams).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Base!, typeInfo);
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
            if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SearchParamsQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SearchParamsQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SearchParamsQuery).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Query!, typeInfo);
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
            if (value.IsIndexSettings)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendIndexSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendIndexSettings).Name}");
                var __element2 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.IndexSettings!.Value, typeInfo);
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
            if (value.IsRecommendSearchParamsVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendSearchParamsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendSearchParamsVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendSearchParamsVariant4).Name}");
                var __element3 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.RecommendSearchParamsVariant4!, typeInfo);
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