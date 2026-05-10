#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Index settings.
    /// </summary>
    public readonly partial struct IndexSettings : global::System.IEquatable<IndexSettings>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BaseIndexSettings? Base { get; init; }
#else
        public global::Algolia.BaseIndexSettings? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.BaseIndexSettings? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.IndexSettingsAsSearchParams? AsSearchParams { get; init; }
#else
        public global::Algolia.IndexSettingsAsSearchParams? AsSearchParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsSearchParams))]
#endif
        public bool IsAsSearchParams => AsSearchParams != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAsSearchParams(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.IndexSettingsAsSearchParams? value)
        {
            value = AsSearchParams;
            return IsAsSearchParams;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexSettings(global::Algolia.BaseIndexSettings value) => new IndexSettings((global::Algolia.BaseIndexSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BaseIndexSettings?(IndexSettings @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public IndexSettings(global::Algolia.BaseIndexSettings? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexSettings FromBase(global::Algolia.BaseIndexSettings? value) => new IndexSettings(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexSettings(global::Algolia.IndexSettingsAsSearchParams value) => new IndexSettings((global::Algolia.IndexSettingsAsSearchParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.IndexSettingsAsSearchParams?(IndexSettings @this) => @this.AsSearchParams;

        /// <summary>
        /// 
        /// </summary>
        public IndexSettings(global::Algolia.IndexSettingsAsSearchParams? value)
        {
            AsSearchParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexSettings FromAsSearchParams(global::Algolia.IndexSettingsAsSearchParams? value) => new IndexSettings(value);

        /// <summary>
        /// 
        /// </summary>
        public IndexSettings(
            global::Algolia.BaseIndexSettings? @base,
            global::Algolia.IndexSettingsAsSearchParams? asSearchParams
            )
        {
            Base = @base;
            AsSearchParams = asSearchParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AsSearchParams as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AsSearchParams?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAsSearchParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.BaseIndexSettings, TResult>? @base = null,
            global::System.Func<global::Algolia.IndexSettingsAsSearchParams, TResult>? asSearchParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsAsSearchParams && asSearchParams != null)
            {
                return asSearchParams(AsSearchParams!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.BaseIndexSettings>? @base = null,

            global::System.Action<global::Algolia.IndexSettingsAsSearchParams>? asSearchParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsAsSearchParams)
            {
                asSearchParams?.Invoke(AsSearchParams!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.BaseIndexSettings>? @base = null,
            global::System.Action<global::Algolia.IndexSettingsAsSearchParams>? asSearchParams = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsAsSearchParams)
            {
                asSearchParams?.Invoke(AsSearchParams!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Algolia.BaseIndexSettings),
                AsSearchParams,
                typeof(global::Algolia.IndexSettingsAsSearchParams),
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
        public bool Equals(IndexSettings other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BaseIndexSettings?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.IndexSettingsAsSearchParams?>.Default.Equals(AsSearchParams, other.AsSearchParams) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IndexSettings obj1, IndexSettings obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IndexSettings>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IndexSettings obj1, IndexSettings obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IndexSettings o && Equals(o);
        }
    }
}
