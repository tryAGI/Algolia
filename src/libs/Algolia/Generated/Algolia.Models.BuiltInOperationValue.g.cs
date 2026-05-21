#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BuiltInOperationValue : global::System.IEquatable<BuiltInOperationValue>
    {
        /// <summary>
        /// A string to append or remove for the `Add`, `Remove`, and `AddUnique` operations.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BuiltInOperationValueVariant1 { get; init; }
#else
        public string? BuiltInOperationValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuiltInOperationValueVariant1))]
#endif
        public bool IsBuiltInOperationValueVariant1 => BuiltInOperationValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBuiltInOperationValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BuiltInOperationValueVariant1;
            return IsBuiltInOperationValueVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickBuiltInOperationValueVariant1() => IsBuiltInOperationValueVariant1
            ? BuiltInOperationValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuiltInOperationValueVariant1' but the value was {ToString()}.");

        /// <summary>
        /// A number to add, remove, or append, depending on the operation.
        /// </summary>
#if NET6_0_OR_GREATER
        public int? BuiltInOperationValueVariant2 { get; init; }
#else
        public int? BuiltInOperationValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuiltInOperationValueVariant2))]
#endif
        public bool IsBuiltInOperationValueVariant2 => BuiltInOperationValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBuiltInOperationValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = BuiltInOperationValueVariant2;
            return IsBuiltInOperationValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public int PickBuiltInOperationValueVariant2() => IsBuiltInOperationValueVariant2
            ? BuiltInOperationValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuiltInOperationValueVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BuiltInOperationValue(string value) => new BuiltInOperationValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(BuiltInOperationValue @this) => @this.BuiltInOperationValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public BuiltInOperationValue(string? value)
        {
            BuiltInOperationValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BuiltInOperationValue FromBuiltInOperationValueVariant1(string? value) => new BuiltInOperationValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BuiltInOperationValue(int value) => new BuiltInOperationValue((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(BuiltInOperationValue @this) => @this.BuiltInOperationValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BuiltInOperationValue(int? value)
        {
            BuiltInOperationValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BuiltInOperationValue FromBuiltInOperationValueVariant2(int? value) => new BuiltInOperationValue(value);

        /// <summary>
        /// 
        /// </summary>
        public BuiltInOperationValue(
            string? builtInOperationValueVariant1,
            int? builtInOperationValueVariant2
            )
        {
            BuiltInOperationValueVariant1 = builtInOperationValueVariant1;
            BuiltInOperationValueVariant2 = builtInOperationValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BuiltInOperationValueVariant2 as object ??
            BuiltInOperationValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BuiltInOperationValueVariant1?.ToString() ??
            BuiltInOperationValueVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBuiltInOperationValueVariant1 && !IsBuiltInOperationValueVariant2 || !IsBuiltInOperationValueVariant1 && IsBuiltInOperationValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? builtInOperationValueVariant1 = null,
            global::System.Func<int?, TResult>? builtInOperationValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuiltInOperationValueVariant1 && builtInOperationValueVariant1 != null)
            {
                return builtInOperationValueVariant1(BuiltInOperationValueVariant1!);
            }
            else if (IsBuiltInOperationValueVariant2 && builtInOperationValueVariant2 != null)
            {
                return builtInOperationValueVariant2(BuiltInOperationValueVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? builtInOperationValueVariant1 = null,

            global::System.Action<int?>? builtInOperationValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuiltInOperationValueVariant1)
            {
                builtInOperationValueVariant1?.Invoke(BuiltInOperationValueVariant1!);
            }
            else if (IsBuiltInOperationValueVariant2)
            {
                builtInOperationValueVariant2?.Invoke(BuiltInOperationValueVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? builtInOperationValueVariant1 = null,
            global::System.Action<int?>? builtInOperationValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuiltInOperationValueVariant1)
            {
                builtInOperationValueVariant1?.Invoke(BuiltInOperationValueVariant1!);
            }
            else if (IsBuiltInOperationValueVariant2)
            {
                builtInOperationValueVariant2?.Invoke(BuiltInOperationValueVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BuiltInOperationValueVariant1,
                typeof(string),
                BuiltInOperationValueVariant2,
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
        public bool Equals(BuiltInOperationValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BuiltInOperationValueVariant1, other.BuiltInOperationValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(BuiltInOperationValueVariant2, other.BuiltInOperationValueVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BuiltInOperationValue obj1, BuiltInOperationValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BuiltInOperationValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BuiltInOperationValue obj1, BuiltInOperationValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BuiltInOperationValue o && Equals(o);
        }
    }
}
