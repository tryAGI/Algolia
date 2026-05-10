#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Determines how many records of a group are included in the search results.<br/>
    /// Records with the same value for the `attributeForDistinct` attribute are considered a group.<br/>
    /// The `distinct` setting controls how many members of the group are returned.<br/>
    /// This is useful for [deduplication and grouping](https://www.algolia.com/doc/guides/managing-results/refine-results/grouping/#introducing-algolias-distinct-feature).<br/>
    /// The `distinct` setting is ignored if `attributeForDistinct` is not set.<br/>
    /// Example: 1
    /// </summary>
    public readonly partial struct Distinct : global::System.IEquatable<Distinct>
    {
        /// <summary>
        /// Whether deduplication is turned on. If true, only one member of a group is shown in the search results.
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? DistinctVariant1 { get; init; }
#else
        public bool? DistinctVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DistinctVariant1))]
#endif
        public bool IsDistinctVariant1 => DistinctVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDistinctVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = DistinctVariant1;
            return IsDistinctVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool PickDistinctVariant1() => IsDistinctVariant1
            ? DistinctVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DistinctVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Number of members of a group of records to include in the search results.<br/>
        /// - Don't use `distinct &gt; 1` for records that might be [promoted by rules](https://www.algolia.com/doc/guides/managing-results/rules/merchandising-and-promoting/how-to/promote-hits).<br/>
        ///   The number of hits won't be correct and faceting won't work as expected.<br/>
        /// - With `distinct &gt; 1`, the `hitsPerPage` parameter controls the number of returned groups.<br/>
        ///   For example, with `hitsPerPage: 10` and `distinct: 2`, up to 20 records are returned.<br/>
        ///   Likewise, the `nbHits` response attribute contains the number of returned groups.<br/>
        /// Default Value: 0
        /// </summary>
#if NET6_0_OR_GREATER
        public int? DistinctVariant2 { get; init; }
#else
        public int? DistinctVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DistinctVariant2))]
#endif
        public bool IsDistinctVariant2 => DistinctVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDistinctVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = DistinctVariant2;
            return IsDistinctVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public int PickDistinctVariant2() => IsDistinctVariant2
            ? DistinctVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DistinctVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Distinct(bool value) => new Distinct((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(Distinct @this) => @this.DistinctVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Distinct(bool? value)
        {
            DistinctVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Distinct FromDistinctVariant1(bool? value) => new Distinct(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Distinct(int value) => new Distinct((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(Distinct @this) => @this.DistinctVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Distinct(int? value)
        {
            DistinctVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Distinct FromDistinctVariant2(int? value) => new Distinct(value);

        /// <summary>
        /// 
        /// </summary>
        public Distinct(
            bool? distinctVariant1,
            int? distinctVariant2
            )
        {
            DistinctVariant1 = distinctVariant1;
            DistinctVariant2 = distinctVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DistinctVariant2 as object ??
            DistinctVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DistinctVariant1?.ToString().ToLowerInvariant() ??
            DistinctVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDistinctVariant1 && !IsDistinctVariant2 || !IsDistinctVariant1 && IsDistinctVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? distinctVariant1 = null,
            global::System.Func<int?, TResult>? distinctVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDistinctVariant1 && distinctVariant1 != null)
            {
                return distinctVariant1(DistinctVariant1!);
            }
            else if (IsDistinctVariant2 && distinctVariant2 != null)
            {
                return distinctVariant2(DistinctVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<bool?>? distinctVariant1 = null,

            global::System.Action<int?>? distinctVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDistinctVariant1)
            {
                distinctVariant1?.Invoke(DistinctVariant1!);
            }
            else if (IsDistinctVariant2)
            {
                distinctVariant2?.Invoke(DistinctVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<bool?>? distinctVariant1 = null,
            global::System.Action<int?>? distinctVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDistinctVariant1)
            {
                distinctVariant1?.Invoke(DistinctVariant1!);
            }
            else if (IsDistinctVariant2)
            {
                distinctVariant2?.Invoke(DistinctVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DistinctVariant1,
                typeof(bool),
                DistinctVariant2,
                typeof(int),
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
        public bool Equals(Distinct other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(DistinctVariant1, other.DistinctVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(DistinctVariant2, other.DistinctVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Distinct obj1, Distinct obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Distinct>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Distinct obj1, Distinct obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Distinct o && Equals(o);
        }
    }
}
