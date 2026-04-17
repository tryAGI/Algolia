#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class PromoteJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Promote>
    {
        /// <inheritdoc />
        public override global::Algolia.Promote Read(
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
            if (__jsonProps.Contains("objectIDs")) __score0++;
            if (__jsonProps.Contains("position")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("objectID")) __score1++;
            if (__jsonProps.Contains("position")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Algolia.PromoteObjectIDs? objectIDs = default;
            global::Algolia.PromoteObjectID? objectID = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.PromoteObjectIDs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.PromoteObjectIDs> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.PromoteObjectIDs).Name}");
                        objectIDs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.PromoteObjectID), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.PromoteObjectID> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.PromoteObjectID).Name}");
                        objectID = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (objectIDs == null && objectID == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.PromoteObjectIDs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.PromoteObjectIDs> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.PromoteObjectIDs).Name}");
                    objectIDs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.PromoteObjectID), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.PromoteObjectID> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.PromoteObjectID).Name}");
                    objectID = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.Promote(
                objectIDs,

                objectID
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Promote value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsObjectIDs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.PromoteObjectIDs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.PromoteObjectIDs?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.PromoteObjectIDs).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ObjectIDs!, typeInfo);
            }
            else if (value.IsObjectID)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.PromoteObjectID), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.PromoteObjectID?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.PromoteObjectID).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ObjectID!, typeInfo);
            }
        }
    }
}