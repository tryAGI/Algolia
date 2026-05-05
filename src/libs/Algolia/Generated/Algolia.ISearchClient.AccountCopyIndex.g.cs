#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Copies the given `sourceIndexName` records, rules and synonyms to an other Algolia application for the given `destinationIndexName`<br/>
        /// Copies the given `sourceIndexName` records, rules and synonyms to an other Algolia application for the given `destinationIndexName`.
        /// </summary>
        /// <param name="sourceIndexName"></param>
        /// <param name="destinationAppID"></param>
        /// <param name="destinationApiKey"></param>
        /// <param name="destinationIndexName"></param>
        /// <param name="batchSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task AccountCopyIndexAsync(
            string sourceIndexName,
            string destinationAppID,
            string destinationApiKey,
            string destinationIndexName,
            int? batchSize = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Copies the given `sourceIndexName` records, rules and synonyms to an other Algolia application for the given `destinationIndexName`<br/>
        /// Copies the given `sourceIndexName` records, rules and synonyms to an other Algolia application for the given `destinationIndexName`.
        /// </summary>
        /// <param name="sourceIndexName"></param>
        /// <param name="destinationAppID"></param>
        /// <param name="destinationApiKey"></param>
        /// <param name="destinationIndexName"></param>
        /// <param name="batchSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse> AccountCopyIndexAsResponseAsync(
            string sourceIndexName,
            string destinationAppID,
            string destinationApiKey,
            string destinationIndexName,
            int? batchSize = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}