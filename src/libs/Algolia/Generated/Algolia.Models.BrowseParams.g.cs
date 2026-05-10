#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BrowseParams : global::System.IEquatable<BrowseParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BrowseParamsConfig? Config { get; init; }
#else
        public global::Algolia.BrowseParamsConfig? Config { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Config))]
#endif
        public bool IsConfig => Config != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.BrowseParamsConfig? value)
        {
            value = Config;
            return IsConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.BrowseParamsConfig PickConfig() => IsConfig
            ? Config!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Config' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public static implicit operator BrowseParams(global::Algolia.BrowseParamsConfig value) => new BrowseParams((global::Algolia.BrowseParamsConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BrowseParamsConfig?(BrowseParams @this) => @this.Config;

        /// <summary>
        /// 
        /// </summary>
        public BrowseParams(global::Algolia.BrowseParamsConfig? value)
        {
            Config = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BrowseParams FromConfig(global::Algolia.BrowseParamsConfig? value) => new BrowseParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BrowseParams(global::Algolia.SearchParamsString value) => new BrowseParams((global::Algolia.SearchParamsString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchParamsString?(BrowseParams @this) => @this.SearchParametersAsQueryString;

        /// <summary>
        /// 
        /// </summary>
        public BrowseParams(global::Algolia.SearchParamsString? value)
        {
            SearchParametersAsQueryString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BrowseParams FromSearchParametersAsQueryString(global::Algolia.SearchParamsString? value) => new BrowseParams(value);

        /// <summary>
        /// 
        /// </summary>
        public BrowseParams(
            global::Algolia.BrowseParamsConfig? config,
            global::Algolia.SearchParamsString? searchParametersAsQueryString
            )
        {
            Config = config;
            SearchParametersAsQueryString = searchParametersAsQueryString;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchParametersAsQueryString as object ??
            Config as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Config?.ToString() ??
            SearchParametersAsQueryString?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConfig && !IsSearchParametersAsQueryString || !IsConfig && IsSearchParametersAsQueryString;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.BrowseParamsConfig?, TResult>? config = null,
            global::System.Func<global::Algolia.SearchParamsString, TResult>? searchParametersAsQueryString = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConfig && config != null)
            {
                return config(Config!);
            }
            else if (IsSearchParametersAsQueryString && searchParametersAsQueryString != null)
            {
                return searchParametersAsQueryString(SearchParametersAsQueryString!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.BrowseParamsConfig?>? config = null,

            global::System.Action<global::Algolia.SearchParamsString>? searchParametersAsQueryString = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConfig)
            {
                config?.Invoke(Config!);
            }
            else if (IsSearchParametersAsQueryString)
            {
                searchParametersAsQueryString?.Invoke(SearchParametersAsQueryString!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.BrowseParamsConfig?>? config = null,
            global::System.Action<global::Algolia.SearchParamsString>? searchParametersAsQueryString = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConfig)
            {
                config?.Invoke(Config!);
            }
            else if (IsSearchParametersAsQueryString)
            {
                searchParametersAsQueryString?.Invoke(SearchParametersAsQueryString!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Config,
                typeof(global::Algolia.BrowseParamsConfig),
                SearchParametersAsQueryString,
                typeof(global::Algolia.SearchParamsString),
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
        public bool Equals(BrowseParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BrowseParamsConfig?>.Default.Equals(Config, other.Config) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchParamsString?>.Default.Equals(SearchParametersAsQueryString, other.SearchParametersAsQueryString) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BrowseParams obj1, BrowseParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BrowseParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BrowseParams obj1, BrowseParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BrowseParams o && Equals(o);
        }
    }
}
