#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Removes stop words from the search query.<br/>
    /// Stop words are common words like articles, conjunctions, prepositions, or pronouns that have little or no meaning on their own.<br/>
    /// In English, "the", "a", or "and" are stop words.<br/>
    /// Only use this feature for the languages used in your index.<br/>
    /// Example: [ca, es]
    /// </summary>
    public readonly partial struct RemoveStopWords : global::System.IEquatable<RemoveStopWords>
    {
        /// <summary>
        /// ISO code for languages for which stop words should be removed. This overrides languages you set in `queryLanguges`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// If true, stop words are removed for all languages you included in `queryLanguages`, or for all supported languages, if `queryLanguages` is empty.<br/>
        /// If false, stop words are not removed.<br/>
        /// Default Value: false
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? Value2 { get; init; }
#else
        public bool? Value2 { get; }
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
        public static implicit operator RemoveStopWords(bool value) => new RemoveStopWords((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(RemoveStopWords @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RemoveStopWords(bool? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RemoveStopWords(
            global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? value1,
            bool? value2
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
            Value2?.ToString().ToLowerInvariant() 
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
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?, TResult>? value1 = null,
            global::System.Func<bool?, TResult>? value2 = null,
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
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?>? value1 = null,
            global::System.Action<bool?>? value2 = null,
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
                typeof(global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>),
                Value2,
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
        public bool Equals(RemoveStopWords other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RemoveStopWords obj1, RemoveStopWords obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RemoveStopWords>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RemoveStopWords obj1, RemoveStopWords obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RemoveStopWords o && Equals(o);
        }
    }
}
