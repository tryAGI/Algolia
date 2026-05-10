
#nullable enable

namespace Algolia
{
    /// <summary>
    /// API key object.
    /// </summary>
    public sealed partial class ApiKey
    {
        /// <summary>
        /// Permissions that determine the type of API requests this key can make.<br/>
        /// The required ACL is listed in each endpoint's reference.<br/>
        /// For more information, see [access control list](https://www.algolia.com/doc/guides/security/api-keys/#access-control-list-acl).<br/>
        /// Default Value: []<br/>
        /// Example: [search, addObject]
        /// </summary>
        /// <example>[search, addObject]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("acl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.Acl> Acl { get; set; }

        /// <summary>
        /// Description of an API key to help you identify this API key.<br/>
        /// Example: Used for indexing by the CLI
        /// </summary>
        /// <example>Used for indexing by the CLI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Index names or patterns that this API key can access.<br/>
        /// By default, an API key can access all indices in the same application.<br/>
        /// You can use leading and trailing wildcard characters (`*`):<br/>
        /// - `dev_*` matches all indices starting with "dev_"<br/>
        /// - `*_dev` matches all indices ending with "_dev"<br/>
        /// - `*_products_*` matches all indices containing "_products_".<br/>
        /// Default Value: []<br/>
        /// Example: [dev_*, prod_en_products]
        /// </summary>
        /// <example>[dev_*, prod_en_products]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexes")]
        public global::System.Collections.Generic.IList<string>? Indexes { get; set; }

        /// <summary>
        /// Maximum number of results this API key can retrieve in one query.<br/>
        /// By default, there's no limit.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxHitsPerQuery")]
        public int? MaxHitsPerQuery { get; set; }

        /// <summary>
        /// Maximum number of API requests allowed per IP address or [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken) per hour.<br/>
        /// If this limit is reached, the API returns an error with status code `429`.<br/>
        /// By default, there's no limit.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxQueriesPerIPPerHour")]
        public int? MaxQueriesPerIPPerHour { get; set; }

        /// <summary>
        /// Query parameters to add when making API requests with this API key.<br/>
        /// To restrict this API key to specific IP addresses, add the `restrictSources` parameter.<br/>
        /// You can only add a single source, but you can provide a range of IP addresses.<br/>
        /// Creating an API key fails if the request is made from an IP address outside the restricted range.<br/>
        /// Example: typoTolerance=strict&amp;restrictSources=192.168.1.0/24
        /// </summary>
        /// <example>typoTolerance=strict&amp;restrictSources=192.168.1.0/24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryParameters")]
        public string? QueryParameters { get; set; }

        /// <summary>
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
        /// </summary>
        /// <example>[*algolia.com*]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("referers")]
        public global::System.Collections.Generic.IList<string>? Referers { get; set; }

        /// <summary>
        /// Duration (in seconds) after which the API key expires.<br/>
        /// By default, API keys don't expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 86400
        /// </summary>
        /// <example>86400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("validity")]
        public int? Validity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKey(
            global::System.Collections.Generic.IList<global::Algolia.Acl> acl,
            string? description,
            global::System.Collections.Generic.IList<string>? indexes,
            int? maxHitsPerQuery,
            int? maxQueriesPerIPPerHour,
            string? queryParameters,
            global::System.Collections.Generic.IList<string>? referers,
            int? validity)
        {
            this.Acl = acl ?? throw new global::System.ArgumentNullException(nameof(acl));
            this.Description = description;
            this.Indexes = indexes;
            this.MaxHitsPerQuery = maxHitsPerQuery;
            this.MaxQueriesPerIPPerHour = maxQueriesPerIPPerHour;
            this.QueryParameters = queryParameters;
            this.Referers = referers;
            this.Validity = validity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        public ApiKey()
        {
        }

    }
}