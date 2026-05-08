#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchResult : global::System.IEquatable<SearchResult>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchResponse? Response { get; init; }
#else
        public global::Algolia.SearchResponse? Response { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Response))]
#endif
        public bool IsResponse => Response != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchResponse? value)
        {
            value = Response;
            return IsResponse;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Algolia.SearchForFacetValuesResponse? ForFacetValuesResponse { get; init; }
#else
        public global::Algolia.SearchForFacetValuesResponse? ForFacetValuesResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ForFacetValuesResponse))]
#endif
        public bool IsForFacetValuesResponse => ForFacetValuesResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickForFacetValuesResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Algolia.SearchForFacetValuesResponse? value)
        {
            value = ForFacetValuesResponse;
            return IsForFacetValuesResponse;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResult(global::Algolia.SearchResponse value) => new SearchResult((global::Algolia.SearchResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchResponse?(SearchResult @this) => @this.Response;

        /// <summary>
        /// 
        /// </summary>
        public SearchResult(global::Algolia.SearchResponse? value)
        {
            Response = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResult(global::Algolia.SearchForFacetValuesResponse value) => new SearchResult((global::Algolia.SearchForFacetValuesResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Algolia.SearchForFacetValuesResponse?(SearchResult @this) => @this.ForFacetValuesResponse;

        /// <summary>
        /// 
        /// </summary>
        public SearchResult(global::Algolia.SearchForFacetValuesResponse? value)
        {
            ForFacetValuesResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchResult(
            global::Algolia.SearchResponse? response,
            global::Algolia.SearchForFacetValuesResponse? forFacetValuesResponse
            )
        {
            Response = response;
            ForFacetValuesResponse = forFacetValuesResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ForFacetValuesResponse as object ??
            Response as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Response?.ToString() ??
            ForFacetValuesResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponse && !IsForFacetValuesResponse || !IsResponse && IsForFacetValuesResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Algolia.SearchResponse?, TResult>? response = null,
            global::System.Func<global::Algolia.SearchForFacetValuesResponse, TResult>? forFacetValuesResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse && response != null)
            {
                return response(Response!);
            }
            else if (IsForFacetValuesResponse && forFacetValuesResponse != null)
            {
                return forFacetValuesResponse(ForFacetValuesResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Algolia.SearchResponse?>? response = null,

            global::System.Action<global::Algolia.SearchForFacetValuesResponse>? forFacetValuesResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse)
            {
                response?.Invoke(Response!);
            }
            else if (IsForFacetValuesResponse)
            {
                forFacetValuesResponse?.Invoke(ForFacetValuesResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Algolia.SearchResponse?>? response = null,
            global::System.Action<global::Algolia.SearchForFacetValuesResponse>? forFacetValuesResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse)
            {
                response?.Invoke(Response!);
            }
            else if (IsForFacetValuesResponse)
            {
                forFacetValuesResponse?.Invoke(ForFacetValuesResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Response,
                typeof(global::Algolia.SearchResponse),
                ForFacetValuesResponse,
                typeof(global::Algolia.SearchForFacetValuesResponse),
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
        public bool Equals(SearchResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchResponse?>.Default.Equals(Response, other.Response) &&
                global::System.Collections.Generic.EqualityComparer<global::Algolia.SearchForFacetValuesResponse?>.Default.Equals(ForFacetValuesResponse, other.ForFacetValuesResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchResult obj1, SearchResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchResult obj1, SearchResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchResult o && Equals(o);
        }
    }
}
