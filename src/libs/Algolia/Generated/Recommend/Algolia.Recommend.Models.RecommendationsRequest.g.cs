#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecommendationsRequest : global::System.IEquatable<RecommendationsRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.BoughtTogetherQuery? FrequentlyBoughtTogether { get; init; }
#else
        public global::Algolia.Recommend.BoughtTogetherQuery? FrequentlyBoughtTogether { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FrequentlyBoughtTogether))]
#endif
        public bool IsFrequentlyBoughtTogether => FrequentlyBoughtTogether != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.RelatedQuery? RelatedProducts { get; init; }
#else
        public global::Algolia.Recommend.RelatedQuery? RelatedProducts { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RelatedProducts))]
#endif
        public bool IsRelatedProducts => RelatedProducts != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.TrendingItemsQuery? TrendingItems { get; init; }
#else
        public global::Algolia.Recommend.TrendingItemsQuery? TrendingItems { get; }
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
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.TrendingFacetsQuery? TrendingFacetValues { get; init; }
#else
        public global::Algolia.Recommend.TrendingFacetsQuery? TrendingFacetValues { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrendingFacetValues))]
#endif
        public bool IsTrendingFacetValues => TrendingFacetValues != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.LookingSimilarQuery? LookingSimilar { get; init; }
#else
        public global::Algolia.Recommend.LookingSimilarQuery? LookingSimilar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LookingSimilar))]
