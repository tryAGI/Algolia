#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Search parameters for filtering the recommendations.
    /// </summary>
    public readonly partial struct RecommendSearchParams : global::System.IEquatable<RecommendSearchParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.BaseRecommendSearchParams? Base { get; init; }
#else
        public global::Algolia.Recommend.BaseRecommendSearchParams? Base { get; }
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
            out global::Algolia.Recommend.BaseRecommendSearchParams? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Recommend.BaseRecommendSearchParams PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.SearchParamsQuery? Query { get; init; }
#else
        public global::Algolia.Recommend.SearchParamsQuery? Query { get; }
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
        public bool TryPickQuery(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.SearchParamsQuery? value)
        {
            value = Query;
            return IsQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Recommend.SearchParamsQuery PickQuery() => IsQuery
            ? Query!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Query' but the value was {ToString()}.");

        /// <summary>
        /// Index settings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.RecommendIndexSettings? IndexSettings { get; init; }
#else
        public global::Algolia.Recommend.RecommendIndexSettings? IndexSettings { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexSettings))]
#endif
        public bool IsIndexSettings => IndexSettings != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIndexSettings(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.RecommendIndexSettings? value)
        {
            value = IndexSettings;
            return IsIndexSettings;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Recommend.RecommendIndexSettings PickIndexSettings() => IsIndexSettings
            ? IndexSettings!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'IndexSettings' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.RecommendSearchParamsVariant4? RecommendSearchParamsVariant4 { get; init; }
#else
        public global::Algolia.Recommend.RecommendSearchParamsVariant4? RecommendSearchParamsVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RecommendSearchParamsVariant4))]
