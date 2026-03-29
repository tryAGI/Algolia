#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Filter to be applied to the search.<br/>
    /// You can use this to respond to search queries that match a facet value.<br/>
    /// For example, if users search for "comedy", which matches a facet value of the "genre" facet,<br/>
    /// you can filter the results to show the top-ranked comedy movies.
    /// </summary>
    public readonly partial struct AutomaticFacetFilters : global::System.IEquatable<AutomaticFacetFilters>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>? Value1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>? Value1 { get; }
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
        public global::System.Collections.Generic.IList<string>? Value2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? Value2 { get; }
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
        public AutomaticFacetFilters(
            global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>? value1,
            global::System.Collections.Generic.IList<string>? value2
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
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? value2 = null,
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
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? value2 = null,
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
                typeof(global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>),
                Value2,
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
        public bool Equals(AutomaticFacetFilters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AutomaticFacetFilters obj1, AutomaticFacetFilters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutomaticFacetFilters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AutomaticFacetFilters obj1, AutomaticFacetFilters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutomaticFacetFilters o && Equals(o);
        }
    }
}
