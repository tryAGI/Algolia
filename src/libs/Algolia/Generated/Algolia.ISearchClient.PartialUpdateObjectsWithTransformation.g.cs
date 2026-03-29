#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Save objects to an Algolia index by leveraging the Transformation pipeline setup using the Push connector (https://www.algolia.com/doc/guides/sending-and-managing-data/send-and-update-your-data/connectors/push)<br/>
        /// Helper: Similar to the `partialUpdateObjects` method but requires a Push connector (https://www.algolia.com/doc/guides/sending-and-managing-data/send-and-update-your-data/connectors/push) to be created first, in order to transform records before indexing them to Algolia. The `region` must have been passed to the client instantiation method.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="objects"></param>
        /// <param name="createIfNotExists">
        /// Default Value: false
        /// </param>
        /// <param name="waitForTasks">
        /// Default Value: false
        /// </param>
        /// <param name="batchSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Algolia.WatchResponse>> PartialUpdateObjectsWithTransformationAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            bool? createIfNotExists = default,
            bool? waitForTasks = default,
            int? batchSize = default,
            object? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}