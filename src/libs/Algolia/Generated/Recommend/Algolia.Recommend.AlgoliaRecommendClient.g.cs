
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// ## Client libraries<br/>
    /// Use Algolia's API clients and libraries to reliably integrate Algolia's APIs with your apps.<br/>
    /// The official API clients are covered by Algolia's [Service Level Agreement](https://www.algolia.com/policies/sla).<br/>
    /// For more information, see [Algolia's ecosystem](https://www.algolia.com/doc/guides/getting-started/how-algolia-works/in-depth/ecosystem).<br/>
    /// ## Base URLs<br/>
    /// Base URLs for the Recommend API:<br/>
    /// - `https://{APPLICATION_ID}.algolia.net`<br/>
    /// - `https://{APPLICATION_ID}-dsn.algolia.net`.<br/>
    ///   If your subscription includes a [Distributed Search Network](https://dashboard.algolia.com/infra),<br/>
    ///   this ensures that requests are sent to servers closest to users.<br/>
    /// Both URLs provide high availability by distributing requests with load balancing.<br/>
    /// **All requests must use HTTPS.**<br/>
    /// ## Retry strategy<br/>
    /// To guarantee a high availability, implement a retry strategy for all API requests using the URLs of your servers as fallbacks:<br/>
    /// - `https://{APPLICATION_ID}-1.algolianet.com`<br/>
    /// - `https://{APPLICATION_ID}-2.algolianet.com`<br/>
    /// - `https://{APPLICATION_ID}-3.algolianet.com`<br/>
    /// These URLs use a different DNS provider than the primary URLs.<br/>
    /// Randomize this list to ensure an even load across the three servers.<br/>
    /// All Algolia API clients implement this retry strategy.<br/>
    /// ## Authentication<br/>
    /// Add these headers to authenticate requests:<br/>
    /// - `x-algolia-application-id`. Your Algolia application ID.<br/>
    /// - `x-algolia-api-key`. An API key with the necessary permissions to make the request.<br/>
    ///   The required access control list (ACL) to make a request is listed in each endpoint's reference.<br/>
    /// You can find your application ID and API key in the [Algolia dashboard](https://dashboard.algolia.com/account/api-keys).<br/>
    /// ## Request format<br/>
    /// Request bodies must be JSON objects.<br/>
    /// ## Response status and errors<br/>
    /// The Recommend API returns JSON responses.<br/>
    /// Since JSON doesn't guarantee any specific ordering, don't rely on the order of attributes in the API response.<br/>
    /// Successful responses return `2xx` statuses. Client errors return `4xx` statuses. Server errors return `5xx` statuses.<br/>
    /// Error responses have a `message` property with more information.<br/>
    /// ## Version<br/>
    /// The current version of the Recommend API is version 1, indicated by the `/1/` in each endpoint's URL.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class AlgoliaRecommendClient : global::Algolia.Recommend.IAlgoliaRecommendClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://algolia_application_id.algolia.net/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Algolia.Recommend.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Algolia.Recommend.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Algolia.Recommend.RecommendSourceGenerationContext.Default;


        /// <summary>
        /// 
        /// </summary>
        public RecommendClient Recommend => new RecommendClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the AlgoliaRecommendClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public AlgoliaRecommendClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Algolia.Recommend.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the AlgoliaRecommendClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public AlgoliaRecommendClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::Algolia.Recommend.EndPointAuthorization>? authorizations,
            global::Algolia.Recommend.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Algolia.Recommend.EndPointAuthorization>();
            Options = options ?? new global::Algolia.Recommend.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}