
#nullable enable

namespace Algolia
{
    /// <summary>
    /// Synonym object.
    /// </summary>
    public sealed partial class SynonymHit
    {
        /// <summary>
        /// Unique identifier of a synonym object.<br/>
        /// Example: synonymID
        /// </summary>
        /// <example>synonymID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectID { get; set; }

        /// <summary>
        /// Synonym type.<br/>
        /// Example: onewaysynonym
        /// </summary>
        /// <example>onewaysynonym</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.SynonymTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Algolia.SynonymType Type { get; set; }

        /// <summary>
        /// Words or phrases considered equivalent.<br/>
        /// Example: [vehicle, auto]
        /// </summary>
        /// <example>[vehicle, auto]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("synonyms")]
        public global::System.Collections.Generic.IList<string>? Synonyms { get; set; }

        /// <summary>
        /// Word or phrase to appear in query strings (for [`onewaysynonym`s](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/one-way-synonyms)).<br/>
        /// Example: car
        /// </summary>
        /// <example>car</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// Word or phrase to appear in query strings (for [`altcorrection1` and `altcorrection2`](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-alternative-corrections)).<br/>
        /// Example: car
        /// </summary>
        /// <example>car</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// Words to be matched in records.<br/>
        /// Example: [vehicle, auto]
        /// </summary>
        /// <example>[vehicle, auto]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("corrections")]
        public global::System.Collections.Generic.IList<string>? Corrections { get; set; }

        /// <summary>
        /// [Placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders) to be put inside records.<br/>
        /// Example: &lt;Street&gt;
        /// </summary>
        /// <example>&lt;Street&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder")]
        public string? Placeholder { get; set; }

        /// <summary>
        /// Query words that will match the [placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders).<br/>
        /// Example: [street, st]
        /// </summary>
        /// <example>[street, st]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacements")]
        public global::System.Collections.Generic.IList<string>? Replacements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SynonymHit" /> class.
        /// </summary>
        /// <param name="objectID">
        /// Unique identifier of a synonym object.<br/>
        /// Example: synonymID
        /// </param>
        /// <param name="type">
        /// Synonym type.<br/>
        /// Example: onewaysynonym
        /// </param>
        /// <param name="synonyms">
        /// Words or phrases considered equivalent.<br/>
        /// Example: [vehicle, auto]
        /// </param>
        /// <param name="input">
        /// Word or phrase to appear in query strings (for [`onewaysynonym`s](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/one-way-synonyms)).<br/>
        /// Example: car
        /// </param>
        /// <param name="word">
        /// Word or phrase to appear in query strings (for [`altcorrection1` and `altcorrection2`](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-alternative-corrections)).<br/>
        /// Example: car
        /// </param>
        /// <param name="corrections">
        /// Words to be matched in records.<br/>
        /// Example: [vehicle, auto]
        /// </param>
        /// <param name="placeholder">
        /// [Placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders) to be put inside records.<br/>
        /// Example: &lt;Street&gt;
        /// </param>
        /// <param name="replacements">
        /// Query words that will match the [placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders).<br/>
        /// Example: [street, st]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SynonymHit(
            string objectID,
            global::Algolia.SynonymType type,
            global::System.Collections.Generic.IList<string>? synonyms,
            string? input,
            string? word,
            global::System.Collections.Generic.IList<string>? corrections,
            string? placeholder,
            global::System.Collections.Generic.IList<string>? replacements)
        {
            this.ObjectID = objectID ?? throw new global::System.ArgumentNullException(nameof(objectID));
            this.Type = type;
            this.Synonyms = synonyms;
            this.Input = input;
            this.Word = word;
            this.Corrections = corrections;
            this.Placeholder = placeholder;
            this.Replacements = replacements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynonymHit" /> class.
        /// </summary>
        public SynonymHit()
        {
        }
    }
}