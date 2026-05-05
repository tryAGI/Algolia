#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Browse for records<br/>
        /// Retrieves records from an index, up to 1,000 per request.<br/>
        /// Searching returns _hits_ (records augmented with highlighting and ranking details).<br/>
        /// Browsing returns matching records only.<br/>
        /// Use browse to export your indices.<br/>
        /// - The Analytics API doesn't collect data when using `browse`.<br/>
        /// - Records are ranked by attributes and custom ranking.<br/>
        /// - There's no ranking for typo tolerance, number of matched words, proximity, or geo distance.<br/>
        /// Browse requests automatically apply these settings:<br/>
        /// - `advancedSyntax`: `false`<br/>
        /// - `attributesToHighlight`: `[]`<br/>
        /// - `attributesToSnippet`: `[]`<br/>
        /// - `distinct`: `false`<br/>
        /// - `enablePersonalization`: `false`<br/>
        /// - `enableRules`: `false`<br/>
        /// - `facets`: `[]`<br/>
        /// - `getRankingInfo`: `false`<br/>
        /// - `ignorePlurals`: `false`<br/>
        /// - `optionalFilters`: `[]`<br/>
        /// - `typoTolerance`: `true` or `false` (`min` and `strict` evaluate to `true`)<br/>
        /// If you send these parameters with your browse requests, they're ignored.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.BrowseResponse> BrowseAsync(
            string indexName,

            global::Algolia.BrowseParams request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Browse for records<br/>
        /// Retrieves records from an index, up to 1,000 per request.<br/>
        /// Searching returns _hits_ (records augmented with highlighting and ranking details).<br/>
        /// Browsing returns matching records only.<br/>
        /// Use browse to export your indices.<br/>
        /// - The Analytics API doesn't collect data when using `browse`.<br/>
        /// - Records are ranked by attributes and custom ranking.<br/>
        /// - There's no ranking for typo tolerance, number of matched words, proximity, or geo distance.<br/>
        /// Browse requests automatically apply these settings:<br/>
        /// - `advancedSyntax`: `false`<br/>
        /// - `attributesToHighlight`: `[]`<br/>
        /// - `attributesToSnippet`: `[]`<br/>
        /// - `distinct`: `false`<br/>
        /// - `enablePersonalization`: `false`<br/>
        /// - `enableRules`: `false`<br/>
        /// - `facets`: `[]`<br/>
        /// - `getRankingInfo`: `false`<br/>
        /// - `ignorePlurals`: `false`<br/>
        /// - `optionalFilters`: `[]`<br/>
        /// - `typoTolerance`: `true` or `false` (`min` and `strict` evaluate to `true`)<br/>
        /// If you send these parameters with your browse requests, they're ignored.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.BrowseResponse>> BrowseAsResponseAsync(
            string indexName,

            global::Algolia.BrowseParams request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Browse for records<br/>
        /// Retrieves records from an index, up to 1,000 per request.<br/>
        /// Searching returns _hits_ (records augmented with highlighting and ranking details).<br/>
        /// Browsing returns matching records only.<br/>
        /// Use browse to export your indices.<br/>
        /// - The Analytics API doesn't collect data when using `browse`.<br/>
        /// - Records are ranked by attributes and custom ranking.<br/>
        /// - There's no ranking for typo tolerance, number of matched words, proximity, or geo distance.<br/>
        /// Browse requests automatically apply these settings:<br/>
        /// - `advancedSyntax`: `false`<br/>
        /// - `attributesToHighlight`: `[]`<br/>
        /// - `attributesToSnippet`: `[]`<br/>
        /// - `distinct`: `false`<br/>
        /// - `enablePersonalization`: `false`<br/>
        /// - `enableRules`: `false`<br/>
        /// - `facets`: `[]`<br/>
        /// - `getRankingInfo`: `false`<br/>
        /// - `ignorePlurals`: `false`<br/>
        /// - `optionalFilters`: `[]`<br/>
        /// - `typoTolerance`: `true` or `false` (`min` and `strict` evaluate to `true`)<br/>
        /// If you send these parameters with your browse requests, they're ignored.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.BrowseResponse> BrowseAsync(
            string indexName,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}