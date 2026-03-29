#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
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
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
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
        public object? Value2 { get; init; }
#else
        public object? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// List of [optional words](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/empty-or-insufficient-results/#creating-a-list-of-optional-words).<br/>
        /// Default Value: []<br/>
        /// Example: [blue, iphone case]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? Value3 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? Value3 { get; }
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
        public static implicit operator OptionalWords(string value) => new OptionalWords((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(OptionalWords @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public OptionalWords(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OptionalWords(
            string? value1,
            object? value2,
            global::System.Collections.Generic.IList<string>? value3
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
            Value2?.ToString() ??
            Value3?.ToString() 
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
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<object?, TResult>? value2 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? value3 = null,
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
            global::System.Action<string?>? value1 = null,
            global::System.Action<object?>? value2 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? value3 = null,
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
                typeof(string),
                Value2,
                typeof(object),
                Value3,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(Value3, other.Value3) 
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
