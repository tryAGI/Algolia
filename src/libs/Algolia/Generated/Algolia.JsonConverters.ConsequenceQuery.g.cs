#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class ConsequenceQueryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.ConsequenceQuery>
    {
        /// <inheritdoc />
        public override global::Algolia.ConsequenceQuery Read(
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
            if (__jsonProps.Contains("edits")) __score0++;
            if (__jsonProps.Contains("remove")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Algolia.ConsequenceQueryObject? objectValue = default;
            string? consequenceQueryVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.ConsequenceQueryObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.ConsequenceQueryObject> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.ConsequenceQueryObject).Name}");
                        objectValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        consequenceQueryVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (objectValue == null && consequenceQueryVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.ConsequenceQueryObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.ConsequenceQueryObject> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.ConsequenceQueryObject).Name}");
                    objectValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    consequenceQueryVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.ConsequenceQuery(
                objectValue,

                consequenceQueryVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.ConsequenceQuery value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsObjectValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.ConsequenceQueryObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.ConsequenceQueryObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.ConsequenceQueryObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ObjectValue!, typeInfo);
            }
            else if (value.IsConsequenceQueryVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConsequenceQueryVariant2!, typeInfo);
            }
        }
    }
}