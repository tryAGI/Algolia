
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Dictionary type. If `null`, this dictionary type isn't supported for the language.
    /// </summary>
    public sealed partial class DictionaryLanguageVariant1
    {
        /// <summary>
        /// Number of custom dictionary entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbCustomEntries")]
        public int? NbCustomEntries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DictionaryLanguageVariant1" /> class.
        /// </summary>
        /// <param name="nbCustomEntries">
        /// Number of custom dictionary entries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DictionaryLanguageVariant1(
            int? nbCustomEntries)
        {
            this.NbCustomEntries = nbCustomEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DictionaryLanguageVariant1" /> class.
        /// </summary>
        public DictionaryLanguageVariant1()
        {
        }

    }
}