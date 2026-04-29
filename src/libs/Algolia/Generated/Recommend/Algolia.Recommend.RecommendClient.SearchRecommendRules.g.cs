
#nullable enable

namespace Algolia.Recommend
{
    public partial class RecommendClient
    {


        private static readonly global::Algolia.Recommend.EndPointSecurityRequirement s_SearchRecommendRulesSecurityRequirement0 =
            new global::Algolia.Recommend.EndPointSecurityRequirement
            {
                Authorizations = new global::Algolia.Recommend.EndPointAuthorizationRequirement[]
                {                    new global::Algolia.Recommend.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Algolia.Recommend.EndPointSecurityRequirement[] s_SearchRecommendRulesSecurityRequirements =
            new global::Algolia.Recommend.EndPointSecurityRequirement[]
            {                s_SearchRecommendRulesSecurityRequirement0,
            };
        partial void PrepareSearchRecommendRulesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexName,
            ref global::Algolia.Recommend.RecommendModels model,
            global::Algolia.Recommend.SearchRecommendRulesRequest request);
        partial void PrepareSearchRecommendRulesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexName,
            global::Algolia.Recommend.RecommendModels model,
            global::Algolia.Recommend.SearchRecommendRulesRequest request);
        partial void ProcessSearchRecommendRulesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchRecommendRulesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search for rules<br/>
        /// Searches for Recommend rules.<br/>
        /// Use an empty query to list all rules for this recommendation scenario.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.Recommend.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.Recommend.SearchRecommendRulesResponse> SearchRecommendRulesAsync(
            string indexName,
            global::Algolia.Recommend.RecommendModels model,

            global::Algolia.Recommend.SearchRecommendRulesRequest request,
            global::Algolia.Recommend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSearchRecommendRulesArguments(
                httpClient: HttpClient,
                indexName: ref indexName,
                model: ref model,
                request: request);


            var __authorizations = global::Algolia.Recommend.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SearchRecommendRulesSecurityRequirements,
                operationName: "SearchRecommendRulesAsync");

            using var __timeoutCancellationTokenSource = global::Algolia.Recommend.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Algolia.Recommend.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Algolia.Recommend.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Algolia.Recommend.PathBuilder(
                                path: $"/1/indexes/{indexName}/{model}/recommend/rules/search",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Algolia.Recommend.AutoSDKRequestOptionsSupport.AppendQueryParameters(
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Algolia.Recommend.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSearchRecommendRulesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    indexName: indexName!,
                    model: model!,
                    request: request);

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
                    await global::Algolia.Recommend.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Algolia.Recommend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SearchRecommendRules",
                                methodName: "SearchRecommendRulesAsync",
                                pathTemplate: "$\"/1/indexes/{indexName}/{model}/recommend/rules/search\"",
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Algolia.Recommend.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Algolia.Recommend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SearchRecommendRules",
                                methodName: "SearchRecommendRulesAsync",
                                pathTemplate: "$\"/1/indexes/{indexName}/{model}/recommend/rules/search\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Algolia.Recommend.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Algolia.Recommend.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Algolia.Recommend.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Algolia.Recommend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SearchRecommendRules",
                                methodName: "SearchRecommendRulesAsync",
                                pathTemplate: "$\"/1/indexes/{indexName}/{model}/recommend/rules/search\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Algolia.Recommend.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessSearchRecommendRulesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Algolia.Recommend.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Algolia.Recommend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SearchRecommendRules",
                                methodName: "SearchRecommendRulesAsync",
                                pathTemplate: "$\"/1/indexes/{indexName}/{model}/recommend/rules/search\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Algolia.Recommend.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Algolia.Recommend.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SearchRecommendRules",
                                methodName: "SearchRecommendRulesAsync",
                                pathTemplate: "$\"/1/indexes/{indexName}/{model}/recommend/rules/search\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad request or request arguments.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Algolia.Recommend.ErrorBase? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Algolia.Recommend.ErrorBase.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::Algolia.Recommend.ErrorBase.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Algolia.Recommend.ErrorBase.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Algolia.Recommend.ErrorBase.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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
                                ProcessSearchRecommendRulesResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Algolia.Recommend.SearchRecommendRulesResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Algolia.Recommend.SearchRecommendRulesResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Search for rules<br/>
        /// Searches for Recommend rules.<br/>
        /// Use an empty query to list all rules for this recommendation scenario.
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="model"></param>
        /// <param name="query">
        /// Search query.
        /// </param>
        /// <param name="context">
        /// Only search for rules with matching context.<br/>
        /// Example: mobile
        /// </param>
        /// <param name="page">
        /// Requested page of the API response.<br/>
        /// Algolia uses `page` and `hitsPerPage` to control how search results are displayed ([paginated](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js)).<br/>
        /// - `hitsPerPage`: sets the number of search results (_hits_) displayed per page.<br/>
        /// - `page`: specifies the page number of the search results you want to retrieve. Page numbering starts at 0, so the first page is `page=0`, the second is `page=1`, and so on.<br/>
        /// For example, to display 10 results per page starting from the third page, set `hitsPerPage` to 10 and `page` to 2.
        /// </param>
        /// <param name="hitsPerPage">
        /// Maximum number of hits per page.<br/>
        /// Algolia uses `page` and `hitsPerPage` to control how search results are displayed ([paginated](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js)).<br/>
        /// - `hitsPerPage`: sets the number of search results (_hits_) displayed per page.<br/>
        /// - `page`: specifies the page number of the search results you want to retrieve. Page numbering starts at 0, so the first page is `page=0`, the second is `page=1`, and so on.<br/>
        /// For example, to display 10 results per page starting from the third page, set `hitsPerPage` to 10 and `page` to 2.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="enabled">
        /// Whether to only show rules where the value of their `enabled` property matches this parameter.<br/>
        /// If absent, show all rules, regardless of their `enabled` property.
        /// </param>
        /// <param name="filters">
        /// Filter expression. This only searches for rules matching the filter expression.<br/>
        /// Example: objectID:rr-123456
        /// </param>
        /// <param name="facets">
        /// Include facets and facet values in the response. Use `['*']` to include all facets.<br/>
        /// Example: [*]
        /// </param>
        /// <param name="maxValuesPerFacet">
        /// Maximum number of values to return for each facet.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.Recommend.SearchRecommendRulesResponse> SearchRecommendRulesAsync(
            string indexName,
            global::Algolia.Recommend.RecommendModels model,
            string? query = default,
            string? context = default,
            int? page = default,
            int? hitsPerPage = default,
            bool? enabled = default,
            string? filters = default,
            global::System.Collections.Generic.IList<string>? facets = default,
            int? maxValuesPerFacet = default,
            global::Algolia.Recommend.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Algolia.Recommend.SearchRecommendRulesRequest
            {
                Query = query,
                Context = context,
                Page = page,
                HitsPerPage = hitsPerPage,
                Enabled = enabled,
                Filters = filters,
                Facets = facets,
                MaxValuesPerFacet = maxValuesPerFacet,
            };

            return await SearchRecommendRulesAsync(
                indexName: indexName,
                model: model,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}