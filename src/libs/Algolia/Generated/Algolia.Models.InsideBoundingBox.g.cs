#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
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
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
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
        public object? Value2 { get; init; }
#else
        public object? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// Coordinates for a rectangular area in which to search.<br/>
        /// Each bounding box is defined by the two opposite points of its diagonal, and expressed as latitude and longitude pair:<br/>
        /// `[p1 lat, p1 long, p2 lat, p2 long]`.<br/>
        /// Provide multiple bounding boxes as nested arrays.<br/>
        /// For more information, see [rectangular area](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas).<br/>
        /// Example: [[47.3165, 4.9665, 47.3424, 5.0201], [40.9234, 2.1185, 38.643, 1.9916]]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Value3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsideBoundingBox(string value) => new InsideBoundingBox((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(InsideBoundingBox @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public InsideBoundingBox(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InsideBoundingBox(
            string? value1,
            object? value2,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 || !IsValue1 && IsValue2 && !IsValue3 || !IsValue1 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<object?, TResult>? value2 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?, TResult>? value3 = null,
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
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<object?>? value2 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?>? value3 = null,
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
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
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
                typeof(string),
                Value2,
                typeof(object),
                Value3,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?>.Default.Equals(Value3, other.Value3) 
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
