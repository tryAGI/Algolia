#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AttributeToUpdate : global::System.IEquatable<AttributeToUpdate>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AttributeToUpdateVariant1 { get; init; }
#else
        public string? AttributeToUpdateVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AttributeToUpdateVariant1))]
#endif
        public bool IsAttributeToUpdateVariant1 => AttributeToUpdateVariant1 != null;

        /// <summary>
        /// Update to perform on the attribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BuiltInOperation? BuiltInOperation { get; init; }
#else
        public global::Algolia.BuiltInOperation? BuiltInOperation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuiltInOperation))]
#endif
        public bool IsBuiltInOperation => BuiltInOperation != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AttributeToUpdate(string value) => new AttributeToUpdate((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AttributeToUpdate @this) => @this.AttributeToUpdateVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AttributeToUpdate(string? value)
        {
            AttributeToUpdateVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AttributeToUpdate(global::Algolia.BuiltInOperation value) => new AttributeToUpdate((global::Algolia.BuiltInOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BuiltInOperation?(AttributeToUpdate @this) => @this.BuiltInOperation;

        /// <summary>
        /// 
        /// </summary>
        public AttributeToUpdate(global::Algolia.BuiltInOperation? value)
        {
            BuiltInOperation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AttributeToUpdate(
            string? attributeToUpdateVariant1,
            global::Algolia.BuiltInOperation? builtInOperation
            )
        {
            AttributeToUpdateVariant1 = attributeToUpdateVariant1;
            BuiltInOperation = builtInOperation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BuiltInOperation as object ??
            AttributeToUpdateVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AttributeToUpdateVariant1?.ToString() ??
            BuiltInOperation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAttributeToUpdateVariant1 && !IsBuiltInOperation || !IsAttributeToUpdateVariant1 && IsBuiltInOperation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? attributeToUpdateVariant1 = null,
            global::System.Func<global::Algolia.BuiltInOperation?, TResult>? builtInOperation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAttributeToUpdateVariant1 && attributeToUpdateVariant1 != null)
            {
                return attributeToUpdateVariant1(AttributeToUpdateVariant1!);
            }
            else if (IsBuiltInOperation && builtInOperation != null)
            {
                return builtInOperation(BuiltInOperation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? attributeToUpdateVariant1 = null,
            global::System.Action<global::Algolia.BuiltInOperation?>? builtInOperation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAttributeToUpdateVariant1)
            {
                attributeToUpdateVariant1?.Invoke(AttributeToUpdateVariant1!);
            }
            else if (IsBuiltInOperation)
            {
                builtInOperation?.Invoke(BuiltInOperation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AttributeToUpdateVariant1,
                typeof(string),
                BuiltInOperation,
                typeof(global::Algolia.BuiltInOperation),
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
        public bool Equals(AttributeToUpdate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AttributeToUpdateVariant1, other.AttributeToUpdateVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BuiltInOperation?>.Default.Equals(BuiltInOperation, other.BuiltInOperation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AttributeToUpdate obj1, AttributeToUpdate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AttributeToUpdate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AttributeToUpdate obj1, AttributeToUpdate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AttributeToUpdate o && Equals(o);
        }
    }
}
