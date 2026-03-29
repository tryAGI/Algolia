#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseSearchParams : global::System.IEquatable<BaseSearchParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchParamsQuery? Query { get; init; }
#else
        public global::Algolia.SearchParamsQuery? Query { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Query))]
#endif
        public bool IsQuery => Query != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BaseSearchParamsWithoutQuery? WithoutQuery { get; init; }
#else
        public global::Algolia.BaseSearchParamsWithoutQuery? WithoutQuery { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WithoutQuery))]
#endif
        public bool IsWithoutQuery => WithoutQuery != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseSearchParams(global::Algolia.SearchParamsQuery value) => new BaseSearchParams((global::Algolia.SearchParamsQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchParamsQuery?(BaseSearchParams @this) => @this.Query;

        /// <summary>
        /// 
        /// </summary>
        public BaseSearchParams(global::Algolia.SearchParamsQuery? value)
        {
            Query = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseSearchParams(global::Algolia.BaseSearchParamsWithoutQuery value) => new BaseSearchParams((global::Algolia.BaseSearchParamsWithoutQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BaseSearchParamsWithoutQuery?(BaseSearchParams @this) => @this.WithoutQuery;

        /// <summary>
        /// 
        /// </summary>
        public BaseSearchParams(global::Algolia.BaseSearchParamsWithoutQuery? value)
        {
            WithoutQuery = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseSearchParams(
            global::Algolia.SearchParamsQuery? query,
            global::Algolia.BaseSearchParamsWithoutQuery? withoutQuery
            )
        {
            Query = query;
            WithoutQuery = withoutQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WithoutQuery as object ??
            Query as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Query?.ToString() ??
            WithoutQuery?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsQuery && IsWithoutQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.SearchParamsQuery?, TResult>? query = null,
            global::System.Func<global::Algolia.BaseSearchParamsWithoutQuery?, TResult>? withoutQuery = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsQuery && query != null)
            {
                return query(Query!);
            }
            else if (IsWithoutQuery && withoutQuery != null)
            {
                return withoutQuery(WithoutQuery!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.SearchParamsQuery?>? query = null,
            global::System.Action<global::Algolia.BaseSearchParamsWithoutQuery?>? withoutQuery = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsQuery)
            {
                query?.Invoke(Query!);
            }
            else if (IsWithoutQuery)
            {
                withoutQuery?.Invoke(WithoutQuery!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Query,
                typeof(global::Algolia.SearchParamsQuery),
                WithoutQuery,
                typeof(global::Algolia.BaseSearchParamsWithoutQuery),
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
        public bool Equals(BaseSearchParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchParamsQuery?>.Default.Equals(Query, other.Query) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BaseSearchParamsWithoutQuery?>.Default.Equals(WithoutQuery, other.WithoutQuery) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseSearchParams obj1, BaseSearchParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseSearchParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseSearchParams obj1, BaseSearchParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseSearchParams o && Equals(o);
        }
    }
}
