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
        public global::Algolia.Recommend.BaseRecommendRequest? Value1 { get; init; }
#else
        public global::Algolia.Recommend.BaseRecommendRequest? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.LookingSimilar? Value2 { get; init; }
#else
        public global::Algolia.Recommend.LookingSimilar? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LookingSimilarQuery(global::Algolia.Recommend.BaseRecommendRequest value) => new LookingSimilarQuery((global::Algolia.Recommend.BaseRecommendRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BaseRecommendRequest?(LookingSimilarQuery @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public LookingSimilarQuery(global::Algolia.Recommend.BaseRecommendRequest? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LookingSimilarQuery(global::Algolia.Recommend.LookingSimilar value) => new LookingSimilarQuery((global::Algolia.Recommend.LookingSimilar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.LookingSimilar?(LookingSimilarQuery @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public LookingSimilarQuery(global::Algolia.Recommend.LookingSimilar? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LookingSimilarQuery(
            global::Algolia.Recommend.BaseRecommendRequest? value1,
            global::Algolia.Recommend.LookingSimilar? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.BaseRecommendRequest?, TResult>? value1 = null,
            global::System.Func<global::Algolia.Recommend.LookingSimilar?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.BaseRecommendRequest?>? value1 = null,
            global::System.Action<global::Algolia.Recommend.LookingSimilar?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Algolia.Recommend.BaseRecommendRequest),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BaseRecommendRequest?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.LookingSimilar?>.Default.Equals(Value2, other.Value2) 
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
