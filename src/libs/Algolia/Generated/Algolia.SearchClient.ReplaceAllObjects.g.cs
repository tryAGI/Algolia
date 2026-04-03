
#nullable enable

namespace Algolia
{
    public partial class SearchClient
    {
        partial void PrepareReplaceAllObjectsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexName,
            global::System.Collections.Generic.IList<object> objects,
            ref int? batchSize,
            global::System.Collections.Generic.IList<global::Algolia.ScopeType>? scopes);
        partial void PrepareReplaceAllObjectsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            int? batchSize,
            global::System.Collections.Generic.IList<global::Algolia.ScopeType>? scopes);
        partial void ProcessReplaceAllObjectsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReplaceAllObjectsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Replace all records in an index<br/>
        /// This method replaces all records in an index without interrupting ongoing searches.<br/>
        /// It combines [batch](https://www.algolia.com/doc/rest-api/search/batch) and [copy/move](https://www.algolia.com/doc/rest-api/search/operation-index) index operations:<br/>
        /// 1. Copy settings, synonyms, and rules to a temporary index.<br/>
        /// 2. Add the records from the `objects` parameter to the temporary index.<br/>
        /// 3. Replace the original index with the temporary one.<br/>
        /// Notes:<br/>
        /// - If there's an error during one of these steps, the temporary index is deleted if your API key has the `deleteIndex` ACL.<br/>
        /// - If your API key restricts access to specific indices, make sure it also grants access to the temporary index `INDEX_NAME_tmp_*` (replace `INDEX_NAME` with the name of your original index).<br/>
        /// - This method is subject to [indexing rate limits](https://support.algolia.com/hc/en-us/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).<br/>
        /// - The response includes the results of the individual API requests.<br/>
        /// - This method creates a temporary index, which temporarily doubles your record count.<br/>
        /// - Algolia doesn't count the three days with the highest number of records toward your monthly usage.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="objects"></param>
        /// <param name="batchSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="scopes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.ReplaceAllObjectsResponse> ReplaceAllObjectsAsync(
            string indexName,
            global::System.Collections.Generic.IList<object> objects,
            int? batchSize = default,
            global::System.Collections.Generic.IList<global::Algolia.ScopeType>? scopes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReplaceAllObjectsArguments(
                httpClient: HttpClient,
                indexName: ref indexName,
                objects: objects,
                batchSize: ref batchSize,
                scopes: scopes);

            var __pathBuilder = new global::Algolia.PathBuilder(
                path: "/replaceAllObjects",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("indexName", indexName)
                .AddRequiredParameter("objects", objects, selector: static x => x.ToString()!, delimiter: ",", explode: true)
                .AddOptionalParameter("batchSize", batchSize?.ToString())
                .AddOptionalParameter("scopes", scopes, selector: static x => x.ToValueString(), delimiter: ",", explode: true) 
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
            PrepareReplaceAllObjectsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                indexName: indexName,
                objects: objects,
                batchSize: batchSize,
                scopes: scopes);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReplaceAllObjectsResponse(
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
                ProcessReplaceAllObjectsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Algolia.ReplaceAllObjectsResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Algolia.ReplaceAllObjectsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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