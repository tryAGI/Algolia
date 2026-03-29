#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Retrieve dictionary settings<br/>
        /// Retrieves the languages for which standard dictionary entries are turned off.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.GetDictionarySettingsResponse> GetDictionarySettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}