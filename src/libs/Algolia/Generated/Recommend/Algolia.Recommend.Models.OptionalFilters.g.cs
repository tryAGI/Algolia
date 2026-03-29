#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Filters to promote or demote records in the search results.<br/>
    /// Optional filters work like facet filters, but they don't exclude records from the search results.<br/>
    /// Records that match the optional filter rank before records that don't match.<br/>
    /// If you're using a negative filter `facet:-value`, matching records rank after records that don't match.<br/>
    /// - Optional filters are applied _after_ sort-by attributes.<br/>
    /// - Optional filters are applied _before_ custom ranking attributes (in the default [ranking](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria)).<br/>
    /// - Optional filters don't work with numeric attributes.<br/>
    /// - On virtual replicas, optional filters are applied _after_ the replica's [relevant sort](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/relevant-sort).<br/>
    /// Example: [category:Book, author:John Doe]
    /// </summary>
    public readonly partial struct OptionalFilters : global::System.IEquatable<OptionalFilters>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>? Value1 { get; }
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
        public static implicit operator OptionalFilters(string value) => new OptionalFilters((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(OptionalFilters @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public OptionalFilters(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OptionalFilters(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>? value1,
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
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>?, TResult>? value1 = null,
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
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>?>? value1 = null,
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
                typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>),
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
        public bool Equals(OptionalFilters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OptionalFilters obj1, OptionalFilters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OptionalFilters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OptionalFilters obj1, OptionalFilters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OptionalFilters o && Equals(o);
        }
    }
}
