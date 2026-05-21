#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
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
        public global::System.Collections.Generic.IList<global::Algolia.FacetFilters>? FacetFiltersVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.FacetFilters>? FacetFiltersVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FacetFiltersVariant1))]
#endif
        public bool IsFacetFiltersVariant1 => FacetFiltersVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFacetFiltersVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Algolia.FacetFilters>? value)
        {
            value = FacetFiltersVariant1;
            return IsFacetFiltersVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Algolia.FacetFilters> PickFacetFiltersVariant1() => IsFacetFiltersVariant1
            ? FacetFiltersVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FacetFiltersVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? FacetFiltersVariant2 { get; init; }
#else
        public string? FacetFiltersVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FacetFiltersVariant2))]
#endif
        public bool IsFacetFiltersVariant2 => FacetFiltersVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFacetFiltersVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = FacetFiltersVariant2;
            return IsFacetFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickFacetFiltersVariant2() => IsFacetFiltersVariant2
            ? FacetFiltersVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FacetFiltersVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FacetFilters(string value) => new FacetFilters((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(FacetFilters @this) => @this.FacetFiltersVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FacetFilters(string? value)
        {
            FacetFiltersVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FacetFilters FromFacetFiltersVariant2(string? value) => new FacetFilters(value);

        /// <summary>
        /// 
        /// </summary>
        public FacetFilters(
            global::System.Collections.Generic.IList<global::Algolia.FacetFilters>? facetFiltersVariant1,
            string? facetFiltersVariant2
            )
        {
            FacetFiltersVariant1 = facetFiltersVariant1;
            FacetFiltersVariant2 = facetFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FacetFiltersVariant2 as object ??
            FacetFiltersVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FacetFiltersVariant1?.ToString() ??
            FacetFiltersVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFacetFiltersVariant1 && !IsFacetFiltersVariant2 || !IsFacetFiltersVariant1 && IsFacetFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.FacetFilters>, TResult>? facetFiltersVariant1 = null,
            global::System.Func<string, TResult>? facetFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFacetFiltersVariant1 && facetFiltersVariant1 != null)
            {
                return facetFiltersVariant1(FacetFiltersVariant1!);
            }
            else if (IsFacetFiltersVariant2 && facetFiltersVariant2 != null)
            {
                return facetFiltersVariant2(FacetFiltersVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.FacetFilters>>? facetFiltersVariant1 = null,

            global::System.Action<string>? facetFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFacetFiltersVariant1)
            {
                facetFiltersVariant1?.Invoke(FacetFiltersVariant1!);
            }
            else if (IsFacetFiltersVariant2)
            {
                facetFiltersVariant2?.Invoke(FacetFiltersVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.FacetFilters>>? facetFiltersVariant1 = null,
            global::System.Action<string>? facetFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFacetFiltersVariant1)
            {
                facetFiltersVariant1?.Invoke(FacetFiltersVariant1!);
            }
            else if (IsFacetFiltersVariant2)
            {
                facetFiltersVariant2?.Invoke(FacetFiltersVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FacetFiltersVariant1,
                typeof(global::System.Collections.Generic.IList<global::Algolia.FacetFilters>),
                FacetFiltersVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.FacetFilters>?>.Default.Equals(FacetFiltersVariant1, other.FacetFiltersVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(FacetFiltersVariant2, other.FacetFiltersVariant2) 
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
