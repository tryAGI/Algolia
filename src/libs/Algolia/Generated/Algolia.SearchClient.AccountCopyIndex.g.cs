
#nullable enable

namespace Algolia
{
    public partial class SearchClient
    {
        partial void PrepareAccountCopyIndexArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sourceIndexName,
            ref string destinationAppID,
            ref string destinationApiKey,
            ref string destinationIndexName,
            ref int? batchSize);
        partial void PrepareAccountCopyIndexRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sourceIndexName,
            string destinationAppID,
            string destinationApiKey,
            string destinationIndexName,
            int? batchSize);
        partial void ProcessAccountCopyIndexResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Copies the given `sourceIndexName` records, rules and synonyms to an other Algolia application for the given `destinationIndexName`<br/>
        /// Copies the given `sourceIndexName` records, rules and synonyms to an other Algolia application for the given `destinationIndexName`.
        /// </summary>
        /// <param name="sourceIndexName"></param>
        /// <param name="destinationAppID"></param>
        /// <param name="destinationApiKey"></param>
        /// <param name="destinationIndexName"></param>
        /// <param name="batchSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AccountCopyIndexAsync(
            string sourceIndexName,
            string destinationAppID,
            string destinationApiKey,
            string destinationIndexName,
            int? batchSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAccountCopyIndexArguments(
                httpClient: HttpClient,
                sourceIndexName: ref sourceIndexName,
                destinationAppID: ref destinationAppID,
                destinationApiKey: ref destinationApiKey,
                destinationIndexName: ref destinationIndexName,
                batchSize: ref batchSize);

            var __pathBuilder = new global::Algolia.PathBuilder(
                path: "/accountCopyIndex",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("sourceIndexName", sourceIndexName)
                .AddRequiredParameter("destinationAppID", destinationAppID)
                .AddRequiredParameter("destinationApiKey", destinationApiKey)
                .AddRequiredParameter("destinationIndexName", destinationIndexName)
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
            PrepareAccountCopyIndexRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                sourceIndexName: sourceIndexName,
                destinationAppID: destinationAppID,
                destinationApiKey: destinationApiKey,
                destinationIndexName: destinationIndexName,
                batchSize: batchSize);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAccountCopyIndexResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Indices are in the same application. Use operationIndex instead.
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
            // Destination index already exists.
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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