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
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>? OptionalFiltersVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>? OptionalFiltersVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OptionalFiltersVariant1))]
#endif
        public bool IsOptionalFiltersVariant1 => OptionalFiltersVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOptionalFiltersVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>? value)
        {
            value = OptionalFiltersVariant1;
            return IsOptionalFiltersVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters> PickOptionalFiltersVariant1() => IsOptionalFiltersVariant1
            ? OptionalFiltersVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OptionalFiltersVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? OptionalFiltersVariant2 { get; init; }
#else
        public string? OptionalFiltersVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OptionalFiltersVariant2))]
#endif
        public bool IsOptionalFiltersVariant2 => OptionalFiltersVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOptionalFiltersVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = OptionalFiltersVariant2;
            return IsOptionalFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickOptionalFiltersVariant2() => IsOptionalFiltersVariant2
            ? OptionalFiltersVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OptionalFiltersVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OptionalFilters(string value) => new OptionalFilters((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(OptionalFilters @this) => @this.OptionalFiltersVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OptionalFilters(string? value)
        {
            OptionalFiltersVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OptionalFilters FromOptionalFiltersVariant2(string? value) => new OptionalFilters(value);

        /// <summary>
        /// 
        /// </summary>
        public OptionalFilters(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>? optionalFiltersVariant1,
            string? optionalFiltersVariant2
            )
        {
            OptionalFiltersVariant1 = optionalFiltersVariant1;
            OptionalFiltersVariant2 = optionalFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OptionalFiltersVariant2 as object ??
            OptionalFiltersVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OptionalFiltersVariant1?.ToString() ??
            OptionalFiltersVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOptionalFiltersVariant1 && !IsOptionalFiltersVariant2 || !IsOptionalFiltersVariant1 && IsOptionalFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>, TResult>? optionalFiltersVariant1 = null,
            global::System.Func<string, TResult>? optionalFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOptionalFiltersVariant1 && optionalFiltersVariant1 != null)
            {
                return optionalFiltersVariant1(OptionalFiltersVariant1!);
            }
            else if (IsOptionalFiltersVariant2 && optionalFiltersVariant2 != null)
            {
                return optionalFiltersVariant2(OptionalFiltersVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>>? optionalFiltersVariant1 = null,

            global::System.Action<string>? optionalFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOptionalFiltersVariant1)
            {
                optionalFiltersVariant1?.Invoke(OptionalFiltersVariant1!);
            }
            else if (IsOptionalFiltersVariant2)
            {
                optionalFiltersVariant2?.Invoke(OptionalFiltersVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>>? optionalFiltersVariant1 = null,
            global::System.Action<string>? optionalFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOptionalFiltersVariant1)
            {
                optionalFiltersVariant1?.Invoke(OptionalFiltersVariant1!);
            }
            else if (IsOptionalFiltersVariant2)
            {
                optionalFiltersVariant2?.Invoke(OptionalFiltersVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OptionalFiltersVariant1,
                typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>),
                OptionalFiltersVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.Recommend.OptionalFilters>?>.Default.Equals(OptionalFiltersVariant1, other.OptionalFiltersVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(OptionalFiltersVariant2, other.OptionalFiltersVariant2) 
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
