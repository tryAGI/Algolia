
#nullable enable

namespace Algolia
{
    public partial class SearchClient
    {
        partial void PreparePartialUpdateObjectsWithTransformationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexName,
            global::System.Collections.Generic.IList<object> objects,
            ref bool? createIfNotExists,
            ref bool? waitForTasks,
            ref int? batchSize,
            object? requestOptions);
        partial void PreparePartialUpdateObjectsWithTransformationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            bool? createIfNotExists,
            bool? waitForTasks,
            int? batchSize,
            object? requestOptions);
        partial void ProcessPartialUpdateObjectsWithTransformationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPartialUpdateObjectsWithTransformationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Algolia.WatchResponse>> PartialUpdateObjectsWithTransformationAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            bool? createIfNotExists = default,
            bool? waitForTasks = default,
            int? batchSize = default,
            object? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePartialUpdateObjectsWithTransformationArguments(
                httpClient: HttpClient,
                indexName: ref indexName,
                objects: objects,
                createIfNotExists: ref createIfNotExists,
                waitForTasks: ref waitForTasks,
                batchSize: ref batchSize,
                requestOptions: requestOptions);

            var __pathBuilder = new global::Algolia.PathBuilder(
                path: "/partialUpdateObjectsWithTransformation",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("indexName", indexName)
                .AddRequiredParameter("objects", objects, selector: static x => x.ToString()!, delimiter: ",", explode: true)
                .AddOptionalParameter("createIfNotExists", createIfNotExists?.ToString().ToLowerInvariant())
                .AddOptionalParameter("waitForTasks", waitForTasks?.ToString().ToLowerInvariant())
                .AddOptionalParameter("batchSize", batchSize?.ToString())
                .AddOptionalParameter("requestOptions", requestOptions?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PreparePartialUpdateObjectsWithTransformationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                indexName: indexName,
                objects: objects,
                createIfNotExists: createIfNotExists,
                waitForTasks: waitForTasks,
                batchSize: batchSize,
                requestOptions: requestOptions);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPartialUpdateObjectsWithTransformationResponse(
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
                ProcessPartialUpdateObjectsWithTransformationResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        (global::System.Collections.Generic.IList<global::Algolia.WatchResponse>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Algolia.WatchResponse>), JsonSerializerContext) ??
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
                        (global::System.Collections.Generic.IList<global::Algolia.WatchResponse>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Algolia.WatchResponse>), JsonSerializerContext).ConfigureAwait(false) ??
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