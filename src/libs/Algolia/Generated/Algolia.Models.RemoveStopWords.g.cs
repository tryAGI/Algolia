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
        public global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? RemoveStopWordsVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? RemoveStopWordsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemoveStopWordsVariant1))]
#endif
        public bool IsRemoveStopWordsVariant1 => RemoveStopWordsVariant1 != null;

        /// <summary>
        /// If true, stop words are removed for all languages you included in `queryLanguages`, or for all supported languages, if `queryLanguages` is empty.<br/>
        /// If false, stop words are not removed.<br/>
        /// Default Value: false
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? RemoveStopWordsVariant2 { get; init; }
#else
        public bool? RemoveStopWordsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemoveStopWordsVariant2))]
#endif
        public bool IsRemoveStopWordsVariant2 => RemoveStopWordsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RemoveStopWords(bool value) => new RemoveStopWords((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(RemoveStopWords @this) => @this.RemoveStopWordsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RemoveStopWords(bool? value)
        {
            RemoveStopWordsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RemoveStopWords(
            global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? removeStopWordsVariant1,
            bool? removeStopWordsVariant2
            )
        {
            RemoveStopWordsVariant1 = removeStopWordsVariant1;
            RemoveStopWordsVariant2 = removeStopWordsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RemoveStopWordsVariant2 as object ??
            RemoveStopWordsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RemoveStopWordsVariant1?.ToString() ??
            RemoveStopWordsVariant2?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRemoveStopWordsVariant1 && !IsRemoveStopWordsVariant2 || !IsRemoveStopWordsVariant1 && IsRemoveStopWordsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?, TResult>? removeStopWordsVariant1 = null,
            global::System.Func<bool?, TResult>? removeStopWordsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRemoveStopWordsVariant1 && removeStopWordsVariant1 != null)
            {
                return removeStopWordsVariant1(RemoveStopWordsVariant1!);
            }
            else if (IsRemoveStopWordsVariant2 && removeStopWordsVariant2 != null)
            {
                return removeStopWordsVariant2(RemoveStopWordsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?>? removeStopWordsVariant1 = null,
            global::System.Action<bool?>? removeStopWordsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRemoveStopWordsVariant1)
            {
                removeStopWordsVariant1?.Invoke(RemoveStopWordsVariant1!);
            }
            else if (IsRemoveStopWordsVariant2)
            {
                removeStopWordsVariant2?.Invoke(RemoveStopWordsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RemoveStopWordsVariant1,
                typeof(global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>),
                RemoveStopWordsVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?>.Default.Equals(RemoveStopWordsVariant1, other.RemoveStopWordsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(RemoveStopWordsVariant2, other.RemoveStopWordsVariant2) 
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
