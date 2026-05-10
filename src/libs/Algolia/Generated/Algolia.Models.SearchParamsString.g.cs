
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Search parameters as query string.
    /// </summary>
    public sealed partial class SearchParamsString
    {
        /// <summary>
        /// Search parameters as a URL-encoded query string.<br/>
        /// Example: hitsPerPage=2&amp;getRankingInfo=1
        /// </summary>
        /// <example>hitsPerPage=2&amp;getRankingInfo=1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public string? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParamsString" /> class.
        /// </summary>
        /// <param name="params">
        /// Search parameters as a URL-encoded query string.<br/>
        /// Example: hitsPerPage=2&amp;getRankingInfo=1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchParamsString(
            string? @params)
        {
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParamsString" /> class.
        /// </summary>
        public SearchParamsString()
        {
        }

    }
}