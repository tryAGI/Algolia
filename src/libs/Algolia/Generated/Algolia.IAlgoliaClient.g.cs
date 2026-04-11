
#nullable enable

namespace Algolia
{
    /// <summary>
    /// ## Client libraries<br/>
    /// Use Algolia's API clients and libraries to reliably integrate Algolia's APIs with your apps.<br/>
    /// The official API clients are covered by Algolia's [Service Level Agreement](https://www.algolia.com/policies/sla).<br/>
    /// For more information, see [Algolia's ecosystem](https://www.algolia.com/doc/guides/getting-started/how-algolia-works/in-depth/ecosystem).<br/>
    /// ## Base URLs<br/>
    /// Base URLs for the Search API:<br/>
    /// - `https://{APPLICATION_ID}.algolia.net`<br/>
    /// - `https://{APPLICATION_ID}-dsn.algolia.net`.<br/>
    ///   If your subscription includes a [Distributed Search Network](https://dashboard.algolia.com/infra),<br/>
    ///   this ensures that requests are sent to servers closest to users.<br/>
    /// Both URLs provide high availability by distributing requests with load balancing.<br/>
    /// **All requests must use HTTPS.**<br/>
    /// ## Retry strategy<br/>
    /// To guarantee high availability, implement a retry strategy for all API requests using the URLs of your servers as fallbacks:<br/>
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
    /// Depending on the endpoint, request bodies are either JSON objects or arrays of JSON objects.<br/>
    /// ## Parameters<br/>
    /// Parameters are passed as query parameters for GET and DELETE requests,<br/>
    /// and in the request body for POST and PUT requests.<br/>
    /// Query parameters must be [URL-encoded](https://developer.mozilla.org/en-US/docs/Glossary/Percent-encoding).<br/>
    /// Non-ASCII characters must be UTF-8 encoded.<br/>
    /// Plus characters (`+`) are interpreted as spaces.<br/>
    /// Arrays as query parameters must be one of:<br/>
    /// - A comma-separated string: `attributesToRetrieve=title,description`<br/>
    /// - A URL-encoded JSON array: `attributesToRetrieve=%5B%22title%22,%22description%22%D`<br/>
    /// ## Response status and errors<br/>
    /// The Search API returns JSON responses.<br/>
    /// Since JSON doesn't guarantee any specific ordering, don't rely on the order of attributes in the API response.<br/>
    /// Successful responses return `2xx` statuses. Client errors return `4xx` statuses. Server errors return `5xx` statuses.<br/>
    /// Error responses have a `message` property with more information.<br/>
    /// ## Version<br/>
    /// The current version of the Search API is version 1, indicated by the `/1/` in each endpoint's URL.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IAlgoliaClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Algolia.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Algolia.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search { get; }

    }
}