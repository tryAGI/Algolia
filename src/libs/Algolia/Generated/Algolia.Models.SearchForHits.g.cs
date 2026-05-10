#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchForHits : global::System.IEquatable<SearchForHits>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchParams? Params { get; init; }
#else
        public global::Algolia.SearchParams? Params { get; }
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
            out global::Algolia.SearchParams? value)
        {
            value = Params;
            return IsParams;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchForHitsSettings? Settings { get; init; }
#else
        public global::Algolia.SearchForHitsSettings? Settings { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Settings))]
#endif
        public bool IsSettings => Settings != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSettings(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchForHitsSettings? value)
        {
            value = Settings;
            return IsSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchForHits(global::Algolia.SearchParams value) => new SearchForHits((global::Algolia.SearchParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchParams?(SearchForHits @this) => @this.Params;

        /// <summary>
        /// 
        /// </summary>
        public SearchForHits(global::Algolia.SearchParams? value)
        {
            Params = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchForHits FromParams(global::Algolia.SearchParams? value) => new SearchForHits(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchForHits(global::Algolia.SearchForHitsSettings value) => new SearchForHits((global::Algolia.SearchForHitsSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchForHitsSettings?(SearchForHits @this) => @this.Settings;

        /// <summary>
        /// 
        /// </summary>
        public SearchForHits(global::Algolia.SearchForHitsSettings? value)
        {
            Settings = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchForHits FromSettings(global::Algolia.SearchForHitsSettings? value) => new SearchForHits(value);

        /// <summary>
        /// 
        /// </summary>
        public SearchForHits(
            global::Algolia.SearchParams? @params,
            global::Algolia.SearchForHitsSettings? settings
            )
        {
            Params = @params;
            Settings = settings;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Settings as object ??
            Params as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Params?.ToString() ??
            Settings?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsParams && IsSettings;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.SearchParams?, TResult>? @params = null,
            global::System.Func<global::Algolia.SearchForHitsSettings, TResult>? settings = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsParams && @params != null)
            {
                return @params(Params!);
            }
            else if (IsSettings && settings != null)
            {
                return settings(Settings!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.SearchParams?>? @params = null,

            global::System.Action<global::Algolia.SearchForHitsSettings>? settings = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsParams)
            {
                @params?.Invoke(Params!);
            }
            else if (IsSettings)
            {
                settings?.Invoke(Settings!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.SearchParams?>? @params = null,
            global::System.Action<global::Algolia.SearchForHitsSettings>? settings = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsParams)
            {
                @params?.Invoke(Params!);
            }
            else if (IsSettings)
            {
                settings?.Invoke(Settings!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Params,
                typeof(global::Algolia.SearchParams),
                Settings,
                typeof(global::Algolia.SearchForHitsSettings),
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
        public bool Equals(SearchForHits other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchParams?>.Default.Equals(Params, other.Params) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchForHitsSettings?>.Default.Equals(Settings, other.Settings) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchForHits obj1, SearchForHits obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchForHits>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchForHits obj1, SearchForHits obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchForHits o && Equals(o);
        }
    }
}
