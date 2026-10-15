#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Update dictionary settings<br/>
        /// Turns standard stop word dictionary entries on or off for a given language.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> SetDictionarySettingsAsync(

            global::Algolia.SetDictionarySettingsRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dictionary settings<br/>
        /// Turns standard stop word dictionary entries on or off for a given language.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.UpdatedAtResponse>> SetDictionarySettingsAsResponseAsync(

            global::Algolia.SetDictionarySettingsRequest request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dictionary settings<br/>
        /// Turns standard stop word dictionary entries on or off for a given language.
        /// </summary>
        /// <param name="disableStandardEntries">
        /// Turn off the built-in Algolia stop words for specific languages.<br/>
        /// Only `stopwords` is supported.<br/>
        /// The keys of the `stopwords` object are [language ISO codes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages) of languages with a built-in stop-word dictionary.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> SetDictionarySettingsAsync(
            global::Algolia.StandardEntries disableStandardEntries,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}