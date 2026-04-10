#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Create or replace a synonym<br/>
        /// If a synonym with the specified object ID doesn't exist, Algolia adds a new one.<br/>
        /// Otherwise, the existing synonym is replaced.<br/>
        /// To add multiple synonyms in a single API request, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/save-synonyms).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Example: synonymID
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SaveSynonymResponse> SaveSynonymAsync(
            string indexName,
            string objectID,

            global::Algolia.SynonymHit request,
            bool? forwardToReplicas = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace a synonym<br/>
        /// If a synonym with the specified object ID doesn't exist, Algolia adds a new one.<br/>
        /// Otherwise, the existing synonym is replaced.<br/>
        /// To add multiple synonyms in a single API request, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/save-synonyms).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Example: synonymID
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="requestObjectID">
        /// Unique identifier of a synonym object.<br/>
        /// Example: synonymID
        /// </param>
        /// <param name="type">
        /// Synonym type.<br/>
        /// Example: onewaysynonym
        /// </param>
        /// <param name="synonyms">
        /// Words or phrases considered equivalent.<br/>
        /// Example: [vehicle, auto]
        /// </param>
        /// <param name="input">
        /// Word or phrase to appear in query strings (for [`onewaysynonym`s](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/one-way-synonyms)).<br/>
        /// Example: car
        /// </param>
        /// <param name="word">
        /// Word or phrase to appear in query strings (for [`altcorrection1` and `altcorrection2`](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-alternative-corrections)).<br/>
        /// Example: car
        /// </param>
        /// <param name="corrections">
        /// Words to be matched in records.<br/>
        /// Example: [vehicle, auto]
        /// </param>
        /// <param name="placeholder">
        /// [Placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders) to be put inside records.<br/>
        /// Example: &lt;Street&gt;
        /// </param>
        /// <param name="replacements">
        /// Query words that will match the [placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders).<br/>
        /// Example: [street, st]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SaveSynonymResponse> SaveSynonymAsync(
            string indexName,
            string objectID,
            string requestObjectID,
            global::Algolia.SynonymType type,
            bool? forwardToReplicas = default,
            global::System.Collections.Generic.IList<string>? synonyms = default,
            string? input = default,
            string? word = default,
            global::System.Collections.Generic.IList<string>? corrections = default,
            string? placeholder = default,
            global::System.Collections.Generic.IList<string>? replacements = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}