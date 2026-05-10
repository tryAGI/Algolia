#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchParams : global::System.IEquatable<SearchParams>
    {
        /// <summary>
        /// Search parameters as query string.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchParamsString? SearchParametersAsQueryString { get; init; }
#else
        public global::Algolia.SearchParamsString? SearchParametersAsQueryString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchParametersAsQueryString))]
#endif
        public bool IsSearchParametersAsQueryString => SearchParametersAsQueryString != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchParametersAsQueryString(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchParamsString? value)
        {
            value = SearchParametersAsQueryString;
            return IsSearchParametersAsQueryString;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.SearchParamsString PickSearchParametersAsQueryString() => IsSearchParametersAsQueryString
            ? SearchParametersAsQueryString!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchParametersAsQueryString' but the value was {ToString()}.");

        /// <summary>
        /// Each parameter value, including the `query` must not be larger than 512 bytes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchParamsObject? SearchParametersAsObject { get; init; }
#else
        public global::Algolia.SearchParamsObject? SearchParametersAsObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchParametersAsObject))]
#endif
        public bool IsSearchParametersAsObject => SearchParametersAsObject != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchParametersAsObject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchParamsObject? value)
        {
            value = SearchParametersAsObject;
            return IsSearchParametersAsObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.SearchParamsObject PickSearchParametersAsObject() => IsSearchParametersAsObject
            ? SearchParametersAsObject!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchParametersAsObject' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchParams(global::Algolia.SearchParamsString value) => new SearchParams((global::Algolia.SearchParamsString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchParamsString?(SearchParams @this) => @this.SearchParametersAsQueryString;

        /// <summary>
        /// 
        /// </summary>
        public SearchParams(global::Algolia.SearchParamsString? value)
        {
            SearchParametersAsQueryString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchParams FromSearchParametersAsQueryString(global::Algolia.SearchParamsString? value) => new SearchParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchParams(global::Algolia.SearchParamsObject value) => new SearchParams((global::Algolia.SearchParamsObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchParamsObject?(SearchParams @this) => @this.SearchParametersAsObject;

        /// <summary>
        /// 
        /// </summary>
        public SearchParams(global::Algolia.SearchParamsObject? value)
        {
            SearchParametersAsObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchParams FromSearchParametersAsObject(global::Algolia.SearchParamsObject? value) => new SearchParams(value);

        /// <summary>
        /// 
        /// </summary>
        public SearchParams(
            global::Algolia.SearchParamsString? searchParametersAsQueryString,
            global::Algolia.SearchParamsObject? searchParametersAsObject
            )
        {
            SearchParametersAsQueryString = searchParametersAsQueryString;
            SearchParametersAsObject = searchParametersAsObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchParametersAsObject as object ??
            SearchParametersAsQueryString as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchParametersAsQueryString?.ToString() ??
            SearchParametersAsObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchParametersAsQueryString && !IsSearchParametersAsObject || !IsSearchParametersAsQueryString && IsSearchParametersAsObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.SearchParamsString, TResult>? searchParametersAsQueryString = null,
            global::System.Func<global::Algolia.SearchParamsObject?, TResult>? searchParametersAsObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchParametersAsQueryString && searchParametersAsQueryString != null)
            {
                return searchParametersAsQueryString(SearchParametersAsQueryString!);
            }
            else if (IsSearchParametersAsObject && searchParametersAsObject != null)
            {
                return searchParametersAsObject(SearchParametersAsObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.SearchParamsString>? searchParametersAsQueryString = null,

            global::System.Action<global::Algolia.SearchParamsObject?>? searchParametersAsObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchParametersAsQueryString)
            {
                searchParametersAsQueryString?.Invoke(SearchParametersAsQueryString!);
            }
            else if (IsSearchParametersAsObject)
            {
                searchParametersAsObject?.Invoke(SearchParametersAsObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.SearchParamsString>? searchParametersAsQueryString = null,
            global::System.Action<global::Algolia.SearchParamsObject?>? searchParametersAsObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchParametersAsQueryString)
            {
                searchParametersAsQueryString?.Invoke(SearchParametersAsQueryString!);
            }
            else if (IsSearchParametersAsObject)
            {
                searchParametersAsObject?.Invoke(SearchParametersAsObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchParametersAsQueryString,
                typeof(global::Algolia.SearchParamsString),
                SearchParametersAsObject,
                typeof(global::Algolia.SearchParamsObject),
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
        public bool Equals(SearchParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchParamsString?>.Default.Equals(SearchParametersAsQueryString, other.SearchParametersAsQueryString) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchParamsObject?>.Default.Equals(SearchParametersAsObject, other.SearchParametersAsObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchParams obj1, SearchParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchParams obj1, SearchParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchParams o && Equals(o);
        }
    }
}
