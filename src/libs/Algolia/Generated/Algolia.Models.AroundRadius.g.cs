#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Maximum radius for a search around a central location.<br/>
    /// This parameter works in combination with the `aroundLatLng` and `aroundLatLngViaIP` parameters.<br/>
    /// By default, the search radius is determined automatically from the density of hits around the central location.<br/>
    /// The search radius is small if there are many hits close to the central coordinates.
    /// </summary>
    public readonly partial struct AroundRadius : global::System.IEquatable<AroundRadius>
    {
        /// <summary>
        /// Maximum search radius around a central location in meters.
        /// </summary>
#if NET6_0_OR_GREATER
        public int? AroundRadiusVariant1 { get; init; }
#else
        public int? AroundRadiusVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AroundRadiusVariant1))]
#endif
        public bool IsAroundRadiusVariant1 => AroundRadiusVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAroundRadiusVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = AroundRadiusVariant1;
            return IsAroundRadiusVariant1;
        }

        /// <summary>
        /// Return all records with a valid `_geoloc` attribute. Don't filter by distance.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.AroundRadiusAll? All { get; init; }
#else
        public global::Algolia.AroundRadiusAll? All { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(All))]
#endif
        public bool IsAll => All != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAll(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.AroundRadiusAll? value)
        {
            value = All;
            return IsAll;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AroundRadius(int value) => new AroundRadius((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(AroundRadius @this) => @this.AroundRadiusVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AroundRadius(int? value)
        {
            AroundRadiusVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AroundRadius FromAroundRadiusVariant1(int? value) => new AroundRadius(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AroundRadius(global::Algolia.AroundRadiusAll value) => new AroundRadius((global::Algolia.AroundRadiusAll?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.AroundRadiusAll?(AroundRadius @this) => @this.All;

        /// <summary>
        /// 
        /// </summary>
        public AroundRadius(global::Algolia.AroundRadiusAll? value)
        {
            All = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AroundRadius FromAll(global::Algolia.AroundRadiusAll? value) => new AroundRadius(value);

        /// <summary>
        /// 
        /// </summary>
        public AroundRadius(
            int? aroundRadiusVariant1,
            global::Algolia.AroundRadiusAll? all
            )
        {
            AroundRadiusVariant1 = aroundRadiusVariant1;
            All = all;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            All as object ??
            AroundRadiusVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AroundRadiusVariant1?.ToString() ??
            All?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAroundRadiusVariant1 && !IsAll || !IsAroundRadiusVariant1 && IsAll;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<int?, TResult>? aroundRadiusVariant1 = null,
            global::System.Func<global::Algolia.AroundRadiusAll?, TResult>? all = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAroundRadiusVariant1 && aroundRadiusVariant1 != null)
            {
                return aroundRadiusVariant1(AroundRadiusVariant1!);
            }
            else if (IsAll && all != null)
            {
                return all(All!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<int?>? aroundRadiusVariant1 = null,

            global::System.Action<global::Algolia.AroundRadiusAll?>? all = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAroundRadiusVariant1)
            {
                aroundRadiusVariant1?.Invoke(AroundRadiusVariant1!);
            }
            else if (IsAll)
            {
                all?.Invoke(All!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<int?>? aroundRadiusVariant1 = null,
            global::System.Action<global::Algolia.AroundRadiusAll?>? all = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAroundRadiusVariant1)
            {
                aroundRadiusVariant1?.Invoke(AroundRadiusVariant1!);
            }
            else if (IsAll)
            {
                all?.Invoke(All!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AroundRadiusVariant1,
                typeof(int),
                All,
                typeof(global::Algolia.AroundRadiusAll),
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
        public bool Equals(AroundRadius other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(AroundRadiusVariant1, other.AroundRadiusVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.AroundRadiusAll?>.Default.Equals(All, other.All) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AroundRadius obj1, AroundRadius obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AroundRadius>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AroundRadius obj1, AroundRadius obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AroundRadius o && Equals(o);
        }
    }
}
