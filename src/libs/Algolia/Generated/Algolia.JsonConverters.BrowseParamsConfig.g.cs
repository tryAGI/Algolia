#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class BrowseParamsConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.BrowseParamsConfig>
    {
        /// <inheritdoc />
        public override global::Algolia.BrowseParamsConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Algolia.SearchParamsObject? searchParametersAsObject = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchParamsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchParamsObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchParamsObject).Name}");
                searchParametersAsObject = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Algolia.Cursor? cursor = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Cursor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Cursor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Cursor).Name}");
                cursor = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Algolia.BrowseParamsConfig(
                searchParametersAsObject,

                cursor
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.BrowseParamsConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsSearchParametersAsObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchParamsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchParamsObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchParamsObject).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.SearchParametersAsObject!.Value, typeInfo);
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
            if (value.IsCursor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Cursor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Cursor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Cursor).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Cursor!, typeInfo);
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