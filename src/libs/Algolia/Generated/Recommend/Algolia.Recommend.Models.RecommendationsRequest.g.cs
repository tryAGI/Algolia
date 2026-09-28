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
        public bool TryPickFrequentlyBoughtTogether(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.BoughtTogetherQuery? value)
        {
            value = FrequentlyBoughtTogether;
            return IsFrequentlyBoughtTogether;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Recommend.BoughtTogetherQuery PickFrequentlyBoughtTogether() => FrequentlyBoughtTogether is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FrequentlyBoughtTogether' but the value was {ToString()}.");

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
        public bool TryPickRelatedProducts(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.RelatedQuery? value)
        {
            value = RelatedProducts;
            return IsRelatedProducts;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Recommend.RelatedQuery PickRelatedProducts() => RelatedProducts is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RelatedProducts' but the value was {ToString()}.");

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
        public bool TryPickTrendingItems(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.TrendingItemsQuery? value)
        {
            value = TrendingItems;
            return IsTrendingItems;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Recommend.TrendingItemsQuery PickTrendingItems() => TrendingItems is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrendingItems' but the value was {ToString()}.");

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
        public bool TryPickTrendingFacetValues(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.TrendingFacetsQuery? value)
        {
            value = TrendingFacetValues;
            return IsTrendingFacetValues;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Recommend.TrendingFacetsQuery PickTrendingFacetValues() => TrendingFacetValues is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrendingFacetValues' but the value was {ToString()}.");

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
        public bool TryPickLookingSimilar(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.LookingSimilarQuery? value)
        {
            value = LookingSimilar;
            return IsLookingSimilar;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Recommend.LookingSimilarQuery PickLookingSimilar() => LookingSimilar is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LookingSimilar' but the value was {ToString()}.");
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
        public static RecommendationsRequest FromFrequentlyBoughtTogether(global::Algolia.Recommend.BoughtTogetherQuery? value) => new RecommendationsRequest(value);

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
        public static RecommendationsRequest FromRelatedProducts(global::Algolia.Recommend.RelatedQuery? value) => new RecommendationsRequest(value);

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
        public static RecommendationsRequest FromTrendingItems(global::Algolia.Recommend.TrendingItemsQuery? value) => new RecommendationsRequest(value);

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
        public static RecommendationsRequest FromTrendingFacetValues(global::Algolia.Recommend.TrendingFacetsQuery? value) => new RecommendationsRequest(value);

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
        public static RecommendationsRequest FromLookingSimilar(global::Algolia.Recommend.LookingSimilarQuery? value) => new RecommendationsRequest(value);

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

            if (FrequentlyBoughtTogether is { } __value0 && frequentlyBoughtTogether != null)
            {
                return frequentlyBoughtTogether(__value0);
            }
            else if (RelatedProducts is { } __value1 && relatedProducts != null)
            {
                return relatedProducts(__value1);
            }
            else if (TrendingItems is { } __value2 && trendingItems != null)
            {
                return trendingItems(__value2);
            }
            else if (TrendingFacetValues is { } __value3 && trendingFacetValues != null)
            {
                return trendingFacetValues(__value3);
            }
            else if (LookingSimilar is { } __value4 && lookingSimilar != null)
            {
                return lookingSimilar(__value4);
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

            if (FrequentlyBoughtTogether is { } __value0)
            {
                frequentlyBoughtTogether?.Invoke(__value0);
            }
            else if (RelatedProducts is { } __value1)
            {
                relatedProducts?.Invoke(__value1);
            }
            else if (TrendingItems is { } __value2)
            {
                trendingItems?.Invoke(__value2);
            }
            else if (TrendingFacetValues is { } __value3)
            {
                trendingFacetValues?.Invoke(__value3);
            }
            else if (LookingSimilar is { } __value4)
            {
                lookingSimilar?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
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

            if (FrequentlyBoughtTogether is { } __value0)
            {
                frequentlyBoughtTogether?.Invoke(__value0);
            }
            else if (RelatedProducts is { } __value1)
            {
                relatedProducts?.Invoke(__value1);
            }
            else if (TrendingItems is { } __value2)
            {
                trendingItems?.Invoke(__value2);
            }
            else if (TrendingFacetValues is { } __value3)
            {
                trendingFacetValues?.Invoke(__value3);
            }
            else if (LookingSimilar is { } __value4)
            {
                lookingSimilar?.Invoke(__value4);
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
