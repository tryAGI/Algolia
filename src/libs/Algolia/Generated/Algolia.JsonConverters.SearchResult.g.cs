#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class SearchResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.SearchResult>
    {
        /// <inheritdoc />
        public override global::Algolia.SearchResult Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("exhaustiveFacetsCount")) __score1++;
            if (__jsonProps.Contains("facetHits")) __score1++;
            if (__jsonProps.Contains("processingTimeMS")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Algolia.SearchResponse? response = default;
            global::Algolia.SearchForFacetValuesResponse? forFacetValuesResponse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchResponse).Name}");
                        response = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchForFacetValuesResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchForFacetValuesResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchForFacetValuesResponse).Name}");
                        forFacetValuesResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (response == null && forFacetValuesResponse == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchResponse).Name}");
                    response = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchForFacetValuesResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchForFacetValuesResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchForFacetValuesResponse).Name}");
                    forFacetValuesResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.SearchResult(
                response,

                forFacetValuesResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.SearchResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Response, typeInfo);
            }
            else if (value.IsForFacetValuesResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchForFacetValuesResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchForFacetValuesResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchForFacetValuesResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ForFacetValuesResponse, typeInfo);
            }
        }
    }
}