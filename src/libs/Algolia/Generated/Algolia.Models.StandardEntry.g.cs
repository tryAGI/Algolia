#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StandardEntry : global::System.IEquatable<StandardEntry>
    {
        /// <summary>
        /// Key-value pair of a language ISO code and a boolean value.<br/>
        /// Example: {"fr":false}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, bool>? StandardEntryVariant1 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, bool>? StandardEntryVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StandardEntryVariant1))]
#endif
        public bool IsStandardEntryVariant1 => StandardEntryVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStandardEntryVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, bool>? value)
        {
            value = StandardEntryVariant1;
            return IsStandardEntryVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? StandardEntryVariant2 { get; init; }
#else
        public object? StandardEntryVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StandardEntryVariant2))]
#endif
        public bool IsStandardEntryVariant2 => StandardEntryVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStandardEntryVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = StandardEntryVariant2;
            return IsStandardEntryVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StandardEntry(global::System.Collections.Generic.Dictionary<string, bool> value) => new StandardEntry((global::System.Collections.Generic.Dictionary<string, bool>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, bool>?(StandardEntry @this) => @this.StandardEntryVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StandardEntry(global::System.Collections.Generic.Dictionary<string, bool>? value)
        {
            StandardEntryVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StandardEntry(
            global::System.Collections.Generic.Dictionary<string, bool>? standardEntryVariant1,
            object? standardEntryVariant2
            )
        {
            StandardEntryVariant1 = standardEntryVariant1;
            StandardEntryVariant2 = standardEntryVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StandardEntryVariant2 as object ??
            StandardEntryVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StandardEntryVariant1?.ToString() ??
            StandardEntryVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStandardEntryVariant1 && !IsStandardEntryVariant2 || !IsStandardEntryVariant1 && IsStandardEntryVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.Dictionary<string, bool>, TResult>? standardEntryVariant1 = null,
            global::System.Func<object, TResult>? standardEntryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandardEntryVariant1 && standardEntryVariant1 != null)
            {
                return standardEntryVariant1(StandardEntryVariant1!);
            }
            else if (IsStandardEntryVariant2 && standardEntryVariant2 != null)
            {
                return standardEntryVariant2(StandardEntryVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.Dictionary<string, bool>>? standardEntryVariant1 = null,

            global::System.Action<object>? standardEntryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandardEntryVariant1)
            {
                standardEntryVariant1?.Invoke(StandardEntryVariant1!);
            }
            else if (IsStandardEntryVariant2)
            {
                standardEntryVariant2?.Invoke(StandardEntryVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.Dictionary<string, bool>>? standardEntryVariant1 = null,
            global::System.Action<object>? standardEntryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStandardEntryVariant1)
            {
                standardEntryVariant1?.Invoke(StandardEntryVariant1!);
            }
            else if (IsStandardEntryVariant2)
            {
                standardEntryVariant2?.Invoke(StandardEntryVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StandardEntryVariant1,
                typeof(global::System.Collections.Generic.Dictionary<string, bool>),
                StandardEntryVariant2,
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
        public bool Equals(StandardEntry other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, bool>?>.Default.Equals(StandardEntryVariant1, other.StandardEntryVariant1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(StandardEntryVariant2, other.StandardEntryVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StandardEntry obj1, StandardEntry obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StandardEntry>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StandardEntry obj1, StandardEntry obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StandardEntry o && Equals(o);
        }
    }
}
