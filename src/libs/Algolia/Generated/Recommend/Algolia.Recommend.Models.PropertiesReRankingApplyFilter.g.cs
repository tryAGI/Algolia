#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PropertiesReRankingApplyFilter : global::System.IEquatable<PropertiesReRankingApplyFilter>
    {
        /// <summary>
        /// Restrict [Dynamic Re-Ranking](https://www.algolia.com/doc/guides/algolia-ai/re-ranking) to records that match these filters.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.ReRankingApplyFilter? ReRankingApplyFilter { get; init; }
#else
        public global::Algolia.Recommend.ReRankingApplyFilter? ReRankingApplyFilter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReRankingApplyFilter))]
#endif
        public bool IsReRankingApplyFilter => ReRankingApplyFilter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReRankingApplyFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.ReRankingApplyFilter? value)
        {
            value = ReRankingApplyFilter;
            return IsReRankingApplyFilter;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? PropertiesReRankingApplyFilterVariant2 { get; init; }
#else
        public object? PropertiesReRankingApplyFilterVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PropertiesReRankingApplyFilterVariant2))]
#endif
        public bool IsPropertiesReRankingApplyFilterVariant2 => PropertiesReRankingApplyFilterVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPropertiesReRankingApplyFilterVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = PropertiesReRankingApplyFilterVariant2;
            return IsPropertiesReRankingApplyFilterVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PropertiesReRankingApplyFilter(global::Algolia.Recommend.ReRankingApplyFilter value) => new PropertiesReRankingApplyFilter((global::Algolia.Recommend.ReRankingApplyFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.ReRankingApplyFilter?(PropertiesReRankingApplyFilter @this) => @this.ReRankingApplyFilter;

        /// <summary>
        /// 
        /// </summary>
        public PropertiesReRankingApplyFilter(global::Algolia.Recommend.ReRankingApplyFilter? value)
        {
            ReRankingApplyFilter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PropertiesReRankingApplyFilter(
            global::Algolia.Recommend.ReRankingApplyFilter? reRankingApplyFilter,
            object? propertiesReRankingApplyFilterVariant2
            )
        {
            ReRankingApplyFilter = reRankingApplyFilter;
            PropertiesReRankingApplyFilterVariant2 = propertiesReRankingApplyFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PropertiesReRankingApplyFilterVariant2 as object ??
            ReRankingApplyFilter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReRankingApplyFilter?.ToString() ??
            PropertiesReRankingApplyFilterVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReRankingApplyFilter && !IsPropertiesReRankingApplyFilterVariant2 || !IsReRankingApplyFilter && IsPropertiesReRankingApplyFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.ReRankingApplyFilter?, TResult>? reRankingApplyFilter = null,
            global::System.Func<object, TResult>? propertiesReRankingApplyFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReRankingApplyFilter && reRankingApplyFilter != null)
            {
                return reRankingApplyFilter(ReRankingApplyFilter!);
            }
            else if (IsPropertiesReRankingApplyFilterVariant2 && propertiesReRankingApplyFilterVariant2 != null)
            {
                return propertiesReRankingApplyFilterVariant2(PropertiesReRankingApplyFilterVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.ReRankingApplyFilter?>? reRankingApplyFilter = null,

            global::System.Action<object>? propertiesReRankingApplyFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReRankingApplyFilter)
            {
                reRankingApplyFilter?.Invoke(ReRankingApplyFilter!);
            }
            else if (IsPropertiesReRankingApplyFilterVariant2)
            {
                propertiesReRankingApplyFilterVariant2?.Invoke(PropertiesReRankingApplyFilterVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.ReRankingApplyFilter?>? reRankingApplyFilter = null,
            global::System.Action<object>? propertiesReRankingApplyFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReRankingApplyFilter)
            {
                reRankingApplyFilter?.Invoke(ReRankingApplyFilter!);
            }
            else if (IsPropertiesReRankingApplyFilterVariant2)
            {
                propertiesReRankingApplyFilterVariant2?.Invoke(PropertiesReRankingApplyFilterVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReRankingApplyFilter,
                typeof(global::Algolia.Recommend.ReRankingApplyFilter),
                PropertiesReRankingApplyFilterVariant2,
                typeof(object),
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
        public bool Equals(PropertiesReRankingApplyFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.ReRankingApplyFilter?>.Default.Equals(ReRankingApplyFilter, other.ReRankingApplyFilter) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(PropertiesReRankingApplyFilterVariant2, other.PropertiesReRankingApplyFilterVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PropertiesReRankingApplyFilter obj1, PropertiesReRankingApplyFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PropertiesReRankingApplyFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PropertiesReRankingApplyFilter obj1, PropertiesReRankingApplyFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PropertiesReRankingApplyFilter o && Equals(o);
        }
    }
}
