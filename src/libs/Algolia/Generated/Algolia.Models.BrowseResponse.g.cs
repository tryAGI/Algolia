#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BrowseResponse : global::System.IEquatable<BrowseResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BaseSearchResponse? BaseSearch { get; init; }
#else
        public global::Algolia.BaseSearchResponse? BaseSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseSearch))]
#endif
        public bool IsBaseSearch => BaseSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBaseSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.BaseSearchResponse? value)
        {
            value = BaseSearch;
            return IsBaseSearch;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BrowsePagination? Pagination { get; init; }
#else
        public global::Algolia.BrowsePagination? Pagination { get; }
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
        public bool TryPickPagination(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.BrowsePagination? value)
        {
            value = Pagination;
            return IsPagination;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchHits? SearchHits { get; init; }
#else
        public global::Algolia.SearchHits? SearchHits { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchHits))]
#endif
        public bool IsSearchHits => SearchHits != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchHits(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchHits? value)
        {
            value = SearchHits;
            return IsSearchHits;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Cursor? Cursor { get; init; }
#else
        public global::Algolia.Cursor? Cursor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cursor))]
#endif
        public bool IsCursor => Cursor != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCursor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Cursor? value)
        {
            value = Cursor;
            return IsCursor;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BrowseResponse(global::Algolia.BaseSearchResponse value) => new BrowseResponse((global::Algolia.BaseSearchResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BaseSearchResponse?(BrowseResponse @this) => @this.BaseSearch;

        /// <summary>
        /// 
        /// </summary>
        public BrowseResponse(global::Algolia.BaseSearchResponse? value)
        {
            BaseSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BrowseResponse FromBaseSearch(global::Algolia.BaseSearchResponse? value) => new BrowseResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BrowseResponse(global::Algolia.BrowsePagination value) => new BrowseResponse((global::Algolia.BrowsePagination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BrowsePagination?(BrowseResponse @this) => @this.Pagination;

        /// <summary>
        /// 
        /// </summary>
        public BrowseResponse(global::Algolia.BrowsePagination? value)
        {
            Pagination = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BrowseResponse FromPagination(global::Algolia.BrowsePagination? value) => new BrowseResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BrowseResponse(global::Algolia.SearchHits value) => new BrowseResponse((global::Algolia.SearchHits?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchHits?(BrowseResponse @this) => @this.SearchHits;

        /// <summary>
        /// 
        /// </summary>
        public BrowseResponse(global::Algolia.SearchHits? value)
        {
            SearchHits = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BrowseResponse FromSearchHits(global::Algolia.SearchHits? value) => new BrowseResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BrowseResponse(global::Algolia.Cursor value) => new BrowseResponse((global::Algolia.Cursor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Cursor?(BrowseResponse @this) => @this.Cursor;

        /// <summary>
        /// 
        /// </summary>
        public BrowseResponse(global::Algolia.Cursor? value)
        {
            Cursor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BrowseResponse FromCursor(global::Algolia.Cursor? value) => new BrowseResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public BrowseResponse(
            global::Algolia.BaseSearchResponse? baseSearch,
            global::Algolia.BrowsePagination? pagination,
            global::Algolia.SearchHits? searchHits,
            global::Algolia.Cursor? cursor
            )
        {
            BaseSearch = baseSearch;
            Pagination = pagination;
            SearchHits = searchHits;
            Cursor = cursor;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Cursor as object ??
            SearchHits as object ??
            Pagination as object ??
            BaseSearch as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseSearch?.ToString() ??
            Pagination?.ToString() ??
            SearchHits?.ToString() ??
            Cursor?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseSearch && IsPagination && IsSearchHits && IsCursor;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.BaseSearchResponse, TResult>? baseSearch = null,
            global::System.Func<global::Algolia.BrowsePagination, TResult>? pagination = null,
            global::System.Func<global::Algolia.SearchHits, TResult>? searchHits = null,
            global::System.Func<global::Algolia.Cursor, TResult>? cursor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseSearch && baseSearch != null)
            {
                return baseSearch(BaseSearch!);
            }
            else if (IsPagination && pagination != null)
            {
                return pagination(Pagination!);
            }
            else if (IsSearchHits && searchHits != null)
            {
                return searchHits(SearchHits!);
            }
            else if (IsCursor && cursor != null)
            {
                return cursor(Cursor!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.BaseSearchResponse>? baseSearch = null,

            global::System.Action<global::Algolia.BrowsePagination>? pagination = null,

            global::System.Action<global::Algolia.SearchHits>? searchHits = null,

            global::System.Action<global::Algolia.Cursor>? cursor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseSearch)
            {
                baseSearch?.Invoke(BaseSearch!);
            }
            else if (IsPagination)
            {
                pagination?.Invoke(Pagination!);
            }
            else if (IsSearchHits)
            {
                searchHits?.Invoke(SearchHits!);
            }
            else if (IsCursor)
            {
                cursor?.Invoke(Cursor!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.BaseSearchResponse>? baseSearch = null,
            global::System.Action<global::Algolia.BrowsePagination>? pagination = null,
            global::System.Action<global::Algolia.SearchHits>? searchHits = null,
            global::System.Action<global::Algolia.Cursor>? cursor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseSearch)
            {
                baseSearch?.Invoke(BaseSearch!);
            }
            else if (IsPagination)
            {
                pagination?.Invoke(Pagination!);
            }
            else if (IsSearchHits)
            {
                searchHits?.Invoke(SearchHits!);
            }
            else if (IsCursor)
            {
                cursor?.Invoke(Cursor!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseSearch,
                typeof(global::Algolia.BaseSearchResponse),
                Pagination,
                typeof(global::Algolia.BrowsePagination),
                SearchHits,
                typeof(global::Algolia.SearchHits),
                Cursor,
                typeof(global::Algolia.Cursor),
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
        public bool Equals(BrowseResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BaseSearchResponse?>.Default.Equals(BaseSearch, other.BaseSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BrowsePagination?>.Default.Equals(Pagination, other.Pagination) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchHits?>.Default.Equals(SearchHits, other.SearchHits) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Cursor?>.Default.Equals(Cursor, other.Cursor) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BrowseResponse obj1, BrowseResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BrowseResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BrowseResponse obj1, BrowseResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BrowseResponse o && Equals(o);
        }
    }
}
