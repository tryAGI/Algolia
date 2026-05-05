#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search dictionary entries<br/>
        /// Searches for standard and custom dictionary entries.
        /// </summary>
        /// <param name="dictionaryName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchDictionaryEntriesResponse> SearchDictionaryEntriesAsync(
            global::Algolia.DictionaryType dictionaryName,

            global::Algolia.SearchDictionaryEntriesRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search dictionary entries<br/>
        /// Searches for standard and custom dictionary entries.
        /// </summary>
        /// <param name="dictionaryName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.SearchDictionaryEntriesResponse>> SearchDictionaryEntriesAsResponseAsync(
            global::Algolia.DictionaryType dictionaryName,

            global::Algolia.SearchDictionaryEntriesRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search dictionary entries<br/>
        /// Searches for standard and custom dictionary entries.
        /// </summary>
        /// <param name="dictionaryName"></param>
        /// <param name="query">
        /// Search query.
        /// </param>
        /// <param name="page">
        /// Page of search results to retrieve.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="hitsPerPage">
        /// Number of hits per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="language">
        /// ISO code for a supported language.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SearchDictionaryEntriesResponse> SearchDictionaryEntriesAsync(
            global::Algolia.DictionaryType dictionaryName,
            string query,
            int? page = default,
            int? hitsPerPage = default,
            global::Algolia.SupportedLanguage? language = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}