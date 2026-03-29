
#nullable enable

namespace Algolia
{
    public partial class SearchClient
    {
        partial void PrepareChunkedBatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexName,
            global::System.Collections.Generic.IList<object> objects,
            ref global::Algolia.Action? action,
            ref bool? waitForTasks,
            ref int? batchSize);
        partial void PrepareChunkedBatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            global::Algolia.Action? action,
            bool? waitForTasks,
            int? batchSize);
        partial void ProcessChunkedBatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChunkedBatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Replace all records in an index<br/>
        /// Helper: Chunks the given `objects` list in subset of 1000 elements max in order to make it fit in `batch` requests.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="objects"></param>
        /// <param name="action">
        /// Which indexing operation to perform:<br/>
        /// - `addObject`: adds records to an index.<br/>
        ///    Equivalent to the "Add a new record (with auto-generated object ID)" operation.<br/>
        /// - `updateObject`: adds or replaces records in an index.<br/>
        ///    Equivalent to the "Add or replace a record" operation.<br/>
        /// - `partialUpdateObject`: adds or updates attributes within records.<br/>
        ///    Equivalent to the "Add or update attributes" operation with the `createIfNoExists` parameter set to true.<br/>
        ///    (If a record with the specified `objectID` doesn't exist in the specified index, this action creates adds the record to the index)<br/>
        /// - `partialUpdateObjectNoCreate`: same as `partialUpdateObject`, but with `createIfNoExists` set to false.<br/>
        ///    (A record isn't added to the index if its `objectID` doesn't exist)<br/>
        /// - `deleteObject`: delete records from an index.<br/>
        ///   Equivalent to the "Delete a record" operation.<br/>
        /// - `delete`. Delete an index. Equivalent to the "Delete an index" operation.<br/>
        /// - `clear`: delete all records from an index. Equivalent to the "Delete all records from an index operation".
        /// </param>
        /// <param name="waitForTasks"></param>
        /// <param name="batchSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Algolia.BatchResponse>> ChunkedBatchAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            global::Algolia.Action? action = default,
            bool? waitForTasks = default,
            int? batchSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareChunkedBatchArguments(
                httpClient: HttpClient,
                indexName: ref indexName,
                objects: objects,
                action: ref action,
                waitForTasks: ref waitForTasks,
                batchSize: ref batchSize);

            var __pathBuilder = new global::Algolia.PathBuilder(
                path: "/chunkedBatch",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("indexName", indexName)
                .AddRequiredParameter("objects", objects, selector: static x => x.ToString()!, delimiter: ",", explode: true)
                .AddOptionalParameter("action", action?.ToValueString())
                .AddOptionalParameter("waitForTasks", waitForTasks?.ToString().ToLowerInvariant())
                .AddOptionalParameter("batchSize", batchSize?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChunkedBatchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                indexName: indexName,
                objects: objects,
                action: action,
                waitForTasks: waitForTasks,
                batchSize: batchSize);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChunkedBatchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Index not found.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Algolia.ErrorBase? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Algolia.ErrorBase.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Algolia.ErrorBase.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Algolia.ApiException<global::Algolia.ErrorBase>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessChunkedBatchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        (global::System.Collections.Generic.IList<global::Algolia.BatchResponse>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Algolia.BatchResponse>), JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Algolia.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        (global::System.Collections.Generic.IList<global::Algolia.BatchResponse>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Algolia.BatchResponse>), JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Algolia.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}