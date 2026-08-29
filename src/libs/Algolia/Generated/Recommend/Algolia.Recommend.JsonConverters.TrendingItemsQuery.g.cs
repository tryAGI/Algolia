#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public class TrendingItemsQueryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.TrendingItemsQuery>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.TrendingItemsQuery Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Algolia.Recommend.BaseRecommendRequest? baseRecommendRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendRequest).Name}");
                baseRecommendRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Recommend.TrendingItems? trendingItems = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.TrendingItems), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.TrendingItems> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.TrendingItems).Name}");
                trendingItems = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Algolia.Recommend.TrendingItemsQuery(
                baseRecommendRequest,

                trendingItems
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.TrendingItemsQuery value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBaseRecommendRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendRequest).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.BaseRecommendRequest!, typeInfo);
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
            if (value.IsTrendingItems)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.TrendingItems), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.TrendingItems?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.TrendingItems).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.TrendingItems!, typeInfo);
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