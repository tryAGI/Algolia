#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Filter the search by values of the special `_tags` attribute.<br/>
    /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
    /// Different from regular facets, `_tags` can only be used for filtering (including or excluding records).<br/>
    /// You won't get a facet count.<br/>
    /// The same combination and escaping rules apply as for `facetFilters`.<br/>
    /// Example: [[Book, Movie], SciFi]
    /// </summary>
    public readonly partial struct TagFilters : global::System.IEquatable<TagFilters>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.TagFilters>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.TagFilters>? Value1 { get; }
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
        public string? Value2 { get; init; }
#else
        public string? Value2 { get; }
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
        public static implicit operator TagFilters(string value) => new TagFilters((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(TagFilters @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public TagFilters(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TagFilters(
            global::System.Collections.Generic.IList<global::Algolia.TagFilters>? value1,
            string? value2
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
            Value2?.ToString() 
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
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.TagFilters>?, TResult>? value1 = null,
            global::System.Func<string?, TResult>? value2 = null,
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
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.TagFilters>?>? value1 = null,
            global::System.Action<string?>? value2 = null,
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
                typeof(global::System.Collections.Generic.IList<global::Algolia.TagFilters>),
                Value2,
                typeof(string),
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
        public bool Equals(TagFilters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.TagFilters>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TagFilters obj1, TagFilters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TagFilters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TagFilters obj1, TagFilters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TagFilters o && Equals(o);
        }
    }
}
