
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Algolia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AttributeToUpdate? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BuiltInOperation? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ErrorBase? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchParamsString? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchParamsQuery? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.FacetFilters? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.FacetFilters>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.OptionalFilters? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.OptionalFilters>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.NumericFilters? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.NumericFilters>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.TagFilters? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.TagFilters>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AroundRadiusAll? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AroundRadius? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.AroundPrecisionFromValueItem>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AroundPrecisionFromValueItem? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AroundPrecision? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.InsideBoundingBox? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SupportedLanguage? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BaseSearchParamsWithoutQuery? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BaseSearchParams? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.TypoToleranceEnum? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.TypoTolerance? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BooleanString? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.IgnorePlurals? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.RemoveStopWords? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.QueryType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.RemoveWordsIfNoResults? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Mode? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SemanticSearch? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.OptionalWords? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ExactOnSingleWordQuery? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AlternativesAsExact? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.AlternativesAsExact>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AdvancedSyntaxFeatures? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.AdvancedSyntaxFeatures>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Distinct? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AttributeCriteriaComputedBy? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Facets? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SortRemainingBy? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Value? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Algolia.Value>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.FacetOrdering? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.RedirectURL? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BannerImageUrl? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BannerImage? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.BannerImageUrl>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BannerLink? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Banner? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Banner>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Widgets? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.RenderingContent? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ReRankingApplyFilter? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.ReRankingApplyFilter>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.IndexSettingsAsSearchParams? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchParamsObject? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchParams? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.RedirectRuleIndexMetadata? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.RedirectRuleIndexMetadataData? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.UserData? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BaseSearchResponse? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BaseSearchResponseExhaustive? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Algolia.BaseSearchResponseFacetsStats2>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BaseSearchResponseFacetsStats2? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BaseSearchResponseRedirect? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.RedirectRuleIndexMetadata>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchPagination? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.MatchLevel? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.HighlightResultOption? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Algolia.HighlightResult>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.HighlightResult? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.HighlightResult>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SnippetResultOption? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Algolia.SnippetResult>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SnippetResult? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.SnippetResult>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.MatchedGeoLocation? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Personalization? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.RankingInfo? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Hit? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.QueryCategorizationType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.CategoryPredictionBin? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.HierarchyPathEntry? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.CategoryPrediction? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.HierarchyPathEntry>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AutoFilteringFilterEntry? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AutoFilteringResult? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.AutoFilteringFilterEntry>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.QueryCategorization? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.CategoryPrediction>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ResponseExtensions? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchHits? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Hit>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchResponse? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchTypeDefault? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchExtensionsQueryCategorization? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchExtensions? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchForHitsSettings? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchForHits? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchTypeFacet? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchForFacetsSettings? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchForFacets? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchQuery? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchStrategy? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchForFacetValuesResponse? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.SearchForFacetValuesResponseFacetHit>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchForFacetValuesResponseFacetHit? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchResponsePartial? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchResponsePartialVariant3? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchResult? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Cursor? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BrowseParamsConfig? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BrowseParams? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BrowsePagination? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BrowseResponse? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DeleteByParams? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.UpdatedAtResponse? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Action? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BatchWriteParams? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.BatchWriteParamsRequest>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BatchWriteParamsRequest? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BatchResponse? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BaseIndexSettings? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.IndexSettings? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.WithPrimary? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SettingsResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SynonymType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SynonymHit? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.SynonymHit>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchSynonymsResponse? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BaseGetApiKeyResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Acl? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ApiKey? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Acl>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.GetApiKeyResponse? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AddApiKeyResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Anchoring? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Condition? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.EditType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Edit? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ConsequenceQueryObject? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Edit>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ConsequenceQuery? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AutomaticFacetFilter? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AutomaticFacetFilters? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Params? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ConsequenceParams? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.PromoteObjectIDs? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.PromoteObjectID? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Promote? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Consequence? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Promote>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.ConsequenceHideItem>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ConsequenceHideItem? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ConsequenceRedirect? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.TimeRange? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Rule? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Condition>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.TimeRange>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DictionaryType? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DictionaryAction? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DictionaryEntryState? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DictionaryEntryType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DictionaryEntry? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchDictionaryEntriesResponse? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.DictionaryEntry>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.StandardEntries? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DictionaryLanguageVariant1? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Languages? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.UserId? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Source? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Source>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.LogType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.TaskStatus? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.GetTaskResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.OperationType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ScopeType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.FetchedIndexAbTestTarget? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.FetchedIndexAbTestVariant? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.FetchedIndexAbTest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.FetchedIndexAbTestVariant>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.FetchedIndex? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ListIndicesResponse? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.FetchedIndex>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ApiKeyOperation? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SecuredApiKeyRestrictions? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ReplaceAllObjectsResponse? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.BatchResponse>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.EventStatusEnum? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.EventType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Event? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.WatchResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Event>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ReplaceAllObjectsWithTransformationResponse? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.WatchResponse>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BuiltInOperationType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BuiltInOperationValue? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchRequest? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.SearchQuery>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchForFacetValuesRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.MultipleBatchRequest? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.MultipleBatchRequestRequest>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.MultipleBatchRequestRequest? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.GetObjectsRequest? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.GetObjectsRequestRequest>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.GetObjectsRequestRequest? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchSynonymsRequest? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Rule>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchRulesRequest? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BatchDictionaryEntriesRequest? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.BatchDictionaryEntriesRequestRequest>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BatchDictionaryEntriesRequestRequest? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchDictionaryEntriesRequest? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SetDictionarySettingsRequest? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AssignUserIdRequest? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BatchAssignUserIdsRequest? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchUserIdsRequest? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.OperationIndexRequest? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.ScopeType>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchResponse2? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.SearchResult>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SaveObjectResponse? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DeleteIndexResponse? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AddOrUpdateObjectResponse? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DeleteObjectResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.PartialUpdateObjectResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.MultipleBatchResponse? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.GetObjectsResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SaveSynonymResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DeleteSynonymResponse? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ListApiKeysResponse? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.GetApiKeyResponse>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.UpdateApiKeyResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DeleteApiKeyResponse? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchRulesResponse? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.GetDictionarySettingsResponse? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Algolia.Languages>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AssignUserIdResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ListUserIdsResponse? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.UserId>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.BatchAssignUserIdsResponse? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.GetTopUserIdsResponse? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Algolia.UserId>>>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Algolia.UserId>>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.RemoveUserIdResponse? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ListClustersResponse? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchUserIdsResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.SearchUserIdsResponseHit>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchUserIdsResponseHit? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchUserIdsResponseHitHighlightResult? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.HasPendingMappingsResponse? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.ReplaceSourcesResponse? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.AppendSourceResponse? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.DeleteSourceResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.GetLogsResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.GetLogsResponseLog>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.GetLogsResponseLog? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.GetLogsResponseLogInnerQuerie>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Algolia.GetLogsResponseLogInnerQuerie? Type277 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.FacetFilters>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.OptionalFilters>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.NumericFilters>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.TagFilters>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.AroundPrecisionFromValueItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.SupportedLanguage>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.AlternativesAsExact>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.AdvancedSyntaxFeatures>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.BannerImageUrl>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.Banner>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.ReRankingApplyFilter>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.RedirectRuleIndexMetadata>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.HighlightResult>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.SnippetResult>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.HierarchyPathEntry>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.AutoFilteringFilterEntry>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.CategoryPrediction>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.Hit>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.SearchForFacetValuesResponseFacetHit>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.BatchWriteParamsRequest>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.SynonymHit>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.Acl>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.Edit>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.AutomaticFacetFilter>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.Promote>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.ConsequenceHideItem>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.Condition>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.TimeRange>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.DictionaryEntry>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.Source>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.FetchedIndexAbTestVariant>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.FetchedIndex>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.BatchResponse>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.Event>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.WatchResponse>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.SearchQuery>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.MultipleBatchRequestRequest>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.GetObjectsRequestRequest>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.Rule>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.BatchDictionaryEntriesRequestRequest>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.ScopeType>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.SearchResult>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.GetApiKeyResponse>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.UserId>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Algolia.UserId>>>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Algolia.UserId>>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.SearchUserIdsResponseHit>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.GetLogsResponseLog>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.GetLogsResponseLogInnerQuerie>? ListType52 { get; set; }
    }
}