#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchQuery : global::System.IEquatable<SearchQuery>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchForHits? ForHits { get; init; }
#else
        public global::Algolia.SearchForHits? ForHits { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ForHits))]
#endif
        public bool IsForHits => ForHits != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickForHits(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchForHits? value)
        {
            value = ForHits;
            return IsForHits;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.SearchForHits PickForHits() => IsForHits
            ? ForHits!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ForHits' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchForFacets? ForFacets { get; init; }
#else
        public global::Algolia.SearchForFacets? ForFacets { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ForFacets))]
#endif
        public bool IsForFacets => ForFacets != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickForFacets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchForFacets? value)
        {
            value = ForFacets;
            return IsForFacets;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Algolia.SearchForFacets PickForFacets() => IsForFacets
            ? ForFacets!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ForFacets' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchQuery(global::Algolia.SearchForHits value) => new SearchQuery((global::Algolia.SearchForHits?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchForHits?(SearchQuery @this) => @this.ForHits;

        /// <summary>
        /// 
        /// </summary>
        public SearchQuery(global::Algolia.SearchForHits? value)
        {
            ForHits = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchQuery FromForHits(global::Algolia.SearchForHits? value) => new SearchQuery(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchQuery(global::Algolia.SearchForFacets value) => new SearchQuery((global::Algolia.SearchForFacets?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchForFacets?(SearchQuery @this) => @this.ForFacets;

        /// <summary>
        /// 
        /// </summary>
        public SearchQuery(global::Algolia.SearchForFacets? value)
        {
            ForFacets = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchQuery FromForFacets(global::Algolia.SearchForFacets? value) => new SearchQuery(value);

        /// <summary>
        /// 
        /// </summary>
        public SearchQuery(
            global::Algolia.SearchForHits? forHits,
            global::Algolia.SearchForFacets? forFacets
            )
        {
            ForHits = forHits;
            ForFacets = forFacets;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ForFacets as object ??
            ForHits as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ForHits?.ToString() ??
            ForFacets?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsForHits && !IsForFacets || !IsForHits && IsForFacets;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.SearchForHits?, TResult>? forHits = null,
            global::System.Func<global::Algolia.SearchForFacets?, TResult>? forFacets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsForHits && forHits != null)
            {
                return forHits(ForHits!);
            }
            else if (IsForFacets && forFacets != null)
            {
                return forFacets(ForFacets!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.SearchForHits?>? forHits = null,

            global::System.Action<global::Algolia.SearchForFacets?>? forFacets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsForHits)
            {
                forHits?.Invoke(ForHits!);
            }
            else if (IsForFacets)
            {
                forFacets?.Invoke(ForFacets!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.SearchForHits?>? forHits = null,
            global::System.Action<global::Algolia.SearchForFacets?>? forFacets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsForHits)
            {
                forHits?.Invoke(ForHits!);
            }
            else if (IsForFacets)
            {
                forFacets?.Invoke(ForFacets!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ForHits,
                typeof(global::Algolia.SearchForHits),
                ForFacets,
                typeof(global::Algolia.SearchForFacets),
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
        public bool Equals(SearchQuery other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchForHits?>.Default.Equals(ForHits, other.ForHits) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchForFacets?>.Default.Equals(ForFacets, other.ForFacets) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchQuery obj1, SearchQuery obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchQuery>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchQuery obj1, SearchQuery obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchQuery o && Equals(o);
        }
    }
}
