#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class ConsequenceParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.ConsequenceParams>
    {
        /// <inheritdoc />
        public override global::Algolia.ConsequenceParams Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Algolia.BaseSearchParamsWithoutQuery? baseSearchWithoutQuery = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParamsWithoutQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParamsWithoutQuery> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParamsWithoutQuery).Name}");
                baseSearchWithoutQuery = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.IndexSettingsAsSearchParams? indexSettingsAsSearch = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.IndexSettingsAsSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.IndexSettingsAsSearchParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.IndexSettingsAsSearchParams).Name}");
                indexSettingsAsSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Params? @params = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Params), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Params> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Params).Name}");
                @params = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Algolia.ConsequenceParams(
                baseSearchWithoutQuery,

                indexSettingsAsSearch,

                @params
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.ConsequenceParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBaseSearchWithoutQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParamsWithoutQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParamsWithoutQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParamsWithoutQuery).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.BaseSearchWithoutQuery!, typeInfo);
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
            if (value.IsIndexSettingsAsSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.IndexSettingsAsSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.IndexSettingsAsSearchParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.IndexSettingsAsSearchParams).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.IndexSettingsAsSearch!, typeInfo);
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
            if (value.IsParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Params), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Params?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Params).Name}");
                var __element2 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Params!, typeInfo);
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