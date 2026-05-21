#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConsequenceParams : global::System.IEquatable<ConsequenceParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BaseSearchParamsWithoutQuery? BaseSearchWithoutQuery { get; init; }
#else
        public global::Algolia.BaseSearchParamsWithoutQuery? BaseSearchWithoutQuery { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseSearchWithoutQuery))]
#endif
        public bool IsBaseSearchWithoutQuery => BaseSearchWithoutQuery != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBaseSearchWithoutQuery(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.BaseSearchParamsWithoutQuery? value)
        {
            value = BaseSearchWithoutQuery;
            return IsBaseSearchWithoutQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.BaseSearchParamsWithoutQuery PickBaseSearchWithoutQuery() => IsBaseSearchWithoutQuery
            ? BaseSearchWithoutQuery!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BaseSearchWithoutQuery' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.IndexSettingsAsSearchParams? IndexSettingsAsSearch { get; init; }
#else
        public global::Algolia.IndexSettingsAsSearchParams? IndexSettingsAsSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexSettingsAsSearch))]
#endif
        public bool IsIndexSettingsAsSearch => IndexSettingsAsSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIndexSettingsAsSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.IndexSettingsAsSearchParams? value)
        {
            value = IndexSettingsAsSearch;
            return IsIndexSettingsAsSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.IndexSettingsAsSearchParams PickIndexSettingsAsSearch() => IsIndexSettingsAsSearch
            ? IndexSettingsAsSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IndexSettingsAsSearch' but the value was {ToString()}.");

        /// <summary>
        /// Parameters to apply to this search.<br/>
        /// You can use all search parameters, plus special `automaticFacetFilters`, `automaticOptionalFacetFilters`, and `query`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Params? Params { get; init; }
#else
        public global::Algolia.Params? Params { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Params))]
#endif
        public bool IsParams => Params != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickParams(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Params? value)
        {
            value = Params;
            return IsParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Params PickParams() => IsParams
            ? Params!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Params' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConsequenceParams(global::Algolia.BaseSearchParamsWithoutQuery value) => new ConsequenceParams((global::Algolia.BaseSearchParamsWithoutQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BaseSearchParamsWithoutQuery?(ConsequenceParams @this) => @this.BaseSearchWithoutQuery;

        /// <summary>
        /// 
        /// </summary>
        public ConsequenceParams(global::Algolia.BaseSearchParamsWithoutQuery? value)
        {
            BaseSearchWithoutQuery = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConsequenceParams FromBaseSearchWithoutQuery(global::Algolia.BaseSearchParamsWithoutQuery? value) => new ConsequenceParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConsequenceParams(global::Algolia.IndexSettingsAsSearchParams value) => new ConsequenceParams((global::Algolia.IndexSettingsAsSearchParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.IndexSettingsAsSearchParams?(ConsequenceParams @this) => @this.IndexSettingsAsSearch;

        /// <summary>
        /// 
        /// </summary>
        public ConsequenceParams(global::Algolia.IndexSettingsAsSearchParams? value)
        {
            IndexSettingsAsSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConsequenceParams FromIndexSettingsAsSearch(global::Algolia.IndexSettingsAsSearchParams? value) => new ConsequenceParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConsequenceParams(global::Algolia.Params value) => new ConsequenceParams((global::Algolia.Params?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Params?(ConsequenceParams @this) => @this.Params;

        /// <summary>
        /// 
        /// </summary>
        public ConsequenceParams(global::Algolia.Params? value)
        {
            Params = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConsequenceParams FromParams(global::Algolia.Params? value) => new ConsequenceParams(value);

        /// <summary>
        /// 
        /// </summary>
        public ConsequenceParams(
            global::Algolia.BaseSearchParamsWithoutQuery? baseSearchWithoutQuery,
            global::Algolia.IndexSettingsAsSearchParams? indexSettingsAsSearch,
            global::Algolia.Params? @params
            )
        {
            BaseSearchWithoutQuery = baseSearchWithoutQuery;
            IndexSettingsAsSearch = indexSettingsAsSearch;
            Params = @params;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Params as object ??
            IndexSettingsAsSearch as object ??
            BaseSearchWithoutQuery as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseSearchWithoutQuery?.ToString() ??
            IndexSettingsAsSearch?.ToString() ??
            Params?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseSearchWithoutQuery && IsIndexSettingsAsSearch && IsParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.BaseSearchParamsWithoutQuery, TResult>? baseSearchWithoutQuery = null,
            global::System.Func<global::Algolia.IndexSettingsAsSearchParams, TResult>? indexSettingsAsSearch = null,
            global::System.Func<global::Algolia.Params, TResult>? @params = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseSearchWithoutQuery && baseSearchWithoutQuery != null)
            {
                return baseSearchWithoutQuery(BaseSearchWithoutQuery!);
            }
            else if (IsIndexSettingsAsSearch && indexSettingsAsSearch != null)
            {
                return indexSettingsAsSearch(IndexSettingsAsSearch!);
            }
            else if (IsParams && @params != null)
            {
                return @params(Params!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.BaseSearchParamsWithoutQuery>? baseSearchWithoutQuery = null,

            global::System.Action<global::Algolia.IndexSettingsAsSearchParams>? indexSettingsAsSearch = null,

            global::System.Action<global::Algolia.Params>? @params = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseSearchWithoutQuery)
            {
                baseSearchWithoutQuery?.Invoke(BaseSearchWithoutQuery!);
            }
            else if (IsIndexSettingsAsSearch)
            {
                indexSettingsAsSearch?.Invoke(IndexSettingsAsSearch!);
            }
            else if (IsParams)
            {
                @params?.Invoke(Params!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.BaseSearchParamsWithoutQuery>? baseSearchWithoutQuery = null,
            global::System.Action<global::Algolia.IndexSettingsAsSearchParams>? indexSettingsAsSearch = null,
            global::System.Action<global::Algolia.Params>? @params = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseSearchWithoutQuery)
            {
                baseSearchWithoutQuery?.Invoke(BaseSearchWithoutQuery!);
            }
            else if (IsIndexSettingsAsSearch)
            {
                indexSettingsAsSearch?.Invoke(IndexSettingsAsSearch!);
            }
            else if (IsParams)
            {
                @params?.Invoke(Params!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseSearchWithoutQuery,
                typeof(global::Algolia.BaseSearchParamsWithoutQuery),
                IndexSettingsAsSearch,
                typeof(global::Algolia.IndexSettingsAsSearchParams),
                Params,
                typeof(global::Algolia.Params),
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
        public bool Equals(ConsequenceParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BaseSearchParamsWithoutQuery?>.Default.Equals(BaseSearchWithoutQuery, other.BaseSearchWithoutQuery) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.IndexSettingsAsSearchParams?>.Default.Equals(IndexSettingsAsSearch, other.IndexSettingsAsSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Params?>.Default.Equals(Params, other.Params) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConsequenceParams obj1, ConsequenceParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConsequenceParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConsequenceParams obj1, ConsequenceParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConsequenceParams o && Equals(o);
        }
    }
}
