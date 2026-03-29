
#nullable enable

namespace Algolia.Recommend
{
    public partial class RecommendClient
    {
        partial void PrepareGetRecommendStatusArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexName,
            ref global::Algolia.Recommend.RecommendModels model,
            ref long taskID);
        partial void PrepareGetRecommendStatusRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexName,
            global::Algolia.Recommend.RecommendModels model,
            long taskID);
        partial void ProcessGetRecommendStatusResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetRecommendStatusResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Check task status<br/>
        /// Checks the status of a given task.<br/>
        /// Deleting a Recommend rule is asynchronous.<br/>
        /// When you delete a rule, a task is created on a queue and completed depending on the load on the server.<br/>
        /// The API response includes a task ID that you can use to check the status.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="model"></param>
        /// <param name="taskID">
        /// Unique identifier of a task.<br/>
        /// A successful API response means that a task was added to a queue.<br/>
        /// It might not run immediately.<br/>
        /// You can check the task's progress with the [`task` operation](https://www.algolia.com/doc/rest-api/search/get-task) and this task ID.<br/>
        /// Example: 1514562690001
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.Recommend.GetRecommendStatusResponse> GetRecommendStatusAsync(
            string indexName,
            global::Algolia.Recommend.RecommendModels model,
            long taskID,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetRecommendStatusArguments(
                httpClient: HttpClient,
                indexName: ref indexName,
                model: ref model,
                taskID: ref taskID);

            var __pathBuilder = new global::Algolia.Recommend.PathBuilder(
                path: $"/1/indexes/{indexName}/{model}/task/{taskID}",
                baseUri: HttpClient.BaseAddress); 
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
            PrepareGetRecommendStatusRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                indexName: indexName,
                model: model,
                taskID: taskID);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetRecommendStatusResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request or request arguments.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Algolia.Recommend.ErrorBase? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Algolia.Recommend.ErrorBase.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Algolia.Recommend.ErrorBase.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Algolia.Recommend.ApiException<global::Algolia.Recommend.ErrorBase>(
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
            // This feature is not enabled on your Algolia account.
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::Algolia.Recommend.ErrorBase? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::Algolia.Recommend.ErrorBase.FromJson(__content_402, JsonSerializerContext);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::Algolia.Recommend.ErrorBase.FromJson(__content_402, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::Algolia.Recommend.ApiException<global::Algolia.Recommend.ErrorBase>(
                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_402,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_402,
                    ResponseObject = __value_402,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Method not allowed with this API key.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::Algolia.Recommend.ErrorBase? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::Algolia.Recommend.ErrorBase.FromJson(__content_403, JsonSerializerContext);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::Algolia.Recommend.ErrorBase.FromJson(__content_403, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::Algolia.Recommend.ApiException<global::Algolia.Recommend.ErrorBase>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Index not found.
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::Algolia.Recommend.ErrorBase? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::Algolia.Recommend.ErrorBase.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::Algolia.Recommend.ErrorBase.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Algolia.Recommend.ApiException<global::Algolia.Recommend.ErrorBase>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
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
                ProcessGetRecommendStatusResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Algolia.Recommend.GetRecommendStatusResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Algolia.Recommend.ApiException(
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
                        await global::Algolia.Recommend.GetRecommendStatusResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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

                    throw new global::Algolia.Recommend.ApiException(
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