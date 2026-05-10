#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Index settings.
    /// </summary>
    public readonly partial struct RecommendIndexSettings : global::System.IEquatable<RecommendIndexSettings>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.BaseIndexSettings? Base1 { get; init; }
#else
        public global::Algolia.Recommend.BaseIndexSettings? Base1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base1))]
#endif
        public bool IsBase1 => Base1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.BaseIndexSettings? value)
        {
            value = Base1;
            return IsBase1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.BaseRecommendIndexSettings? Base2 { get; init; }
#else
        public global::Algolia.Recommend.BaseRecommendIndexSettings? Base2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base2))]
#endif
        public bool IsBase2 => Base2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.BaseRecommendIndexSettings? value)
        {
            value = Base2;
            return IsBase2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendIndexSettings(global::Algolia.Recommend.BaseIndexSettings value) => new RecommendIndexSettings((global::Algolia.Recommend.BaseIndexSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BaseIndexSettings?(RecommendIndexSettings @this) => @this.Base1;

        /// <summary>
        /// 
        /// </summary>
        public RecommendIndexSettings(global::Algolia.Recommend.BaseIndexSettings? value)
        {
            Base1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecommendIndexSettings FromBase1(global::Algolia.Recommend.BaseIndexSettings? value) => new RecommendIndexSettings(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecommendIndexSettings(global::Algolia.Recommend.BaseRecommendIndexSettings value) => new RecommendIndexSettings((global::Algolia.Recommend.BaseRecommendIndexSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BaseRecommendIndexSettings?(RecommendIndexSettings @this) => @this.Base2;

        /// <summary>
        /// 
        /// </summary>
        public RecommendIndexSettings(global::Algolia.Recommend.BaseRecommendIndexSettings? value)
        {
            Base2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecommendIndexSettings FromBase2(global::Algolia.Recommend.BaseRecommendIndexSettings? value) => new RecommendIndexSettings(value);

        /// <summary>
        /// 
        /// </summary>
        public RecommendIndexSettings(
            global::Algolia.Recommend.BaseIndexSettings? base1,
            global::Algolia.Recommend.BaseRecommendIndexSettings? base2
            )
        {
            Base1 = base1;
            Base2 = base2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Base2 as object ??
            Base1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base1?.ToString() ??
            Base2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase1 && IsBase2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.BaseIndexSettings, TResult>? base1 = null,
            global::System.Func<global::Algolia.Recommend.BaseRecommendIndexSettings, TResult>? base2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase1 && base1 != null)
            {
                return base1(Base1!);
            }
            else if (IsBase2 && base2 != null)
            {
                return base2(Base2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.BaseIndexSettings>? base1 = null,

            global::System.Action<global::Algolia.Recommend.BaseRecommendIndexSettings>? base2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase1)
            {
                base1?.Invoke(Base1!);
            }
            else if (IsBase2)
            {
                base2?.Invoke(Base2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.BaseIndexSettings>? base1 = null,
            global::System.Action<global::Algolia.Recommend.BaseRecommendIndexSettings>? base2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase1)
            {
                base1?.Invoke(Base1!);
            }
            else if (IsBase2)
            {
                base2?.Invoke(Base2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base1,
                typeof(global::Algolia.Recommend.BaseIndexSettings),
                Base2,
                typeof(global::Algolia.Recommend.BaseRecommendIndexSettings),
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
        public bool Equals(RecommendIndexSettings other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BaseIndexSettings?>.Default.Equals(Base1, other.Base1) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BaseRecommendIndexSettings?>.Default.Equals(Base2, other.Base2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecommendIndexSettings obj1, RecommendIndexSettings obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecommendIndexSettings>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecommendIndexSettings obj1, RecommendIndexSettings obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecommendIndexSettings o && Equals(o);
        }
    }
}
