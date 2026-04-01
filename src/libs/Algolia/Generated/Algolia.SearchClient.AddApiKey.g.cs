
#nullable enable

namespace Algolia
{
    public partial class SearchClient
    {
        partial void PrepareAddApiKeyArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Algolia.ApiKey request);
        partial void PrepareAddApiKeyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Algolia.ApiKey request);
        partial void ProcessAddApiKeyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddApiKeyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an API key<br/>
        /// Creates a new API key with specific permissions and restrictions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.AddApiKeyResponse> AddApiKeyAsync(

            global::Algolia.ApiKey request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAddApiKeyArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Algolia.PathBuilder(
                path: "/1/keys",
                baseUri: HttpClient.BaseAddress); 
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAddApiKeyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAddApiKeyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request or request arguments.
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
            // This feature is not enabled on your Algolia account.
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::Algolia.ErrorBase? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::Algolia.ErrorBase.FromJson(__content_402, JsonSerializerContext);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::Algolia.ErrorBase.FromJson(__content_403, JsonSerializerContext);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::Algolia.ErrorBase.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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
                ProcessAddApiKeyResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Algolia.AddApiKeyResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Algolia.AddApiKeyResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <summary>
        /// Create an API key<br/>
        /// Creates a new API key with specific permissions and restrictions.
        /// </summary>
        /// <param name="acl">
        /// Permissions that determine the type of API requests this key can make.<br/>
        /// The required ACL is listed in each endpoint's reference.<br/>
        /// For more information, see [access control list](https://www.algolia.com/doc/guides/security/api-keys/#access-control-list-acl).<br/>
        /// Default Value: []<br/>
        /// Example: [search, addObject]
        /// </param>
        /// <param name="description">
        /// Description of an API key to help you identify this API key.<br/>
        /// Example: Used for indexing by the CLI
        /// </param>
        /// <param name="indexes">
        /// Index names or patterns that this API key can access.<br/>
        /// By default, an API key can access all indices in the same application.<br/>
        /// You can use leading and trailing wildcard characters (`*`):<br/>
        /// - `dev_*` matches all indices starting with "dev_"<br/>
        /// - `*_dev` matches all indices ending with "_dev"<br/>
        /// - `*_products_*` matches all indices containing "_products_".<br/>
        /// Default Value: []<br/>
        /// Example: [dev_*, prod_en_products]
        /// </param>
        /// <param name="maxHitsPerQuery">
        /// Maximum number of results this API key can retrieve in one query.<br/>
        /// By default, there's no limit.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxQueriesPerIPPerHour">
        /// Maximum number of API requests allowed per IP address or [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken) per hour.<br/>
        /// If this limit is reached, the API returns an error with status code `429`.<br/>
        /// By default, there's no limit.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="queryParameters">
        /// Query parameters to add when making API requests with this API key.<br/>
        /// To restrict this API key to specific IP addresses, add the `restrictSources` parameter.<br/>
        /// You can only add a single source, but you can provide a range of IP addresses.<br/>
        /// Creating an API key fails if the request is made from an IP address outside the restricted range.<br/>
        /// Example: typoTolerance=strict&amp;restrictSources=192.168.1.0/24
        /// </param>
        /// <param name="referers">
        /// Allowed HTTP referrers for this API key.<br/>
        /// By default, all referrers are allowed.<br/>
        /// You can use leading and trailing wildcard characters (`*`):<br/>
        /// - `https://algolia.com/*` allows all referrers starting with "https://algolia.com/"<br/>
        /// - `*.algolia.com` allows all referrers ending with ".algolia.com"<br/>
        /// - `*algolia.com*` allows all referrers in the domain "algolia.com".<br/>
        /// Like all HTTP headers, referrers can be spoofed. Don't rely on them to secure your data.<br/>
        /// For more information, see [HTTP referrer restrictions](https://www.algolia.com/doc/guides/security/security-best-practices/#http-referrers-restrictions).<br/>
        /// Default Value: []<br/>
        /// Example: [*algolia.com*]
        /// </param>
        /// <param name="validity">
        /// Duration (in seconds) after which the API key expires.<br/>
        /// By default, API keys don't expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 86400
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.AddApiKeyResponse> AddApiKeyAsync(
            global::System.Collections.Generic.IList<global::Algolia.Acl> acl,
            string? description = default,
            global::System.Collections.Generic.IList<string>? indexes = default,
            int? maxHitsPerQuery = default,
            int? maxQueriesPerIPPerHour = default,
            string? queryParameters = default,
            global::System.Collections.Generic.IList<string>? referers = default,
            int? validity = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::Algolia.ApiKey
            {
                Acl = acl,
                Description = description,
                Indexes = indexes,
                MaxHitsPerQuery = maxHitsPerQuery,
                MaxQueriesPerIPPerHour = maxQueriesPerIPPerHour,
                QueryParameters = queryParameters,
                Referers = referers,
                Validity = validity,
            };

            return await AddApiKeyAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}