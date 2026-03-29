#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Whether [typo tolerance](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance) is enabled and how it is applied.<br/>
    /// If typo tolerance is true, `min`, or `strict`, [word splitting and concatenation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/splitting-and-concatenation) are also active.
    /// </summary>
    public readonly partial struct TypoTolerance : global::System.IEquatable<TypoTolerance>
    {
        /// <summary>
        /// Whether typo tolerance is active. If true, matches with typos are included in the search results and rank after exact matches.<br/>
        /// Default Value: true
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? Value1 { get; init; }
#else
        public bool? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// - `min`. Return matches with the lowest number of typos.<br/>
        ///   For example, if you have matches without typos, only include those.<br/>
        ///   But if there are no matches without typos (with 1 typo), include matches with 1 typo (2 typos).<br/>
        /// - `strict`. Return matches with the two lowest numbers of typos.<br/>
        ///   With `strict`, the Typo ranking criterion is applied first in the `ranking` setting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.TypoToleranceEnum? Value2 { get; init; }
#else
        public global::Algolia.TypoToleranceEnum? Value2 { get; }
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
        public static implicit operator TypoTolerance(bool value) => new TypoTolerance((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(TypoTolerance @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public TypoTolerance(bool? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TypoTolerance(global::Algolia.TypoToleranceEnum value) => new TypoTolerance((global::Algolia.TypoToleranceEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.TypoToleranceEnum?(TypoTolerance @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public TypoTolerance(global::Algolia.TypoToleranceEnum? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TypoTolerance(
            bool? value1,
            global::Algolia.TypoToleranceEnum? value2
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
            Value1?.ToString().ToLowerInvariant() ??
            Value2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? value1 = null,
            global::System.Func<global::Algolia.TypoToleranceEnum?, TResult>? value2 = null,
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
            global::System.Action<bool?>? value1 = null,
            global::System.Action<global::Algolia.TypoToleranceEnum?>? value2 = null,
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
                typeof(bool),
                Value2,
                typeof(global::Algolia.TypoToleranceEnum),
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
        public bool Equals(TypoTolerance other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.TypoToleranceEnum?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TypoTolerance obj1, TypoTolerance obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TypoTolerance>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TypoTolerance obj1, TypoTolerance obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TypoTolerance o && Equals(o);
        }
    }
}
