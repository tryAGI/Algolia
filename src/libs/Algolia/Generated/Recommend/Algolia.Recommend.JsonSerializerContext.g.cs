
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Algolia.Recommend.JsonConverters.AroundRadiusAllJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.AroundRadiusAllNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.SupportedLanguageJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.SupportedLanguageNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TypoToleranceEnumJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TypoToleranceEnumNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.BooleanStringJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.BooleanStringNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.QueryTypeJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.QueryTypeNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RemoveWordsIfNoResultsJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RemoveWordsIfNoResultsNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.ExactOnSingleWordQueryJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.ExactOnSingleWordQueryNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.AlternativesAsExactJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.AlternativesAsExactNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.AdvancedSyntaxFeaturesJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.AdvancedSyntaxFeaturesNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.SortRemainingByJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.SortRemainingByNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.FbtModelJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.FbtModelNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RelatedModelJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RelatedModelNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TrendingItemsModelJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TrendingItemsModelNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TrendingFacetsModelJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TrendingFacetsModelNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.LookingSimilarModelJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.LookingSimilarModelNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.MatchLevelJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.MatchLevelNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RecommendModelsJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RecommendModelsNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TaskStatusJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TaskStatusNullableJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.FacetFiltersJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.OptionalFiltersJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.NumericFiltersJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TagFiltersJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.AroundRadiusJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.AroundPrecisionJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.InsideBoundingBoxJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TypoToleranceJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.IgnorePluralsJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RemoveStopWordsJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.OptionalWordsJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.DistinctJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.ReRankingApplyFilterJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.PropertiesReRankingApplyFilterJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RecommendIndexSettingsJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RecommendSearchParamsJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.FallbackParamsJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.BoughtTogetherQueryJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RelatedQueryJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TrendingItemsQueryJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.TrendingFacetsQueryJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.LookingSimilarQueryJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RecommendationsRequestJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.HighlightResultJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.SnippetResultJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RecommendationsHitJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.RecommendationsResultsJsonConverter),

            typeof(global::Algolia.Recommend.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.ErrorBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.FacetFilters), TypeInfoPropertyName = "FacetFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.FacetFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.OptionalFilters), TypeInfoPropertyName = "OptionalFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.NumericFilters), TypeInfoPropertyName = "NumericFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.NumericFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TagFilters), TypeInfoPropertyName = "TagFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.TagFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.AroundRadiusAll), TypeInfoPropertyName = "AroundRadiusAll2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.AroundRadius), TypeInfoPropertyName = "AroundRadius2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.AroundPrecisionFromValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.AroundPrecisionFromValueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.AroundPrecision), TypeInfoPropertyName = "AroundPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.InsideBoundingBox), TypeInfoPropertyName = "InsideBoundingBox2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.SupportedLanguage), TypeInfoPropertyName = "SupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.SupportedLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BaseRecommendSearchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.SearchParamsQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.UserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BaseIndexSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TypoToleranceEnum), TypeInfoPropertyName = "TypoToleranceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TypoTolerance), TypeInfoPropertyName = "TypoTolerance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BooleanString), TypeInfoPropertyName = "BooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.IgnorePlurals), TypeInfoPropertyName = "IgnorePlurals2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RemoveStopWords), TypeInfoPropertyName = "RemoveStopWords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.QueryType), TypeInfoPropertyName = "QueryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RemoveWordsIfNoResults), TypeInfoPropertyName = "RemoveWordsIfNoResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.OptionalWords), TypeInfoPropertyName = "OptionalWords2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.ExactOnSingleWordQuery), TypeInfoPropertyName = "ExactOnSingleWordQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.AlternativesAsExact), TypeInfoPropertyName = "AlternativesAsExact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.AlternativesAsExact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.AdvancedSyntaxFeatures), TypeInfoPropertyName = "AdvancedSyntaxFeatures2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.AdvancedSyntaxFeatures>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.Distinct), TypeInfoPropertyName = "Distinct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.IndexSettingsFacets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.SortRemainingBy), TypeInfoPropertyName = "SortRemainingBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.Value))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Algolia.Recommend.Value>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.FacetOrdering))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RedirectURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BannerImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BannerImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.BannerImageUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BannerLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.Banner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.Banner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.Widgets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RenderingContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.ReRankingApplyFilter), TypeInfoPropertyName = "ReRankingApplyFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.ReRankingApplyFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.PropertiesReRankingApplyFilter), TypeInfoPropertyName = "PropertiesReRankingApplyFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BaseRecommendIndexSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendIndexSettings), TypeInfoPropertyName = "RecommendIndexSettings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendSearchParams), TypeInfoPropertyName = "RecommendSearchParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BaseRecommendRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.FbtModel), TypeInfoPropertyName = "FbtModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.FallbackParams), TypeInfoPropertyName = "FallbackParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.FrequentlyBoughtTogether))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BoughtTogetherQuery), TypeInfoPropertyName = "BoughtTogetherQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RelatedModel), TypeInfoPropertyName = "RelatedModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RelatedProducts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RelatedQuery), TypeInfoPropertyName = "RelatedQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TrendingItemsModel), TypeInfoPropertyName = "TrendingItemsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TrendingItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TrendingItemsQuery), TypeInfoPropertyName = "TrendingItemsQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TrendingFacetsModel), TypeInfoPropertyName = "TrendingFacetsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TrendingFacets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TrendingFacetsQuery), TypeInfoPropertyName = "TrendingFacetsQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.LookingSimilarModel), TypeInfoPropertyName = "LookingSimilarModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.LookingSimilar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.LookingSimilarQuery), TypeInfoPropertyName = "LookingSimilarQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendationsRequest), TypeInfoPropertyName = "RecommendationsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RedirectRuleIndexMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RedirectRuleIndexMetadataData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BaseSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BaseSearchResponseExhaustive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Algolia.Recommend.BaseSearchResponseFacetsStats2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BaseSearchResponseFacetsStats2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.BaseSearchResponseRedirect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.RedirectRuleIndexMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.SearchPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.MatchLevel), TypeInfoPropertyName = "MatchLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.HighlightResultOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.HighlightResultMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.HighlightResult), TypeInfoPropertyName = "HighlightResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.SnippetResultOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.SnippetResultMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.SnippetResult), TypeInfoPropertyName = "SnippetResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.MatchedGeoLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.Personalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RankingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TrendingFacetHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendationsHit), TypeInfoPropertyName = "RecommendationsHit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendationsHits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendationsHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendationsResults), TypeInfoPropertyName = "RecommendationsResults2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendModels), TypeInfoPropertyName = "RecommendModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.Condition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.HideConsequenceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.HideConsequenceObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.PromoteConsequenceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.PromoteConsequenceObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.AutoFacetFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.ParamsConsequence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.AutoFacetFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.Consequence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendRuleMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.TimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.RecommendUpdatedAtResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.GetRecommendationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendationsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.SearchRecommendRulesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.GetRecommendationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.RecommendationsResults>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.DeleteRecommendRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.GetRecommendStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Algolia.Recommend.SearchRecommendRulesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.FacetFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.OptionalFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.NumericFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.TagFilters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.AroundPrecisionFromValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.SupportedLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.AlternativesAsExact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.AdvancedSyntaxFeatures>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.BannerImageUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.Banner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.ReRankingApplyFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.RedirectRuleIndexMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.HighlightResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.SnippetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.RecommendationsHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.HideConsequenceObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.PromoteConsequenceObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.AutoFacetFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.TimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.RecommendationsRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.RecommendRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Algolia.Recommend.RecommendationsResults>))]
    public sealed partial class RecommendSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}