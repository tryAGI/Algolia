#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Promote : global::System.IEquatable<Promote>
    {
        /// <summary>
        /// Records to promote.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.PromoteObjectIDs? ObjectIDs { get; init; }
#else
        public global::Algolia.PromoteObjectIDs? ObjectIDs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectIDs))]
#endif
        public bool IsObjectIDs => ObjectIDs != null;

        /// <summary>
        /// Record to promote.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.PromoteObjectID? ObjectID { get; init; }
#else
        public global::Algolia.PromoteObjectID? ObjectID { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectID))]
#endif
        public bool IsObjectID => ObjectID != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Promote(global::Algolia.PromoteObjectIDs value) => new Promote((global::Algolia.PromoteObjectIDs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.PromoteObjectIDs?(Promote @this) => @this.ObjectIDs;

        /// <summary>
        /// 
        /// </summary>
        public Promote(global::Algolia.PromoteObjectIDs? value)
        {
            ObjectIDs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Promote(global::Algolia.PromoteObjectID value) => new Promote((global::Algolia.PromoteObjectID?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.PromoteObjectID?(Promote @this) => @this.ObjectID;

        /// <summary>
        /// 
        /// </summary>
        public Promote(global::Algolia.PromoteObjectID? value)
        {
            ObjectID = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Promote(
            global::Algolia.PromoteObjectIDs? objectIDs,
            global::Algolia.PromoteObjectID? objectID
            )
        {
            ObjectIDs = objectIDs;
            ObjectID = objectID;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ObjectID as object ??
            ObjectIDs as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ObjectIDs?.ToString() ??
            ObjectID?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsObjectIDs && !IsObjectID || !IsObjectIDs && IsObjectID;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.PromoteObjectIDs?, TResult>? objectIDs = null,
            global::System.Func<global::Algolia.PromoteObjectID?, TResult>? objectID = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectIDs && objectIDs != null)
            {
                return objectIDs(ObjectIDs!);
            }
            else if (IsObjectID && objectID != null)
            {
                return objectID(ObjectID!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.PromoteObjectIDs?>? objectIDs = null,
            global::System.Action<global::Algolia.PromoteObjectID?>? objectID = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectIDs)
            {
                objectIDs?.Invoke(ObjectIDs!);
            }
            else if (IsObjectID)
            {
                objectID?.Invoke(ObjectID!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ObjectIDs,
                typeof(global::Algolia.PromoteObjectIDs),
                ObjectID,
                typeof(global::Algolia.PromoteObjectID),
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
        public bool Equals(Promote other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.PromoteObjectIDs?>.Default.Equals(ObjectIDs, other.ObjectIDs) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.PromoteObjectID?>.Default.Equals(ObjectID, other.ObjectID) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Promote obj1, Promote obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Promote>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Promote obj1, Promote obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Promote o && Equals(o);
        }
    }
}
