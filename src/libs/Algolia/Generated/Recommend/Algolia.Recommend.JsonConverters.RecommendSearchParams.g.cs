#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.Recommend.JsonConverters
{
    /// <inheritdoc />
    public class RecommendSearchParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.Recommend.RecommendSearchParams>
    {
        /// <inheritdoc />
        public override global::Algolia.Recommend.RecommendSearchParams Read(
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
            if (__jsonProps.Contains("analytics")) __score0++;
            if (__jsonProps.Contains("analyticsTags")) __score0++;
            if (__jsonProps.Contains("aroundLatLng")) __score0++;
            if (__jsonProps.Contains("aroundLatLngViaIP")) __score0++;
            if (__jsonProps.Contains("aroundPrecision")) __score0++;
            if (__jsonProps.Contains("aroundRadius")) __score0++;
            if (__jsonProps.Contains("clickAnalytics")) __score0++;
            if (__jsonProps.Contains("enableABTest")) __score0++;
            if (__jsonProps.Contains("facetFilters")) __score0++;
            if (__jsonProps.Contains("facetingAfterDistinct")) __score0++;
            if (__jsonProps.Contains("facets")) __score0++;
            if (__jsonProps.Contains("filters")) __score0++;
            if (__jsonProps.Contains("getRankingInfo")) __score0++;
            if (__jsonProps.Contains("insideBoundingBox")) __score0++;
            if (__jsonProps.Contains("insidePolygon")) __score0++;
            if (__jsonProps.Contains("minimumAroundRadius")) __score0++;
            if (__jsonProps.Contains("naturalLanguages")) __score0++;
            if (__jsonProps.Contains("numericFilters")) __score0++;
            if (__jsonProps.Contains("optionalFilters")) __score0++;
            if (__jsonProps.Contains("percentileComputation")) __score0++;
            if (__jsonProps.Contains("personalizationImpact")) __score0++;
            if (__jsonProps.Contains("restrictSearchableAttributes")) __score0++;
            if (__jsonProps.Contains("ruleContexts")) __score0++;
            if (__jsonProps.Contains("similarQuery")) __score0++;
            if (__jsonProps.Contains("sumOrFiltersScores")) __score0++;
            if (__jsonProps.Contains("synonyms")) __score0++;
            if (__jsonProps.Contains("tagFilters")) __score0++;
            if (__jsonProps.Contains("userToken")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("query")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Algolia.Recommend.BaseRecommendSearchParams? @base = default;
            global::Algolia.Recommend.SearchParamsQuery? query = default;
            global::Algolia.Recommend.RecommendIndexSettings? indexSettings = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendSearchParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendSearchParams).Name}");
                        @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SearchParamsQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SearchParamsQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SearchParamsQuery).Name}");
                        query = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendIndexSettings> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendIndexSettings).Name}");
                        indexSettings = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && query == null && indexSettings == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendSearchParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendSearchParams).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SearchParamsQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SearchParamsQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SearchParamsQuery).Name}");
                    query = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendIndexSettings> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendIndexSettings).Name}");
                    indexSettings = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.Recommend.RecommendSearchParams(
                @base,

                query,

                indexSettings
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.Recommend.RecommendSearchParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.BaseRecommendSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.BaseRecommendSearchParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.BaseRecommendSearchParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base, typeInfo);
            }
            else if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.SearchParamsQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.SearchParamsQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.SearchParamsQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeInfo);
            }
            else if (value.IsIndexSettings)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Recommend.RecommendIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Recommend.RecommendIndexSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Recommend.RecommendIndexSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IndexSettings, typeInfo);
            }
        }
    }
}