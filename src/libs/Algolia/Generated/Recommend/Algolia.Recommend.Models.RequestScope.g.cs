#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// Facet that a Trending Items request must target for the rule to apply.<br/>
    /// Only available for the `trending-items` model.<br/>
    /// Rules without `requestScope` apply to all Trending Items requests.
    /// </summary>
    public readonly partial struct RequestScope : global::System.IEquatable<RequestScope>
    {
        /// <summary>
        /// Apply the rule only to Trending Items requests without `facetName` and `facetValue`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.GlobalRequestScope? GlobalRequestScope { get; init; }
#else
        public global::Algolia.Recommend.GlobalRequestScope? GlobalRequestScope { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GlobalRequestScope))]
#endif
        public bool IsGlobalRequestScope => GlobalRequestScope != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGlobalRequestScope(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.GlobalRequestScope? value)
        {
            value = GlobalRequestScope;
            return IsGlobalRequestScope;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Recommend.GlobalRequestScope PickGlobalRequestScope() => GlobalRequestScope is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GlobalRequestScope' but the value was {ToString()}.");

        /// <summary>
        /// Apply the rule only to Trending Items requests with the same `facetName` and `facetValue`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.Recommend.FacetRequestScope? FacetRequestScope { get; init; }
#else
        public global::Algolia.Recommend.FacetRequestScope? FacetRequestScope { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FacetRequestScope))]
#endif
        public bool IsFacetRequestScope => FacetRequestScope != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFacetRequestScope(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.Recommend.FacetRequestScope? value)
        {
            value = FacetRequestScope;
            return IsFacetRequestScope;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Algolia.Recommend.FacetRequestScope PickFacetRequestScope() => FacetRequestScope is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FacetRequestScope' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestScope(global::Algolia.Recommend.GlobalRequestScope value) => new RequestScope((global::Algolia.Recommend.GlobalRequestScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Algolia.Recommend.GlobalRequestScope?(RequestScope @this) => @this.GlobalRequestScope;

        /// <summary>
        ///
        /// </summary>
        public RequestScope(global::Algolia.Recommend.GlobalRequestScope? value)
        {
            GlobalRequestScope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestScope FromGlobalRequestScope(global::Algolia.Recommend.GlobalRequestScope? value) => new RequestScope(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestScope(global::Algolia.Recommend.FacetRequestScope value) => new RequestScope((global::Algolia.Recommend.FacetRequestScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Algolia.Recommend.FacetRequestScope?(RequestScope @this) => @this.FacetRequestScope;

        /// <summary>
        ///
        /// </summary>
        public RequestScope(global::Algolia.Recommend.FacetRequestScope? value)
        {
            FacetRequestScope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestScope FromFacetRequestScope(global::Algolia.Recommend.FacetRequestScope? value) => new RequestScope(value);

        /// <summary>
        ///
        /// </summary>
        public RequestScope(
            global::Algolia.Recommend.GlobalRequestScope? globalRequestScope,
            global::Algolia.Recommend.FacetRequestScope? facetRequestScope
            )
        {
            GlobalRequestScope = globalRequestScope;
            FacetRequestScope = facetRequestScope;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FacetRequestScope as object ??
            GlobalRequestScope as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GlobalRequestScope?.ToString() ??
            FacetRequestScope?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGlobalRequestScope && !IsFacetRequestScope || !IsGlobalRequestScope && IsFacetRequestScope;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.Recommend.GlobalRequestScope, TResult>? globalRequestScope = null,
            global::System.Func<global::Algolia.Recommend.FacetRequestScope, TResult>? facetRequestScope = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GlobalRequestScope is { } __value0 && globalRequestScope != null)
            {
                return globalRequestScope(__value0);
            }
            else if (FacetRequestScope is { } __value1 && facetRequestScope != null)
            {
                return facetRequestScope(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.Recommend.GlobalRequestScope>? globalRequestScope = null,

            global::System.Action<global::Algolia.Recommend.FacetRequestScope>? facetRequestScope = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GlobalRequestScope is { } __value0)
            {
                globalRequestScope?.Invoke(__value0);
            }
            else if (FacetRequestScope is { } __value1)
            {
                facetRequestScope?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.Recommend.GlobalRequestScope>? globalRequestScope = null,
            global::System.Action<global::Algolia.Recommend.FacetRequestScope>? facetRequestScope = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GlobalRequestScope is { } __value0)
            {
                globalRequestScope?.Invoke(__value0);
            }
            else if (FacetRequestScope is { } __value1)
            {
                facetRequestScope?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GlobalRequestScope,
                typeof(global::Algolia.Recommend.GlobalRequestScope),
                FacetRequestScope,
                typeof(global::Algolia.Recommend.FacetRequestScope),
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
        public bool Equals(RequestScope other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.GlobalRequestScope?>.Default.Equals(GlobalRequestScope, other.GlobalRequestScope) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.Recommend.FacetRequestScope?>.Default.Equals(FacetRequestScope, other.FacetRequestScope)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RequestScope obj1, RequestScope obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RequestScope>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RequestScope obj1, RequestScope obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestScope o && Equals(o);
        }
    }
}
