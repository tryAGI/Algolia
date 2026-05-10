#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
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
        public bool? TypoToleranceVariant1 { get; init; }
#else
        public bool? TypoToleranceVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypoToleranceVariant1))]
#endif
        public bool IsTypoToleranceVariant1 => TypoToleranceVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTypoToleranceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = TypoToleranceVariant1;
            return IsTypoToleranceVariant1;
        }

        /// <summary>
        /// - `min`. Return matches with the lowest number of typos.<br/>
        ///   For example, if you have matches without typos, only include those.<br/>
        ///   But if there are no matches without typos (with 1 typo), include matches with 1 typo (2 typos).<br/>
        /// - `strict`. Return matches with the two lowest numbers of typos.<br/>
        ///   With `strict`, the Typo ranking criterion is applied first in the `ranking` setting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.TypoToleranceEnum? Enum { get; init; }
#else
        public global::Algolia.Recommend.TypoToleranceEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.TypoToleranceEnum? value)
        {
            value = Enum;
            return IsEnum;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TypoTolerance(bool value) => new TypoTolerance((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(TypoTolerance @this) => @this.TypoToleranceVariant1;

        /// <summary>
        /// 
        /// </summary>
        public TypoTolerance(bool? value)
        {
            TypoToleranceVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TypoTolerance FromTypoToleranceVariant1(bool? value) => new TypoTolerance(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TypoTolerance(global::Algolia.Recommend.TypoToleranceEnum value) => new TypoTolerance((global::Algolia.Recommend.TypoToleranceEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.TypoToleranceEnum?(TypoTolerance @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public TypoTolerance(global::Algolia.Recommend.TypoToleranceEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TypoTolerance FromEnum(global::Algolia.Recommend.TypoToleranceEnum? value) => new TypoTolerance(value);

        /// <summary>
        /// 
        /// </summary>
        public TypoTolerance(
            bool? typoToleranceVariant1,
            global::Algolia.Recommend.TypoToleranceEnum? @enum
            )
        {
            TypoToleranceVariant1 = typoToleranceVariant1;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            TypoToleranceVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TypoToleranceVariant1?.ToString().ToLowerInvariant() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTypoToleranceVariant1 && !IsEnum || !IsTypoToleranceVariant1 && IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? typoToleranceVariant1 = null,
            global::System.Func<global::Algolia.Recommend.TypoToleranceEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTypoToleranceVariant1 && typoToleranceVariant1 != null)
            {
                return typoToleranceVariant1(TypoToleranceVariant1!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<bool?>? typoToleranceVariant1 = null,

            global::System.Action<global::Algolia.Recommend.TypoToleranceEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTypoToleranceVariant1)
            {
                typoToleranceVariant1?.Invoke(TypoToleranceVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<bool?>? typoToleranceVariant1 = null,
            global::System.Action<global::Algolia.Recommend.TypoToleranceEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTypoToleranceVariant1)
            {
                typoToleranceVariant1?.Invoke(TypoToleranceVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TypoToleranceVariant1,
                typeof(bool),
                Enum,
                typeof(global::Algolia.Recommend.TypoToleranceEnum),
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
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(TypoToleranceVariant1, other.TypoToleranceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.TypoToleranceEnum?>.Default.Equals(Enum, other.Enum) 
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
