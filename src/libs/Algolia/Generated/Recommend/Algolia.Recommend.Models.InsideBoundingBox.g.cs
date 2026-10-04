#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InsideBoundingBox : global::System.IEquatable<InsideBoundingBox>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? InsideBoundingBoxVariant1 { get; init; }
#else
        public string? InsideBoundingBoxVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InsideBoundingBoxVariant1))]
#endif
        public bool IsInsideBoundingBoxVariant1 => InsideBoundingBoxVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInsideBoundingBoxVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = InsideBoundingBoxVariant1;
            return IsInsideBoundingBoxVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickInsideBoundingBoxVariant1() => InsideBoundingBoxVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InsideBoundingBoxVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Coordinates for a rectangular area in which to search.<br/>
        /// Each bounding box is defined by the two opposite points of its diagonal, and expressed as latitude and longitude pair:<br/>
        /// `[p1 lat, p1 long, p2 lat, p2 long]`.<br/>
        /// Provide multiple bounding boxes as nested arrays.<br/>
        /// For more information, see [rectangular area](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas).<br/>
        /// Example: [[47.3165, 4.9665, 47.3424, 5.0201], [40.9234, 2.1185, 38.643, 1.9916]]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Array { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Array { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Array))]
#endif
        public bool IsArray => Array != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArray(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> PickArray() => Array is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Array' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InsideBoundingBox(string value) => new InsideBoundingBox((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(InsideBoundingBox @this) => @this.InsideBoundingBoxVariant1;

        /// <summary>
        ///
        /// </summary>
        public InsideBoundingBox(string? value)
        {
            InsideBoundingBoxVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InsideBoundingBox FromInsideBoundingBoxVariant1(string? value) => new InsideBoundingBox(value);

        /// <summary>
        ///
        /// </summary>
        public InsideBoundingBox(
            string? insideBoundingBoxVariant1,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? array
            )
        {
            InsideBoundingBoxVariant1 = insideBoundingBoxVariant1;
            Array = array;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Array as object ??
            InsideBoundingBoxVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InsideBoundingBoxVariant1?.ToString() ??
            Array?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInsideBoundingBoxVariant1 && !IsArray || !IsInsideBoundingBoxVariant1 && IsArray;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? insideBoundingBoxVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, TResult>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InsideBoundingBoxVariant1 is { } __value0 && insideBoundingBoxVariant1 != null)
            {
                return insideBoundingBoxVariant1(__value0);
            }
            else if (Array is { } __value1 && array != null)
            {
                return array(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? insideBoundingBoxVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InsideBoundingBoxVariant1 is { } __value0)
            {
                insideBoundingBoxVariant1?.Invoke(__value0);
            }
            else if (Array is { } __value1)
            {
                array?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? insideBoundingBoxVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InsideBoundingBoxVariant1 is { } __value0)
            {
                insideBoundingBoxVariant1?.Invoke(__value0);
            }
            else if (Array is { } __value1)
            {
                array?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InsideBoundingBoxVariant1,
                typeof(string),
                Array,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>),
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
        public bool Equals(InsideBoundingBox other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(InsideBoundingBoxVariant1, other.InsideBoundingBoxVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?>.Default.Equals(Array, other.Array)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InsideBoundingBox obj1, InsideBoundingBox obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InsideBoundingBox>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InsideBoundingBox obj1, InsideBoundingBox obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InsideBoundingBox o && Equals(o);
        }
    }
}
