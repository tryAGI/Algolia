#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LookingSimilarQuery : global::System.IEquatable<LookingSimilarQuery>
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
        public global::Algolia.Recommend.LookingSimilar? LookingSimilar { get; init; }
#else
        public global::Algolia.Recommend.LookingSimilar? LookingSimilar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LookingSimilar))]
#endif
        public bool IsLookingSimilar => LookingSimilar != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLookingSimilar(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.LookingSimilar? value)
        {
            value = LookingSimilar;
            return IsLookingSimilar;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.Recommend.LookingSimilar PickLookingSimilar() => IsLookingSimilar
            ? LookingSimilar!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LookingSimilar' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LookingSimilarQuery(global::Algolia.Recommend.BaseRecommendRequest value) => new LookingSimilarQuery((global::Algolia.Recommend.BaseRecommendRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BaseRecommendRequest?(LookingSimilarQuery @this) => @this.BaseRecommendRequest;

        /// <summary>
        /// 
        /// </summary>
        public LookingSimilarQuery(global::Algolia.Recommend.BaseRecommendRequest? value)
        {
            BaseRecommendRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LookingSimilarQuery FromBaseRecommendRequest(global::Algolia.Recommend.BaseRecommendRequest? value) => new LookingSimilarQuery(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LookingSimilarQuery(global::Algolia.Recommend.LookingSimilar value) => new LookingSimilarQuery((global::Algolia.Recommend.LookingSimilar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.LookingSimilar?(LookingSimilarQuery @this) => @this.LookingSimilar;

        /// <summary>
        /// 
        /// </summary>
        public LookingSimilarQuery(global::Algolia.Recommend.LookingSimilar? value)
        {
            LookingSimilar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LookingSimilarQuery FromLookingSimilar(global::Algolia.Recommend.LookingSimilar? value) => new LookingSimilarQuery(value);

        /// <summary>
        /// 
        /// </summary>
        public LookingSimilarQuery(
            global::Algolia.Recommend.BaseRecommendRequest? baseRecommendRequest,
            global::Algolia.Recommend.LookingSimilar? lookingSimilar
            )
        {
            BaseRecommendRequest = baseRecommendRequest;
            LookingSimilar = lookingSimilar;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LookingSimilar as object ??
            BaseRecommendRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseRecommendRequest?.ToString() ??
            LookingSimilar?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseRecommendRequest && IsLookingSimilar;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.BaseRecommendRequest, TResult>? baseRecommendRequest = null,
            global::System.Func<global::Algolia.Recommend.LookingSimilar, TResult>? lookingSimilar = null,
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
            else if (IsLookingSimilar && lookingSimilar != null)
            {
                return lookingSimilar(LookingSimilar!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.BaseRecommendRequest>? baseRecommendRequest = null,

            global::System.Action<global::Algolia.Recommend.LookingSimilar>? lookingSimilar = null,
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
            else if (IsLookingSimilar)
            {
                lookingSimilar?.Invoke(LookingSimilar!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.BaseRecommendRequest>? baseRecommendRequest = null,
            global::System.Action<global::Algolia.Recommend.LookingSimilar>? lookingSimilar = null,
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
            else if (IsLookingSimilar)
            {
                lookingSimilar?.Invoke(LookingSimilar!);
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
                LookingSimilar,
                typeof(global::Algolia.Recommend.LookingSimilar),
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
        public bool Equals(LookingSimilarQuery other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BaseRecommendRequest?>.Default.Equals(BaseRecommendRequest, other.BaseRecommendRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.LookingSimilar?>.Default.Equals(LookingSimilar, other.LookingSimilar) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LookingSimilarQuery obj1, LookingSimilarQuery obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LookingSimilarQuery>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LookingSimilarQuery obj1, LookingSimilarQuery obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LookingSimilarQuery o && Equals(o);
        }
    }
}
