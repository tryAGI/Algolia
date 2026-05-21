#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class IndexSettingsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.IndexSettings>
    {
        /// <inheritdoc />
        public override global::Algolia.IndexSettings Read(
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
            if (__jsonProps.Contains("allowCompressionOfIntegerArray")) __score0++;
            if (__jsonProps.Contains("attributeForDistinct")) __score0++;
            if (__jsonProps.Contains("attributesForFaceting")) __score0++;
            if (__jsonProps.Contains("attributesToTransliterate")) __score0++;
            if (__jsonProps.Contains("camelCaseAttributes")) __score0++;
            if (__jsonProps.Contains("customNormalization")) __score0++;
            if (__jsonProps.Contains("customRanking")) __score0++;
            if (__jsonProps.Contains("decompoundedAttributes")) __score0++;
            if (__jsonProps.Contains("disablePrefixOnAttributes")) __score0++;
            if (__jsonProps.Contains("disableTypoToleranceOnWords")) __score0++;
            if (__jsonProps.Contains("indexLanguages")) __score0++;
            if (__jsonProps.Contains("keepDiacriticsOnCharacters")) __score0++;
            if (__jsonProps.Contains("maxFacetHits")) __score0++;
            if (__jsonProps.Contains("numericAttributesForFiltering")) __score0++;
            if (__jsonProps.Contains("paginationLimitedTo")) __score0++;
            if (__jsonProps.Contains("replicas")) __score0++;
            if (__jsonProps.Contains("searchableAttributes")) __score0++;
            if (__jsonProps.Contains("separatorsToIndex")) __score0++;
            if (__jsonProps.Contains("unretrievableAttributes")) __score0++;
            if (__jsonProps.Contains("userData")) __score0++;
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Algolia.BaseIndexSettings? @base = default;
            global::Algolia.IndexSettingsAsSearchParams? asSearchParams = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseIndexSettings> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseIndexSettings).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.IndexSettingsAsSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.IndexSettingsAsSearchParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.IndexSettingsAsSearchParams).Name}");
                        asSearchParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && asSearchParams == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseIndexSettings> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseIndexSettings).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (@base == null && asSearchParams == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.IndexSettingsAsSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.IndexSettingsAsSearchParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.IndexSettingsAsSearchParams).Name}");
                    asSearchParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.IndexSettings(
                @base,

                asSearchParams
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.IndexSettings value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseIndexSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseIndexSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseIndexSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsAsSearchParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.IndexSettingsAsSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.IndexSettingsAsSearchParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.IndexSettingsAsSearchParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsSearchParams!, typeInfo);
            }
        }
    }
}