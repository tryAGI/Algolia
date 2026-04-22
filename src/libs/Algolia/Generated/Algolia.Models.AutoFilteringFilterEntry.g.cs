#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AutoFilteringFilterEntry : global::System.IEquatable<AutoFilteringFilterEntry>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AutoFilteringFilterEntryVariant1 { get; init; }
#else
        public string? AutoFilteringFilterEntryVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoFilteringFilterEntryVariant1))]
#endif
        public bool IsAutoFilteringFilterEntryVariant1 => AutoFilteringFilterEntryVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? AutoFilteringFilterEntryVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? AutoFilteringFilterEntryVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoFilteringFilterEntryVariant2))]
#endif
        public bool IsAutoFilteringFilterEntryVariant2 => AutoFilteringFilterEntryVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AutoFilteringFilterEntry(string value) => new AutoFilteringFilterEntry((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AutoFilteringFilterEntry @this) => @this.AutoFilteringFilterEntryVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AutoFilteringFilterEntry(string? value)
        {
            AutoFilteringFilterEntryVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AutoFilteringFilterEntry(
            string? autoFilteringFilterEntryVariant1,
            global::System.Collections.Generic.IList<string>? autoFilteringFilterEntryVariant2
            )
        {
            AutoFilteringFilterEntryVariant1 = autoFilteringFilterEntryVariant1;
            AutoFilteringFilterEntryVariant2 = autoFilteringFilterEntryVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AutoFilteringFilterEntryVariant2 as object ??
            AutoFilteringFilterEntryVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AutoFilteringFilterEntryVariant1?.ToString() ??
            AutoFilteringFilterEntryVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAutoFilteringFilterEntryVariant1 && !IsAutoFilteringFilterEntryVariant2 || !IsAutoFilteringFilterEntryVariant1 && IsAutoFilteringFilterEntryVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? autoFilteringFilterEntryVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? autoFilteringFilterEntryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoFilteringFilterEntryVariant1 && autoFilteringFilterEntryVariant1 != null)
            {
                return autoFilteringFilterEntryVariant1(AutoFilteringFilterEntryVariant1!);
            }
            else if (IsAutoFilteringFilterEntryVariant2 && autoFilteringFilterEntryVariant2 != null)
            {
                return autoFilteringFilterEntryVariant2(AutoFilteringFilterEntryVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? autoFilteringFilterEntryVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? autoFilteringFilterEntryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoFilteringFilterEntryVariant1)
            {
                autoFilteringFilterEntryVariant1?.Invoke(AutoFilteringFilterEntryVariant1!);
            }
            else if (IsAutoFilteringFilterEntryVariant2)
            {
                autoFilteringFilterEntryVariant2?.Invoke(AutoFilteringFilterEntryVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoFilteringFilterEntryVariant1,
                typeof(string),
                AutoFilteringFilterEntryVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(AutoFilteringFilterEntry other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AutoFilteringFilterEntryVariant1, other.AutoFilteringFilterEntryVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(AutoFilteringFilterEntryVariant2, other.AutoFilteringFilterEntryVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AutoFilteringFilterEntry obj1, AutoFilteringFilterEntry obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoFilteringFilterEntry>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AutoFilteringFilterEntry obj1, AutoFilteringFilterEntry obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoFilteringFilterEntry o && Equals(o);
        }
    }
}
