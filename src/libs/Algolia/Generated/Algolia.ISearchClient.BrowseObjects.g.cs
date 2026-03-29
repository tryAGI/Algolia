#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Get all records from an index<br/>
        /// You can use the browse method to get records from an index—for example, to export your index as a backup. To export all records, use an empty query.<br/>
        /// Use browse instead of search when exporting records from your index, when ranking, or analytics, isn't important. The Analytics API doesn't collect data when using browse.<br/>
        /// Don't use this method for building a search UI. Use search instead.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="browseParams"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task BrowseObjectsAsync(
            string indexName,
            global::Algolia.BrowseParamsConfig browseParams,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}