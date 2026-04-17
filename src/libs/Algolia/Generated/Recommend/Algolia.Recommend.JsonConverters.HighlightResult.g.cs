#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public class HighlightResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.HighlightResult>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.HighlightResult Read(
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

            global::Algolia.Recommend.HighlightResultOption? highlightResultOption = default;
            global::Algolia.Recommend.HighlightResultMap? highlightResultMap = default;
            global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>? highlightResultArray = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.HighlightResultOption), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.HighlightResultOption> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.HighlightResultOption).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.HighlightResultMap), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.HighlightResultMap> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.HighlightResultMap).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.HighlightResultOption), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.HighlightResultOption> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.HighlightResultOption).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.HighlightResultMap), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.HighlightResultMap> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.HighlightResultMap).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>).Name}");
                    highlightResultArray = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.Recommend.HighlightResult(
                highlightResultOption,

                highlightResultMap,

                highlightResultArray
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.HighlightResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsHighlightResultOption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.HighlightResultOption), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.HighlightResultOption?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.HighlightResultOption).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HighlightResultOption!, typeInfo);
            }
            else if (value.IsHighlightResultMap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.HighlightResultMap), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.HighlightResultMap?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.HighlightResultMap).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HighlightResultMap!, typeInfo);
            }
            else if (value.IsHighlightResultArray)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HighlightResultArray!, typeInfo);
            }
        }
    }
}