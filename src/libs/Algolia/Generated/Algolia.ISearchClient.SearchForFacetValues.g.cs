#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search for facet values<br/>
        /// Searches for values of a specified facet attribute.<br/>
        /// - By default, facet values are sorted by decreasing count.<br/>
        ///   You can adjust this with the `sortFacetValueBy` parameter.<br/>
        /// - Searching for facet values doesn't work if you have **more than 65 searchable facets and searchable attributes combined**.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="facetName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchForFacetValuesResponse> SearchForFacetValuesAsync(
            string indexName,
            string facetName,

            global::Algolia.SearchForFacetValuesRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for facet values<br/>
        /// Searches for values of a specified facet attribute.<br/>
        /// - By default, facet values are sorted by decreasing count.<br/>
        ///   You can adjust this with the `sortFacetValueBy` parameter.<br/>
        /// - Searching for facet values doesn't work if you have **more than 65 searchable facets and searchable attributes combined**.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="facetName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.SearchForFacetValuesResponse>> SearchForFacetValuesAsResponseAsync(
            string indexName,
            string facetName,

            global::Algolia.SearchForFacetValuesRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for facet values<br/>
        /// Searches for values of a specified facet attribute.<br/>
        /// - By default, facet values are sorted by decreasing count.<br/>
        ///   You can adjust this with the `sortFacetValueBy` parameter.<br/>
        /// - Searching for facet values doesn't work if you have **more than 65 searchable facets and searchable attributes combined**.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="facetName"></param>
        /// <param name="params">
        /// Search parameters as a URL-encoded query string.<br/>
        /// Example: hitsPerPage=2&amp;getRankingInfo=1
        /// </param>
        /// <param name="facetQuery">
        /// Text to search inside the facet's values.<br/>
        /// Example: george
        /// </param>
        /// <param name="maxFacetHits">
        /// Maximum number of facet values to return when [searching for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchForFacetValuesResponse> SearchForFacetValuesAsync(
            string indexName,
            string facetName,
            string? @params = default,
            string? facetQuery = default,
            int? maxFacetHits = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}