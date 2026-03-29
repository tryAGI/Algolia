
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseIndexSettings
    {
        /// <summary>
        /// Attributes used for [faceting](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting).<br/>
        /// Facets are attributes that let you categorize search results.<br/>
        /// They can be used for filtering search results.<br/>
        /// By default, no attribute is used for faceting.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// **Modifiers**<br/>
        /// - `filterOnly("ATTRIBUTE")`.<br/>
        ///   Allows the attribute to be used as a filter but doesn't evaluate the facet values.<br/>
        /// - `searchable("ATTRIBUTE")`.<br/>
        ///   Allows searching for facet values.<br/>
        /// - `afterDistinct("ATTRIBUTE")`.<br/>
        ///   Evaluates the facet count _after_ deduplication with `distinct`.<br/>
        ///   This ensures accurate facet counts.<br/>
        ///   You can apply this modifier to searchable facets: `afterDistinct(searchable(ATTRIBUTE))`.<br/>
        /// Default Value: []<br/>
        /// Example: [author, filterOnly(isbn), searchable(edition), afterDistinct(category), afterDistinct(searchable(publisher))]
        /// </summary>
        /// <example>[author, filterOnly(isbn), searchable(edition), afterDistinct(category), afterDistinct(searchable(publisher))]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributesForFaceting")]
        public global::System.Collections.Generic.IList<string>? AttributesForFaceting { get; set; }

        /// <summary>
        /// Creates [replica indices](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/replicas).<br/>
        /// Replicas are copies of a primary index with the same records but different settings, synonyms, or rules.<br/>
        /// If you want to offer a different ranking or sorting of your search results, you'll use replica indices.<br/>
        /// All index operations on a primary index are automatically forwarded to its replicas.<br/>
        /// To add a replica index, you must provide the complete set of replicas to this parameter.<br/>
        /// If you omit a replica from this list, the replica turns into a regular, standalone index that will no longer be synced with the primary index.<br/>
        /// **Modifier**<br/>
        /// - `virtual("REPLICA")`.<br/>
        ///   Create a virtual replica,<br/>
        ///   Virtual replicas don't increase the number of records and are optimized for [Relevant sorting](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/relevant-sort).<br/>
        /// Default Value: []<br/>
        /// Example: [virtual(prod_products_price_asc), dev_products_replica]
        /// </summary>
        /// <example>[virtual(prod_products_price_asc), dev_products_replica]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public global::System.Collections.Generic.IList<string>? Replicas { get; set; }

        /// <summary>
        /// Maximum number of search results that can be obtained through pagination.<br/>
        /// Higher pagination limits might slow down your search.<br/>
        /// For pagination limits above 1,000, the sorting of results beyond the 1,000th hit can't be guaranteed.<br/>
        /// Default Value: 1000<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("paginationLimitedTo")]
        public int? PaginationLimitedTo { get; set; }

        /// <summary>
        /// Attributes that can't be retrieved at query time.<br/>
        /// This can be useful if you want to use an attribute for ranking or to [restrict access](https://www.algolia.com/doc/guides/security/api-keys/how-to/user-restricted-access-to-data),<br/>
        /// but don't want to include it in the search results.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Default Value: []<br/>
        /// Example: [total_sales]
        /// </summary>
        /// <example>[total_sales]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unretrievableAttributes")]
        public global::System.Collections.Generic.IList<string>? UnretrievableAttributes { get; set; }

        /// <summary>
        /// Creates a list of [words which require exact matches](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#turn-off-typo-tolerance-for-certain-words).<br/>
        /// This also turns off [word splitting and concatenation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/splitting-and-concatenation) for the specified words.<br/>
        /// Default Value: []<br/>
        /// Example: [wheel, 1X2BCD]
        /// </summary>
        /// <example>[wheel, 1X2BCD]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableTypoToleranceOnWords")]
        public global::System.Collections.Generic.IList<string>? DisableTypoToleranceOnWords { get; set; }

        /// <summary>
        /// Attributes, for which you want to support [Japanese transliteration](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations/#japanese-transliteration-and-type-ahead).<br/>
        /// Transliteration supports searching in any of the Japanese writing systems.<br/>
        /// To support transliteration, you must set the indexing language to Japanese.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Example: [name, description]
        /// </summary>
        /// <example>[name, description]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributesToTransliterate")]
        public global::System.Collections.Generic.IList<string>? AttributesToTransliterate { get; set; }

        /// <summary>
        /// Attributes for which to split [camel case](https://wikipedia.org/wiki/Camel_case) words.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Default Value: []<br/>
        /// Example: [description]
        /// </summary>
        /// <example>[description]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("camelCaseAttributes")]
        public global::System.Collections.Generic.IList<string>? CamelCaseAttributes { get; set; }

        /// <summary>
        /// Searchable attributes to which Algolia should apply [word segmentation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/how-to/customize-segmentation) (decompounding).<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Compound words are formed by combining two or more individual words,<br/>
        /// and are particularly prevalent in Germanic languages—for example, "firefighter".<br/>
        /// With decompounding, the individual components are indexed separately.<br/>
        /// You can specify different lists for different languages.<br/>
        /// Decompounding is supported for these languages:<br/>
        /// Dutch (`nl`), German (`de`), Finnish (`fi`), Danish (`da`), Swedish (`sv`), and Norwegian (`no`).<br/>
        /// Decompounding doesn't work for words with [non-spacing mark Unicode characters](https://www.charactercodes.net/category/non-spacing_mark).<br/>
        /// For example, `Gartenstühle` won't be decompounded if the `ü` consists of `u` (U+0075) and `◌̈` (U+0308).<br/>
        /// Default Value: {}<br/>
        /// Example: {"de":["name"]}
        /// </summary>
        /// <example>{"de":["name"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("decompoundedAttributes")]
        public object? DecompoundedAttributes { get; set; }

        /// <summary>
        /// Languages for language-specific processing steps, such as word detection and dictionary settings.<br/>
        /// **Always specify an indexing language.**<br/>
        /// If you don't specify an indexing language, the search engine uses all [supported languages](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages),<br/>
        /// or the languages you specified with the `ignorePlurals` or `removeStopWords` parameters.<br/>
        /// This can lead to unexpected search results.<br/>
        /// For more information, see [Language-specific configuration](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations).<br/>
        /// Default Value: []<br/>
        /// Example: [ja]
        /// </summary>
        /// <example>[ja]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexLanguages")]
        public global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? IndexLanguages { get; set; }

        /// <summary>
        /// Searchable attributes for which you want to turn off [prefix matching](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/#adjusting-prefix-search).<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Default Value: []<br/>
        /// Example: [sku]
        /// </summary>
        /// <example>[sku]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disablePrefixOnAttributes")]
        public global::System.Collections.Generic.IList<string>? DisablePrefixOnAttributes { get; set; }

        /// <summary>
        /// Whether arrays with exclusively non-negative integers should be compressed for better performance.<br/>
        /// If true, the compressed arrays may be reordered.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowCompressionOfIntegerArray")]
        public bool? AllowCompressionOfIntegerArray { get; set; }

        /// <summary>
        /// Numeric attributes that can be used as [numerical filters](https://www.algolia.com/doc/guides/managing-results/rules/detecting-intent/how-to/applying-a-custom-filter-for-a-specific-query/#numerical-filters).<br/>
        /// Attribute names are case-sensitive.<br/>
        /// By default, all numeric attributes are available as numerical filters.<br/>
        /// For faster indexing, reduce the number of numeric attributes.<br/>
        /// To turn off filtering for all numeric attributes, specify an attribute that doesn't exist in your index, such as `NO_NUMERIC_FILTERING`.<br/>
        /// **Modifier**<br/>
        /// - `equalOnly("ATTRIBUTE")`.<br/>
        ///   Support only filtering based on equality comparisons `=` and `!=`.<br/>
        /// Default Value: []<br/>
        /// Example: [equalOnly(quantity), popularity]
        /// </summary>
        /// <example>[equalOnly(quantity), popularity]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numericAttributesForFiltering")]
        public global::System.Collections.Generic.IList<string>? NumericAttributesForFiltering { get; set; }

        /// <summary>
        /// Control which non-alphanumeric characters are indexed.<br/>
        /// By default, Algolia ignores [non-alphanumeric characters](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/how-to/how-to-search-in-hyphenated-attributes/#handling-non-alphanumeric-characters) like hyphen (`-`), plus (`+`), and parentheses (`(`,`)`).<br/>
        /// To include such characters, define them with `separatorsToIndex`.<br/>
        /// Separators are all non-letter characters except spaces and currency characters, such as $€£¥.<br/>
        /// With `separatorsToIndex`, Algolia treats separator characters as separate words.<br/>
        /// For example, in a search for "Disney+", Algolia considers "Disney" and "+" as two separate words.<br/>
        /// Example: +#
        /// </summary>
        /// <example>+#</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("separatorsToIndex")]
        public string? SeparatorsToIndex { get; set; }

        /// <summary>
        /// Attributes used for searching. Attribute names are case-sensitive.<br/>
        /// By default, all attributes are searchable and the [Attribute](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#attribute) ranking criterion is turned off.<br/>
        /// With a non-empty list, Algolia only returns results with matches in the selected attributes.<br/>
        /// In addition, the Attribute ranking criterion is turned on: matches in attributes that are higher in the list of `searchableAttributes` rank first.<br/>
        /// To make matches in two attributes rank equally, include them in a comma-separated string, such as `"title,alternate_title"`.<br/>
        /// Attributes with the same priority are always unordered.<br/>
        /// For more information, see [Searchable attributes](https://www.algolia.com/doc/guides/sending-and-managing-data/prepare-your-data/how-to/setting-searchable-attributes).<br/>
        /// **Modifier**<br/>
        /// - `unordered("ATTRIBUTE")`.<br/>
        ///   Ignore the position of a match within the attribute.<br/>
        /// Without a modifier, matches at the beginning of an attribute rank higher than matches at the end.<br/>
        /// Default Value: []<br/>
        /// Example: [title,alternative_title, author, unordered(text), emails.personal]
        /// </summary>
        /// <example>[title,alternative_title, author, unordered(text), emails.personal]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchableAttributes")]
        public global::System.Collections.Generic.IList<string>? SearchableAttributes { get; set; }

        /// <summary>
        /// An object with custom data.<br/>
        /// You can store up to 32kB as custom data.<br/>
        /// Default Value: {}<br/>
        /// Example: {"settingID":"f2a7b51e3503acc6a39b3784ffb84300","pluginVersion":"1.6.0"}
        /// </summary>
        /// <example>{"settingID":"f2a7b51e3503acc6a39b3784ffb84300","pluginVersion":"1.6.0"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userData")]
        public global::Algolia.UserData? UserData { get; set; }

        /// <summary>
        /// Characters and their normalized replacements.<br/>
        /// This overrides Algolia's default [normalization](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/normalization).<br/>
        /// Example: {"default":{"\u00E4":"ae","\u00FC":"ue"}}
        /// </summary>
        /// <example>{"default":{"\u00E4":"ae","\u00FC":"ue"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("customNormalization")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? CustomNormalization { get; set; }

        /// <summary>
        /// Attribute that should be used to establish groups of results.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// All records with the same value for this attribute are considered a group.<br/>
        /// You can combine `attributeForDistinct` with the `distinct` search parameter to control<br/>
        /// how many items per group are included in the search results.<br/>
        /// If you want to use the same attribute also for faceting, use the `afterDistinct` modifier of the `attributesForFaceting` setting.<br/>
        /// This applies faceting _after_ deduplication, which will result in accurate facet counts.<br/>
        /// Example: url
        /// </summary>
        /// <example>url</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributeForDistinct")]
        public string? AttributeForDistinct { get; set; }

        /// <summary>
        /// Maximum number of facet values to return when [searching for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxFacetHits")]
        public int? MaxFacetHits { get; set; }

        /// <summary>
        /// Characters for which diacritics should be preserved.<br/>
        /// By default, Algolia removes diacritics from letters.<br/>
        /// For example, `é` becomes `e`. If this causes issues in your search,<br/>
        /// you can specify characters that should keep their diacritics.<br/>
        /// Example: øé
        /// </summary>
        /// <example>øé</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepDiacriticsOnCharacters")]
        public string? KeepDiacriticsOnCharacters { get; set; }

        /// <summary>
        /// Attributes to use as [custom ranking](https://www.algolia.com/doc/guides/managing-results/must-do/custom-ranking).<br/>
        /// Attribute names are case-sensitive.<br/>
        /// The custom ranking attributes decide which items are shown first if the other ranking criteria are equal.<br/>
        /// Records with missing values for your selected custom ranking attributes are always sorted last.<br/>
        /// Boolean attributes are sorted based on their alphabetical order.<br/>
        /// **Modifiers**<br/>
        /// - `asc("ATTRIBUTE")`.<br/>
        ///   Sort the index by the values of an attribute, in ascending order.<br/>
        /// - `desc("ATTRIBUTE")`.<br/>
        ///   Sort the index by the values of an attribute, in descending order.<br/>
        /// If you use two or more custom ranking attributes,<br/>
        /// [reduce the precision](https://www.algolia.com/doc/guides/managing-results/must-do/custom-ranking/how-to/controlling-custom-ranking-metrics-precision) of your first attributes,<br/>
        /// or the other attributes will never be applied.<br/>
        /// Default Value: []<br/>
        /// Example: [desc(popularity), asc(price)]
        /// </summary>
        /// <example>[desc(popularity), asc(price)]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("customRanking")]
        public global::System.Collections.Generic.IList<string>? CustomRanking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseIndexSettings" /> class.
        /// </summary>
        /// <param name="attributesForFaceting">
        /// Attributes used for [faceting](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting).<br/>
        /// Facets are attributes that let you categorize search results.<br/>
        /// They can be used for filtering search results.<br/>
        /// By default, no attribute is used for faceting.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// **Modifiers**<br/>
        /// - `filterOnly("ATTRIBUTE")`.<br/>
        ///   Allows the attribute to be used as a filter but doesn't evaluate the facet values.<br/>
        /// - `searchable("ATTRIBUTE")`.<br/>
        ///   Allows searching for facet values.<br/>
        /// - `afterDistinct("ATTRIBUTE")`.<br/>
        ///   Evaluates the facet count _after_ deduplication with `distinct`.<br/>
        ///   This ensures accurate facet counts.<br/>
        ///   You can apply this modifier to searchable facets: `afterDistinct(searchable(ATTRIBUTE))`.<br/>
        /// Default Value: []<br/>
        /// Example: [author, filterOnly(isbn), searchable(edition), afterDistinct(category), afterDistinct(searchable(publisher))]
        /// </param>
        /// <param name="replicas">
        /// Creates [replica indices](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/replicas).<br/>
        /// Replicas are copies of a primary index with the same records but different settings, synonyms, or rules.<br/>
        /// If you want to offer a different ranking or sorting of your search results, you'll use replica indices.<br/>
        /// All index operations on a primary index are automatically forwarded to its replicas.<br/>
        /// To add a replica index, you must provide the complete set of replicas to this parameter.<br/>
        /// If you omit a replica from this list, the replica turns into a regular, standalone index that will no longer be synced with the primary index.<br/>
        /// **Modifier**<br/>
        /// - `virtual("REPLICA")`.<br/>
        ///   Create a virtual replica,<br/>
        ///   Virtual replicas don't increase the number of records and are optimized for [Relevant sorting](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/relevant-sort).<br/>
        /// Default Value: []<br/>
        /// Example: [virtual(prod_products_price_asc), dev_products_replica]
        /// </param>
        /// <param name="paginationLimitedTo">
        /// Maximum number of search results that can be obtained through pagination.<br/>
        /// Higher pagination limits might slow down your search.<br/>
        /// For pagination limits above 1,000, the sorting of results beyond the 1,000th hit can't be guaranteed.<br/>
        /// Default Value: 1000<br/>
        /// Example: 100
        /// </param>
        /// <param name="unretrievableAttributes">
        /// Attributes that can't be retrieved at query time.<br/>
        /// This can be useful if you want to use an attribute for ranking or to [restrict access](https://www.algolia.com/doc/guides/security/api-keys/how-to/user-restricted-access-to-data),<br/>
        /// but don't want to include it in the search results.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Default Value: []<br/>
        /// Example: [total_sales]
        /// </param>
        /// <param name="disableTypoToleranceOnWords">
        /// Creates a list of [words which require exact matches](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#turn-off-typo-tolerance-for-certain-words).<br/>
        /// This also turns off [word splitting and concatenation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/splitting-and-concatenation) for the specified words.<br/>
        /// Default Value: []<br/>
        /// Example: [wheel, 1X2BCD]
        /// </param>
        /// <param name="attributesToTransliterate">
        /// Attributes, for which you want to support [Japanese transliteration](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations/#japanese-transliteration-and-type-ahead).<br/>
        /// Transliteration supports searching in any of the Japanese writing systems.<br/>
        /// To support transliteration, you must set the indexing language to Japanese.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Example: [name, description]
        /// </param>
        /// <param name="camelCaseAttributes">
        /// Attributes for which to split [camel case](https://wikipedia.org/wiki/Camel_case) words.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Default Value: []<br/>
        /// Example: [description]
        /// </param>
        /// <param name="decompoundedAttributes">
        /// Searchable attributes to which Algolia should apply [word segmentation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/how-to/customize-segmentation) (decompounding).<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Compound words are formed by combining two or more individual words,<br/>
        /// and are particularly prevalent in Germanic languages—for example, "firefighter".<br/>
        /// With decompounding, the individual components are indexed separately.<br/>
        /// You can specify different lists for different languages.<br/>
        /// Decompounding is supported for these languages:<br/>
        /// Dutch (`nl`), German (`de`), Finnish (`fi`), Danish (`da`), Swedish (`sv`), and Norwegian (`no`).<br/>
        /// Decompounding doesn't work for words with [non-spacing mark Unicode characters](https://www.charactercodes.net/category/non-spacing_mark).<br/>
        /// For example, `Gartenstühle` won't be decompounded if the `ü` consists of `u` (U+0075) and `◌̈` (U+0308).<br/>
        /// Default Value: {}<br/>
        /// Example: {"de":["name"]}
        /// </param>
        /// <param name="indexLanguages">
        /// Languages for language-specific processing steps, such as word detection and dictionary settings.<br/>
        /// **Always specify an indexing language.**<br/>
        /// If you don't specify an indexing language, the search engine uses all [supported languages](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages),<br/>
        /// or the languages you specified with the `ignorePlurals` or `removeStopWords` parameters.<br/>
        /// This can lead to unexpected search results.<br/>
        /// For more information, see [Language-specific configuration](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations).<br/>
        /// Default Value: []<br/>
        /// Example: [ja]
        /// </param>
        /// <param name="disablePrefixOnAttributes">
        /// Searchable attributes for which you want to turn off [prefix matching](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/#adjusting-prefix-search).<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Default Value: []<br/>
        /// Example: [sku]
        /// </param>
        /// <param name="allowCompressionOfIntegerArray">
        /// Whether arrays with exclusively non-negative integers should be compressed for better performance.<br/>
        /// If true, the compressed arrays may be reordered.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="numericAttributesForFiltering">
        /// Numeric attributes that can be used as [numerical filters](https://www.algolia.com/doc/guides/managing-results/rules/detecting-intent/how-to/applying-a-custom-filter-for-a-specific-query/#numerical-filters).<br/>
        /// Attribute names are case-sensitive.<br/>
        /// By default, all numeric attributes are available as numerical filters.<br/>
        /// For faster indexing, reduce the number of numeric attributes.<br/>
        /// To turn off filtering for all numeric attributes, specify an attribute that doesn't exist in your index, such as `NO_NUMERIC_FILTERING`.<br/>
        /// **Modifier**<br/>
        /// - `equalOnly("ATTRIBUTE")`.<br/>
        ///   Support only filtering based on equality comparisons `=` and `!=`.<br/>
        /// Default Value: []<br/>
        /// Example: [equalOnly(quantity), popularity]
        /// </param>
        /// <param name="separatorsToIndex">
        /// Control which non-alphanumeric characters are indexed.<br/>
        /// By default, Algolia ignores [non-alphanumeric characters](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/how-to/how-to-search-in-hyphenated-attributes/#handling-non-alphanumeric-characters) like hyphen (`-`), plus (`+`), and parentheses (`(`,`)`).<br/>
        /// To include such characters, define them with `separatorsToIndex`.<br/>
        /// Separators are all non-letter characters except spaces and currency characters, such as $€£¥.<br/>
        /// With `separatorsToIndex`, Algolia treats separator characters as separate words.<br/>
        /// For example, in a search for "Disney+", Algolia considers "Disney" and "+" as two separate words.<br/>
        /// Example: +#
        /// </param>
        /// <param name="searchableAttributes">
        /// Attributes used for searching. Attribute names are case-sensitive.<br/>
        /// By default, all attributes are searchable and the [Attribute](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#attribute) ranking criterion is turned off.<br/>
        /// With a non-empty list, Algolia only returns results with matches in the selected attributes.<br/>
        /// In addition, the Attribute ranking criterion is turned on: matches in attributes that are higher in the list of `searchableAttributes` rank first.<br/>
        /// To make matches in two attributes rank equally, include them in a comma-separated string, such as `"title,alternate_title"`.<br/>
        /// Attributes with the same priority are always unordered.<br/>
        /// For more information, see [Searchable attributes](https://www.algolia.com/doc/guides/sending-and-managing-data/prepare-your-data/how-to/setting-searchable-attributes).<br/>
        /// **Modifier**<br/>
        /// - `unordered("ATTRIBUTE")`.<br/>
        ///   Ignore the position of a match within the attribute.<br/>
        /// Without a modifier, matches at the beginning of an attribute rank higher than matches at the end.<br/>
        /// Default Value: []<br/>
        /// Example: [title,alternative_title, author, unordered(text), emails.personal]
        /// </param>
        /// <param name="userData">
        /// An object with custom data.<br/>
        /// You can store up to 32kB as custom data.<br/>
        /// Default Value: {}<br/>
        /// Example: {"settingID":"f2a7b51e3503acc6a39b3784ffb84300","pluginVersion":"1.6.0"}
        /// </param>
        /// <param name="customNormalization">
        /// Characters and their normalized replacements.<br/>
        /// This overrides Algolia's default [normalization](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/normalization).<br/>
        /// Example: {"default":{"\u00E4":"ae","\u00FC":"ue"}}
        /// </param>
        /// <param name="attributeForDistinct">
        /// Attribute that should be used to establish groups of results.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// All records with the same value for this attribute are considered a group.<br/>
        /// You can combine `attributeForDistinct` with the `distinct` search parameter to control<br/>
        /// how many items per group are included in the search results.<br/>
        /// If you want to use the same attribute also for faceting, use the `afterDistinct` modifier of the `attributesForFaceting` setting.<br/>
        /// This applies faceting _after_ deduplication, which will result in accurate facet counts.<br/>
        /// Example: url
        /// </param>
        /// <param name="maxFacetHits">
        /// Maximum number of facet values to return when [searching for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="keepDiacriticsOnCharacters">
        /// Characters for which diacritics should be preserved.<br/>
        /// By default, Algolia removes diacritics from letters.<br/>
        /// For example, `é` becomes `e`. If this causes issues in your search,<br/>
        /// you can specify characters that should keep their diacritics.<br/>
        /// Example: øé
        /// </param>
        /// <param name="customRanking">
        /// Attributes to use as [custom ranking](https://www.algolia.com/doc/guides/managing-results/must-do/custom-ranking).<br/>
        /// Attribute names are case-sensitive.<br/>
        /// The custom ranking attributes decide which items are shown first if the other ranking criteria are equal.<br/>
        /// Records with missing values for your selected custom ranking attributes are always sorted last.<br/>
        /// Boolean attributes are sorted based on their alphabetical order.<br/>
        /// **Modifiers**<br/>
        /// - `asc("ATTRIBUTE")`.<br/>
        ///   Sort the index by the values of an attribute, in ascending order.<br/>
        /// - `desc("ATTRIBUTE")`.<br/>
        ///   Sort the index by the values of an attribute, in descending order.<br/>
        /// If you use two or more custom ranking attributes,<br/>
        /// [reduce the precision](https://www.algolia.com/doc/guides/managing-results/must-do/custom-ranking/how-to/controlling-custom-ranking-metrics-precision) of your first attributes,<br/>
        /// or the other attributes will never be applied.<br/>
        /// Default Value: []<br/>
        /// Example: [desc(popularity), asc(price)]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseIndexSettings(
            global::System.Collections.Generic.IList<string>? attributesForFaceting,
            global::System.Collections.Generic.IList<string>? replicas,
            int? paginationLimitedTo,
            global::System.Collections.Generic.IList<string>? unretrievableAttributes,
            global::System.Collections.Generic.IList<string>? disableTypoToleranceOnWords,
            global::System.Collections.Generic.IList<string>? attributesToTransliterate,
            global::System.Collections.Generic.IList<string>? camelCaseAttributes,
            object? decompoundedAttributes,
            global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? indexLanguages,
            global::System.Collections.Generic.IList<string>? disablePrefixOnAttributes,
            bool? allowCompressionOfIntegerArray,
            global::System.Collections.Generic.IList<string>? numericAttributesForFiltering,
            string? separatorsToIndex,
            global::System.Collections.Generic.IList<string>? searchableAttributes,
            global::Algolia.UserData? userData,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? customNormalization,
            string? attributeForDistinct,
            int? maxFacetHits,
            string? keepDiacriticsOnCharacters,
            global::System.Collections.Generic.IList<string>? customRanking)
        {
            this.AttributesForFaceting = attributesForFaceting;
            this.Replicas = replicas;
            this.PaginationLimitedTo = paginationLimitedTo;
            this.UnretrievableAttributes = unretrievableAttributes;
            this.DisableTypoToleranceOnWords = disableTypoToleranceOnWords;
            this.AttributesToTransliterate = attributesToTransliterate;
            this.CamelCaseAttributes = camelCaseAttributes;
            this.DecompoundedAttributes = decompoundedAttributes;
            this.IndexLanguages = indexLanguages;
            this.DisablePrefixOnAttributes = disablePrefixOnAttributes;
            this.AllowCompressionOfIntegerArray = allowCompressionOfIntegerArray;
            this.NumericAttributesForFiltering = numericAttributesForFiltering;
            this.SeparatorsToIndex = separatorsToIndex;
            this.SearchableAttributes = searchableAttributes;
            this.UserData = userData;
            this.CustomNormalization = customNormalization;
            this.AttributeForDistinct = attributeForDistinct;
            this.MaxFacetHits = maxFacetHits;
            this.KeepDiacriticsOnCharacters = keepDiacriticsOnCharacters;
            this.CustomRanking = customRanking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseIndexSettings" /> class.
        /// </summary>
        public BaseIndexSettings()
        {
        }
    }
}