#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// List available languages<br/>
        /// Lists supported languages with their supported dictionary types and number of custom entries.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Algolia.Languages>> GetDictionaryLanguagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}