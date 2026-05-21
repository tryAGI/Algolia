#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// Each parameter value, including the `query` must not be larger than 512 bytes.
    /// </summary>
    public readonly partial struct SearchParamsObject : global::System.IEquatable<SearchParamsObject>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.BaseSearchParams? Base { get; init; }
#else
        public global::Algolia.BaseSearchParams? Base { get; }
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
            out global::Algolia.BaseSearchParams? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.BaseSearchParams PickBase() => IsBase
            ? Base!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.IndexSettingsAsSearchParams? IndexSettingsAs { get; init; }
#else
        public global::Algolia.IndexSettingsAsSearchParams? IndexSettingsAs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexSettingsAs))]
#endif
        public bool IsIndexSettingsAs => IndexSettingsAs != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIndexSettingsAs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.IndexSettingsAsSearchParams? value)
        {
            value = IndexSettingsAs;
            return IsIndexSettingsAs;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.IndexSettingsAsSearchParams PickIndexSettingsAs() => IsIndexSettingsAs
            ? IndexSettingsAs!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IndexSettingsAs' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchParamsObject(global::Algolia.BaseSearchParams value) => new SearchParamsObject((global::Algolia.BaseSearchParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.BaseSearchParams?(SearchParamsObject @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SearchParamsObject(global::Algolia.BaseSearchParams? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchParamsObject FromBase(global::Algolia.BaseSearchParams? value) => new SearchParamsObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchParamsObject(global::Algolia.IndexSettingsAsSearchParams value) => new SearchParamsObject((global::Algolia.IndexSettingsAsSearchParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.IndexSettingsAsSearchParams?(SearchParamsObject @this) => @this.IndexSettingsAs;

        /// <summary>
        /// 
        /// </summary>
        public SearchParamsObject(global::Algolia.IndexSettingsAsSearchParams? value)
        {
            IndexSettingsAs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchParamsObject FromIndexSettingsAs(global::Algolia.IndexSettingsAsSearchParams? value) => new SearchParamsObject(value);

        /// <summary>
        /// 
        /// </summary>
        public SearchParamsObject(
            global::Algolia.BaseSearchParams? @base,
            global::Algolia.IndexSettingsAsSearchParams? indexSettingsAs
            )
        {
            Base = @base;
            IndexSettingsAs = indexSettingsAs;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IndexSettingsAs as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            IndexSettingsAs?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsIndexSettingsAs;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.BaseSearchParams?, TResult>? @base = null,
            global::System.Func<global::Algolia.IndexSettingsAsSearchParams, TResult>? indexSettingsAs = null,
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
            else if (IsIndexSettingsAs && indexSettingsAs != null)
            {
                return indexSettingsAs(IndexSettingsAs!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.BaseSearchParams?>? @base = null,

            global::System.Action<global::Algolia.IndexSettingsAsSearchParams>? indexSettingsAs = null,
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
            else if (IsIndexSettingsAs)
            {
                indexSettingsAs?.Invoke(IndexSettingsAs!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.BaseSearchParams?>? @base = null,
            global::System.Action<global::Algolia.IndexSettingsAsSearchParams>? indexSettingsAs = null,
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
            else if (IsIndexSettingsAs)
            {
                indexSettingsAs?.Invoke(IndexSettingsAs!);
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
                typeof(global::Algolia.BaseSearchParams),
                IndexSettingsAs,
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
        public bool Equals(SearchParamsObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.BaseSearchParams?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.IndexSettingsAsSearchParams?>.Default.Equals(IndexSettingsAs, other.IndexSettingsAs) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchParamsObject obj1, SearchParamsObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchParamsObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchParamsObject obj1, SearchParamsObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchParamsObject o && Equals(o);
        }
    }
}
