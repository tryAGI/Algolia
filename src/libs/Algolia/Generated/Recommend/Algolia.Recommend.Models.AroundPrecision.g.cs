#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Precision of a coordinate-based search in meters to group results with similar distances.<br/>
    /// The Geo ranking criterion considers all matches within the same range of distances to be equal.
    /// </summary>
    public readonly partial struct AroundPrecision : global::System.IEquatable<AroundPrecision>
    {
        /// <summary>
        /// Distance in meters to group results by similar distances.<br/>
        /// For example, if you set `aroundPrecision` to 100, records wihin 100 meters to the central coordinate are considered to have the same distance,<br/>
        /// as are records between 100 and 199 meters.<br/>
        /// Default Value: 10
        /// </summary>
#if NET6_0_OR_GREATER
        public int? AroundPrecisionVariant1 { get; init; }
#else
        public int? AroundPrecisionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AroundPrecisionVariant1))]
#endif
        public bool IsAroundPrecisionVariant1 => AroundPrecisionVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.AroundPrecisionFromValueItem>? RangeObjects { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.AroundPrecisionFromValueItem>? RangeObjects { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RangeObjects))]
#endif
        public bool IsRangeObjects => RangeObjects != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AroundPrecision(int value) => new AroundPrecision((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(AroundPrecision @this) => @this.AroundPrecisionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AroundPrecision(int? value)
        {
            AroundPrecisionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AroundPrecision(
            int? aroundPrecisionVariant1,
            global::System.Collections.Generic.IList<global::Algolia.Recommend.AroundPrecisionFromValueItem>? rangeObjects
            )
        {
            AroundPrecisionVariant1 = aroundPrecisionVariant1;
            RangeObjects = rangeObjects;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RangeObjects as object ??
            AroundPrecisionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AroundPrecisionVariant1?.ToString() ??
            RangeObjects?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAroundPrecisionVariant1 && !IsRangeObjects || !IsAroundPrecisionVariant1 && IsRangeObjects;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<int?, TResult>? aroundPrecisionVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Algolia.Recommend.AroundPrecisionFromValueItem>?, TResult>? rangeObjects = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAroundPrecisionVariant1 && aroundPrecisionVariant1 != null)
            {
                return aroundPrecisionVariant1(AroundPrecisionVariant1!);
            }
            else if (IsRangeObjects && rangeObjects != null)
            {
                return rangeObjects(RangeObjects!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<int?>? aroundPrecisionVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Algolia.Recommend.AroundPrecisionFromValueItem>?>? rangeObjects = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAroundPrecisionVariant1)
            {
                aroundPrecisionVariant1?.Invoke(AroundPrecisionVariant1!);
            }
            else if (IsRangeObjects)
            {
                rangeObjects?.Invoke(RangeObjects!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AroundPrecisionVariant1,
                typeof(int),
                RangeObjects,
                typeof(global::System.Collections.Generic.IList<global::Algolia.Recommend.AroundPrecisionFromValueItem>),
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
        public bool Equals(AroundPrecision other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(AroundPrecisionVariant1, other.AroundPrecisionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Algolia.Recommend.AroundPrecisionFromValueItem>?>.Default.Equals(RangeObjects, other.RangeObjects) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AroundPrecision obj1, AroundPrecision obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AroundPrecision>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AroundPrecision obj1, AroundPrecision obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AroundPrecision o && Equals(o);
        }
    }
}
