
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// [Redirect results to a URL](https://www.algolia.com/doc/guides/managing-results/rules/merchandising-and-promoting/how-to/redirects), this this parameter is for internal use only.
    /// </summary>
    public sealed partial class BaseSearchResponseRedirect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.RedirectRuleIndexMetadata>? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchResponseRedirect" /> class.
        /// </summary>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseSearchResponseRedirect(
            global::System.Collections.Generic.IList<global::Algolia.Recommend.RedirectRuleIndexMetadata>? index)
        {
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchResponseRedirect" /> class.
        /// </summary>
        public BaseSearchResponseRedirect()
        {
        }
    }
}