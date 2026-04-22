
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoryPrediction
    {
        /// <summary>
        /// Confidence level of the category prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.CategoryPredictionBinJsonConverter))]
        public global::Algolia.CategoryPredictionBin? Bin { get; set; }

        /// <summary>
        /// Ordered list of category levels from root to the predicted category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchyPath")]
        public global::System.Collections.Generic.IList<global::Algolia.HierarchyPathEntry>? HierarchyPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryPrediction" /> class.
        /// </summary>
        /// <param name="bin">
        /// Confidence level of the category prediction.
        /// </param>
        /// <param name="hierarchyPath">
        /// Ordered list of category levels from root to the predicted category.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CategoryPrediction(
            global::Algolia.CategoryPredictionBin? bin,
            global::System.Collections.Generic.IList<global::Algolia.HierarchyPathEntry>? hierarchyPath)
        {
            this.Bin = bin;
            this.HierarchyPath = hierarchyPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryPrediction" /> class.
        /// </summary>
        public CategoryPrediction()
        {
        }
    }
}