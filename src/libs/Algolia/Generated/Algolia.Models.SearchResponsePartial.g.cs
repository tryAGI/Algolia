#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Partial search response returned when the `responseFields` parameter excludes<br/>
    /// fields like `hits`. Contains all possible search response properties but<br/>
    /// none are required, so it acts as an unconditional fallback during oneOf<br/>
    /// deserialization.
    /// </summary>
    public readonly partial struct SearchResponsePartial : global::System.IEquatable<SearchResponsePartial>
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
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.BaseSearchResponse? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.BaseSearchResponse PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

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
        public bool TryPickPagination(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchPagination? value)
        {
            value = Pagination;
            return IsPagination;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.SearchPagination PickPagination() => IsPagination
            ? Pagination!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pagination' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchResponsePartialVariant3? SearchResponsePartialVariant3 { get; init; }
#else
        public global::Algolia.SearchResponsePartialVariant3? SearchResponsePartialVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResponsePartialVariant3))]
#endif
        public bool IsSearchResponsePartialVariant3 => SearchResponsePartialVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchResponsePartialVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchResponsePartialVariant3? value)
        {
            value = SearchResponsePartialVariant3;
            return IsSearchResponsePartialVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.SearchResponsePartialVariant3 PickSearchResponsePartialVariant3() => IsSearchResponsePartialVariant3
            ? SearchResponsePartialVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResponsePartialVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResponsePartial(global::Algolia.BaseSearchResponse value) => new SearchResponsePartial((global::Algolia.BaseSearchResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BaseSearchResponse?(SearchResponsePartial @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SearchResponsePartial(global::Algolia.BaseSearchResponse? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchResponsePartial FromBase(global::Algolia.BaseSearchResponse? value) => new SearchResponsePartial(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResponsePartial(global::Algolia.SearchPagination value) => new SearchResponsePartial((global::Algolia.SearchPagination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchPagination?(SearchResponsePartial @this) => @this.Pagination;

        /// <summary>
        /// 
        /// </summary>
        public SearchResponsePartial(global::Algolia.SearchPagination? value)
        {
            Pagination = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchResponsePartial FromPagination(global::Algolia.SearchPagination? value) => new SearchResponsePartial(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResponsePartial(global::Algolia.SearchResponsePartialVariant3 value) => new SearchResponsePartial((global::Algolia.SearchResponsePartialVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchResponsePartialVariant3?(SearchResponsePartial @this) => @this.SearchResponsePartialVariant3;

        /// <summary>
        /// 
        /// </summary>
        public SearchResponsePartial(global::Algolia.SearchResponsePartialVariant3? value)
        {
            SearchResponsePartialVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchResponsePartial FromSearchResponsePartialVariant3(global::Algolia.SearchResponsePartialVariant3? value) => new SearchResponsePartial(value);

        /// <summary>
        /// 
        /// </summary>
        public SearchResponsePartial(
            global::Algolia.BaseSearchResponse? @base,
            global::Algolia.SearchPagination? pagination,
            global::Algolia.SearchResponsePartialVariant3? searchResponsePartialVariant3
            )
        {
            Base = @base;
            Pagination = pagination;
            SearchResponsePartialVariant3 = searchResponsePartialVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchResponsePartialVariant3 as object ??
            Pagination as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            Pagination?.ToString() ??
            SearchResponsePartialVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsPagination && IsSearchResponsePartialVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.BaseSearchResponse, TResult>? @base = null,
            global::System.Func<global::Algolia.SearchPagination, TResult>? pagination = null,
            global::System.Func<global::Algolia.SearchResponsePartialVariant3, TResult>? searchResponsePartialVariant3 = null,
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
            else if (IsSearchResponsePartialVariant3 && searchResponsePartialVariant3 != null)
            {
                return searchResponsePartialVariant3(SearchResponsePartialVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.BaseSearchResponse>? @base = null,

            global::System.Action<global::Algolia.SearchPagination>? pagination = null,

            global::System.Action<global::Algolia.SearchResponsePartialVariant3>? searchResponsePartialVariant3 = null,
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
            else if (IsSearchResponsePartialVariant3)
            {
                searchResponsePartialVariant3?.Invoke(SearchResponsePartialVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.BaseSearchResponse>? @base = null,
            global::System.Action<global::Algolia.SearchPagination>? pagination = null,
            global::System.Action<global::Algolia.SearchResponsePartialVariant3>? searchResponsePartialVariant3 = null,
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
            else if (IsSearchResponsePartialVariant3)
            {
                searchResponsePartialVariant3?.Invoke(SearchResponsePartialVariant3!);
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
                SearchResponsePartialVariant3,
                typeof(global::Algolia.SearchResponsePartialVariant3),
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
        public bool Equals(SearchResponsePartial other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BaseSearchResponse?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchPagination?>.Default.Equals(Pagination, other.Pagination) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchResponsePartialVariant3?>.Default.Equals(SearchResponsePartialVariant3, other.SearchResponsePartialVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchResponsePartial obj1, SearchResponsePartial obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchResponsePartial>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchResponsePartial obj1, SearchResponsePartial obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchResponsePartial o && Equals(o);
        }
    }
}
