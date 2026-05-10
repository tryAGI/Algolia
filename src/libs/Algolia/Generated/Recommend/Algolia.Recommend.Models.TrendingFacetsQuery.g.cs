#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TrendingFacetsQuery : global::System.IEquatable<TrendingFacetsQuery>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.TrendingFacets? TrendingFacets { get; init; }
#else
        public global::Algolia.Recommend.TrendingFacets? TrendingFacets { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrendingFacets))]
#endif
        public bool IsTrendingFacets => TrendingFacets != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTrendingFacets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.TrendingFacets? value)
        {
            value = TrendingFacets;
            return IsTrendingFacets;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TrendingFacetsQuery(global::Algolia.Recommend.TrendingFacets value) => new TrendingFacetsQuery((global::Algolia.Recommend.TrendingFacets?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.TrendingFacets?(TrendingFacetsQuery @this) => @this.TrendingFacets;

        /// <summary>
        /// 
        /// </summary>
        public TrendingFacetsQuery(global::Algolia.Recommend.TrendingFacets? value)
        {
            TrendingFacets = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TrendingFacetsQuery FromTrendingFacets(global::Algolia.Recommend.TrendingFacets? value) => new TrendingFacetsQuery(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TrendingFacets as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TrendingFacets?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTrendingFacets;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.TrendingFacets, TResult>? trendingFacets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrendingFacets && trendingFacets != null)
            {
                return trendingFacets(TrendingFacets!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.TrendingFacets>? trendingFacets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrendingFacets)
            {
                trendingFacets?.Invoke(TrendingFacets!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.TrendingFacets>? trendingFacets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrendingFacets)
            {
                trendingFacets?.Invoke(TrendingFacets!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TrendingFacets,
                typeof(global::Algolia.Recommend.TrendingFacets),
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
        public bool Equals(TrendingFacetsQuery other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.TrendingFacets?>.Default.Equals(TrendingFacets, other.TrendingFacets) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TrendingFacetsQuery obj1, TrendingFacetsQuery obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrendingFacetsQuery>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TrendingFacetsQuery obj1, TrendingFacetsQuery obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrendingFacetsQuery o && Equals(o);
        }
    }
}
