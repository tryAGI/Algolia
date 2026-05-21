#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public class SnippetResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.SnippetResult>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.SnippetResult Read(
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
            if (__jsonProps.Contains("matchLevel")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Algolia.Recommend.SnippetResultOption? snippetResultOption = default;
            global::Algolia.Recommend.SnippetResultMap? snippetResultMap = default;
            global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>? snippetResultArray = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SnippetResultOption), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SnippetResultOption> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SnippetResultOption).Name}");
                        snippetResultOption = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SnippetResultMap), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SnippetResultMap> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SnippetResultMap).Name}");
                        snippetResultMap = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>).Name}");
                        snippetResultArray = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (snippetResultOption == null && snippetResultMap == null && snippetResultArray == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SnippetResultOption), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SnippetResultOption> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SnippetResultOption).Name}");
                    snippetResultOption = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (snippetResultOption == null && snippetResultMap == null && snippetResultArray == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SnippetResultMap), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SnippetResultMap> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SnippetResultMap).Name}");
                    snippetResultMap = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (snippetResultOption == null && snippetResultMap == null && snippetResultArray == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>).Name}");
                    snippetResultArray = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.Recommend.SnippetResult(
                snippetResultOption,

                snippetResultMap,

                snippetResultArray
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.SnippetResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSnippetResultOption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SnippetResultOption), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SnippetResultOption?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SnippetResultOption).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SnippetResultOption!, typeInfo);
            }
            else if (value.IsSnippetResultMap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SnippetResultMap), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SnippetResultMap?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SnippetResultMap).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SnippetResultMap!, typeInfo);
            }
            else if (value.IsSnippetResultArray)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SnippetResultArray!, typeInfo);
            }
        }
    }
}