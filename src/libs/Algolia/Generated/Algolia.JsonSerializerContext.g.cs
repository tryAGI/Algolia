
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Algolia.JsonConverters.AroundRadiusAllJsonConverter),

            typeof(global::Algolia.JsonConverters.AroundRadiusAllNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.SupportedLanguageJsonConverter),

            typeof(global::Algolia.JsonConverters.SupportedLanguageNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.TypoToleranceEnumJsonConverter),

            typeof(global::Algolia.JsonConverters.TypoToleranceEnumNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.BooleanStringJsonConverter),

            typeof(global::Algolia.JsonConverters.BooleanStringNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.QueryTypeJsonConverter),

            typeof(global::Algolia.JsonConverters.QueryTypeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.RemoveWordsIfNoResultsJsonConverter),

            typeof(global::Algolia.JsonConverters.RemoveWordsIfNoResultsNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.ModeJsonConverter),

            typeof(global::Algolia.JsonConverters.ModeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.ExactOnSingleWordQueryJsonConverter),

            typeof(global::Algolia.JsonConverters.ExactOnSingleWordQueryNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.AlternativesAsExactJsonConverter),

            typeof(global::Algolia.JsonConverters.AlternativesAsExactNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.AdvancedSyntaxFeaturesJsonConverter),

            typeof(global::Algolia.JsonConverters.AdvancedSyntaxFeaturesNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.SortRemainingByJsonConverter),

            typeof(global::Algolia.JsonConverters.SortRemainingByNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.MatchLevelJsonConverter),

            typeof(global::Algolia.JsonConverters.MatchLevelNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchTypeDefaultJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchTypeDefaultNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchTypeFacetJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchTypeFacetNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchStrategyJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchStrategyNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.ActionJsonConverter),

            typeof(global::Algolia.JsonConverters.ActionNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.SynonymTypeJsonConverter),

            typeof(global::Algolia.JsonConverters.SynonymTypeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.AclJsonConverter),

            typeof(global::Algolia.JsonConverters.AclNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.AnchoringJsonConverter),

            typeof(global::Algolia.JsonConverters.AnchoringNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.EditTypeJsonConverter),

            typeof(global::Algolia.JsonConverters.EditTypeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.DictionaryTypeJsonConverter),

            typeof(global::Algolia.JsonConverters.DictionaryTypeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.DictionaryActionJsonConverter),

            typeof(global::Algolia.JsonConverters.DictionaryActionNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.DictionaryEntryStateJsonConverter),

            typeof(global::Algolia.JsonConverters.DictionaryEntryStateNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.DictionaryEntryTypeJsonConverter),

            typeof(global::Algolia.JsonConverters.DictionaryEntryTypeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.LogTypeJsonConverter),

            typeof(global::Algolia.JsonConverters.LogTypeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.TaskStatusJsonConverter),

            typeof(global::Algolia.JsonConverters.TaskStatusNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.OperationTypeJsonConverter),

            typeof(global::Algolia.JsonConverters.OperationTypeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.ScopeTypeJsonConverter),

            typeof(global::Algolia.JsonConverters.ScopeTypeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.ApiKeyOperationJsonConverter),

            typeof(global::Algolia.JsonConverters.ApiKeyOperationNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.EventStatusEnumJsonConverter),

            typeof(global::Algolia.JsonConverters.EventStatusEnumNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.EventTypeJsonConverter),

            typeof(global::Algolia.JsonConverters.EventTypeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.BuiltInOperationTypeJsonConverter),

            typeof(global::Algolia.JsonConverters.BuiltInOperationTypeNullableJsonConverter),

            typeof(global::Algolia.JsonConverters.AttributeToUpdateJsonConverter),

            typeof(global::Algolia.JsonConverters.FacetFiltersJsonConverter),

            typeof(global::Algolia.JsonConverters.OptionalFiltersJsonConverter),

            typeof(global::Algolia.JsonConverters.NumericFiltersJsonConverter),

            typeof(global::Algolia.JsonConverters.TagFiltersJsonConverter),

            typeof(global::Algolia.JsonConverters.AroundRadiusJsonConverter),

            typeof(global::Algolia.JsonConverters.AroundPrecisionJsonConverter),

            typeof(global::Algolia.JsonConverters.InsideBoundingBoxJsonConverter),

            typeof(global::Algolia.JsonConverters.BaseSearchParamsJsonConverter),

            typeof(global::Algolia.JsonConverters.TypoToleranceJsonConverter),

            typeof(global::Algolia.JsonConverters.IgnorePluralsJsonConverter),

            typeof(global::Algolia.JsonConverters.RemoveStopWordsJsonConverter),

            typeof(global::Algolia.JsonConverters.OptionalWordsJsonConverter),

            typeof(global::Algolia.JsonConverters.DistinctJsonConverter),

            typeof(global::Algolia.JsonConverters.ReRankingApplyFilterJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchParamsObjectJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchParamsJsonConverter),

            typeof(global::Algolia.JsonConverters.HighlightResultJsonConverter),

            typeof(global::Algolia.JsonConverters.SnippetResultJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchResponseJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchForHitsJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchForFacetsJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchQueryJsonConverter),

            typeof(global::Algolia.JsonConverters.SearchResultJsonConverter),

            typeof(global::Algolia.JsonConverters.BrowseParamsConfigJsonConverter),

            typeof(global::Algolia.JsonConverters.BrowseParamsJsonConverter),

            typeof(global::Algolia.JsonConverters.BrowseResponseJsonConverter),

            typeof(global::Algolia.JsonConverters.IndexSettingsJsonConverter),

            typeof(global::Algolia.JsonConverters.SettingsResponseJsonConverter),

            typeof(global::Algolia.JsonConverters.GetApiKeyResponseJsonConverter),

            typeof(global::Algolia.JsonConverters.ConsequenceQueryJsonConverter),

            typeof(global::Algolia.JsonConverters.AutomaticFacetFiltersJsonConverter),

            typeof(global::Algolia.JsonConverters.ConsequenceParamsJsonConverter),

            typeof(global::Algolia.JsonConverters.PromoteJsonConverter),

            typeof(global::Algolia.JsonConverters.StandardEntryJsonConverter),

            typeof(global::Algolia.JsonConverters.DictionaryLanguageJsonConverter),

            typeof(global::Algolia.JsonConverters.EventStatusJsonConverter),

            typeof(global::Algolia.JsonConverters.BuiltInOperationValueJsonConverter),

            typeof(global::Algolia.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Algolia.JsonConverters.OneOfJsonConverter<global::Algolia.ReRankingApplyFilter?, object>),

            typeof(global::Algolia.JsonConverters.OneOfJsonConverter<bool?, object>),

            typeof(global::Algolia.JsonConverters.OneOfJsonConverter<int?, object>),

            typeof(global::Algolia.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Algolia.JsonConverters.OneOfJsonConverter<int?, object>),

            typeof(global::Algolia.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AttributeToUpdate), TypeInfoPropertyName = "AttributeToUpdate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BuiltInOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ErrorBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchParamsString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchParamsQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.FacetFilters), TypeInfoPropertyName = "FacetFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.FacetFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.OptionalFilters), TypeInfoPropertyName = "OptionalFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.OptionalFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.NumericFilters), TypeInfoPropertyName = "NumericFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.NumericFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.TagFilters), TypeInfoPropertyName = "TagFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.TagFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AroundRadiusAll), TypeInfoPropertyName = "AroundRadiusAll2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AroundRadius), TypeInfoPropertyName = "AroundRadius2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.AroundPrecisionFromValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AroundPrecisionFromValueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AroundPrecision), TypeInfoPropertyName = "AroundPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.InsideBoundingBox), TypeInfoPropertyName = "InsideBoundingBox2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SupportedLanguage), TypeInfoPropertyName = "SupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BaseSearchParamsWithoutQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BaseSearchParams), TypeInfoPropertyName = "BaseSearchParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.TypoToleranceEnum), TypeInfoPropertyName = "TypoToleranceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.TypoTolerance), TypeInfoPropertyName = "TypoTolerance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BooleanString), TypeInfoPropertyName = "BooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.IgnorePlurals), TypeInfoPropertyName = "IgnorePlurals2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.RemoveStopWords), TypeInfoPropertyName = "RemoveStopWords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.QueryType), TypeInfoPropertyName = "QueryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.RemoveWordsIfNoResults), TypeInfoPropertyName = "RemoveWordsIfNoResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Mode), TypeInfoPropertyName = "Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SemanticSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.OneOf<global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "OneOfIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.OptionalWords), TypeInfoPropertyName = "OptionalWords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ExactOnSingleWordQuery), TypeInfoPropertyName = "ExactOnSingleWordQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AlternativesAsExact), TypeInfoPropertyName = "AlternativesAsExact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.AlternativesAsExact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AdvancedSyntaxFeatures), TypeInfoPropertyName = "AdvancedSyntaxFeatures2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.AdvancedSyntaxFeatures>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Distinct), TypeInfoPropertyName = "Distinct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Facets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SortRemainingBy), TypeInfoPropertyName = "SortRemainingBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Algolia.Value>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.FacetOrdering))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.RedirectURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BannerImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BannerImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.BannerImageUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BannerLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Banner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Banner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Widgets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.RenderingContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ReRankingApplyFilter), TypeInfoPropertyName = "ReRankingApplyFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.ReRankingApplyFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.IndexSettingsAsSearchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.OneOf<global::Algolia.ReRankingApplyFilter?, object>), TypeInfoPropertyName = "OneOfReRankingApplyFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchParamsObject), TypeInfoPropertyName = "SearchParamsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchParams), TypeInfoPropertyName = "SearchParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.RedirectRuleIndexMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.RedirectRuleIndexMetadataData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.UserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BaseSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BaseSearchResponseExhaustive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Algolia.BaseSearchResponseFacetsStats2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BaseSearchResponseFacetsStats2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BaseSearchResponseRedirect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.RedirectRuleIndexMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.MatchLevel), TypeInfoPropertyName = "MatchLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.HighlightResultOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.HighlightResultMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.HighlightResult), TypeInfoPropertyName = "HighlightResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.HighlightResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SnippetResultOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SnippetResultMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SnippetResult), TypeInfoPropertyName = "SnippetResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.SnippetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.MatchedGeoLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Personalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.RankingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Hit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchHits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Hit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchResponse), TypeInfoPropertyName = "SearchResponse3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchTypeDefault), TypeInfoPropertyName = "SearchTypeDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchForHitsSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchForHits), TypeInfoPropertyName = "SearchForHits2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchTypeFacet), TypeInfoPropertyName = "SearchTypeFacet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchForFacetsSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchForFacets), TypeInfoPropertyName = "SearchForFacets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchQuery), TypeInfoPropertyName = "SearchQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchStrategy), TypeInfoPropertyName = "SearchStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchForFacetValuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.SearchForFacetValuesResponseFacetHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchForFacetValuesResponseFacetHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchResult), TypeInfoPropertyName = "SearchResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Cursor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BrowseParamsConfig), TypeInfoPropertyName = "BrowseParamsConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BrowseParams), TypeInfoPropertyName = "BrowseParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BrowsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BrowseResponse), TypeInfoPropertyName = "BrowseResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DeleteByParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.UpdatedAtResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Action), TypeInfoPropertyName = "Action2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BatchWriteParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.BatchWriteParamsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BatchWriteParamsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BaseIndexSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.IndexSettings), TypeInfoPropertyName = "IndexSettings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.WithPrimary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SettingsResponse), TypeInfoPropertyName = "SettingsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SynonymType), TypeInfoPropertyName = "SynonymType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SynonymHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.SynonymHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchSynonymsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BaseGetApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Acl), TypeInfoPropertyName = "Acl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Acl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.GetApiKeyResponse), TypeInfoPropertyName = "GetApiKeyResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AddApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Anchoring), TypeInfoPropertyName = "Anchoring2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Condition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.EditType), TypeInfoPropertyName = "EditType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Edit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ConsequenceQueryObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Edit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ConsequenceQuery), TypeInfoPropertyName = "ConsequenceQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AutomaticFacetFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AutomaticFacetFilters), TypeInfoPropertyName = "AutomaticFacetFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Params))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ConsequenceParams), TypeInfoPropertyName = "ConsequenceParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.PromoteObjectIDs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.PromoteObjectID))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Promote), TypeInfoPropertyName = "Promote2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Consequence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Promote>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.ConsequenceHideItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ConsequenceHideItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ConsequenceRedirect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.TimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Rule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.TimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DictionaryType), TypeInfoPropertyName = "DictionaryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DictionaryAction), TypeInfoPropertyName = "DictionaryAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DictionaryEntryState), TypeInfoPropertyName = "DictionaryEntryState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DictionaryEntryType), TypeInfoPropertyName = "DictionaryEntryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DictionaryEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchDictionaryEntriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.DictionaryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.StandardEntry), TypeInfoPropertyName = "StandardEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.StandardEntries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DictionaryLanguage), TypeInfoPropertyName = "DictionaryLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DictionaryLanguageVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Languages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.UserId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.LogType), TypeInfoPropertyName = "LogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.GetTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.OperationType), TypeInfoPropertyName = "OperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ScopeType), TypeInfoPropertyName = "ScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.FetchedIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ListIndicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.FetchedIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ApiKeyOperation), TypeInfoPropertyName = "ApiKeyOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SecuredApiKeyRestrictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ReplaceAllObjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.BatchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.EventStatus), TypeInfoPropertyName = "EventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.EventStatusEnum), TypeInfoPropertyName = "EventStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.EventType), TypeInfoPropertyName = "EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.WatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ReplaceAllObjectsWithTransformationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.WatchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BuiltInOperationType), TypeInfoPropertyName = "BuiltInOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BuiltInOperationValue), TypeInfoPropertyName = "BuiltInOperationValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.SearchQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchForFacetValuesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.MultipleBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.MultipleBatchRequestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.MultipleBatchRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.GetObjectsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.GetObjectsRequestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.GetObjectsRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchSynonymsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Rule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchRulesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.OneOf<bool?, object>), TypeInfoPropertyName = "OneOfBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BatchDictionaryEntriesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.BatchDictionaryEntriesRequestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BatchDictionaryEntriesRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchDictionaryEntriesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SetDictionarySettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AssignUserIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BatchAssignUserIdsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchUserIdsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.OperationIndexRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.ScopeType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.OneOf<int?, object>), TypeInfoPropertyName = "OneOfInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SaveObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DeleteIndexResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AddOrUpdateObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DeleteObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.PartialUpdateObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.MultipleBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.GetObjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SaveSynonymResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DeleteSynonymResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ListApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.GetApiKeyResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.UpdateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DeleteApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchRulesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.GetDictionarySettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Algolia.Languages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AssignUserIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ListUserIdsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.UserId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.BatchAssignUserIdsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.GetTopUserIdsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Algolia.UserId>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Algolia.UserId>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.RemoveUserIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ListClustersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchUserIdsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.SearchUserIdsResponseHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchUserIdsResponseHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.SearchUserIdsResponseHitHighlightResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.HasPendingMappingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.ReplaceSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.AppendSourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.DeleteSourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.GetLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.GetLogsResponseLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.GetLogsResponseLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.GetLogsResponseLogInnerQuerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.GetLogsResponseLogInnerQuerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.FacetFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.OptionalFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.NumericFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.TagFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.AroundPrecisionFromValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.SupportedLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.OneOf<global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.AlternativesAsExact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.AdvancedSyntaxFeatures>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.BannerImageUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Banner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.ReRankingApplyFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.RedirectRuleIndexMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.HighlightResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.SnippetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Hit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.SearchForFacetValuesResponseFacetHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.BatchWriteParamsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.SynonymHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Acl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Edit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.AutomaticFacetFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Promote>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.ConsequenceHideItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.TimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.DictionaryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.FetchedIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.BatchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.WatchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.SearchQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.MultipleBatchRequestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.GetObjectsRequestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Rule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.BatchDictionaryEntriesRequestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.ScopeType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.GetApiKeyResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.UserId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Algolia.UserId>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Algolia.UserId>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.SearchUserIdsResponseHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.GetLogsResponseLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.GetLogsResponseLogInnerQuerie>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}