#endif
        public bool IsLookingSimilar => LookingSimilar != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendationsRequest(global::Algolia.Recommend.BoughtTogetherQuery value) => new RecommendationsRequest((global::Algolia.Recommend.BoughtTogetherQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BoughtTogetherQuery?(RecommendationsRequest @this) => @this.FrequentlyBoughtTogether;

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsRequest(global::Algolia.Recommend.BoughtTogetherQuery? value)
        {
            FrequentlyBoughtTogether = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendationsRequest(global::Algolia.Recommend.RelatedQuery value) => new RecommendationsRequest((global::Algolia.Recommend.RelatedQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.RelatedQuery?(RecommendationsRequest @this) => @this.RelatedProducts;

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsRequest(global::Algolia.Recommend.RelatedQuery? value)
        {
            RelatedProducts = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendationsRequest(global::Algolia.Recommend.TrendingItemsQuery value) => new RecommendationsRequest((global::Algolia.Recommend.TrendingItemsQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.TrendingItemsQuery?(RecommendationsRequest @this) => @this.TrendingItems;

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsRequest(global::Algolia.Recommend.TrendingItemsQuery? value)
        {
            TrendingItems = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendationsRequest(global::Algolia.Recommend.TrendingFacetsQuery value) => new RecommendationsRequest((global::Algolia.Recommend.TrendingFacetsQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.TrendingFacetsQuery?(RecommendationsRequest @this) => @this.TrendingFacetValues;

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsRequest(global::Algolia.Recommend.TrendingFacetsQuery? value)
        {
            TrendingFacetValues = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendationsRequest(global::Algolia.Recommend.LookingSimilarQuery value) => new RecommendationsRequest((global::Algolia.Recommend.LookingSimilarQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.LookingSimilarQuery?(RecommendationsRequest @this) => @this.LookingSimilar;

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsRequest(global::Algolia.Recommend.LookingSimilarQuery? value)
        {
            LookingSimilar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsRequest(
            global::Algolia.Recommend.BoughtTogetherQuery? frequentlyBoughtTogether,
            global::Algolia.Recommend.RelatedQuery? relatedProducts,
            global::Algolia.Recommend.TrendingItemsQuery? trendingItems,
            global::Algolia.Recommend.TrendingFacetsQuery? trendingFacetValues,
            global::Algolia.Recommend.LookingSimilarQuery? lookingSimilar
            )
        {
            FrequentlyBoughtTogether = frequentlyBoughtTogether;
            RelatedProducts = relatedProducts;
            TrendingItems = trendingItems;
            TrendingFacetValues = trendingFacetValues;
            LookingSimilar = lookingSimilar;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LookingSimilar as object ??
            TrendingFacetValues as object ??
            TrendingItems as object ??
            RelatedProducts as object ??
            FrequentlyBoughtTogether as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FrequentlyBoughtTogether?.ToString() ??
            RelatedProducts?.ToString() ??
            TrendingItems?.ToString() ??
            TrendingFacetValues?.ToString() ??
            LookingSimilar?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFrequentlyBoughtTogether && !IsRelatedProducts && !IsTrendingItems && !IsTrendingFacetValues && !IsLookingSimilar || !IsFrequentlyBoughtTogether && IsRelatedProducts && !IsTrendingItems && !IsTrendingFacetValues && !IsLookingSimilar || !IsFrequentlyBoughtTogether && !IsRelatedProducts && IsTrendingItems && !IsTrendingFacetValues && !IsLookingSimilar || !IsFrequentlyBoughtTogether && !IsRelatedProducts && !IsTrendingItems && IsTrendingFacetValues && !IsLookingSimilar || !IsFrequentlyBoughtTogether && !IsRelatedProducts && !IsTrendingItems && !IsTrendingFacetValues && IsLookingSimilar;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.BoughtTogetherQuery?, TResult>? frequentlyBoughtTogether = null,
            global::System.Func<global::Algolia.Recommend.RelatedQuery?, TResult>? relatedProducts = null,
            global::System.Func<global::Algolia.Recommend.TrendingItemsQuery?, TResult>? trendingItems = null,
            global::System.Func<global::Algolia.Recommend.TrendingFacetsQuery?, TResult>? trendingFacetValues = null,
            global::System.Func<global::Algolia.Recommend.LookingSimilarQuery?, TResult>? lookingSimilar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFrequentlyBoughtTogether && frequentlyBoughtTogether != null)
            {
                return frequentlyBoughtTogether(FrequentlyBoughtTogether!);
            }
            else if (IsRelatedProducts && relatedProducts != null)
            {
                return relatedProducts(RelatedProducts!);
            }
            else if (IsTrendingItems && trendingItems != null)
            {
                return trendingItems(TrendingItems!);
            }
            else if (IsTrendingFacetValues && trendingFacetValues != null)
            {
                return trendingFacetValues(TrendingFacetValues!);
            }
            else if (IsLookingSimilar && lookingSimilar != null)
            {
                return lookingSimilar(LookingSimilar!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.BoughtTogetherQuery?>? frequentlyBoughtTogether = null,
            global::System.Action<global::Algolia.Recommend.RelatedQuery?>? relatedProducts = null,
            global::System.Action<global::Algolia.Recommend.TrendingItemsQuery?>? trendingItems = null,
            global::System.Action<global::Algolia.Recommend.TrendingFacetsQuery?>? trendingFacetValues = null,
            global::System.Action<global::Algolia.Recommend.LookingSimilarQuery?>? lookingSimilar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFrequentlyBoughtTogether)
            {
                frequentlyBoughtTogether?.Invoke(FrequentlyBoughtTogether!);
            }
            else if (IsRelatedProducts)
            {
                relatedProducts?.Invoke(RelatedProducts!);
            }
            else if (IsTrendingItems)
            {
                trendingItems?.Invoke(TrendingItems!);
            }
            else if (IsTrendingFacetValues)
            {
                trendingFacetValues?.Invoke(TrendingFacetValues!);
            }
            else if (IsLookingSimilar)
            {
                lookingSimilar?.Invoke(LookingSimilar!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FrequentlyBoughtTogether,
                typeof(global::Algolia.Recommend.BoughtTogetherQuery),
                RelatedProducts,
                typeof(global::Algolia.Recommend.RelatedQuery),
                TrendingItems,
                typeof(global::Algolia.Recommend.TrendingItemsQuery),
                TrendingFacetValues,
                typeof(global::Algolia.Recommend.TrendingFacetsQuery),
                LookingSimilar,
                typeof(global::Algolia.Recommend.LookingSimilarQuery),
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
        public bool Equals(RecommendationsRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BoughtTogetherQuery?>.Default.Equals(FrequentlyBoughtTogether, other.FrequentlyBoughtTogether) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.RelatedQuery?>.Default.Equals(RelatedProducts, other.RelatedProducts) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.TrendingItemsQuery?>.Default.Equals(TrendingItems, other.TrendingItems) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.TrendingFacetsQuery?>.Default.Equals(TrendingFacetValues, other.TrendingFacetValues) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.LookingSimilarQuery?>.Default.Equals(LookingSimilar, other.LookingSimilar) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecommendationsRequest obj1, RecommendationsRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecommendationsRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecommendationsRequest obj1, RecommendationsRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecommendationsRequest o && Equals(o);
        }
    }
}
