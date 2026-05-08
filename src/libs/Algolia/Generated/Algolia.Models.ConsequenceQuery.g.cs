#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Replace or edit the search query.<br/>
    /// If `consequenceQuery` is a string, the entire search query is replaced with that string.<br/>
    /// If `consequenceQuery` is an object, it describes incremental edits made to the query.
    /// </summary>
    public readonly partial struct ConsequenceQuery : global::System.IEquatable<ConsequenceQuery>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.ConsequenceQueryObject? ObjectValue { get; init; }
#else
        public global::Algolia.ConsequenceQueryObject? ObjectValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectValue))]
#endif
        public bool IsObjectValue => ObjectValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickObjectValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.ConsequenceQueryObject? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ConsequenceQueryVariant2 { get; init; }
#else
        public string? ConsequenceQueryVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConsequenceQueryVariant2))]
#endif
        public bool IsConsequenceQueryVariant2 => ConsequenceQueryVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConsequenceQueryVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ConsequenceQueryVariant2;
            return IsConsequenceQueryVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConsequenceQuery(global::Algolia.ConsequenceQueryObject value) => new ConsequenceQuery((global::Algolia.ConsequenceQueryObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.ConsequenceQueryObject?(ConsequenceQuery @this) => @this.ObjectValue;

        /// <summary>
        /// 
        /// </summary>
        public ConsequenceQuery(global::Algolia.ConsequenceQueryObject? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConsequenceQuery(string value) => new ConsequenceQuery((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ConsequenceQuery @this) => @this.ConsequenceQueryVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ConsequenceQuery(string? value)
        {
            ConsequenceQueryVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConsequenceQuery(
            global::Algolia.ConsequenceQueryObject? objectValue,
            string? consequenceQueryVariant2
            )
        {
            ObjectValue = objectValue;
            ConsequenceQueryVariant2 = consequenceQueryVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConsequenceQueryVariant2 as object ??
            ObjectValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ObjectValue?.ToString() ??
            ConsequenceQueryVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsObjectValue && !IsConsequenceQueryVariant2 || !IsObjectValue && IsConsequenceQueryVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.ConsequenceQueryObject, TResult>? objectValue = null,
            global::System.Func<string, TResult>? consequenceQueryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue && objectValue != null)
            {
                return objectValue(ObjectValue!);
            }
            else if (IsConsequenceQueryVariant2 && consequenceQueryVariant2 != null)
            {
                return consequenceQueryVariant2(ConsequenceQueryVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.ConsequenceQueryObject>? objectValue = null,

            global::System.Action<string>? consequenceQueryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsConsequenceQueryVariant2)
            {
                consequenceQueryVariant2?.Invoke(ConsequenceQueryVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.ConsequenceQueryObject>? objectValue = null,
            global::System.Action<string>? consequenceQueryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsConsequenceQueryVariant2)
            {
                consequenceQueryVariant2?.Invoke(ConsequenceQueryVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ObjectValue,
                typeof(global::Algolia.ConsequenceQueryObject),
                ConsequenceQueryVariant2,
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
        public bool Equals(ConsequenceQuery other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.ConsequenceQueryObject?>.Default.Equals(ObjectValue, other.ObjectValue) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ConsequenceQueryVariant2, other.ConsequenceQueryVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConsequenceQuery obj1, ConsequenceQuery obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConsequenceQuery>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConsequenceQuery obj1, ConsequenceQuery obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConsequenceQuery o && Equals(o);
        }
    }
}
