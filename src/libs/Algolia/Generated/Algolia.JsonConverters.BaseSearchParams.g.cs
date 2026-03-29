#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class BaseSearchParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.BaseSearchParams>
    {
        /// <inheritdoc />
        public override global::Algolia.BaseSearchParams Read(
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
            if (__jsonProps.Contains("query")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("analytics")) __score1++;
            if (__jsonProps.Contains("analyticsTags")) __score1++;
            if (__jsonProps.Contains("aroundLatLng")) __score1++;
            if (__jsonProps.Contains("aroundLatLngViaIP")) __score1++;
            if (__jsonProps.Contains("aroundPrecision")) __score1++;
            if (__jsonProps.Contains("aroundRadius")) __score1++;
            if (__jsonProps.Contains("clickAnalytics")) __score1++;
            if (__jsonProps.Contains("enableABTest")) __score1++;
            if (__jsonProps.Contains("facetFilters")) __score1++;
            if (__jsonProps.Contains("facetingAfterDistinct")) __score1++;
            if (__jsonProps.Contains("facets")) __score1++;
            if (__jsonProps.Contains("filters")) __score1++;
            if (__jsonProps.Contains("getRankingInfo")) __score1++;
            if (__jsonProps.Contains("insideBoundingBox")) __score1++;
            if (__jsonProps.Contains("insidePolygon")) __score1++;
            if (__jsonProps.Contains("length")) __score1++;
            if (__jsonProps.Contains("minimumAroundRadius")) __score1++;
            if (__jsonProps.Contains("naturalLanguages")) __score1++;
            if (__jsonProps.Contains("numericFilters")) __score1++;
            if (__jsonProps.Contains("offset")) __score1++;
            if (__jsonProps.Contains("optionalFilters")) __score1++;
            if (__jsonProps.Contains("page")) __score1++;
            if (__jsonProps.Contains("percentileComputation")) __score1++;
            if (__jsonProps.Contains("personalizationImpact")) __score1++;
            if (__jsonProps.Contains("restrictSearchableAttributes")) __score1++;
            if (__jsonProps.Contains("ruleContexts")) __score1++;
            if (__jsonProps.Contains("similarQuery")) __score1++;
            if (__jsonProps.Contains("sumOrFiltersScores")) __score1++;
            if (__jsonProps.Contains("synonyms")) __score1++;
            if (__jsonProps.Contains("tagFilters")) __score1++;
            if (__jsonProps.Contains("userToken")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Algolia.SearchParamsQuery? query = default;
            global::Algolia.BaseSearchParamsWithoutQuery? withoutQuery = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchParamsQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchParamsQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchParamsQuery).Name}");
                        query = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParamsWithoutQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParamsWithoutQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParamsWithoutQuery).Name}");
                        withoutQuery = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (query == null && withoutQuery == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchParamsQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchParamsQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchParamsQuery).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParamsWithoutQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParamsWithoutQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParamsWithoutQuery).Name}");
                    withoutQuery = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.BaseSearchParams(
                query,

                withoutQuery
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.BaseSearchParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.SearchParamsQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.SearchParamsQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.SearchParamsQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeInfo);
            }
            else if (value.IsWithoutQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParamsWithoutQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParamsWithoutQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParamsWithoutQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WithoutQuery, typeInfo);
            }
        }
    }
}