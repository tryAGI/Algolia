
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchForFacetValuesResponseFacetHit
    {
        /// <summary>
        /// Facet value.<br/>
        /// Example: Mobile phone
        /// </summary>
        /// <example>Mobile phone</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Highlighted attribute value, including HTML tags.<br/>
        /// Example: &lt;em&gt;George&lt;/em&gt; &lt;em&gt;Clo&lt;/em&gt;oney
        /// </summary>
        /// <example>&lt;em&gt;George&lt;/em&gt; &lt;em&gt;Clo&lt;/em&gt;oney</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlighted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Highlighted { get; set; }

        /// <summary>
        /// Number of records with this facet value. [The count may be approximated](https://support.algolia.com/hc/articles/4406975248145-Why-are-my-facet-and-hit-counts-not-accurate).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForFacetValuesResponseFacetHit" /> class.
        /// </summary>
        /// <param name="value">
        /// Facet value.<br/>
        /// Example: Mobile phone
        /// </param>
        /// <param name="highlighted">
        /// Highlighted attribute value, including HTML tags.<br/>
        /// Example: &lt;em&gt;George&lt;/em&gt; &lt;em&gt;Clo&lt;/em&gt;oney
        /// </param>
        /// <param name="count">
        /// Number of records with this facet value. [The count may be approximated](https://support.algolia.com/hc/articles/4406975248145-Why-are-my-facet-and-hit-counts-not-accurate).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchForFacetValuesResponseFacetHit(
            string value,
            string highlighted,
            int count)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Highlighted = highlighted ?? throw new global::System.ArgumentNullException(nameof(highlighted));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForFacetValuesResponseFacetHit" /> class.
        /// </summary>
        public SearchForFacetValuesResponseFacetHit()
        {
        }

    }
}