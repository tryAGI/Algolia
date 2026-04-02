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
        public global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>? AutomaticFacetFiltersVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>? AutomaticFacetFiltersVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutomaticFacetFiltersVariant1))]
#endif
        public bool IsAutomaticFacetFiltersVariant1 => AutomaticFacetFiltersVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? AutomaticFacetFiltersVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? AutomaticFacetFiltersVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutomaticFacetFiltersVariant2))]
#endif
        public bool IsAutomaticFacetFiltersVariant2 => AutomaticFacetFiltersVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public AutomaticFacetFilters(
            global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>? automaticFacetFiltersVariant1,
            global::System.Collections.Generic.IList<string>? automaticFacetFiltersVariant2
            )
        {
            AutomaticFacetFiltersVariant1 = automaticFacetFiltersVariant1;
            AutomaticFacetFiltersVariant2 = automaticFacetFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AutomaticFacetFiltersVariant2 as object ??
            AutomaticFacetFiltersVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AutomaticFacetFiltersVariant1?.ToString() ??
            AutomaticFacetFiltersVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAutomaticFacetFiltersVariant1 && !IsAutomaticFacetFiltersVariant2 || !IsAutomaticFacetFiltersVariant1 && IsAutomaticFacetFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>?, TResult>? automaticFacetFiltersVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? automaticFacetFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutomaticFacetFiltersVariant1 && automaticFacetFiltersVariant1 != null)
            {
                return automaticFacetFiltersVariant1(AutomaticFacetFiltersVariant1!);
            }
            else if (IsAutomaticFacetFiltersVariant2 && automaticFacetFiltersVariant2 != null)
            {
                return automaticFacetFiltersVariant2(AutomaticFacetFiltersVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>?>? automaticFacetFiltersVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? automaticFacetFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutomaticFacetFiltersVariant1)
            {
                automaticFacetFiltersVariant1?.Invoke(AutomaticFacetFiltersVariant1!);
            }
            else if (IsAutomaticFacetFiltersVariant2)
            {
                automaticFacetFiltersVariant2?.Invoke(AutomaticFacetFiltersVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutomaticFacetFiltersVariant1,
                typeof(global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>),
                AutomaticFacetFiltersVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.AutomaticFacetFilter>?>.Default.Equals(AutomaticFacetFiltersVariant1, other.AutomaticFacetFiltersVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(AutomaticFacetFiltersVariant2, other.AutomaticFacetFiltersVariant2) 
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
