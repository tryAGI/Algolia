#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecommendationsResults : global::System.IEquatable<RecommendationsResults>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.BaseSearchResponse? BaseSearchResponse { get; init; }
#else
        public global::Algolia.Recommend.BaseSearchResponse? BaseSearchResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseSearchResponse))]
#endif
        public bool IsBaseSearchResponse => BaseSearchResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBaseSearchResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.BaseSearchResponse? value)
        {
            value = BaseSearchResponse;
            return IsBaseSearchResponse;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.SearchPagination? SearchPagination { get; init; }
#else
        public global::Algolia.Recommend.SearchPagination? SearchPagination { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchPagination))]
#endif
        public bool IsSearchPagination => SearchPagination != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchPagination(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.SearchPagination? value)
        {
            value = SearchPagination;
            return IsSearchPagination;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.RecommendationsHits? Hits { get; init; }
#else
        public global::Algolia.Recommend.RecommendationsHits? Hits { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hits))]
#endif
        public bool IsHits => Hits != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHits(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.RecommendationsHits? value)
        {
            value = Hits;
            return IsHits;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendationsResults(global::Algolia.Recommend.BaseSearchResponse value) => new RecommendationsResults((global::Algolia.Recommend.BaseSearchResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BaseSearchResponse?(RecommendationsResults @this) => @this.BaseSearchResponse;

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsResults(global::Algolia.Recommend.BaseSearchResponse? value)
        {
            BaseSearchResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecommendationsResults FromBaseSearchResponse(global::Algolia.Recommend.BaseSearchResponse? value) => new RecommendationsResults(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendationsResults(global::Algolia.Recommend.SearchPagination value) => new RecommendationsResults((global::Algolia.Recommend.SearchPagination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.SearchPagination?(RecommendationsResults @this) => @this.SearchPagination;

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsResults(global::Algolia.Recommend.SearchPagination? value)
        {
            SearchPagination = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecommendationsResults FromSearchPagination(global::Algolia.Recommend.SearchPagination? value) => new RecommendationsResults(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendationsResults(global::Algolia.Recommend.RecommendationsHits value) => new RecommendationsResults((global::Algolia.Recommend.RecommendationsHits?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.RecommendationsHits?(RecommendationsResults @this) => @this.Hits;

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsResults(global::Algolia.Recommend.RecommendationsHits? value)
        {
            Hits = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecommendationsResults FromHits(global::Algolia.Recommend.RecommendationsHits? value) => new RecommendationsResults(value);

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsResults(
            global::Algolia.Recommend.BaseSearchResponse? baseSearchResponse,
            global::Algolia.Recommend.SearchPagination? searchPagination,
            global::Algolia.Recommend.RecommendationsHits? hits
            )
        {
            BaseSearchResponse = baseSearchResponse;
            SearchPagination = searchPagination;
            Hits = hits;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Hits as object ??
            SearchPagination as object ??
            BaseSearchResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseSearchResponse?.ToString() ??
            SearchPagination?.ToString() ??
            Hits?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseSearchResponse && IsSearchPagination && IsHits;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.BaseSearchResponse, TResult>? baseSearchResponse = null,
            global::System.Func<global::Algolia.Recommend.SearchPagination, TResult>? searchPagination = null,
            global::System.Func<global::Algolia.Recommend.RecommendationsHits, TResult>? hits = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseSearchResponse && baseSearchResponse != null)
            {
                return baseSearchResponse(BaseSearchResponse!);
            }
            else if (IsSearchPagination && searchPagination != null)
            {
                return searchPagination(SearchPagination!);
            }
            else if (IsHits && hits != null)
            {
                return hits(Hits!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.BaseSearchResponse>? baseSearchResponse = null,

            global::System.Action<global::Algolia.Recommend.SearchPagination>? searchPagination = null,

            global::System.Action<global::Algolia.Recommend.RecommendationsHits>? hits = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseSearchResponse)
            {
                baseSearchResponse?.Invoke(BaseSearchResponse!);
            }
            else if (IsSearchPagination)
            {
                searchPagination?.Invoke(SearchPagination!);
            }
            else if (IsHits)
            {
                hits?.Invoke(Hits!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.BaseSearchResponse>? baseSearchResponse = null,
            global::System.Action<global::Algolia.Recommend.SearchPagination>? searchPagination = null,
            global::System.Action<global::Algolia.Recommend.RecommendationsHits>? hits = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseSearchResponse)
            {
                baseSearchResponse?.Invoke(BaseSearchResponse!);
            }
            else if (IsSearchPagination)
            {
                searchPagination?.Invoke(SearchPagination!);
            }
            else if (IsHits)
            {
                hits?.Invoke(Hits!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseSearchResponse,
                typeof(global::Algolia.Recommend.BaseSearchResponse),
                SearchPagination,
                typeof(global::Algolia.Recommend.SearchPagination),
                Hits,
                typeof(global::Algolia.Recommend.RecommendationsHits),
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
        public bool Equals(RecommendationsResults other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BaseSearchResponse?>.Default.Equals(BaseSearchResponse, other.BaseSearchResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.SearchPagination?>.Default.Equals(SearchPagination, other.SearchPagination) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.RecommendationsHits?>.Default.Equals(Hits, other.Hits) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecommendationsResults obj1, RecommendationsResults obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecommendationsResults>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecommendationsResults obj1, RecommendationsResults obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecommendationsResults o && Equals(o);
        }
    }
}
