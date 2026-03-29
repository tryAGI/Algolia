#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Retrieve index settings<br/>
        /// Retrieves an object with non-null index settings.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="getVersion">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.SettingsResponse> GetSettingsAsync(
            string indexName,
            int? getVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}