#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EventStatus : global::System.IEquatable<EventStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.EventStatusEnum? Enum { get; init; }
#else
        public global::Algolia.EventStatusEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.EventStatusEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? EventStatusVariant2 { get; init; }
#else
        public object? EventStatusVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EventStatusVariant2))]
#endif
        public bool IsEventStatusVariant2 => EventStatusVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEventStatusVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = EventStatusVariant2;
            return IsEventStatusVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventStatus(global::Algolia.EventStatusEnum value) => new EventStatus((global::Algolia.EventStatusEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.EventStatusEnum?(EventStatus @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public EventStatus(global::Algolia.EventStatusEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EventStatus(
            global::Algolia.EventStatusEnum? @enum,
            object? eventStatusVariant2
            )
        {
            Enum = @enum;
            EventStatusVariant2 = eventStatusVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EventStatusVariant2 as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            EventStatusVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsEventStatusVariant2 || !IsEnum && IsEventStatusVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.EventStatusEnum?, TResult>? @enum = null,
            global::System.Func<object, TResult>? eventStatusVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsEventStatusVariant2 && eventStatusVariant2 != null)
            {
                return eventStatusVariant2(EventStatusVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.EventStatusEnum?>? @enum = null,

            global::System.Action<object>? eventStatusVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsEventStatusVariant2)
            {
                eventStatusVariant2?.Invoke(EventStatusVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.EventStatusEnum?>? @enum = null,
            global::System.Action<object>? eventStatusVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsEventStatusVariant2)
            {
                eventStatusVariant2?.Invoke(EventStatusVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::Algolia.EventStatusEnum),
                EventStatusVariant2,
                typeof(object),
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
        public bool Equals(EventStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.EventStatusEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(EventStatusVariant2, other.EventStatusVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EventStatus obj1, EventStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EventStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EventStatus obj1, EventStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EventStatus o && Equals(o);
        }
    }
}
