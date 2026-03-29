#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Filter the search by facet values, so that only records with the same facet values are retrieved.<br/>
    /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
    /// - `[filter1, filter2]` is interpreted as `filter1 AND filter2`.<br/>
    /// - `[[filter1, filter2], filter3]` is interpreted as `filter1 OR filter2 AND filter3`.<br/>
    /// - `facet:-value` is interpreted as `NOT facet:value`.<br/>
    /// While it's best to avoid attributes that start with a `-`, you can still filter them by escaping with a backslash:<br/>
    /// `facet:\-value`.<br/>
    /// Example: [[category:Book, category:-Movie], author:John Doe]
    /// </summary>
    public readonly partial struct FacetFilters : global::System.IEquatable<FacetFilters>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.FacetFilters>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.FacetFilters>? Value1 { get; }
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
        public static implicit operator FacetFilters(string value) => new FacetFilters((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(FacetFilters @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public FacetFilters(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FacetFilters(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.FacetFilters>? value1,
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
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.Recommend.FacetFilters>?, TResult>? value1 = null,
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
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.FacetFilters>?>? value1 = null,
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
                typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.FacetFilters>),
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
        public bool Equals(FacetFilters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.Recommend.FacetFilters>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FacetFilters obj1, FacetFilters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FacetFilters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FacetFilters obj1, FacetFilters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FacetFilters o && Equals(o);
        }
    }
}
