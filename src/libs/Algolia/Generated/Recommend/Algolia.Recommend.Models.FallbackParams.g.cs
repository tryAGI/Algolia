#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FallbackParams : global::System.IEquatable<FallbackParams>
    {
        /// <summary>
        /// Search parameters for filtering the recommendations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.RecommendSearchParams? SearchParametersAsObject { get; init; }
#else
        public global::Algolia.Recommend.RecommendSearchParams? SearchParametersAsObject { get; }
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
            out global::Algolia.Recommend.RecommendSearchParams? value)
        {
            value = SearchParametersAsObject;
            return IsSearchParametersAsObject;
        }

        /// <summary>
        /// Search parameters to use for a fallback request if there aren't enough recommendations.
        /// </summary>
#if NET6_0_OR_GREATER
        public object? FallbackParamsVariant2 { get; init; }
#else
        public object? FallbackParamsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FallbackParamsVariant2))]
#endif
        public bool IsFallbackParamsVariant2 => FallbackParamsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFallbackParamsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = FallbackParamsVariant2;
            return IsFallbackParamsVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FallbackParams(global::Algolia.Recommend.RecommendSearchParams value) => new FallbackParams((global::Algolia.Recommend.RecommendSearchParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.RecommendSearchParams?(FallbackParams @this) => @this.SearchParametersAsObject;

        /// <summary>
        /// 
        /// </summary>
        public FallbackParams(global::Algolia.Recommend.RecommendSearchParams? value)
        {
            SearchParametersAsObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FallbackParams(
            global::Algolia.Recommend.RecommendSearchParams? searchParametersAsObject,
            object? fallbackParamsVariant2
            )
        {
            SearchParametersAsObject = searchParametersAsObject;
            FallbackParamsVariant2 = fallbackParamsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FallbackParamsVariant2 as object ??
            SearchParametersAsObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchParametersAsObject?.ToString() ??
            FallbackParamsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchParametersAsObject && IsFallbackParamsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.RecommendSearchParams?, TResult>? searchParametersAsObject = null,
            global::System.Func<object, TResult>? fallbackParamsVariant2 = null,
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
            else if (IsFallbackParamsVariant2 && fallbackParamsVariant2 != null)
            {
                return fallbackParamsVariant2(FallbackParamsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.RecommendSearchParams?>? searchParametersAsObject = null,

            global::System.Action<object>? fallbackParamsVariant2 = null,
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
            else if (IsFallbackParamsVariant2)
            {
                fallbackParamsVariant2?.Invoke(FallbackParamsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.RecommendSearchParams?>? searchParametersAsObject = null,
            global::System.Action<object>? fallbackParamsVariant2 = null,
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
            else if (IsFallbackParamsVariant2)
            {
                fallbackParamsVariant2?.Invoke(FallbackParamsVariant2!);
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
                typeof(global::Algolia.Recommend.RecommendSearchParams),
                FallbackParamsVariant2,
                typeof(object),
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
        public bool Equals(FallbackParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.RecommendSearchParams?>.Default.Equals(SearchParametersAsObject, other.SearchParametersAsObject) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(FallbackParamsVariant2, other.FallbackParamsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FallbackParams obj1, FallbackParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FallbackParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FallbackParams obj1, FallbackParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FallbackParams o && Equals(o);
        }
    }
}
