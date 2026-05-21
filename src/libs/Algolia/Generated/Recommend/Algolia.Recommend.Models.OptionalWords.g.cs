#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Words that should be considered optional when found in the query.<br/>
    /// By default, records must match all words in the search query to be included in the search results.<br/>
    /// Adding optional words can increase the number of search results by running an additional search query that doesn't include the optional words.<br/>
    /// For example, if the search query is "action video" and "video" is optional,<br/>
    /// the search engine runs two queries: one for "action video" and one for "action".<br/>
    /// Records that match all words are ranked higher.<br/>
    /// For a search query with 4 or more words **and** all its words are optional,<br/>
    /// the number of matched words required for a record to be included in the search results increases for every 1,000 records:<br/>
    /// - If `optionalWords` has fewer than 10 words, the required number of matched words increases by 1:<br/>
    ///   results 1 to 1,000 require 1 matched word; results 1,001 to 2,000 need 2 matched words.<br/>
    /// - If `optionalWords` has 10 or more words, the required number of matched words increases by the number of optional words divided by 5 (rounded down).<br/>
    ///   Example: with 18 optional words, results 1 to 1,000 require 1 matched word; results 1,001 to 2,000 need 4 matched words.<br/>
    /// For more information, see [Optional words](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/empty-or-insufficient-results/#creating-a-list-of-optional-words).
    /// </summary>
    public readonly partial struct OptionalWords : global::System.IEquatable<OptionalWords>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? OptionalWordsVariant1 { get; init; }
#else
        public string? OptionalWordsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OptionalWordsVariant1))]
#endif
        public bool IsOptionalWordsVariant1 => OptionalWordsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOptionalWordsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = OptionalWordsVariant1;
            return IsOptionalWordsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickOptionalWordsVariant1() => IsOptionalWordsVariant1
            ? OptionalWordsVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OptionalWordsVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? OptionalWordsVariant2 { get; init; }
#else
        public object? OptionalWordsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OptionalWordsVariant2))]
#endif
        public bool IsOptionalWordsVariant2 => OptionalWordsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOptionalWordsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = OptionalWordsVariant2;
            return IsOptionalWordsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickOptionalWordsVariant2() => IsOptionalWordsVariant2
            ? OptionalWordsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OptionalWordsVariant2' but the value was {ToString()}.");

        /// <summary>
        /// List of [optional words](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/empty-or-insufficient-results/#creating-a-list-of-optional-words).<br/>
        /// Default Value: []<br/>
        /// Example: [blue, iphone case]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? Array { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? Array { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Array))]
#endif
        public bool IsArray => Array != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickArray(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickArray() => IsArray
            ? Array!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Array' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OptionalWords(string value) => new OptionalWords((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(OptionalWords @this) => @this.OptionalWordsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public OptionalWords(string? value)
        {
            OptionalWordsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OptionalWords FromOptionalWordsVariant1(string? value) => new OptionalWords(value);

        /// <summary>
        /// 
        /// </summary>
        public OptionalWords(
            string? optionalWordsVariant1,
            object? optionalWordsVariant2,
            global::System.Collections.Generic.IList<string>? array
            )
        {
            OptionalWordsVariant1 = optionalWordsVariant1;
            OptionalWordsVariant2 = optionalWordsVariant2;
            Array = array;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Array as object ??
            OptionalWordsVariant2 as object ??
            OptionalWordsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OptionalWordsVariant1?.ToString() ??
            OptionalWordsVariant2?.ToString() ??
            Array?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOptionalWordsVariant1 && !IsOptionalWordsVariant2 && !IsArray || !IsOptionalWordsVariant1 && IsOptionalWordsVariant2 && !IsArray || !IsOptionalWordsVariant1 && !IsOptionalWordsVariant2 && IsArray;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? optionalWordsVariant1 = null,
            global::System.Func<object, TResult>? optionalWordsVariant2 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOptionalWordsVariant1 && optionalWordsVariant1 != null)
            {
                return optionalWordsVariant1(OptionalWordsVariant1!);
            }
            else if (IsOptionalWordsVariant2 && optionalWordsVariant2 != null)
            {
                return optionalWordsVariant2(OptionalWordsVariant2!);
            }
            else if (IsArray && array != null)
            {
                return array(Array!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? optionalWordsVariant1 = null,

            global::System.Action<object>? optionalWordsVariant2 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOptionalWordsVariant1)
            {
                optionalWordsVariant1?.Invoke(OptionalWordsVariant1!);
            }
            else if (IsOptionalWordsVariant2)
            {
                optionalWordsVariant2?.Invoke(OptionalWordsVariant2!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? optionalWordsVariant1 = null,
            global::System.Action<object>? optionalWordsVariant2 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOptionalWordsVariant1)
            {
                optionalWordsVariant1?.Invoke(OptionalWordsVariant1!);
            }
            else if (IsOptionalWordsVariant2)
            {
                optionalWordsVariant2?.Invoke(OptionalWordsVariant2!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OptionalWordsVariant1,
                typeof(string),
                OptionalWordsVariant2,
                typeof(object),
                Array,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(OptionalWords other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(OptionalWordsVariant1, other.OptionalWordsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(OptionalWordsVariant2, other.OptionalWordsVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(Array, other.Array) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OptionalWords obj1, OptionalWords obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OptionalWords>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OptionalWords obj1, OptionalWords obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OptionalWords o && Equals(o);
        }
    }
}
