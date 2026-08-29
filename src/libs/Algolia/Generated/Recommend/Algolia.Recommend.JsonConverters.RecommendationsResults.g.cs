#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public class RecommendationsResultsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.RecommendationsResults>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.RecommendationsResults Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Algolia.Recommend.BaseSearchResponse? baseSearchResponse = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseSearchResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseSearchResponse).Name}");
                baseSearchResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Recommend.SearchPagination? searchPagination = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SearchPagination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SearchPagination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SearchPagination).Name}");
                searchPagination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Recommend.RecommendationsHits? hits = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendationsHits), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendationsHits> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendationsHits).Name}");
                hits = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Algolia.Recommend.RecommendationsResults(
                baseSearchResponse,

                searchPagination,

                hits
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.RecommendationsResults value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBaseSearchResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseSearchResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseSearchResponse).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.BaseSearchResponse!, typeInfo);
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
            if (value.IsSearchPagination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SearchPagination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SearchPagination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SearchPagination).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.SearchPagination!, typeInfo);
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
            if (value.IsHits)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendationsHits), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendationsHits?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendationsHits).Name}");
                var __element2 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Hits!, typeInfo);
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
            writer.WriteEndObject();
        }
    }
}