#endif
        public bool IsRecommendSearchParamsVariant4 => RecommendSearchParamsVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRecommendSearchParamsVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.RecommendSearchParamsVariant4? value)
        {
            value = RecommendSearchParamsVariant4;
            return IsRecommendSearchParamsVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Recommend.RecommendSearchParamsVariant4 PickRecommendSearchParamsVariant4() => IsRecommendSearchParamsVariant4
            ? RecommendSearchParamsVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RecommendSearchParamsVariant4' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendSearchParams(global::Algolia.Recommend.BaseRecommendSearchParams value) => new RecommendSearchParams((global::Algolia.Recommend.BaseRecommendSearchParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BaseRecommendSearchParams?(RecommendSearchParams @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public RecommendSearchParams(global::Algolia.Recommend.BaseRecommendSearchParams? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecommendSearchParams FromBase(global::Algolia.Recommend.BaseRecommendSearchParams? value) => new RecommendSearchParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendSearchParams(global::Algolia.Recommend.SearchParamsQuery value) => new RecommendSearchParams((global::Algolia.Recommend.SearchParamsQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.SearchParamsQuery?(RecommendSearchParams @this) => @this.Query;

        /// <summary>
        /// 
        /// </summary>
        public RecommendSearchParams(global::Algolia.Recommend.SearchParamsQuery? value)
        {
            Query = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecommendSearchParams FromQuery(global::Algolia.Recommend.SearchParamsQuery? value) => new RecommendSearchParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendSearchParams(global::Algolia.Recommend.RecommendIndexSettings value) => new RecommendSearchParams((global::Algolia.Recommend.RecommendIndexSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.RecommendIndexSettings?(RecommendSearchParams @this) => @this.IndexSettings;

        /// <summary>
        /// 
        /// </summary>
        public RecommendSearchParams(global::Algolia.Recommend.RecommendIndexSettings? value)
        {
            IndexSettings = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecommendSearchParams FromIndexSettings(global::Algolia.Recommend.RecommendIndexSettings? value) => new RecommendSearchParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendSearchParams(global::Algolia.Recommend.RecommendSearchParamsVariant4 value) => new RecommendSearchParams((global::Algolia.Recommend.RecommendSearchParamsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.RecommendSearchParamsVariant4?(RecommendSearchParams @this) => @this.RecommendSearchParamsVariant4;

        /// <summary>
        /// 
        /// </summary>
        public RecommendSearchParams(global::Algolia.Recommend.RecommendSearchParamsVariant4? value)
        {
            RecommendSearchParamsVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecommendSearchParams FromRecommendSearchParamsVariant4(global::Algolia.Recommend.RecommendSearchParamsVariant4? value) => new RecommendSearchParams(value);

        /// <summary>
        /// 
        /// </summary>
        public RecommendSearchParams(
            global::Algolia.Recommend.BaseRecommendSearchParams? @base,
            global::Algolia.Recommend.SearchParamsQuery? query,
            global::Algolia.Recommend.RecommendIndexSettings? indexSettings,
            global::Algolia.Recommend.RecommendSearchParamsVariant4? recommendSearchParamsVariant4
            )
        {
            Base = @base;
            Query = query;
            IndexSettings = indexSettings;
            RecommendSearchParamsVariant4 = recommendSearchParamsVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RecommendSearchParamsVariant4 as object ??
            IndexSettings as object ??
            Query as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            Query?.ToString() ??
            IndexSettings?.ToString() ??
            RecommendSearchParamsVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsQuery && IsIndexSettings && IsRecommendSearchParamsVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.BaseRecommendSearchParams, TResult>? @base = null,
            global::System.Func<global::Algolia.Recommend.SearchParamsQuery, TResult>? query = null,
            global::System.Func<global::Algolia.Recommend.RecommendIndexSettings?, TResult>? indexSettings = null,
            global::System.Func<global::Algolia.Recommend.RecommendSearchParamsVariant4, TResult>? recommendSearchParamsVariant4 = null,
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
            else if (IsQuery && query != null)
            {
                return query(Query!);
            }
            else if (IsIndexSettings && indexSettings != null)
            {
                return indexSettings(IndexSettings!);
            }
            else if (IsRecommendSearchParamsVariant4 && recommendSearchParamsVariant4 != null)
            {
                return recommendSearchParamsVariant4(RecommendSearchParamsVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.BaseRecommendSearchParams>? @base = null,

            global::System.Action<global::Algolia.Recommend.SearchParamsQuery>? query = null,

            global::System.Action<global::Algolia.Recommend.RecommendIndexSettings?>? indexSettings = null,

            global::System.Action<global::Algolia.Recommend.RecommendSearchParamsVariant4>? recommendSearchParamsVariant4 = null,
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
            else if (IsQuery)
            {
                query?.Invoke(Query!);
            }
            else if (IsIndexSettings)
            {
                indexSettings?.Invoke(IndexSettings!);
            }
            else if (IsRecommendSearchParamsVariant4)
            {
                recommendSearchParamsVariant4?.Invoke(RecommendSearchParamsVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.BaseRecommendSearchParams>? @base = null,
            global::System.Action<global::Algolia.Recommend.SearchParamsQuery>? query = null,
            global::System.Action<global::Algolia.Recommend.RecommendIndexSettings?>? indexSettings = null,
            global::System.Action<global::Algolia.Recommend.RecommendSearchParamsVariant4>? recommendSearchParamsVariant4 = null,
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
            else if (IsQuery)
            {
                query?.Invoke(Query!);
            }
            else if (IsIndexSettings)
            {
                indexSettings?.Invoke(IndexSettings!);
            }
            else if (IsRecommendSearchParamsVariant4)
            {
                recommendSearchParamsVariant4?.Invoke(RecommendSearchParamsVariant4!);
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
                typeof(global::Algolia.Recommend.BaseRecommendSearchParams),
                Query,
                typeof(global::Algolia.Recommend.SearchParamsQuery),
                IndexSettings,
                typeof(global::Algolia.Recommend.RecommendIndexSettings),
                RecommendSearchParamsVariant4,
                typeof(global::Algolia.Recommend.RecommendSearchParamsVariant4),
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
        public bool Equals(RecommendSearchParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BaseRecommendSearchParams?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.SearchParamsQuery?>.Default.Equals(Query, other.Query) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.RecommendIndexSettings?>.Default.Equals(IndexSettings, other.IndexSettings) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.RecommendSearchParamsVariant4?>.Default.Equals(RecommendSearchParamsVariant4, other.RecommendSearchParamsVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecommendSearchParams obj1, RecommendSearchParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecommendSearchParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecommendSearchParams obj1, RecommendSearchParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecommendSearchParams o && Equals(o);
        }
    }
}
