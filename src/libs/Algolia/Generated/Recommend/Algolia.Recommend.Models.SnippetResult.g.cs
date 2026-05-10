#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SnippetResult : global::System.IEquatable<SnippetResult>
    {
        /// <summary>
        /// Snippets that show the context around a matching search query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.SnippetResultOption? SnippetResultOption { get; init; }
#else
        public global::Algolia.Recommend.SnippetResultOption? SnippetResultOption { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SnippetResultOption))]
#endif
        public bool IsSnippetResultOption => SnippetResultOption != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSnippetResultOption(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.SnippetResultOption? value)
        {
            value = SnippetResultOption;
            return IsSnippetResultOption;
        }

        /// <summary>
        /// Snippets that show the context around a matching search query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.SnippetResultMap? SnippetResultMap { get; init; }
#else
        public global::Algolia.Recommend.SnippetResultMap? SnippetResultMap { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SnippetResultMap))]
#endif
        public bool IsSnippetResultMap => SnippetResultMap != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSnippetResultMap(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.SnippetResultMap? value)
        {
            value = SnippetResultMap;
            return IsSnippetResultMap;
        }

        /// <summary>
        /// Snippets that show the context around a matching search query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>? SnippetResultArray { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>? SnippetResultArray { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SnippetResultArray))]
#endif
        public bool IsSnippetResultArray => SnippetResultArray != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSnippetResultArray(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>? value)
        {
            value = SnippetResultArray;
            return IsSnippetResultArray;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SnippetResult(global::Algolia.Recommend.SnippetResultOption value) => new SnippetResult((global::Algolia.Recommend.SnippetResultOption?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.SnippetResultOption?(SnippetResult @this) => @this.SnippetResultOption;

        /// <summary>
        /// 
        /// </summary>
        public SnippetResult(global::Algolia.Recommend.SnippetResultOption? value)
        {
            SnippetResultOption = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SnippetResult FromSnippetResultOption(global::Algolia.Recommend.SnippetResultOption? value) => new SnippetResult(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SnippetResult(global::Algolia.Recommend.SnippetResultMap value) => new SnippetResult((global::Algolia.Recommend.SnippetResultMap?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.Recommend.SnippetResultMap?(SnippetResult @this) => @this.SnippetResultMap;

        /// <summary>
        /// 
        /// </summary>
        public SnippetResult(global::Algolia.Recommend.SnippetResultMap? value)
        {
            SnippetResultMap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SnippetResult FromSnippetResultMap(global::Algolia.Recommend.SnippetResultMap? value) => new SnippetResult(value);

        /// <summary>
        /// 
        /// </summary>
        public SnippetResult(
            global::Algolia.Recommend.SnippetResultOption? snippetResultOption,
            global::Algolia.Recommend.SnippetResultMap? snippetResultMap,
            global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>? snippetResultArray
            )
        {
            SnippetResultOption = snippetResultOption;
            SnippetResultMap = snippetResultMap;
            SnippetResultArray = snippetResultArray;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SnippetResultArray as object ??
            SnippetResultMap as object ??
            SnippetResultOption as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SnippetResultOption?.ToString() ??
            SnippetResultMap?.ToString() ??
            SnippetResultArray?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSnippetResultOption && !IsSnippetResultMap && !IsSnippetResultArray || !IsSnippetResultOption && IsSnippetResultMap && !IsSnippetResultArray || !IsSnippetResultOption && !IsSnippetResultMap && IsSnippetResultArray;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.SnippetResultOption, TResult>? snippetResultOption = null,
            global::System.Func<global::Algolia.Recommend.SnippetResultMap, TResult>? snippetResultMap = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>, TResult>? snippetResultArray = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSnippetResultOption && snippetResultOption != null)
            {
                return snippetResultOption(SnippetResultOption!);
            }
            else if (IsSnippetResultMap && snippetResultMap != null)
            {
                return snippetResultMap(SnippetResultMap!);
            }
            else if (IsSnippetResultArray && snippetResultArray != null)
            {
                return snippetResultArray(SnippetResultArray!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.SnippetResultOption>? snippetResultOption = null,

            global::System.Action<global::Algolia.Recommend.SnippetResultMap>? snippetResultMap = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>>? snippetResultArray = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSnippetResultOption)
            {
                snippetResultOption?.Invoke(SnippetResultOption!);
            }
            else if (IsSnippetResultMap)
            {
                snippetResultMap?.Invoke(SnippetResultMap!);
            }
            else if (IsSnippetResultArray)
            {
                snippetResultArray?.Invoke(SnippetResultArray!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.SnippetResultOption>? snippetResultOption = null,
            global::System.Action<global::Algolia.Recommend.SnippetResultMap>? snippetResultMap = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>>? snippetResultArray = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSnippetResultOption)
            {
                snippetResultOption?.Invoke(SnippetResultOption!);
            }
            else if (IsSnippetResultMap)
            {
                snippetResultMap?.Invoke(SnippetResultMap!);
            }
            else if (IsSnippetResultArray)
            {
                snippetResultArray?.Invoke(SnippetResultArray!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SnippetResultOption,
                typeof(global::Algolia.Recommend.SnippetResultOption),
                SnippetResultMap,
                typeof(global::Algolia.Recommend.SnippetResultMap),
                SnippetResultArray,
                typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>),
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
        public bool Equals(SnippetResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.SnippetResultOption?>.Default.Equals(SnippetResultOption, other.SnippetResultOption) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.SnippetResultMap?>.Default.Equals(SnippetResultMap, other.SnippetResultMap) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.Recommend.SnippetResult>?>.Default.Equals(SnippetResultArray, other.SnippetResultArray) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SnippetResult obj1, SnippetResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SnippetResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SnippetResult obj1, SnippetResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SnippetResult o && Equals(o);
        }
    }
}
