#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class HighlightResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.HighlightResult>
    {
        /// <inheritdoc />
        public override global::Algolia.HighlightResult Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("fullyHighlighted")) __score0++;
            if (__jsonProps.Contains("matchLevel")) __score0++;
            if (__jsonProps.Contains("matchedWords")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Algolia.HighlightResultOption? highlightResultOption = default;
            global::Algolia.HighlightResultMap? highlightResultMap = default;
            global::System.Collections.Generic.IList<global::Algolia.HighlightResult>? highlightResultArray = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.HighlightResultOption), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.HighlightResultOption> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.HighlightResultOption).Name}");
                        highlightResultOption = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.HighlightResultMap), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.HighlightResultMap> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.HighlightResultMap).Name}");
                        highlightResultMap = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Algolia.HighlightResult>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Algolia.HighlightResult>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Algolia.HighlightResult>).Name}");
                        highlightResultArray = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (highlightResultOption == null && highlightResultMap == null && highlightResultArray == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.HighlightResultOption), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.HighlightResultOption> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.HighlightResultOption).Name}");
                    highlightResultOption = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.HighlightResultMap), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.HighlightResultMap> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.HighlightResultMap).Name}");
                    highlightResultMap = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Algolia.HighlightResult>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Algolia.HighlightResult>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Algolia.HighlightResult>).Name}");
                    highlightResultArray = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.HighlightResult(
                highlightResultOption,

                highlightResultMap,

                highlightResultArray
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.HighlightResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsHighlightResultOption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.HighlightResultOption), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.HighlightResultOption?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.HighlightResultOption).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HighlightResultOption!, typeInfo);
            }
            else if (value.IsHighlightResultMap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.HighlightResultMap), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.HighlightResultMap?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.HighlightResultMap).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HighlightResultMap!, typeInfo);
            }
            else if (value.IsHighlightResultArray)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Algolia.HighlightResult>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Algolia.HighlightResult>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Algolia.HighlightResult>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HighlightResultArray!, typeInfo);
            }
        }
    }
}