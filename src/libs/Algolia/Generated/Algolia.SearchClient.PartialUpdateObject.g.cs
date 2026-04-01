
#nullable enable

namespace Algolia
{
    public partial class SearchClient
    {
        partial void PreparePartialUpdateObjectArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexName,
            ref string objectID,
            ref bool? createIfNotExists,
            object request);
        partial void PreparePartialUpdateObjectRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexName,
            string objectID,
            bool? createIfNotExists,
            object request);
        partial void ProcessPartialUpdateObjectResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPartialUpdateObjectResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add or update attributes<br/>
        /// Adds new attributes to a record, or updates existing ones.<br/>
        /// - If a record with the specified object ID doesn't exist,<br/>
        ///   a new record is added to the index **if** `createIfNotExists` is true.<br/>
        /// - If the index doesn't exist yet, this method creates a new index.<br/>
        /// - Use first-level attributes only. Nested attributes aren't supported.<br/>
        ///   If you specify a nested attribute, this operation replaces its first-level ancestor.<br/>
        /// To update attributes without replacing the full record, use these built-in operations.<br/>
        /// These operations are useful when the initial data isn't available.<br/>
        /// - `Increment`: increment a numeric attribute.<br/>
        /// - `Decrement`: decrement a numeric attribute.<br/>
        /// - `Add`: append a number or string element to an array attribute.<br/>
        /// - `Remove`: remove all matching number or string elements from an array attribute made of numbers or strings.<br/>
        /// - `AddUnique`: add a number or string element to an array attribute made of numbers or strings only if it's not already present.<br/>
        /// - `IncrementFrom`: increment a numeric integer attribute only if the provided value matches the current value. Otherwise, the update is ignored.<br/>
        ///   Example: If you pass an `IncrementFrom` value of 2 for the `version` attribute but the current value is 1, the API ignores the update.<br/>
        ///   If the object doesn't exist, the API only creates it if you pass an `IncrementFrom` value of 0.<br/>
        /// - `IncrementSet`: increment a numeric integer attribute only if the provided value is greater than the current value. Otherwise, the update is ignored.<br/>
        ///   Example: If you pass an `IncrementSet` value of 2 for the `version` attribute and the current value is 1, the API updates the object.<br/>
        ///   If the object doesn't exist yet, the API only creates it if you pass an `IncrementSet` value greater than 0.<br/>
        /// Specify an operation by providing an object with the attribute to update as the key and its value as an object with these properties:<br/>
        /// - `_operation`: the operation to apply on the attribute.<br/>
        /// - `value`: the right-hand side argument to the operation, for example, increment or decrement step, or a value to add or remove.<br/>
        /// When updating multiple attributes or using multiple operations targeting the same record, use a single partial update for faster processing.<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="createIfNotExists">
        /// Default Value: true
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.PartialUpdateObjectResponse> PartialUpdateObjectAsync(
            string indexName,
            string objectID,

            object request,
            bool? createIfNotExists = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePartialUpdateObjectArguments(
                httpClient: HttpClient,
                indexName: ref indexName,
                objectID: ref objectID,
                createIfNotExists: ref createIfNotExists,
                request: request);

            var __pathBuilder = new global::Algolia.PathBuilder(
                path: $"/1/indexes/{indexName}/{objectID}/partial",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("createIfNotExists", createIfNotExists?.ToString().ToLowerInvariant()) 
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
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePartialUpdateObjectRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                indexName: indexName,
                objectID: objectID,
                createIfNotExists: createIfNotExists,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPartialUpdateObjectResponse(
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
                ProcessPartialUpdateObjectResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Algolia.PartialUpdateObjectResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Algolia.PartialUpdateObjectResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Add or update attributes<br/>
        /// Adds new attributes to a record, or updates existing ones.<br/>
        /// - If a record with the specified object ID doesn't exist,<br/>
        ///   a new record is added to the index **if** `createIfNotExists` is true.<br/>
        /// - If the index doesn't exist yet, this method creates a new index.<br/>
        /// - Use first-level attributes only. Nested attributes aren't supported.<br/>
        ///   If you specify a nested attribute, this operation replaces its first-level ancestor.<br/>
        /// To update attributes without replacing the full record, use these built-in operations.<br/>
        /// These operations are useful when the initial data isn't available.<br/>
        /// - `Increment`: increment a numeric attribute.<br/>
        /// - `Decrement`: decrement a numeric attribute.<br/>
        /// - `Add`: append a number or string element to an array attribute.<br/>
        /// - `Remove`: remove all matching number or string elements from an array attribute made of numbers or strings.<br/>
        /// - `AddUnique`: add a number or string element to an array attribute made of numbers or strings only if it's not already present.<br/>
        /// - `IncrementFrom`: increment a numeric integer attribute only if the provided value matches the current value. Otherwise, the update is ignored.<br/>
        ///   Example: If you pass an `IncrementFrom` value of 2 for the `version` attribute but the current value is 1, the API ignores the update.<br/>
        ///   If the object doesn't exist, the API only creates it if you pass an `IncrementFrom` value of 0.<br/>
        /// - `IncrementSet`: increment a numeric integer attribute only if the provided value is greater than the current value. Otherwise, the update is ignored.<br/>
        ///   Example: If you pass an `IncrementSet` value of 2 for the `version` attribute and the current value is 1, the API updates the object.<br/>
        ///   If the object doesn't exist yet, the API only creates it if you pass an `IncrementSet` value greater than 0.<br/>
        /// Specify an operation by providing an object with the attribute to update as the key and its value as an object with these properties:<br/>
        /// - `_operation`: the operation to apply on the attribute.<br/>
        /// - `value`: the right-hand side argument to the operation, for example, increment or decrement step, or a value to add or remove.<br/>
        /// When updating multiple attributes or using multiple operations targeting the same record, use a single partial update for faster processing.<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="objectID">
        /// Unique record identifier.<br/>
        /// Example: test-record-123
        /// </param>
        /// <param name="createIfNotExists">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Algolia.PartialUpdateObjectResponse> PartialUpdateObjectAsync(
            string indexName,
            string objectID,
            bool? createIfNotExists = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new object
            {
            };

            return await PartialUpdateObjectAsync(
                indexName: indexName,
                objectID: objectID,
                createIfNotExists: createIfNotExists,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}