#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BrowseParamsConfig : global::System.IEquatable<BrowseParamsConfig>
    {
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
        public static implicit operator BrowseParamsConfig(global::Algolia.SearchParamsObject value) => new BrowseParamsConfig((global::Algolia.SearchParamsObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchParamsObject?(BrowseParamsConfig @this) => @this.SearchParametersAsObject;

        /// <summary>
        /// 
        /// </summary>
        public BrowseParamsConfig(global::Algolia.SearchParamsObject? value)
        {
            SearchParametersAsObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BrowseParamsConfig(global::Algolia.Cursor value) => new BrowseParamsConfig((global::Algolia.Cursor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Cursor?(BrowseParamsConfig @this) => @this.Cursor;

        /// <summary>
        /// 
        /// </summary>
        public BrowseParamsConfig(global::Algolia.Cursor? value)
        {
            Cursor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BrowseParamsConfig(
            global::Algolia.SearchParamsObject? searchParametersAsObject,
            global::Algolia.Cursor? cursor
            )
        {
            SearchParametersAsObject = searchParametersAsObject;
            Cursor = cursor;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Cursor as object ??
            SearchParametersAsObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchParametersAsObject?.ToString() ??
            Cursor?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchParametersAsObject && IsCursor;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.SearchParamsObject?, TResult>? searchParametersAsObject = null,
            global::System.Func<global::Algolia.Cursor, TResult>? cursor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchParametersAsObject && searchParametersAsObject != null)
            {
                return searchParametersAsObject(SearchParametersAsObject!);
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
            global::System.Action<global::Algolia.SearchParamsObject?>? searchParametersAsObject = null,

            global::System.Action<global::Algolia.Cursor>? cursor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchParametersAsObject)
            {
                searchParametersAsObject?.Invoke(SearchParametersAsObject!);
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
            global::System.Action<global::Algolia.SearchParamsObject?>? searchParametersAsObject = null,
            global::System.Action<global::Algolia.Cursor>? cursor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchParametersAsObject)
            {
                searchParametersAsObject?.Invoke(SearchParametersAsObject!);
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
                SearchParametersAsObject,
                typeof(global::Algolia.SearchParamsObject),
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
        public bool Equals(BrowseParamsConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchParamsObject?>.Default.Equals(SearchParametersAsObject, other.SearchParametersAsObject) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Cursor?>.Default.Equals(Cursor, other.Cursor) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BrowseParamsConfig obj1, BrowseParamsConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BrowseParamsConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BrowseParamsConfig obj1, BrowseParamsConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BrowseParamsConfig o && Equals(o);
        }
    }
}
