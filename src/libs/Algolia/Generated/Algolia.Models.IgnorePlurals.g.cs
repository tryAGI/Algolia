#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Treat singular, plurals, and other forms of declensions as equivalent.<br/>
    /// Only use this feature for the languages used in your index.<br/>
    /// Example: [ca, es]
    /// </summary>
    public readonly partial struct IgnorePlurals : global::System.IEquatable<IgnorePlurals>
    {
        /// <summary>
        /// ISO code for languages for which this feature should be active.<br/>
        /// This overrides languages you set with `queryLanguages`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? IgnorePluralsVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? IgnorePluralsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IgnorePluralsVariant1))]
#endif
        public bool IsIgnorePluralsVariant1 => IgnorePluralsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BooleanString? BooleanString { get; init; }
#else
        public global::Algolia.BooleanString? BooleanString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BooleanString))]
#endif
        public bool IsBooleanString => BooleanString != null;

        /// <summary>
        /// If true, `ignorePlurals` is active for all languages included in `queryLanguages`, or for all supported languages, if `queryLanguges` is empty.<br/>
        /// If false, singulars, plurals, and other declensions won't be considered equivalent.<br/>
        /// Default Value: false
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? IgnorePluralsVariant3 { get; init; }
#else
        public bool? IgnorePluralsVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IgnorePluralsVariant3))]
#endif
        public bool IsIgnorePluralsVariant3 => IgnorePluralsVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IgnorePlurals(global::Algolia.BooleanString value) => new IgnorePlurals((global::Algolia.BooleanString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BooleanString?(IgnorePlurals @this) => @this.BooleanString;

        /// <summary>
        /// 
        /// </summary>
        public IgnorePlurals(global::Algolia.BooleanString? value)
        {
            BooleanString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IgnorePlurals(bool value) => new IgnorePlurals((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(IgnorePlurals @this) => @this.IgnorePluralsVariant3;

        /// <summary>
        /// 
        /// </summary>
        public IgnorePlurals(bool? value)
        {
            IgnorePluralsVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IgnorePlurals(
            global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? ignorePluralsVariant1,
            global::Algolia.BooleanString? booleanString,
            bool? ignorePluralsVariant3
            )
        {
            IgnorePluralsVariant1 = ignorePluralsVariant1;
            BooleanString = booleanString;
            IgnorePluralsVariant3 = ignorePluralsVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IgnorePluralsVariant3 as object ??
            BooleanString as object ??
            IgnorePluralsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            IgnorePluralsVariant1?.ToString() ??
            BooleanString?.ToValueString() ??
            IgnorePluralsVariant3?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIgnorePluralsVariant1 && !IsBooleanString && !IsIgnorePluralsVariant3 || !IsIgnorePluralsVariant1 && IsBooleanString && !IsIgnorePluralsVariant3 || !IsIgnorePluralsVariant1 && !IsBooleanString && IsIgnorePluralsVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?, TResult>? ignorePluralsVariant1 = null,
            global::System.Func<global::Algolia.BooleanString?, TResult>? booleanString = null,
            global::System.Func<bool?, TResult>? ignorePluralsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIgnorePluralsVariant1 && ignorePluralsVariant1 != null)
            {
                return ignorePluralsVariant1(IgnorePluralsVariant1!);
            }
            else if (IsBooleanString && booleanString != null)
            {
                return booleanString(BooleanString!);
            }
            else if (IsIgnorePluralsVariant3 && ignorePluralsVariant3 != null)
            {
                return ignorePluralsVariant3(IgnorePluralsVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?>? ignorePluralsVariant1 = null,
            global::System.Action<global::Algolia.BooleanString?>? booleanString = null,
            global::System.Action<bool?>? ignorePluralsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIgnorePluralsVariant1)
            {
                ignorePluralsVariant1?.Invoke(IgnorePluralsVariant1!);
            }
            else if (IsBooleanString)
            {
                booleanString?.Invoke(BooleanString!);
            }
            else if (IsIgnorePluralsVariant3)
            {
                ignorePluralsVariant3?.Invoke(IgnorePluralsVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IgnorePluralsVariant1,
                typeof(global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>),
                BooleanString,
                typeof(global::Algolia.BooleanString),
                IgnorePluralsVariant3,
                typeof(bool),
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
        public bool Equals(IgnorePlurals other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?>.Default.Equals(IgnorePluralsVariant1, other.IgnorePluralsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BooleanString?>.Default.Equals(BooleanString, other.BooleanString) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(IgnorePluralsVariant3, other.IgnorePluralsVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IgnorePlurals obj1, IgnorePlurals obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IgnorePlurals>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IgnorePlurals obj1, IgnorePlurals obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IgnorePlurals o && Equals(o);
        }
    }
}
