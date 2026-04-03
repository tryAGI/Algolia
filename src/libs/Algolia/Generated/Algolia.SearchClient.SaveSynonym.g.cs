
#nullable enable

namespace Algolia
{
    public partial class SearchClient
    {
        partial void PrepareSaveSynonymArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexName,
            ref string objectID,
            ref bool? forwardToReplicas,
            global::Algolia.SynonymHit request);
        partial void PrepareSaveSynonymRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexName,
            string objectID,
            bool? forwardToReplicas,
            global::Algolia.SynonymHit request);
        partial void ProcessSaveSynonymResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSaveSynonymResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or replace a synonym<br/>
        /// If a synonym with the specified object ID doesn't exist, Algolia adds a new one.<br/>
        /// Otherwise, the existing synonym is replaced.<br/>
        /// To add multiple synonyms in a single API request, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/save-synonyms).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Example: synonymID
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.SaveSynonymResponse> SaveSynonymAsync(
            string indexName,
            string objectID,

            global::Algolia.SynonymHit request,
            bool? forwardToReplicas = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSaveSynonymArguments(
                httpClient: HttpClient,
                indexName: ref indexName,
                objectID: ref objectID,
                forwardToReplicas: ref forwardToReplicas,
                request: request);

            var __pathBuilder = new global::Algolia.PathBuilder(
                path: $"/1/indexes/{indexName}/synonyms/{objectID}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("forwardToReplicas", forwardToReplicas?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareSaveSynonymRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                indexName: indexName,
                objectID: objectID,
                forwardToReplicas: forwardToReplicas,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSaveSynonymResponse(
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
                ProcessSaveSynonymResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Algolia.SaveSynonymResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Algolia.SaveSynonymResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create or replace a synonym<br/>
        /// If a synonym with the specified object ID doesn't exist, Algolia adds a new one.<br/>
        /// Otherwise, the existing synonym is replaced.<br/>
        /// To add multiple synonyms in a single API request, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/save-synonyms).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Example: synonymID
        /// </param>
        /// <param name="forwardToReplicas"></param>
        /// <param name="requestObjectID">
        /// Unique identifier of a synonym object.<br/>
        /// Example: synonymID
        /// </param>
        /// <param name="type">
        /// Synonym type.<br/>
        /// Example: onewaysynonym
        /// </param>
        /// <param name="synonyms">
        /// Words or phrases considered equivalent.<br/>
        /// Example: [vehicle, auto]
        /// </param>
        /// <param name="input">
        /// Word or phrase to appear in query strings (for [`onewaysynonym`s](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/one-way-synonyms)).<br/>
        /// Example: car
        /// </param>
        /// <param name="word">
        /// Word or phrase to appear in query strings (for [`altcorrection1` and `altcorrection2`](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-alternative-corrections)).<br/>
        /// Example: car
        /// </param>
        /// <param name="corrections">
        /// Words to be matched in records.<br/>
        /// Example: [vehicle, auto]
        /// </param>
        /// <param name="placeholder">
        /// [Placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders) to be put inside records.<br/>
        /// Example: &lt;Street&gt;
        /// </param>
        /// <param name="replacements">
        /// Query words that will match the [placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders).<br/>
        /// Example: [street, st]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.SaveSynonymResponse> SaveSynonymAsync(
            string indexName,
            string objectID,
            string requestObjectID,
            global::Algolia.SynonymType type,
            bool? forwardToReplicas = default,
            global::System.Collections.Generic.IList<string>? synonyms = default,
            string? input = default,
            string? word = default,
            global::System.Collections.Generic.IList<string>? corrections = default,
            string? placeholder = default,
            global::System.Collections.Generic.IList<string>? replacements = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Algolia.SynonymHit
            {
                ObjectID = requestObjectID,
                Type = type,
                Synonyms = synonyms,
                Input = input,
                Word = word,
                Corrections = corrections,
                Placeholder = placeholder,
                Replacements = replacements,
            };

            return await SaveSynonymAsync(
                indexName: indexName,
                objectID: objectID,
                forwardToReplicas: forwardToReplicas,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}