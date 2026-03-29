#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Send requests to the Algolia REST API<br/>
        /// This method lets you send requests to the Algolia REST API.
        /// </summary>
        /// <param name="path">
        /// Example: /keys
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CustomPostAsync(
            string path,

            object request,
            object? parameters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send requests to the Algolia REST API<br/>
        /// This method lets you send requests to the Algolia REST API.
        /// </summary>
        /// <param name="path">
        /// Example: /keys
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CustomPostAsync(
            string path,
            object? parameters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}