#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia.JsonConverters
{
    /// <inheritdoc />
    public class SearchParamsObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Algolia.SearchParamsObject>
    {
        /// <inheritdoc />
        public override global::Algolia.SearchParamsObject Read(
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
            if (__jsonProps.Contains("replaceSynonymsInHighlight")) __score1++;
            if (__jsonProps.Contains("responseFields")) __score1++;
            if (__jsonProps.Contains("restrictHighlightAndSnippetArrays")) __score1++;
            if (__jsonProps.Contains("semanticSearch")) __score1++;
            if (__jsonProps.Contains("snippetEllipsisText")) __score1++;
            if (__jsonProps.Contains("sortFacetValuesBy")) __score1++;
            if (__jsonProps.Contains("typoTolerance")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Algolia.BaseSearchParams? @base = default;
            global::Algolia.IndexSettingsAsSearchParams? indexSettingsAs = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParams).Name}");
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
                        indexSettingsAs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && indexSettingsAs == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParams).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.IndexSettingsAsSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.IndexSettingsAsSearchParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.IndexSettingsAsSearchParams).Name}");
                    indexSettingsAs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Algolia.SearchParamsObject(
                @base,

                indexSettingsAs
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Algolia.SearchParamsObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.BaseSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.BaseSearchParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.BaseSearchParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!.Value, typeInfo);
            }
            else if (value.IsIndexSettingsAs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Algolia.IndexSettingsAsSearchParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Algolia.IndexSettingsAsSearchParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Algolia.IndexSettingsAsSearchParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IndexSettingsAs!, typeInfo);
            }
        }
    }
}