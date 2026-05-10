#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BoughtTogetherQuery : global::System.IEquatable<BoughtTogetherQuery>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.BaseRecommendRequest? BaseRecommendRequest { get; init; }
#else
        public global::Algolia.Recommend.BaseRecommendRequest? BaseRecommendRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseRecommendRequest))]
#endif
        public bool IsBaseRecommendRequest => BaseRecommendRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBaseRecommendRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.BaseRecommendRequest? value)
        {
            value = BaseRecommendRequest;
            return IsBaseRecommendRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Recommend.BaseRecommendRequest PickBaseRecommendRequest() => IsBaseRecommendRequest
            ? BaseRecommendRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BaseRecommendRequest' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.FrequentlyBoughtTogether? Frequently { get; init; }
#else
        public global::Algolia.Recommend.FrequentlyBoughtTogether? Frequently { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Frequently))]
#endif
        public bool IsFrequently => Frequently != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFrequently(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.FrequentlyBoughtTogether? value)
        {
            value = Frequently;
            return IsFrequently;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Recommend.FrequentlyBoughtTogether PickFrequently() => IsFrequently
            ? Frequently!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Frequently' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BoughtTogetherQuery(global::Algolia.Recommend.BaseRecommendRequest value) => new BoughtTogetherQuery((global::Algolia.Recommend.BaseRecommendRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BaseRecommendRequest?(BoughtTogetherQuery @this) => @this.BaseRecommendRequest;

        /// <summary>
        /// 
        /// </summary>
        public BoughtTogetherQuery(global::Algolia.Recommend.BaseRecommendRequest? value)
        {
            BaseRecommendRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BoughtTogetherQuery FromBaseRecommendRequest(global::Algolia.Recommend.BaseRecommendRequest? value) => new BoughtTogetherQuery(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BoughtTogetherQuery(global::Algolia.Recommend.FrequentlyBoughtTogether value) => new BoughtTogetherQuery((global::Algolia.Recommend.FrequentlyBoughtTogether?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.FrequentlyBoughtTogether?(BoughtTogetherQuery @this) => @this.Frequently;

        /// <summary>
        /// 
        /// </summary>
        public BoughtTogetherQuery(global::Algolia.Recommend.FrequentlyBoughtTogether? value)
        {
            Frequently = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BoughtTogetherQuery FromFrequently(global::Algolia.Recommend.FrequentlyBoughtTogether? value) => new BoughtTogetherQuery(value);

        /// <summary>
        /// 
        /// </summary>
        public BoughtTogetherQuery(
            global::Algolia.Recommend.BaseRecommendRequest? baseRecommendRequest,
            global::Algolia.Recommend.FrequentlyBoughtTogether? frequently
            )
        {
            BaseRecommendRequest = baseRecommendRequest;
            Frequently = frequently;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Frequently as object ??
            BaseRecommendRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseRecommendRequest?.ToString() ??
            Frequently?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseRecommendRequest && IsFrequently;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.BaseRecommendRequest, TResult>? baseRecommendRequest = null,
            global::System.Func<global::Algolia.Recommend.FrequentlyBoughtTogether, TResult>? frequently = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendRequest && baseRecommendRequest != null)
            {
                return baseRecommendRequest(BaseRecommendRequest!);
            }
            else if (IsFrequently && frequently != null)
            {
                return frequently(Frequently!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.BaseRecommendRequest>? baseRecommendRequest = null,

            global::System.Action<global::Algolia.Recommend.FrequentlyBoughtTogether>? frequently = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendRequest)
            {
                baseRecommendRequest?.Invoke(BaseRecommendRequest!);
            }
            else if (IsFrequently)
            {
                frequently?.Invoke(Frequently!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.BaseRecommendRequest>? baseRecommendRequest = null,
            global::System.Action<global::Algolia.Recommend.FrequentlyBoughtTogether>? frequently = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseRecommendRequest)
            {
                baseRecommendRequest?.Invoke(BaseRecommendRequest!);
            }
            else if (IsFrequently)
            {
                frequently?.Invoke(Frequently!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseRecommendRequest,
                typeof(global::Algolia.Recommend.BaseRecommendRequest),
                Frequently,
                typeof(global::Algolia.Recommend.FrequentlyBoughtTogether),
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
        public bool Equals(BoughtTogetherQuery other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BaseRecommendRequest?>.Default.Equals(BaseRecommendRequest, other.BaseRecommendRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.FrequentlyBoughtTogether?>.Default.Equals(Frequently, other.Frequently) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BoughtTogetherQuery obj1, BoughtTogetherQuery obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BoughtTogetherQuery>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BoughtTogetherQuery obj1, BoughtTogetherQuery obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BoughtTogetherQuery o && Equals(o);
        }
    }
}
