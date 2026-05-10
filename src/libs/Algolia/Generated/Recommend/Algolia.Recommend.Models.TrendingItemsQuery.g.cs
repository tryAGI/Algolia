#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrendingItemsQuery : global::System.IEquatable<TrendingItemsQuery>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.BaseRecommendRequest? BaseRecommendRequest { get; init; }
#else
        public global::Algolia.Recommend.BaseRecommendRequest? BaseRecommendRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseRecommendRequest))]
#endif
        public bool IsBaseRecommendRequest => BaseRecommendRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBaseRecommendRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.BaseRecommendRequest? value)
        {
            value = BaseRecommendRequest;
            return IsBaseRecommendRequest;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.TrendingItems? TrendingItems { get; init; }
#else
        public global::Algolia.Recommend.TrendingItems? TrendingItems { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrendingItems))]
#endif
        public bool IsTrendingItems => TrendingItems != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTrendingItems(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.TrendingItems? value)
        {
            value = TrendingItems;
            return IsTrendingItems;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrendingItemsQuery(global::Algolia.Recommend.BaseRecommendRequest value) => new TrendingItemsQuery((global::Algolia.Recommend.BaseRecommendRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BaseRecommendRequest?(TrendingItemsQuery @this) => @this.BaseRecommendRequest;

        /// <summary>
        /// 
        /// </summary>
        public TrendingItemsQuery(global::Algolia.Recommend.BaseRecommendRequest? value)
        {
            BaseRecommendRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TrendingItemsQuery FromBaseRecommendRequest(global::Algolia.Recommend.BaseRecommendRequest? value) => new TrendingItemsQuery(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrendingItemsQuery(global::Algolia.Recommend.TrendingItems value) => new TrendingItemsQuery((global::Algolia.Recommend.TrendingItems?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.TrendingItems?(TrendingItemsQuery @this) => @this.TrendingItems;

        /// <summary>
        /// 
        /// </summary>
        public TrendingItemsQuery(global::Algolia.Recommend.TrendingItems? value)
        {
            TrendingItems = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TrendingItemsQuery FromTrendingItems(global::Algolia.Recommend.TrendingItems? value) => new TrendingItemsQuery(value);

        /// <summary>
        /// 
        /// </summary>
        public TrendingItemsQuery(
            global::Algolia.Recommend.BaseRecommendRequest? baseRecommendRequest,
            global::Algolia.Recommend.TrendingItems? trendingItems
            )
        {
            BaseRecommendRequest = baseRecommendRequest;
            TrendingItems = trendingItems;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrendingItems as object ??
            BaseRecommendRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseRecommendRequest?.ToString() ??
            TrendingItems?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseRecommendRequest && IsTrendingItems;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.BaseRecommendRequest, TResult>? baseRecommendRequest = null,
            global::System.Func<global::Algolia.Recommend.TrendingItems, TResult>? trendingItems = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendRequest && baseRecommendRequest != null)
            {
                return baseRecommendRequest(BaseRecommendRequest!);
            }
            else if (IsTrendingItems && trendingItems != null)
            {
                return trendingItems(TrendingItems!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.BaseRecommendRequest>? baseRecommendRequest = null,

            global::System.Action<global::Algolia.Recommend.TrendingItems>? trendingItems = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendRequest)
            {
                baseRecommendRequest?.Invoke(BaseRecommendRequest!);
            }
            else if (IsTrendingItems)
            {
                trendingItems?.Invoke(TrendingItems!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.BaseRecommendRequest>? baseRecommendRequest = null,
            global::System.Action<global::Algolia.Recommend.TrendingItems>? trendingItems = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendRequest)
            {
                baseRecommendRequest?.Invoke(BaseRecommendRequest!);
            }
            else if (IsTrendingItems)
            {
                trendingItems?.Invoke(TrendingItems!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseRecommendRequest,
                typeof(global::Algolia.Recommend.BaseRecommendRequest),
                TrendingItems,
                typeof(global::Algolia.Recommend.TrendingItems),
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
        public bool Equals(TrendingItemsQuery other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BaseRecommendRequest?>.Default.Equals(BaseRecommendRequest, other.BaseRecommendRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.TrendingItems?>.Default.Equals(TrendingItems, other.TrendingItems) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrendingItemsQuery obj1, TrendingItemsQuery obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrendingItemsQuery>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrendingItemsQuery obj1, TrendingItemsQuery obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrendingItemsQuery o && Equals(o);
        }
    }
}
