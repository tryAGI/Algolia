#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Search parameters to use for a fallback request if there aren't enough recommendations.
    /// </summary>
    public readonly partial struct FallbackParams : global::System.IEquatable<FallbackParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.BaseRecommendSearchParams? BaseRecommendSearch { get; init; }
#else
        public global::Algolia.Recommend.BaseRecommendSearchParams? BaseRecommendSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseRecommendSearch))]
#endif
        public bool IsBaseRecommendSearch => BaseRecommendSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBaseRecommendSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.BaseRecommendSearchParams? value)
        {
            value = BaseRecommendSearch;
            return IsBaseRecommendSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Recommend.BaseRecommendSearchParams PickBaseRecommendSearch() => IsBaseRecommendSearch
            ? BaseRecommendSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BaseRecommendSearch' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.SearchParamsQuery? SearchQuery { get; init; }
#else
        public global::Algolia.Recommend.SearchParamsQuery? SearchQuery { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchQuery))]
#endif
        public bool IsSearchQuery => SearchQuery != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchQuery(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.SearchParamsQuery? value)
        {
            value = SearchQuery;
            return IsSearchQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Recommend.SearchParamsQuery PickSearchQuery() => IsSearchQuery
            ? SearchQuery!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchQuery' but the value was {ToString()}.");

        /// <summary>
        /// Index settings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.RecommendIndexSettings? RecommendIndexSettings { get; init; }
#else
        public global::Algolia.Recommend.RecommendIndexSettings? RecommendIndexSettings { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RecommendIndexSettings))]
#endif
        public bool IsRecommendIndexSettings => RecommendIndexSettings != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRecommendIndexSettings(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.RecommendIndexSettings? value)
        {
            value = RecommendIndexSettings;
            return IsRecommendIndexSettings;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Recommend.RecommendIndexSettings PickRecommendIndexSettings() => IsRecommendIndexSettings
            ? RecommendIndexSettings!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RecommendIndexSettings' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FallbackParams(global::Algolia.Recommend.BaseRecommendSearchParams value) => new FallbackParams((global::Algolia.Recommend.BaseRecommendSearchParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BaseRecommendSearchParams?(FallbackParams @this) => @this.BaseRecommendSearch;

        /// <summary>
        /// 
        /// </summary>
        public FallbackParams(global::Algolia.Recommend.BaseRecommendSearchParams? value)
        {
            BaseRecommendSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FallbackParams FromBaseRecommendSearch(global::Algolia.Recommend.BaseRecommendSearchParams? value) => new FallbackParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FallbackParams(global::Algolia.Recommend.SearchParamsQuery value) => new FallbackParams((global::Algolia.Recommend.SearchParamsQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.SearchParamsQuery?(FallbackParams @this) => @this.SearchQuery;

        /// <summary>
        /// 
        /// </summary>
        public FallbackParams(global::Algolia.Recommend.SearchParamsQuery? value)
        {
            SearchQuery = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FallbackParams FromSearchQuery(global::Algolia.Recommend.SearchParamsQuery? value) => new FallbackParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FallbackParams(global::Algolia.Recommend.RecommendIndexSettings value) => new FallbackParams((global::Algolia.Recommend.RecommendIndexSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.RecommendIndexSettings?(FallbackParams @this) => @this.RecommendIndexSettings;

        /// <summary>
        /// 
        /// </summary>
        public FallbackParams(global::Algolia.Recommend.RecommendIndexSettings? value)
        {
            RecommendIndexSettings = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FallbackParams FromRecommendIndexSettings(global::Algolia.Recommend.RecommendIndexSettings? value) => new FallbackParams(value);

        /// <summary>
        /// 
        /// </summary>
        public FallbackParams(
            global::Algolia.Recommend.BaseRecommendSearchParams? baseRecommendSearch,
            global::Algolia.Recommend.SearchParamsQuery? searchQuery,
            global::Algolia.Recommend.RecommendIndexSettings? recommendIndexSettings
            )
        {
            BaseRecommendSearch = baseRecommendSearch;
            SearchQuery = searchQuery;
            RecommendIndexSettings = recommendIndexSettings;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RecommendIndexSettings as object ??
            SearchQuery as object ??
            BaseRecommendSearch as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseRecommendSearch?.ToString() ??
            SearchQuery?.ToString() ??
            RecommendIndexSettings?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseRecommendSearch && IsSearchQuery && IsRecommendIndexSettings;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.BaseRecommendSearchParams, TResult>? baseRecommendSearch = null,
            global::System.Func<global::Algolia.Recommend.SearchParamsQuery, TResult>? searchQuery = null,
            global::System.Func<global::Algolia.Recommend.RecommendIndexSettings?, TResult>? recommendIndexSettings = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendSearch && baseRecommendSearch != null)
            {
                return baseRecommendSearch(BaseRecommendSearch!);
            }
            else if (IsSearchQuery && searchQuery != null)
            {
                return searchQuery(SearchQuery!);
            }
            else if (IsRecommendIndexSettings && recommendIndexSettings != null)
            {
                return recommendIndexSettings(RecommendIndexSettings!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.BaseRecommendSearchParams>? baseRecommendSearch = null,

            global::System.Action<global::Algolia.Recommend.SearchParamsQuery>? searchQuery = null,

            global::System.Action<global::Algolia.Recommend.RecommendIndexSettings?>? recommendIndexSettings = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendSearch)
            {
                baseRecommendSearch?.Invoke(BaseRecommendSearch!);
            }
            else if (IsSearchQuery)
            {
                searchQuery?.Invoke(SearchQuery!);
            }
            else if (IsRecommendIndexSettings)
            {
                recommendIndexSettings?.Invoke(RecommendIndexSettings!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.BaseRecommendSearchParams>? baseRecommendSearch = null,
            global::System.Action<global::Algolia.Recommend.SearchParamsQuery>? searchQuery = null,
            global::System.Action<global::Algolia.Recommend.RecommendIndexSettings?>? recommendIndexSettings = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendSearch)
            {
                baseRecommendSearch?.Invoke(BaseRecommendSearch!);
            }
            else if (IsSearchQuery)
            {
                searchQuery?.Invoke(SearchQuery!);
            }
            else if (IsRecommendIndexSettings)
            {
                recommendIndexSettings?.Invoke(RecommendIndexSettings!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseRecommendSearch,
                typeof(global::Algolia.Recommend.BaseRecommendSearchParams),
                SearchQuery,
                typeof(global::Algolia.Recommend.SearchParamsQuery),
                RecommendIndexSettings,
                typeof(global::Algolia.Recommend.RecommendIndexSettings),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(FallbackParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BaseRecommendSearchParams?>.Default.Equals(BaseRecommendSearch, other.BaseRecommendSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.SearchParamsQuery?>.Default.Equals(SearchQuery, other.SearchQuery) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.RecommendIndexSettings?>.Default.Equals(RecommendIndexSettings, other.RecommendIndexSettings) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FallbackParams obj1, FallbackParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FallbackParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FallbackParams obj1, FallbackParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FallbackParams o && Equals(o);
        }
    }
}
