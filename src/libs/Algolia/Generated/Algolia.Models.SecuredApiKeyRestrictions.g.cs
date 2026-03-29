
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecuredApiKeyRestrictions
    {
        /// <summary>
        /// Each parameter value, including the `query` must not be larger than 512 bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchParams")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.SearchParamsObjectJsonConverter))]
        public global::Algolia.SearchParamsObject? SearchParams { get; set; }

        /// <summary>
        /// Filters that apply to every search made with the secured API key.<br/>
        /// Extra filters added at search time will be combined with `AND`.<br/>
        /// For example, if you set `group:admin` as fixed filter on your generated API key,<br/>
        /// and add `groups:visitors` to the search query, the complete set of filters will be `group:admin AND groups:visitors`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public string? Filters { get; set; }

        /// <summary>
        /// Timestamp when the secured API key expires, measured in seconds since the Unix epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validUntil")]
        public long? ValidUntil { get; set; }

        /// <summary>
        /// Index names or patterns that this API key can access.<br/>
        /// By default, an API key can access all indices in the same application.<br/>
        /// You can use leading and trailing wildcard characters (`*`):<br/>
        /// - `dev_*` matches all indices starting with "dev_"<br/>
        /// - `*_dev` matches all indices ending with "_dev"<br/>
        /// - `*_products_*` matches all indices containing "_products_".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictIndices")]
        public global::System.Collections.Generic.IList<string>? RestrictIndices { get; set; }

        /// <summary>
        /// IP network that are allowed to use this key.<br/>
        /// You can only add a single source, but you can provide a range of IP addresses.<br/>
        /// Use this to protect against API key leaking and reuse.<br/>
        /// Example: 192.168.1.0/24
        /// </summary>
        /// <example>192.168.1.0/24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictSources")]
        public string? RestrictSources { get; set; }

        /// <summary>
        /// Pseudonymous user identifier to restrict usage of this API key to specific users.<br/>
        /// By default, rate limits are set based on IP addresses. This can be an issue if many users search from the same IP address.<br/>
        /// To avoid this, add a user token to each generated API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userToken")]
        public string? UserToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecuredApiKeyRestrictions" /> class.
        /// </summary>
        /// <param name="searchParams">
        /// Each parameter value, including the `query` must not be larger than 512 bytes.
        /// </param>
        /// <param name="filters">
        /// Filters that apply to every search made with the secured API key.<br/>
        /// Extra filters added at search time will be combined with `AND`.<br/>
        /// For example, if you set `group:admin` as fixed filter on your generated API key,<br/>
        /// and add `groups:visitors` to the search query, the complete set of filters will be `group:admin AND groups:visitors`.
        /// </param>
        /// <param name="validUntil">
        /// Timestamp when the secured API key expires, measured in seconds since the Unix epoch.
        /// </param>
        /// <param name="restrictIndices">
        /// Index names or patterns that this API key can access.<br/>
        /// By default, an API key can access all indices in the same application.<br/>
        /// You can use leading and trailing wildcard characters (`*`):<br/>
        /// - `dev_*` matches all indices starting with "dev_"<br/>
        /// - `*_dev` matches all indices ending with "_dev"<br/>
        /// - `*_products_*` matches all indices containing "_products_".
        /// </param>
        /// <param name="restrictSources">
        /// IP network that are allowed to use this key.<br/>
        /// You can only add a single source, but you can provide a range of IP addresses.<br/>
        /// Use this to protect against API key leaking and reuse.<br/>
        /// Example: 192.168.1.0/24
        /// </param>
        /// <param name="userToken">
        /// Pseudonymous user identifier to restrict usage of this API key to specific users.<br/>
        /// By default, rate limits are set based on IP addresses. This can be an issue if many users search from the same IP address.<br/>
        /// To avoid this, add a user token to each generated API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecuredApiKeyRestrictions(
            global::Algolia.SearchParamsObject? searchParams,
            string? filters,
            long? validUntil,
            global::System.Collections.Generic.IList<string>? restrictIndices,
            string? restrictSources,
            string? userToken)
        {
            this.SearchParams = searchParams;
            this.Filters = filters;
            this.ValidUntil = validUntil;
            this.RestrictIndices = restrictIndices;
            this.RestrictSources = restrictSources;
            this.UserToken = userToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecuredApiKeyRestrictions" /> class.
        /// </summary>
        public SecuredApiKeyRestrictions()
        {
        }
    }
}