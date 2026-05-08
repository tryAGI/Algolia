#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Restrict [Dynamic Re-Ranking](https://www.algolia.com/doc/guides/algolia-ai/re-ranking) to records that match these filters.
    /// </summary>
    public readonly partial struct ReRankingApplyFilter : global::System.IEquatable<ReRankingApplyFilter>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.ReRankingApplyFilter>? ReRankingApplyFilterVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.ReRankingApplyFilter>? ReRankingApplyFilterVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReRankingApplyFilterVariant1))]
#endif
        public bool IsReRankingApplyFilterVariant1 => ReRankingApplyFilterVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReRankingApplyFilterVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Algolia.Recommend.ReRankingApplyFilter>? value)
        {
            value = ReRankingApplyFilterVariant1;
            return IsReRankingApplyFilterVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ReRankingApplyFilterVariant2 { get; init; }
#else
        public string? ReRankingApplyFilterVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReRankingApplyFilterVariant2))]
#endif
        public bool IsReRankingApplyFilterVariant2 => ReRankingApplyFilterVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReRankingApplyFilterVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ReRankingApplyFilterVariant2;
            return IsReRankingApplyFilterVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReRankingApplyFilter(string value) => new ReRankingApplyFilter((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ReRankingApplyFilter @this) => @this.ReRankingApplyFilterVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ReRankingApplyFilter(string? value)
        {
            ReRankingApplyFilterVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReRankingApplyFilter(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.ReRankingApplyFilter>? reRankingApplyFilterVariant1,
            string? reRankingApplyFilterVariant2
            )
        {
            ReRankingApplyFilterVariant1 = reRankingApplyFilterVariant1;
            ReRankingApplyFilterVariant2 = reRankingApplyFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReRankingApplyFilterVariant2 as object ??
            ReRankingApplyFilterVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReRankingApplyFilterVariant1?.ToString() ??
            ReRankingApplyFilterVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReRankingApplyFilterVariant1 && !IsReRankingApplyFilterVariant2 || !IsReRankingApplyFilterVariant1 && IsReRankingApplyFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.Recommend.ReRankingApplyFilter>, TResult>? reRankingApplyFilterVariant1 = null,
            global::System.Func<string, TResult>? reRankingApplyFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReRankingApplyFilterVariant1 && reRankingApplyFilterVariant1 != null)
            {
                return reRankingApplyFilterVariant1(ReRankingApplyFilterVariant1!);
            }
            else if (IsReRankingApplyFilterVariant2 && reRankingApplyFilterVariant2 != null)
            {
                return reRankingApplyFilterVariant2(ReRankingApplyFilterVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.ReRankingApplyFilter>>? reRankingApplyFilterVariant1 = null,

            global::System.Action<string>? reRankingApplyFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReRankingApplyFilterVariant1)
            {
                reRankingApplyFilterVariant1?.Invoke(ReRankingApplyFilterVariant1!);
            }
            else if (IsReRankingApplyFilterVariant2)
            {
                reRankingApplyFilterVariant2?.Invoke(ReRankingApplyFilterVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.ReRankingApplyFilter>>? reRankingApplyFilterVariant1 = null,
            global::System.Action<string>? reRankingApplyFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReRankingApplyFilterVariant1)
            {
                reRankingApplyFilterVariant1?.Invoke(ReRankingApplyFilterVariant1!);
            }
            else if (IsReRankingApplyFilterVariant2)
            {
                reRankingApplyFilterVariant2?.Invoke(ReRankingApplyFilterVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReRankingApplyFilterVariant1,
                typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.ReRankingApplyFilter>),
                ReRankingApplyFilterVariant2,
                typeof(string),
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
        public bool Equals(ReRankingApplyFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.Recommend.ReRankingApplyFilter>?>.Default.Equals(ReRankingApplyFilterVariant1, other.ReRankingApplyFilterVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ReRankingApplyFilterVariant2, other.ReRankingApplyFilterVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReRankingApplyFilter obj1, ReRankingApplyFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReRankingApplyFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReRankingApplyFilter obj1, ReRankingApplyFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReRankingApplyFilter o && Equals(o);
        }
    }
}
