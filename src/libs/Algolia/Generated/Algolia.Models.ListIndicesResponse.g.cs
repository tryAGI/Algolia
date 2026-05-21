
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListIndicesResponse
    {
        /// <summary>
        /// All indices in your Algolia application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Algolia.FetchedIndex> Items { get; set; }

        /// <summary>
        /// Number of pages.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbPages")]
        public int? NbPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListIndicesResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// All indices in your Algolia application.
        /// </param>
        /// <param name="nbPages">
        /// Number of pages.<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListIndicesResponse(
            global::System.Collections.Generic.IList<global::Algolia.FetchedIndex> items,
            int? nbPages)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NbPages = nbPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListIndicesResponse" /> class.
        /// </summary>
        public ListIndicesResponse()
        {
        }

    }
}