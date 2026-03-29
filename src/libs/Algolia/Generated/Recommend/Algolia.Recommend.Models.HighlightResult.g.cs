#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct HighlightResult : global::System.IEquatable<HighlightResult>
    {
        /// <summary>
        /// Surround words that match the query with HTML tags for highlighting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.HighlightResultOption? HighlightResultOption { get; init; }
#else
        public global::Algolia.Recommend.HighlightResultOption? HighlightResultOption { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightResultOption))]
#endif
        public bool IsHighlightResultOption => HighlightResultOption != null;

        /// <summary>
        /// Surround words that match the query with HTML tags for highlighting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.HighlightResultMap? HighlightResultMap { get; init; }
#else
        public global::Algolia.Recommend.HighlightResultMap? HighlightResultMap { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightResultMap))]
#endif
        public bool IsHighlightResultMap => HighlightResultMap != null;

        /// <summary>
        /// Surround words that match the query with HTML tags for highlighting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>? HighlightResultArray { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>? HighlightResultArray { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HighlightResultArray))]
#endif
        public bool IsHighlightResultArray => HighlightResultArray != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HighlightResult(global::Algolia.Recommend.HighlightResultOption value) => new HighlightResult((global::Algolia.Recommend.HighlightResultOption?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.HighlightResultOption?(HighlightResult @this) => @this.HighlightResultOption;

        /// <summary>
        /// 
        /// </summary>
        public HighlightResult(global::Algolia.Recommend.HighlightResultOption? value)
        {
            HighlightResultOption = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HighlightResult(global::Algolia.Recommend.HighlightResultMap value) => new HighlightResult((global::Algolia.Recommend.HighlightResultMap?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.HighlightResultMap?(HighlightResult @this) => @this.HighlightResultMap;

        /// <summary>
        /// 
        /// </summary>
        public HighlightResult(global::Algolia.Recommend.HighlightResultMap? value)
        {
            HighlightResultMap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public HighlightResult(
            global::Algolia.Recommend.HighlightResultOption? highlightResultOption,
            global::Algolia.Recommend.HighlightResultMap? highlightResultMap,
            global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>? highlightResultArray
            )
        {
            HighlightResultOption = highlightResultOption;
            HighlightResultMap = highlightResultMap;
            HighlightResultArray = highlightResultArray;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            HighlightResultArray as object ??
            HighlightResultMap as object ??
            HighlightResultOption as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            HighlightResultOption?.ToString() ??
            HighlightResultMap?.ToString() ??
            HighlightResultArray?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsHighlightResultOption && !IsHighlightResultMap && !IsHighlightResultArray || !IsHighlightResultOption && IsHighlightResultMap && !IsHighlightResultArray || !IsHighlightResultOption && !IsHighlightResultMap && IsHighlightResultArray;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.HighlightResultOption?, TResult>? highlightResultOption = null,
            global::System.Func<global::Algolia.Recommend.HighlightResultMap?, TResult>? highlightResultMap = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>?, TResult>? highlightResultArray = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHighlightResultOption && highlightResultOption != null)
            {
                return highlightResultOption(HighlightResultOption!);
            }
            else if (IsHighlightResultMap && highlightResultMap != null)
            {
                return highlightResultMap(HighlightResultMap!);
            }
            else if (IsHighlightResultArray && highlightResultArray != null)
            {
                return highlightResultArray(HighlightResultArray!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.HighlightResultOption?>? highlightResultOption = null,
            global::System.Action<global::Algolia.Recommend.HighlightResultMap?>? highlightResultMap = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>?>? highlightResultArray = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHighlightResultOption)
            {
                highlightResultOption?.Invoke(HighlightResultOption!);
            }
            else if (IsHighlightResultMap)
            {
                highlightResultMap?.Invoke(HighlightResultMap!);
            }
            else if (IsHighlightResultArray)
            {
                highlightResultArray?.Invoke(HighlightResultArray!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                HighlightResultOption,
                typeof(global::Algolia.Recommend.HighlightResultOption),
                HighlightResultMap,
                typeof(global::Algolia.Recommend.HighlightResultMap),
                HighlightResultArray,
                typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>),
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
        public bool Equals(HighlightResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.HighlightResultOption?>.Default.Equals(HighlightResultOption, other.HighlightResultOption) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.HighlightResultMap?>.Default.Equals(HighlightResultMap, other.HighlightResultMap) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.Recommend.HighlightResult>?>.Default.Equals(HighlightResultArray, other.HighlightResultArray) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(HighlightResult obj1, HighlightResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HighlightResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(HighlightResult obj1, HighlightResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HighlightResult o && Equals(o);
        }
    }
}
