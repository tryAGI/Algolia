#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Filter by numeric facets.<br/>
    /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
    /// You can use numeric comparison operators: `&lt;`, `&lt;=`, `=`, `!=`, `&gt;`, `&gt;=`.<br/>
    /// Comparisons are precise up to 3 decimals.<br/>
    /// You can also provide ranges: `facet:&lt;lower&gt; TO &lt;upper&gt;`. The range includes the lower and upper boundaries.<br/>
    /// The same combination rules apply as for `facetFilters`.<br/>
    /// Example: [[inStock = 1, deliveryDate &lt; 1441755506], price &lt; 1000]
    /// </summary>
    public readonly partial struct NumericFilters : global::System.IEquatable<NumericFilters>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.NumericFilters>? NumericFiltersVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.NumericFilters>? NumericFiltersVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumericFiltersVariant1))]
#endif
        public bool IsNumericFiltersVariant1 => NumericFiltersVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNumericFiltersVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Algolia.NumericFilters>? value)
        {
            value = NumericFiltersVariant1;
            return IsNumericFiltersVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? NumericFiltersVariant2 { get; init; }
#else
        public string? NumericFiltersVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumericFiltersVariant2))]
#endif
        public bool IsNumericFiltersVariant2 => NumericFiltersVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNumericFiltersVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = NumericFiltersVariant2;
            return IsNumericFiltersVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NumericFilters(string value) => new NumericFilters((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(NumericFilters @this) => @this.NumericFiltersVariant2;

        /// <summary>
        /// 
        /// </summary>
        public NumericFilters(string? value)
        {
            NumericFiltersVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NumericFilters(
            global::System.Collections.Generic.IList<global::Algolia.NumericFilters>? numericFiltersVariant1,
            string? numericFiltersVariant2
            )
        {
            NumericFiltersVariant1 = numericFiltersVariant1;
            NumericFiltersVariant2 = numericFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NumericFiltersVariant2 as object ??
            NumericFiltersVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NumericFiltersVariant1?.ToString() ??
            NumericFiltersVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNumericFiltersVariant1 && !IsNumericFiltersVariant2 || !IsNumericFiltersVariant1 && IsNumericFiltersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.NumericFilters>, TResult>? numericFiltersVariant1 = null,
            global::System.Func<string, TResult>? numericFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNumericFiltersVariant1 && numericFiltersVariant1 != null)
            {
                return numericFiltersVariant1(NumericFiltersVariant1!);
            }
            else if (IsNumericFiltersVariant2 && numericFiltersVariant2 != null)
            {
                return numericFiltersVariant2(NumericFiltersVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.NumericFilters>>? numericFiltersVariant1 = null,

            global::System.Action<string>? numericFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNumericFiltersVariant1)
            {
                numericFiltersVariant1?.Invoke(NumericFiltersVariant1!);
            }
            else if (IsNumericFiltersVariant2)
            {
                numericFiltersVariant2?.Invoke(NumericFiltersVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.NumericFilters>>? numericFiltersVariant1 = null,
            global::System.Action<string>? numericFiltersVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNumericFiltersVariant1)
            {
                numericFiltersVariant1?.Invoke(NumericFiltersVariant1!);
            }
            else if (IsNumericFiltersVariant2)
            {
                numericFiltersVariant2?.Invoke(NumericFiltersVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NumericFiltersVariant1,
                typeof(global::System.Collections.Generic.IList<global::Algolia.NumericFilters>),
                NumericFiltersVariant2,
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
        public bool Equals(NumericFilters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.NumericFilters>?>.Default.Equals(NumericFiltersVariant1, other.NumericFiltersVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(NumericFiltersVariant2, other.NumericFiltersVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NumericFilters obj1, NumericFilters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NumericFilters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NumericFilters obj1, NumericFilters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NumericFilters o && Equals(o);
        }
    }
}
