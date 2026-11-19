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
        public global::Algolia.BaseSearchParams PickBase() => Base is { } value
            ? value
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
        public global::Algolia.IndexSettingsAsSearchParams PickIndexSettingsAs() => IndexSettingsAs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'IndexSettingsAs' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchParamsAllowReRanking? AllowReRanking { get; init; }
#else
        public global::Algolia.SearchParamsAllowReRanking? AllowReRanking { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AllowReRanking))]
#endif
        public bool IsAllowReRanking => AllowReRanking != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAllowReRanking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchParamsAllowReRanking? value)
        {
            value = AllowReRanking;
            return IsAllowReRanking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Algolia.SearchParamsAllowReRanking PickAllowReRanking() => AllowReRanking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AllowReRanking' but the value was {ToString()}.");
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
        public static implicit operator SearchParamsObject(global::Algolia.SearchParamsAllowReRanking value) => new SearchParamsObject((global::Algolia.SearchParamsAllowReRanking?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Algolia.SearchParamsAllowReRanking?(SearchParamsObject @this) => @this.AllowReRanking;

        /// <summary>
        ///
        /// </summary>
        public SearchParamsObject(global::Algolia.SearchParamsAllowReRanking? value)
        {
            AllowReRanking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchParamsObject FromAllowReRanking(global::Algolia.SearchParamsAllowReRanking? value) => new SearchParamsObject(value);

        /// <summary>
        ///
        /// </summary>
        public SearchParamsObject(
            global::Algolia.BaseSearchParams? @base,
            global::Algolia.IndexSettingsAsSearchParams? indexSettingsAs,
            global::Algolia.SearchParamsAllowReRanking? allowReRanking
            )
        {
            Base = @base;
            IndexSettingsAs = indexSettingsAs;
            AllowReRanking = allowReRanking;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AllowReRanking as object ??
            IndexSettingsAs as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            IndexSettingsAs?.ToString() ??
            AllowReRanking?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsIndexSettingsAs && IsAllowReRanking;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.BaseSearchParams?, TResult>? @base = null,
            global::System.Func<global::Algolia.IndexSettingsAsSearchParams, TResult>? indexSettingsAs = null,
            global::System.Func<global::Algolia.SearchParamsAllowReRanking, TResult>? allowReRanking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (IndexSettingsAs is { } __value1 && indexSettingsAs != null)
            {
                return indexSettingsAs(__value1);
            }
            else if (AllowReRanking is { } __value2 && allowReRanking != null)
            {
                return allowReRanking(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.BaseSearchParams?>? @base = null,

            global::System.Action<global::Algolia.IndexSettingsAsSearchParams>? indexSettingsAs = null,

            global::System.Action<global::Algolia.SearchParamsAllowReRanking>? allowReRanking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (IndexSettingsAs is { } __value1)
            {
                indexSettingsAs?.Invoke(__value1);
            }
            else if (AllowReRanking is { } __value2)
            {
                allowReRanking?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.BaseSearchParams?>? @base = null,
            global::System.Action<global::Algolia.IndexSettingsAsSearchParams>? indexSettingsAs = null,
            global::System.Action<global::Algolia.SearchParamsAllowReRanking>? allowReRanking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (IndexSettingsAs is { } __value1)
            {
                indexSettingsAs?.Invoke(__value1);
            }
            else if (AllowReRanking is { } __value2)
            {
                allowReRanking?.Invoke(__value2);
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
                AllowReRanking,
                typeof(global::Algolia.SearchParamsAllowReRanking),
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
                global::System.Collections.Generic.EqualityComparer<global::Algolia.IndexSettingsAsSearchParams?>.Default.Equals(IndexSettingsAs, other.IndexSettingsAs) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchParamsAllowReRanking?>.Default.Equals(AllowReRanking, other.AllowReRanking)
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
