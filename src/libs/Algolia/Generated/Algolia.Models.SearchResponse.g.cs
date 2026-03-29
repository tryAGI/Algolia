#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchResponse : global::System.IEquatable<SearchResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BaseSearchResponse? Base { get; init; }
#else
        public global::Algolia.BaseSearchResponse? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchPagination? Pagination { get; init; }
#else
        public global::Algolia.SearchPagination? Pagination { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pagination))]
#endif
        public bool IsPagination => Pagination != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchHits? Hits { get; init; }
#else
        public global::Algolia.SearchHits? Hits { get; }
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
        public static implicit operator SearchResponse(global::Algolia.BaseSearchResponse value) => new SearchResponse((global::Algolia.BaseSearchResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BaseSearchResponse?(SearchResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SearchResponse(global::Algolia.BaseSearchResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResponse(global::Algolia.SearchPagination value) => new SearchResponse((global::Algolia.SearchPagination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchPagination?(SearchResponse @this) => @this.Pagination;

        /// <summary>
        /// 
        /// </summary>
        public SearchResponse(global::Algolia.SearchPagination? value)
        {
            Pagination = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResponse(global::Algolia.SearchHits value) => new SearchResponse((global::Algolia.SearchHits?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchHits?(SearchResponse @this) => @this.Hits;

        /// <summary>
        /// 
        /// </summary>
        public SearchResponse(global::Algolia.SearchHits? value)
        {
            Hits = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchResponse(
            global::Algolia.BaseSearchResponse? @base,
            global::Algolia.SearchPagination? pagination,
            global::Algolia.SearchHits? hits
            )
        {
            Base = @base;
            Pagination = pagination;
            Hits = hits;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Hits as object ??
            Pagination as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            Pagination?.ToString() ??
            Hits?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsPagination && IsHits;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.BaseSearchResponse?, TResult>? @base = null,
            global::System.Func<global::Algolia.SearchPagination?, TResult>? pagination = null,
            global::System.Func<global::Algolia.SearchHits?, TResult>? hits = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsPagination && pagination != null)
            {
                return pagination(Pagination!);
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
            global::System.Action<global::Algolia.BaseSearchResponse?>? @base = null,
            global::System.Action<global::Algolia.SearchPagination?>? pagination = null,
            global::System.Action<global::Algolia.SearchHits?>? hits = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsPagination)
            {
                pagination?.Invoke(Pagination!);
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
                Base,
                typeof(global::Algolia.BaseSearchResponse),
                Pagination,
                typeof(global::Algolia.SearchPagination),
                Hits,
                typeof(global::Algolia.SearchHits),
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
        public bool Equals(SearchResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BaseSearchResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchPagination?>.Default.Equals(Pagination, other.Pagination) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchHits?>.Default.Equals(Hits, other.Hits) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchResponse obj1, SearchResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchResponse obj1, SearchResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchResponse o && Equals(o);
        }
    }
}
