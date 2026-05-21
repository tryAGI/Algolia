#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class BrowseResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.BrowseResponse>
    {
        /// <inheritdoc />
        public override global::Algolia.BrowseResponse Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("_automaticInsights")) __score0++;
            if (__jsonProps.Contains("abTestID")) __score0++;
            if (__jsonProps.Contains("abTestVariantID")) __score0++;
            if (__jsonProps.Contains("appliedRules")) __score0++;
            if (__jsonProps.Contains("aroundLatLng")) __score0++;
            if (__jsonProps.Contains("automaticRadius")) __score0++;
            if (__jsonProps.Contains("exhaustive")) __score0++;
            if (__jsonProps.Contains("exhaustive.facetValues")) __score0++;
            if (__jsonProps.Contains("exhaustive.facetsCount")) __score0++;
            if (__jsonProps.Contains("exhaustive.nbHits")) __score0++;
            if (__jsonProps.Contains("exhaustive.rulesMatch")) __score0++;
            if (__jsonProps.Contains("exhaustive.typo")) __score0++;
            if (__jsonProps.Contains("exhaustiveFacetsCount")) __score0++;
            if (__jsonProps.Contains("exhaustiveNbHits")) __score0++;
            if (__jsonProps.Contains("exhaustiveTypo")) __score0++;
            if (__jsonProps.Contains("facets")) __score0++;
            if (__jsonProps.Contains("facets_stats")) __score0++;
            if (__jsonProps.Contains("index")) __score0++;
            if (__jsonProps.Contains("indexUsed")) __score0++;
            if (__jsonProps.Contains("message")) __score0++;
            if (__jsonProps.Contains("nbSortedHits")) __score0++;
            if (__jsonProps.Contains("parsedQuery")) __score0++;
            if (__jsonProps.Contains("processingTimeMS")) __score0++;
            if (__jsonProps.Contains("processingTimingsMS")) __score0++;
            if (__jsonProps.Contains("queryAfterRemoval")) __score0++;
            if (__jsonProps.Contains("queryID")) __score0++;
            if (__jsonProps.Contains("redirect")) __score0++;
            if (__jsonProps.Contains("redirect.index")) __score0++;
            if (__jsonProps.Contains("renderingContent")) __score0++;
            if (__jsonProps.Contains("renderingContent.facetOrdering")) __score0++;
            if (__jsonProps.Contains("renderingContent.redirect")) __score0++;
            if (__jsonProps.Contains("renderingContent.widgets")) __score0++;
            if (__jsonProps.Contains("serverTimeMS")) __score0++;
            if (__jsonProps.Contains("serverUsed")) __score0++;
            if (__jsonProps.Contains("userData")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("hitsPerPage")) __score1++;
            if (__jsonProps.Contains("nbHits")) __score1++;
            if (__jsonProps.Contains("nbPages")) __score1++;
            if (__jsonProps.Contains("page")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("extensions")) __score2++;
            if (__jsonProps.Contains("extensions.queryCategorization")) __score2++;
            if (__jsonProps.Contains("hits")) __score2++;
            if (__jsonProps.Contains("params")) __score2++;
            if (__jsonProps.Contains("query")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("cursor")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Algolia.BaseSearchResponse? baseSearch = default;
            global::Algolia.BrowsePagination? pagination = default;
            global::Algolia.SearchHits? searchHits = default;
            global::Algolia.Cursor? cursor = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchResponse).Name}");
                        baseSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BrowsePagination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BrowsePagination> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BrowsePagination).Name}");
                        pagination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchHits), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchHits> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchHits).Name}");
                        searchHits = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
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
                }
            }

            if (baseSearch == null && pagination == null && searchHits == null && cursor == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchResponse).Name}");
                    baseSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (baseSearch == null && pagination == null && searchHits == null && cursor == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BrowsePagination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BrowsePagination> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BrowsePagination).Name}");
                    pagination = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (baseSearch == null && pagination == null && searchHits == null && cursor == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchHits), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchHits> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchHits).Name}");
                    searchHits = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (baseSearch == null && pagination == null && searchHits == null && cursor == null)
            {
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
            }

            var __value = new global::Algolia.BrowseResponse(
                baseSearch,

                pagination,

                searchHits,

                cursor
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.BrowseResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBaseSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseSearch!, typeInfo);
            }
            else if (value.IsPagination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BrowsePagination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BrowsePagination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BrowsePagination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pagination!, typeInfo);
            }
            else if (value.IsSearchHits)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchHits), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchHits?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchHits).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchHits!, typeInfo);
            }
            else if (value.IsCursor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Cursor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Cursor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Cursor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cursor!, typeInfo);
            }
        }
    }
}