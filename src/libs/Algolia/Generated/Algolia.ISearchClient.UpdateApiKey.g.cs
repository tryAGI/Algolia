#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Update an API key<br/>
        /// Replaces the permissions of an existing API key.<br/>
        /// Any unspecified attribute resets that attribute to its default value.
        /// </summary>
        /// <param name="key">
        /// Example: ALGOLIA_API_KEY
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdateApiKeyResponse> UpdateApiKeyAsync(
            string key,

            global::Algolia.ApiKey request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an API key<br/>
        /// Replaces the permissions of an existing API key.<br/>
        /// Any unspecified attribute resets that attribute to its default value.
        /// </summary>
        /// <param name="key">
        /// Example: ALGOLIA_API_KEY
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.AutoSDKHttpResponse<global::Algolia.UpdateApiKeyResponse>> UpdateApiKeyAsResponseAsync(
            string key,

            global::Algolia.ApiKey request,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an API key<br/>
        /// Replaces the permissions of an existing API key.<br/>
        /// Any unspecified attribute resets that attribute to its default value.
        /// </summary>
        /// <param name="key">
        /// Example: ALGOLIA_API_KEY
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdateApiKeyResponse> UpdateApiKeyAsync(
            string key,
            global::System.Collections.Generic.IList<global::Algolia.Acl> acl,
            string? description = default,
            global::System.Collections.Generic.IList<string>? indexes = default,
            int? maxHitsPerQuery = default,
            int? maxQueriesPerIPPerHour = default,
            string? queryParameters = default,
            global::System.Collections.Generic.IList<string>? referers = default,
            int? validity = default,
            global::Algolia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}