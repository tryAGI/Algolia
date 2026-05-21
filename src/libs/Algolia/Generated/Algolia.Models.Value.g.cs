
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Value
    {
        /// <summary>
        /// Explicit order of facets or facet values.<br/>
        /// This setting lets you always show specific facets or facet values at the top of the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public global::System.Collections.Generic.IList<string>? Order { get; set; }

        /// <summary>
        /// Order of facet values that aren't explicitly positioned with the `order` setting.<br/>
        /// - `count`.<br/>
        ///   Order remaining facet values by decreasing count.<br/>
        ///   The count is the number of matching records containing this facet value.<br/>
        /// - `alpha`.<br/>
        ///   Sort facet values alphabetically.<br/>
        /// - `hidden`.<br/>
        ///   Don't show facet values that aren't explicitly positioned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortRemainingBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.SortRemainingByJsonConverter))]
        public global::Algolia.SortRemainingBy? SortRemainingBy { get; set; }

        /// <summary>
        /// Hide facet values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide")]
        public global::System.Collections.Generic.IList<string>? Hide { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class.
        /// </summary>
        /// <param name="order">
        /// Explicit order of facets or facet values.<br/>
        /// This setting lets you always show specific facets or facet values at the top of the list.
        /// </param>
        /// <param name="sortRemainingBy">
        /// Order of facet values that aren't explicitly positioned with the `order` setting.<br/>
        /// - `count`.<br/>
        ///   Order remaining facet values by decreasing count.<br/>
        ///   The count is the number of matching records containing this facet value.<br/>
        /// - `alpha`.<br/>
        ///   Sort facet values alphabetically.<br/>
        /// - `hidden`.<br/>
        ///   Don't show facet values that aren't explicitly positioned.
        /// </param>
        /// <param name="hide">
        /// Hide facet values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Value(
            global::System.Collections.Generic.IList<string>? order,
            global::Algolia.SortRemainingBy? sortRemainingBy,
            global::System.Collections.Generic.IList<string>? hide)
        {
            this.Order = order;
            this.SortRemainingBy = sortRemainingBy;
            this.Hide = hide;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value" /> class.
        /// </summary>
        public Value()
        {
        }

    }
}