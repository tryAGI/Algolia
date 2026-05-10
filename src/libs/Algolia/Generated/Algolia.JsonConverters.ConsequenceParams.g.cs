#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class ConsequenceParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.ConsequenceParams>
    {
        /// <inheritdoc />
        public override global::Algolia.ConsequenceParams Read(
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
            if (__jsonProps.Contains("length")) __score0++;
            if (__jsonProps.Contains("minimumAroundRadius")) __score0++;
            if (__jsonProps.Contains("naturalLanguages")) __score0++;
            if (__jsonProps.Contains("numericFilters")) __score0++;
            if (__jsonProps.Contains("offset")) __score0++;
            if (__jsonProps.Contains("optionalFilters")) __score0++;
            if (__jsonProps.Contains("page")) __score0++;
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
            if (__jsonProps.Contains("advancedSyntax")) __score1++;
            if (__jsonProps.Contains("advancedSyntaxFeatures")) __score1++;
            if (__jsonProps.Contains("allowTyposOnNumericTokens")) __score1++;
            if (__jsonProps.Contains("alternativesAsExact")) __score1++;
            if (__jsonProps.Contains("attributeCriteriaComputedByMinProximity")) __score1++;
            if (__jsonProps.Contains("attributesToHighlight")) __score1++;
            if (__jsonProps.Contains("attributesToRetrieve")) __score1++;
            if (__jsonProps.Contains("attributesToSnippet")) __score1++;
            if (__jsonProps.Contains("decompoundQuery")) __score1++;
            if (__jsonProps.Contains("disableExactOnAttributes")) __score1++;
            if (__jsonProps.Contains("disableTypoToleranceOnAttributes")) __score1++;
            if (__jsonProps.Contains("distinct")) __score1++;
            if (__jsonProps.Contains("enablePersonalization")) __score1++;
            if (__jsonProps.Contains("enableReRanking")) __score1++;
            if (__jsonProps.Contains("enableRules")) __score1++;
            if (__jsonProps.Contains("exactOnSingleWordQuery")) __score1++;
            if (__jsonProps.Contains("highlightPostTag")) __score1++;
            if (__jsonProps.Contains("highlightPreTag")) __score1++;
            if (__jsonProps.Contains("hitsPerPage")) __score1++;
            if (__jsonProps.Contains("ignorePlurals")) __score1++;
            if (__jsonProps.Contains("maxValuesPerFacet")) __score1++;
            if (__jsonProps.Contains("minProximity")) __score1++;
            if (__jsonProps.Contains("minWordSizefor1Typo")) __score1++;
            if (__jsonProps.Contains("minWordSizefor2Typos")) __score1++;
            if (__jsonProps.Contains("mode")) __score1++;
            if (__jsonProps.Contains("optionalWords")) __score1++;
            if (__jsonProps.Contains("queryLanguages")) __score1++;
            if (__jsonProps.Contains("queryType")) __score1++;
            if (__jsonProps.Contains("ranking")) __score1++;
            if (__jsonProps.Contains("reRankingApplyFilter")) __score1++;
            if (__jsonProps.Contains("relevancyStrictness")) __score1++;
            if (__jsonProps.Contains("removeStopWords")) __score1++;
            if (__jsonProps.Contains("removeWordsIfNoResults")) __score1++;
            if (__jsonProps.Contains("renderingContent")) __score1++;
            if (__jsonProps.Contains("renderingContent.facetOrdering")) __score1++;
            if (__jsonProps.Contains("renderingContent.redirect")) __score1++;
            if (__jsonProps.Contains("renderingContent.widgets")) __score1++;
            if (__jsonProps.Contains("replaceSynonymsInHighlight")) __score1++;
            if (__jsonProps.Contains("responseFields")) __score1++;
            if (__jsonProps.Contains("restrictHighlightAndSnippetArrays")) __score1++;
            if (__jsonProps.Contains("semanticSearch")) __score1++;
            if (__jsonProps.Contains("semanticSearch.eventSources")) __score1++;
            if (__jsonProps.Contains("snippetEllipsisText")) __score1++;
            if (__jsonProps.Contains("sortFacetValuesBy")) __score1++;
            if (__jsonProps.Contains("typoTolerance")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("automaticFacetFilters")) __score2++;
            if (__jsonProps.Contains("automaticOptionalFacetFilters")) __score2++;
            if (__jsonProps.Contains("query")) __score2++;
            if (__jsonProps.Contains("renderingContent")) __score2++;
            if (__jsonProps.Contains("renderingContent.facetOrdering")) __score2++;
            if (__jsonProps.Contains("renderingContent.redirect")) __score2++;
            if (__jsonProps.Contains("renderingContent.widgets")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Algolia.BaseSearchParamsWithoutQuery? baseSearchWithoutQuery = default;
            global::Algolia.IndexSettingsAsSearchParams? indexSettingsAsSearch = default;
            global::Algolia.Params? @params = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParamsWithoutQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParamsWithoutQuery> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParamsWithoutQuery).Name}");
                        baseSearchWithoutQuery = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.IndexSettingsAsSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.IndexSettingsAsSearchParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.IndexSettingsAsSearchParams).Name}");
                        indexSettingsAsSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Params), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Params> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Params).Name}");
                        @params = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseSearchWithoutQuery == null && indexSettingsAsSearch == null && @params == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParamsWithoutQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParamsWithoutQuery> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParamsWithoutQuery).Name}");
                    baseSearchWithoutQuery = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (baseSearchWithoutQuery == null && indexSettingsAsSearch == null && @params == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.IndexSettingsAsSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.IndexSettingsAsSearchParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.IndexSettingsAsSearchParams).Name}");
                    indexSettingsAsSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (baseSearchWithoutQuery == null && indexSettingsAsSearch == null && @params == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Params), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Params> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Params).Name}");
                    @params = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.ConsequenceParams(
                baseSearchWithoutQuery,

                indexSettingsAsSearch,

                @params
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.ConsequenceParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBaseSearchWithoutQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParamsWithoutQuery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParamsWithoutQuery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParamsWithoutQuery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseSearchWithoutQuery!, typeInfo);
            }
            else if (value.IsIndexSettingsAsSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.IndexSettingsAsSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.IndexSettingsAsSearchParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.IndexSettingsAsSearchParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IndexSettingsAsSearch!, typeInfo);
            }
            else if (value.IsParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.Params), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.Params?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.Params).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Params!, typeInfo);
            }
        }
    }
}