#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
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
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.SupportedLanguage>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.SupportedLanguage>? Value1 { get; }
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
        public global::Algolia.Recommend.BooleanString? Value2 { get; init; }
#else
        public global::Algolia.Recommend.BooleanString? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// If true, `ignorePlurals` is active for all languages included in `queryLanguages`, or for all supported languages, if `queryLanguges` is empty.<br/>
        /// If false, singulars, plurals, and other declensions won't be considered equivalent.<br/>
        /// Default Value: false
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? Value3 { get; init; }
#else
        public bool? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IgnorePlurals(global::Algolia.Recommend.BooleanString value) => new IgnorePlurals((global::Algolia.Recommend.BooleanString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.BooleanString?(IgnorePlurals @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public IgnorePlurals(global::Algolia.Recommend.BooleanString? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IgnorePlurals(bool value) => new IgnorePlurals((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(IgnorePlurals @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public IgnorePlurals(bool? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IgnorePlurals(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.SupportedLanguage>? value1,
            global::Algolia.Recommend.BooleanString? value2,
            bool? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToValueString() ??
            Value3?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 || !IsValue1 && IsValue2 && !IsValue3 || !IsValue1 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.Recommend.SupportedLanguage>?, TResult>? value1 = null,
            global::System.Func<global::Algolia.Recommend.BooleanString?, TResult>? value2 = null,
            global::System.Func<bool?, TResult>? value3 = null,
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
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.SupportedLanguage>?>? value1 = null,
            global::System.Action<global::Algolia.Recommend.BooleanString?>? value2 = null,
            global::System.Action<bool?>? value3 = null,
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
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
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
                typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.SupportedLanguage>),
                Value2,
                typeof(global::Algolia.Recommend.BooleanString),
                Value3,
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
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.Recommend.SupportedLanguage>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.BooleanString?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(Value3, other.Value3) 
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
