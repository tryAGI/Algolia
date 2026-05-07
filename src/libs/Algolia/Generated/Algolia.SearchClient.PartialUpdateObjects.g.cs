
#nullable enable

namespace Algolia
{
    public partial class SearchClient
    {


        private static readonly global::Algolia.EndPointSecurityRequirement s_PartialUpdateObjectsSecurityRequirement0 =
            new global::Algolia.EndPointSecurityRequirement
            {
                Authorizations = new global::Algolia.EndPointAuthorizationRequirement[]
                {                    new global::Algolia.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Algolia.EndPointSecurityRequirement[] s_PartialUpdateObjectsSecurityRequirements =
            new global::Algolia.EndPointSecurityRequirement[]
            {                s_PartialUpdateObjectsSecurityRequirement0,
            };
        partial void PreparePartialUpdateObjectsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexName,
            global::System.Collections.Generic.IList<object> objects,
            ref bool? createIfNotExists,
            ref bool? waitForTasks,
            ref int? batchSize,
            object? algoliaRequestOptions);
        partial void PreparePartialUpdateObjectsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            bool? createIfNotExists,
            bool? waitForTasks,
            int? batchSize,
            object? algoliaRequestOptions);
        partial void ProcessPartialUpdateObjectsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPartialUpdateObjectsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Replaces object content of all the given objects according to their respective `objectID` field<br/>
        /// Helper: Replaces object content of all the given objects according to their respective `objectID` field. The `chunkedBatch` helper splits this into `batch` requests with at most 1,000 objects each.
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
        /// <param name="algoliaRequestOptions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Algolia.BatchResponse>> PartialUpdateObjectsAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            bool? createIfNotExists = default,
            bool? waitForTasks = default,
            int? batchSize = default,
            object? algoliaRequestOptions = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PartialUpdateObjectsAsResponseAsync(
                indexName: indexName,
                objects: objects,
                createIfNotExists: createIfNotExists,
                waitForTasks: waitForTasks,
                batchSize: batchSize,
                algoliaRequestOptions: algoliaRequestOptions,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Replaces object content of all the given objects according to their respective `objectID` field<br/>
        /// Helper: Replaces object content of all the given objects according to their respective `objectID` field. The `chunkedBatch` helper splits this into `batch` requests with at most 1,000 objects each.
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
        /// <param name="algoliaRequestOptions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Algolia.BatchResponse>>> PartialUpdateObjectsAsResponseAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            bool? createIfNotExists = default,
            bool? waitForTasks = default,
            int? batchSize = default,
            object? algoliaRequestOptions = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePartialUpdateObjectsArguments(
                httpClient: HttpClient,
                indexName: ref indexName,
                objects: objects,
                createIfNotExists: ref createIfNotExists,
                waitForTasks: ref waitForTasks,
                batchSize: ref batchSize,
                algoliaRequestOptions: algoliaRequestOptions);


            var __authorizations = global::Algolia.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PartialUpdateObjectsSecurityRequirements,
                operationName: "PartialUpdateObjectsAsync");

            using var __timeoutCancellationTokenSource = global::Algolia.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Algolia.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Algolia.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Algolia.PathBuilder(
                                path: "/partialUpdateObjects",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("indexName", indexName)
                                .AddRequiredParameter("objects", objects, selector: static x => x.ToString()!, delimiter: ",", explode: true)
                                .AddOptionalParameter("createIfNotExists", createIfNotExists?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("waitForTasks", waitForTasks?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("batchSize", batchSize?.ToString())
                                .AddOptionalParameter("algoliaRequestOptions", algoliaRequestOptions?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Algolia.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Algolia.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PreparePartialUpdateObjectsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    indexName: indexName!,
                    objects: objects!,
                    createIfNotExists: createIfNotExists,
                    waitForTasks: waitForTasks,
                    batchSize: batchSize,
                    algoliaRequestOptions: algoliaRequestOptions);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Algolia.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Algolia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PartialUpdateObjects",
                                methodName: "PartialUpdateObjectsAsync",
                                pathTemplate: "\"/partialUpdateObjects\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Algolia.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Algolia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Algolia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PartialUpdateObjects",
                                methodName: "PartialUpdateObjectsAsync",
                                pathTemplate: "\"/partialUpdateObjects\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Algolia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Algolia.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Algolia.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Algolia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Algolia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PartialUpdateObjects",
                                methodName: "PartialUpdateObjectsAsync",
                                pathTemplate: "\"/partialUpdateObjects\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Algolia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessPartialUpdateObjectsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Algolia.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Algolia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PartialUpdateObjects",
                                methodName: "PartialUpdateObjectsAsync",
                                pathTemplate: "\"/partialUpdateObjects\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Algolia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Algolia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PartialUpdateObjects",
                                methodName: "PartialUpdateObjectsAsync",
                                pathTemplate: "\"/partialUpdateObjects\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Index not found.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Algolia.ErrorBase? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Algolia.ErrorBase.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessPartialUpdateObjectsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::Algolia.BatchResponse>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Algolia.BatchResponse>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Algolia.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Algolia.BatchResponse>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Algolia.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = (global::System.Collections.Generic.IList<global::Algolia.BatchResponse>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Algolia.BatchResponse>), JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Algolia.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Algolia.BatchResponse>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Algolia.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}