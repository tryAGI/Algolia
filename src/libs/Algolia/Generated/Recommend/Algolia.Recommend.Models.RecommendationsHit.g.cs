#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecommendationsHit : global::System.IEquatable<RecommendationsHit>
    {
        /// <summary>
        /// Recommend hit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.RecommendHit? Recommend { get; init; }
#else
        public global::Algolia.Recommend.RecommendHit? Recommend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Recommend))]
#endif
        public bool IsRecommend => Recommend != null;

        /// <summary>
        /// Trending facet hit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.TrendingFacetHit? TrendingFacetHit { get; init; }
#else
        public global::Algolia.Recommend.TrendingFacetHit? TrendingFacetHit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrendingFacetHit))]
#endif
        public bool IsTrendingFacetHit => TrendingFacetHit != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendationsHit(global::Algolia.Recommend.RecommendHit value) => new RecommendationsHit((global::Algolia.Recommend.RecommendHit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.RecommendHit?(RecommendationsHit @this) => @this.Recommend;

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsHit(global::Algolia.Recommend.RecommendHit? value)
        {
            Recommend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendationsHit(global::Algolia.Recommend.TrendingFacetHit value) => new RecommendationsHit((global::Algolia.Recommend.TrendingFacetHit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.TrendingFacetHit?(RecommendationsHit @this) => @this.TrendingFacetHit;

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsHit(global::Algolia.Recommend.TrendingFacetHit? value)
        {
            TrendingFacetHit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsHit(
            global::Algolia.Recommend.RecommendHit? recommend,
            global::Algolia.Recommend.TrendingFacetHit? trendingFacetHit
            )
        {
            Recommend = recommend;
            TrendingFacetHit = trendingFacetHit;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrendingFacetHit as object ??
            Recommend as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Recommend?.ToString() ??
            TrendingFacetHit?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRecommend && !IsTrendingFacetHit || !IsRecommend && IsTrendingFacetHit;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.RecommendHit?, TResult>? recommend = null,
            global::System.Func<global::Algolia.Recommend.TrendingFacetHit?, TResult>? trendingFacetHit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRecommend && recommend != null)
            {
                return recommend(Recommend!);
            }
            else if (IsTrendingFacetHit && trendingFacetHit != null)
            {
                return trendingFacetHit(TrendingFacetHit!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.RecommendHit?>? recommend = null,
            global::System.Action<global::Algolia.Recommend.TrendingFacetHit?>? trendingFacetHit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRecommend)
            {
                recommend?.Invoke(Recommend!);
            }
            else if (IsTrendingFacetHit)
            {
                trendingFacetHit?.Invoke(TrendingFacetHit!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Recommend,
                typeof(global::Algolia.Recommend.RecommendHit),
                TrendingFacetHit,
                typeof(global::Algolia.Recommend.TrendingFacetHit),
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
        public bool Equals(RecommendationsHit other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.RecommendHit?>.Default.Equals(Recommend, other.Recommend) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.TrendingFacetHit?>.Default.Equals(TrendingFacetHit, other.TrendingFacetHit) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecommendationsHit obj1, RecommendationsHit obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecommendationsHit>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecommendationsHit obj1, RecommendationsHit obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecommendationsHit o && Equals(o);
        }
    }
}
