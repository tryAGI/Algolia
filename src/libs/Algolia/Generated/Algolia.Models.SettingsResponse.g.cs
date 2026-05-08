#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SettingsResponse : global::System.IEquatable<SettingsResponse>
    {
        /// <summary>
        /// Index settings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.IndexSettings? Index { get; init; }
#else
        public global::Algolia.IndexSettings? Index { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Index))]
#endif
        public bool IsIndex => Index != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIndex(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.IndexSettings? value)
        {
            value = Index;
            return IsIndex;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.WithPrimary? WithPrimary { get; init; }
#else
        public global::Algolia.WithPrimary? WithPrimary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WithPrimary))]
#endif
        public bool IsWithPrimary => WithPrimary != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWithPrimary(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.WithPrimary? value)
        {
            value = WithPrimary;
            return IsWithPrimary;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SettingsResponse(global::Algolia.IndexSettings value) => new SettingsResponse((global::Algolia.IndexSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.IndexSettings?(SettingsResponse @this) => @this.Index;

        /// <summary>
        /// 
        /// </summary>
        public SettingsResponse(global::Algolia.IndexSettings? value)
        {
            Index = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SettingsResponse(global::Algolia.WithPrimary value) => new SettingsResponse((global::Algolia.WithPrimary?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.WithPrimary?(SettingsResponse @this) => @this.WithPrimary;

        /// <summary>
        /// 
        /// </summary>
        public SettingsResponse(global::Algolia.WithPrimary? value)
        {
            WithPrimary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SettingsResponse(
            global::Algolia.IndexSettings? index,
            global::Algolia.WithPrimary? withPrimary
            )
        {
            Index = index;
            WithPrimary = withPrimary;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WithPrimary as object ??
            Index as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Index?.ToString() ??
            WithPrimary?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIndex && IsWithPrimary;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.IndexSettings?, TResult>? index = null,
            global::System.Func<global::Algolia.WithPrimary, TResult>? withPrimary = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIndex && index != null)
            {
                return index(Index!);
            }
            else if (IsWithPrimary && withPrimary != null)
            {
                return withPrimary(WithPrimary!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.IndexSettings?>? index = null,

            global::System.Action<global::Algolia.WithPrimary>? withPrimary = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIndex)
            {
                index?.Invoke(Index!);
            }
            else if (IsWithPrimary)
            {
                withPrimary?.Invoke(WithPrimary!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.IndexSettings?>? index = null,
            global::System.Action<global::Algolia.WithPrimary>? withPrimary = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIndex)
            {
                index?.Invoke(Index!);
            }
            else if (IsWithPrimary)
            {
                withPrimary?.Invoke(WithPrimary!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Index,
                typeof(global::Algolia.IndexSettings),
                WithPrimary,
                typeof(global::Algolia.WithPrimary),
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
        public bool Equals(SettingsResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.IndexSettings?>.Default.Equals(Index, other.Index) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.WithPrimary?>.Default.Equals(WithPrimary, other.WithPrimary) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SettingsResponse obj1, SettingsResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SettingsResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SettingsResponse obj1, SettingsResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SettingsResponse o && Equals(o);
        }
    }
}
