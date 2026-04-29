
#nullable enable

namespace Algolia
{
    public partial class SearchClient
    {


        private static readonly global::Algolia.EndPointSecurityRequirement s_SaveRuleSecurityRequirement0 =
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
        private static readonly global::Algolia.EndPointSecurityRequirement[] s_SaveRuleSecurityRequirements =
            new global::Algolia.EndPointSecurityRequirement[]
            {                s_SaveRuleSecurityRequirement0,
            };
        partial void PrepareSaveRuleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexName,
            ref string objectID,
            ref bool? forwardToReplicas,
            global::Algolia.Rule request);
        partial void PrepareSaveRuleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexName,
            string objectID,
            bool? forwardToReplicas,
            global::Algolia.Rule request);
        partial void ProcessSaveRuleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSaveRuleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or replace a rule<br/>
        /// If a rule with the specified object ID doesn't exist, it's created.<br/>
        /// Otherwise, the existing rule is replaced.<br/>
        /// To create or update more than one rule, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/save-rules).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Unique identifier of a rule object.
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> SaveRuleAsync(
            string indexName,
            string objectID,

            global::Algolia.Rule request,
            bool? forwardToReplicas = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSaveRuleArguments(
                httpClient: HttpClient,
                indexName: ref indexName,
                objectID: ref objectID,
                forwardToReplicas: ref forwardToReplicas,
                request: request);


            var __authorizations = global::Algolia.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SaveRuleSecurityRequirements,
                operationName: "SaveRuleAsync");

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
                                path: $"/1/indexes/{indexName}/rules/{objectID}",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("forwardToReplicas", forwardToReplicas?.ToString().ToLowerInvariant()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Algolia.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
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
                global::Algolia.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSaveRuleRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    indexName: indexName!,
                    objectID: objectID!,
                    forwardToReplicas: forwardToReplicas,
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
                    await global::Algolia.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Algolia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SaveRule",
                                methodName: "SaveRuleAsync",
                                pathTemplate: "$\"/1/indexes/{indexName}/rules/{objectID}\"",
                                httpMethod: "PUT",
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
                        await global::Algolia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Algolia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SaveRule",
                                methodName: "SaveRuleAsync",
                                pathTemplate: "$\"/1/indexes/{indexName}/rules/{objectID}\"",
                                httpMethod: "PUT",
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
                        await global::Algolia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Algolia.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Algolia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Algolia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SaveRule",
                                methodName: "SaveRuleAsync",
                                pathTemplate: "$\"/1/indexes/{indexName}/rules/{objectID}\"",
                                httpMethod: "PUT",
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
                        await global::Algolia.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
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
                ProcessSaveRuleResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Algolia.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Algolia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SaveRule",
                                methodName: "SaveRuleAsync",
                                pathTemplate: "$\"/1/indexes/{indexName}/rules/{objectID}\"",
                                httpMethod: "PUT",
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
                    await global::Algolia.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Algolia.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SaveRule",
                                methodName: "SaveRuleAsync",
                                pathTemplate: "$\"/1/indexes/{indexName}/rules/{objectID}\"",
                                httpMethod: "PUT",
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
                            // This feature is not enabled on your Algolia account.
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                global::Algolia.ErrorBase? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::Algolia.ErrorBase.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = global::Algolia.ErrorBase.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }

                                throw new global::Algolia.ApiException<global::Algolia.ErrorBase>(
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
                                global::Algolia.ErrorBase? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Algolia.ErrorBase.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Algolia.ErrorBase.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }

                                throw new global::Algolia.ApiException<global::Algolia.ErrorBase>(
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
                                global::Algolia.ErrorBase? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Algolia.ErrorBase.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Algolia.ErrorBase.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }

                                throw new global::Algolia.ApiException<global::Algolia.ErrorBase>(
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
                                ProcessSaveRuleResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Algolia.UpdatedAtResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Algolia.UpdatedAtResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <summary>
        /// Create or replace a rule<br/>
        /// If a rule with the specified object ID doesn't exist, it's created.<br/>
        /// Otherwise, the existing rule is replaced.<br/>
        /// To create or update more than one rule, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/save-rules).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Unique identifier of a rule object.
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="requestObjectID">
        /// Unique identifier of a rule object.
        /// </param>
        /// <param name="conditions">
        /// Conditions that trigger a rule.<br/>
        /// Some consequences require specific conditions or don't require any condition.<br/>
        /// For more information, see [Conditions](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#conditions).
        /// </param>
        /// <param name="consequence">
        /// Effect of the rule.<br/>
        /// For more information, see [Consequences](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#consequences).
        /// </param>
        /// <param name="description">
        /// Description of the rule's purpose to help you distinguish between different rules.<br/>
        /// Example: Display a promotional banner
        /// </param>
        /// <param name="enabled">
        /// Whether the rule is active.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="validity">
        /// Time periods when the rule is active.
        /// </param>
        /// <param name="tags"></param>
        /// <param name="scope"></param>
        /// <param name="condition"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> SaveRuleAsync(
            string indexName,
            string objectID,
            string requestObjectID,
            global::Algolia.Consequence consequence,
            bool? forwardToReplicas = default,
            global::System.Collections.Generic.IList<global::Algolia.Condition>? conditions = default,
            string? description = default,
            bool? enabled = default,
            global::System.Collections.Generic.IList<global::Algolia.TimeRange>? validity = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? scope = default,
            global::Algolia.Condition? condition = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Algolia.Rule
            {
                ObjectID = requestObjectID,
                Conditions = conditions,
                Consequence = consequence,
                Description = description,
                Enabled = enabled,
                Validity = validity,
                Tags = tags,
                Scope = scope,
                Condition = condition,
            };

            return await SaveRuleAsync(
                indexName: indexName,
                objectID: objectID,
                forwardToReplicas: forwardToReplicas,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}