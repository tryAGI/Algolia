
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexSettingsAsSearchParams
    {
        /// <summary>
        /// Attributes to include in the API response<br/>
        /// To reduce the size of your response, you can retrieve only some of the attributes.<br/>
        /// Attribute names are case-sensitive<br/>
        /// - `*` retrieves all attributes, except attributes included in the `customRanking` and `unretrievableAttributes` settings.<br/>
        /// - To retrieve all attributes except a specific one, prefix the attribute with a dash and combine it with the `*`: `["*", "-ATTRIBUTE"]`.<br/>
        /// - The `objectID` attribute is always included.<br/>
        /// Default Value: [*]<br/>
        /// Example: [author, title, content]
        /// </summary>
        /// <example>[author, title, content]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributesToRetrieve")]
        public global::System.Collections.Generic.IList<string>? AttributesToRetrieve { get; set; }

        /// <summary>
        /// Determines the order in which Algolia returns your results.<br/>
        /// By default, each entry corresponds to a [ranking criteria](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria).<br/>
        /// The tie-breaking algorithm sequentially applies each criterion in the order they're specified.<br/>
        /// If you configure a replica index for [sorting by an attribute](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/how-to/sort-by-attribute),<br/>
        /// you put the sorting attribute at the top of the list.<br/>
        /// **Modifiers**<br/>
        /// - `asc("ATTRIBUTE")`.<br/>
        ///   Sort the index by the values of an attribute, in ascending order.<br/>
        /// - `desc("ATTRIBUTE")`.<br/>
        ///   Sort the index by the values of an attribute, in descending order.<br/>
        /// Before you modify the default setting,<br/>
        /// test your changes in the dashboard,<br/>
        /// and by [A/B testing](https://www.algolia.com/doc/guides/ab-testing/what-is-ab-testing).<br/>
        /// Default Value: [typo, geo, words, filters, proximity, attribute, exact, custom]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking")]
        public global::System.Collections.Generic.IList<string>? Ranking { get; set; }

        /// <summary>
        /// Relevancy threshold below which less relevant results aren't included in the results<br/>
        /// You can only set `relevancyStrictness` on [virtual replica indices](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/replicas/#what-are-virtual-replicas).<br/>
        /// Use this setting to strike a balance between the relevance and number of returned results.<br/>
        /// Default Value: 100<br/>
        /// Example: 90
        /// </summary>
        /// <example>90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevancyStrictness")]
        public int? RelevancyStrictness { get; set; }

        /// <summary>
        /// Attributes to highlight<br/>
        /// By default, all searchable attributes are highlighted.<br/>
        /// Use `*` to highlight all attributes or use an empty array `[]` to turn off highlighting.<br/>
        /// Attribute names are case-sensitive<br/>
        /// With highlighting, strings that match the search query are surrounded by HTML tags defined by `highlightPreTag` and `highlightPostTag`.<br/>
        /// You can use this to visually highlight matching parts of a search query in your UI<br/>
        /// For more information, see [Highlighting and snippeting](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/highlighting-snippeting/js).<br/>
        /// Example: [author, title, conten, content]
        /// </summary>
        /// <example>[author, title, conten, content]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributesToHighlight")]
        public global::System.Collections.Generic.IList<string>? AttributesToHighlight { get; set; }

        /// <summary>
        /// Attributes for which to enable snippets.<br/>
        /// Attribute names are case-sensitive<br/>
        /// Snippets provide additional context to matched words.<br/>
        /// If you enable snippets, they include 10 words, including the matched word.<br/>
        /// The matched word will also be wrapped by HTML tags for highlighting.<br/>
        /// You can adjust the number of words with the following notation: `ATTRIBUTE:NUMBER`,<br/>
        /// where `NUMBER` is the number of words to be extracted.<br/>
        /// Default Value: []<br/>
        /// Example: [content:80, description]
        /// </summary>
        /// <example>[content:80, description]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributesToSnippet")]
        public global::System.Collections.Generic.IList<string>? AttributesToSnippet { get; set; }

        /// <summary>
        /// HTML tag to insert before the highlighted parts in all highlighted results and snippets.<br/>
        /// Default Value: &lt;em&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightPreTag")]
        public string? HighlightPreTag { get; set; }

        /// <summary>
        /// HTML tag to insert after the highlighted parts in all highlighted results and snippets.<br/>
        /// Default Value: &lt;/em&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightPostTag")]
        public string? HighlightPostTag { get; set; }

        /// <summary>
        /// String used as an ellipsis indicator when a snippet is truncated.<br/>
        /// Default Value: …
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippetEllipsisText")]
        public string? SnippetEllipsisText { get; set; }

        /// <summary>
        /// Whether to restrict highlighting and snippeting to items that at least partially matched the search query.<br/>
        /// By default, all items are highlighted and snippeted.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictHighlightAndSnippetArrays")]
        public bool? RestrictHighlightAndSnippetArrays { get; set; }

        /// <summary>
        /// Number of hits per page.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hitsPerPage")]
        public int? HitsPerPage { get; set; }

        /// <summary>
        /// Minimum number of characters a word in the search query must contain to accept matches with [one typo](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#configuring-word-length-for-typos).<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minWordSizefor1Typo")]
        public int? MinWordSizefor1Typo { get; set; }

        /// <summary>
        /// Minimum number of characters a word in the search query must contain to accept matches with [two typos](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#configuring-word-length-for-typos).<br/>
        /// Default Value: 8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minWordSizefor2Typos")]
        public int? MinWordSizefor2Typos { get; set; }

        /// <summary>
        /// Whether [typo tolerance](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance) is enabled and how it is applied.<br/>
        /// If typo tolerance is true, `min`, or `strict`, [word splitting and concatenation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/splitting-and-concatenation) are also active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typoTolerance")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.TypoToleranceJsonConverter))]
        public global::Algolia.TypoTolerance? TypoTolerance { get; set; }

        /// <summary>
        /// Whether to allow typos on numbers in the search query<br/>
        /// Turn off this setting to reduce the number of irrelevant matches<br/>
        /// when searching in large sets of similar numbers.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowTyposOnNumericTokens")]
        public bool? AllowTyposOnNumericTokens { get; set; }

        /// <summary>
        /// Attributes for which you want to turn off [typo tolerance](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance).<br/>
        /// Attribute names are case-sensitive<br/>
        /// Returning only exact matches can help when<br/>
        /// - [Searching in hyphenated attributes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/how-to/how-to-search-in-hyphenated-attributes).<br/>
        /// - Reducing the number of matches when you have too many.<br/>
        ///   This can happen with attributes that are long blocks of text, such as product descriptions<br/>
        /// Consider alternatives such as `disableTypoToleranceOnWords` or adding synonyms if your attributes have intentional unusual spellings that might look like typos.<br/>
        /// Default Value: []<br/>
        /// Example: [sku]
        /// </summary>
        /// <example>[sku]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableTypoToleranceOnAttributes")]
        public global::System.Collections.Generic.IList<string>? DisableTypoToleranceOnAttributes { get; set; }

        /// <summary>
        /// Treat singular, plurals, and other forms of declensions as equivalent.<br/>
        /// Only use this feature for the languages used in your index.<br/>
        /// Example: [ca, es]
        /// </summary>
        /// <example>[ca, es]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignorePlurals")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.IgnorePluralsJsonConverter))]
        public global::Algolia.IgnorePlurals? IgnorePlurals { get; set; }

        /// <summary>
        /// Removes stop words from the search query.<br/>
        /// Stop words are common words like articles, conjunctions, prepositions, or pronouns that have little or no meaning on their own.<br/>
        /// In English, "the", "a", or "and" are stop words.<br/>
        /// Only use this feature for the languages used in your index.<br/>
        /// Example: [ca, es]
        /// </summary>
        /// <example>[ca, es]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeStopWords")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.RemoveStopWordsJsonConverter))]
        public global::Algolia.RemoveStopWords? RemoveStopWords { get; set; }

        /// <summary>
        /// Languages for language-specific query processing steps such as plurals, stop-word removal, and word-detection dictionaries.<br/>
        /// This setting sets a default list of languages used by the `removeStopWords` and `ignorePlurals` settings.<br/>
        /// This setting also sets a dictionary for word detection in the logogram-based [CJK](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/normalization/#normalization-for-logogram-based-languages-cjk) languages.<br/>
        /// To support this, place the CJK language **first**.<br/>
        /// **Always specify a query language.**<br/>
        /// If you don't specify an indexing language, the search engine uses all [supported languages](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages),<br/>
        /// or the languages you specified with the `ignorePlurals` or `removeStopWords` parameters.<br/>
        /// This can lead to unexpected search results.<br/>
        /// For more information, see [Language-specific configuration](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations).<br/>
        /// Default Value: []<br/>
        /// Example: [es]
        /// </summary>
        /// <example>[es]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryLanguages")]
        public global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? QueryLanguages { get; set; }

        /// <summary>
        /// Whether to split compound words in the query into their building blocks<br/>
        /// For more information, see [Word segmentation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations/#splitting-compound-words).<br/>
        /// Word segmentation is supported for these languages: German, Dutch, Finnish, Swedish, and Norwegian.<br/>
        /// Decompounding doesn't work for words with [non-spacing mark Unicode characters](https://www.charactercodes.net/category/non-spacing_mark).<br/>
        /// For example, `Gartenstühle` won't be decompounded if the `ü` consists of `u` (U+0075) and `◌̈` (U+0308).<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decompoundQuery")]
        public bool? DecompoundQuery { get; set; }

        /// <summary>
        /// Whether to enable rules.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableRules")]
        public bool? EnableRules { get; set; }

        /// <summary>
        /// Whether to enable Personalization.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enablePersonalization")]
        public bool? EnablePersonalization { get; set; }

        /// <summary>
        /// Determines if and how query words are interpreted as prefixes.<br/>
        /// By default, only the last query word is treated as a prefix (`prefixLast`).<br/>
        /// To turn off prefix search, use `prefixNone`.<br/>
        /// Avoid `prefixAll`, which treats all query words as prefixes.<br/>
        /// This might lead to counterintuitive results and makes your search slower.<br/>
        /// For more information, see [Prefix searching](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/prefix-searching).<br/>
        /// Default Value: prefixLast
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.QueryTypeJsonConverter))]
        public global::Algolia.QueryType? QueryType { get; set; }

        /// <summary>
        /// Strategy for removing words from the query when it doesn't return any results.<br/>
        /// This helps to avoid returning empty search results.<br/>
        /// - `none`.<br/>
        ///   No words are removed when a query doesn't return results.<br/>
        /// - `lastWords`.<br/>
        ///   Treat the last (then second to last, then third to last) word as optional,<br/>
        ///   until there are results or at most 5 words have been removed.<br/>
        /// - `firstWords`.<br/>
        ///   Treat the first (then second, then third) word as optional,<br/>
        ///   until there are results or at most 5 words have been removed.<br/>
        /// - `allOptional`.<br/>
        ///   Treat all words as optional.<br/>
        /// For more information, see [Remove words to improve results](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/empty-or-insufficient-results/in-depth/why-use-remove-words-if-no-results).<br/>
        /// Default Value: none<br/>
        /// Example: firstWords
        /// </summary>
        /// <example>firstWords</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeWordsIfNoResults")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.RemoveWordsIfNoResultsJsonConverter))]
        public global::Algolia.RemoveWordsIfNoResults? RemoveWordsIfNoResults { get; set; }

        /// <summary>
        /// Search mode the index will use to query for results.<br/>
        /// This setting only applies to indices, for which Algolia enabled NeuralSearch for you.<br/>
        /// Default Value: keywordSearch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.ModeJsonConverter))]
        public global::Algolia.Mode? Mode { get; set; }

        /// <summary>
        /// Settings for the semantic search part of NeuralSearch.<br/>
        /// Only used when `mode` is `neuralSearch`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semanticSearch")]
        public global::Algolia.SemanticSearch? SemanticSearch { get; set; }

        /// <summary>
        /// Whether to support phrase matching and excluding words from search queries<br/>
        /// Use the `advancedSyntaxFeatures` parameter to control which feature is supported.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advancedSyntax")]
        public bool? AdvancedSyntax { get; set; }

        /// <summary>
        /// Words that should be considered optional when found in the query.<br/>
        /// By default, records must match all words in the search query to be included in the search results.<br/>
        /// Adding optional words can increase the number of search results by running an additional search query that doesn't include the optional words.<br/>
        /// For example, if the search query is "action video" and "video" is optional,<br/>
        /// the search engine runs two queries: one for "action video" and one for "action".<br/>
        /// Records that match all words are ranked higher.<br/>
        /// For a search query with 4 or more words **and** all its words are optional,<br/>
        /// the number of matched words required for a record to be included in the search results increases for every 1,000 records:<br/>
        /// - If `optionalWords` has fewer than 10 words, the required number of matched words increases by 1:<br/>
        ///   results 1 to 1,000 require 1 matched word; results 1,001 to 2,000 need 2 matched words.<br/>
        /// - If `optionalWords` has 10 or more words, the required number of matched words increases by the number of optional words divided by 5 (rounded down).<br/>
        ///   Example: with 18 optional words, results 1 to 1,000 require 1 matched word; results 1,001 to 2,000 need 4 matched words.<br/>
        /// For more information, see [Optional words](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/empty-or-insufficient-results/#creating-a-list-of-optional-words).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionalWords")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.OptionalWordsJsonConverter))]
        public global::Algolia.OptionalWords? OptionalWords { get; set; }

        /// <summary>
        /// Searchable attributes for which you want to [turn off the Exact ranking criterion](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes).<br/>
        /// Attribute names are case-sensitive<br/>
        /// This can be useful for attributes with long values, where the likelihood of an exact match is high,<br/>
        /// such as product descriptions.<br/>
        /// Turning off the Exact ranking criterion for these attributes favors exact matching on other attributes.<br/>
        /// This reduces the impact of individual attributes with a lot of content on ranking.<br/>
        /// Default Value: []<br/>
        /// Example: [description]
        /// </summary>
        /// <example>[description]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableExactOnAttributes")]
        public global::System.Collections.Generic.IList<string>? DisableExactOnAttributes { get; set; }

        /// <summary>
        /// Determines how the [Exact ranking criterion](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes) is computed when the search query has only one word.<br/>
        /// - `attribute`.<br/>
        ///   The Exact ranking criterion is 1 if the query word and attribute value are the same.<br/>
        ///   For example, a search for "road" will match the value "road", but not "road trip".<br/>
        /// - `none`.<br/>
        ///   The Exact ranking criterion is ignored on single-word searches.<br/>
        /// - `word`.<br/>
        ///   The Exact ranking criterion is 1 if the query word is found in the attribute value.<br/>
        ///   The query word must have at least 3 characters and must not be a stop word.<br/>
        ///   Only exact matches will be highlighted,<br/>
        ///   partial and prefix matches won't.<br/>
        /// Default Value: attribute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exactOnSingleWordQuery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.ExactOnSingleWordQueryJsonConverter))]
        public global::Algolia.ExactOnSingleWordQuery? ExactOnSingleWordQuery { get; set; }

        /// <summary>
        /// Determine which plurals and synonyms should be considered an exact matches<br/>
        /// By default, Algolia treats singular and plural forms of a word, and single-word synonyms, as [exact](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#exact) matches when searching.<br/>
        /// For example<br/>
        /// - "swimsuit" and "swimsuits" are treated the same<br/>
        /// - "swimsuit" and "swimwear" are treated the same (if they are [synonyms](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/#regular-synonyms))<br/>
        /// - `ignorePlurals`.<br/>
        ///   Plurals and similar declensions added by the `ignorePlurals` setting are considered exact matches<br/>
        /// - `singleWordSynonym`.<br/>
        ///   Single-word synonyms, such as "NY" = "NYC", are considered exact matches<br/>
        /// - `multiWordsSynonym`.<br/>
        ///   Multi-word synonyms, such as "NY" = "New York", are considered exact matches.<br/>
        /// Default Value: [ignorePlurals, singleWordSynonym]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alternativesAsExact")]
        public global::System.Collections.Generic.IList<global::Algolia.AlternativesAsExact>? AlternativesAsExact { get; set; }

        /// <summary>
        /// Advanced search syntax features you want to support<br/>
        /// - `exactPhrase`.<br/>
        ///   Phrases in quotes must match exactly.<br/>
        ///   For example, `sparkly blue "iPhone case"` only returns records with the exact string "iPhone case"<br/>
        /// - `excludeWords`.<br/>
        ///   Query words prefixed with a `-` must not occur in a record.<br/>
        ///   For example, `search -engine` matches records that contain "search" but not "engine"<br/>
        /// This setting only has an effect if `advancedSyntax` is true.<br/>
        /// Default Value: [exactPhrase, excludeWords]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advancedSyntaxFeatures")]
        public global::System.Collections.Generic.IList<global::Algolia.AdvancedSyntaxFeatures>? AdvancedSyntaxFeatures { get; set; }

        /// <summary>
        /// Determines how many records of a group are included in the search results.<br/>
        /// Records with the same value for the `attributeForDistinct` attribute are considered a group.<br/>
        /// The `distinct` setting controls how many members of the group are returned.<br/>
        /// This is useful for [deduplication and grouping](https://www.algolia.com/doc/guides/managing-results/refine-results/grouping/#introducing-algolias-distinct-feature).<br/>
        /// The `distinct` setting is ignored if `attributeForDistinct` is not set.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.DistinctJsonConverter))]
        public global::Algolia.Distinct? Distinct { get; set; }

        /// <summary>
        /// Whether to replace a highlighted word with the matched synonym<br/>
        /// By default, the original words are highlighted even if a synonym matches.<br/>
        /// For example, with `home` as a synonym for `house` and a search for `home`,<br/>
        /// records matching either "home" or "house" are included in the search results,<br/>
        /// and either "home" or "house" are highlighted<br/>
        /// With `replaceSynonymsInHighlight` set to `true`, a search for `home` still matches the same records,<br/>
        /// but all occurrences of "house" are replaced by "home" in the highlighted response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaceSynonymsInHighlight")]
        public bool? ReplaceSynonymsInHighlight { get; set; }

        /// <summary>
        /// Minimum proximity score for two matching words<br/>
        /// This adjusts the [Proximity ranking criterion](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#proximity)<br/>
        /// by equally scoring matches that are farther apart<br/>
        /// For example, if `minProximity` is 2, neighboring matches and matches with one word between them would have the same score.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minProximity")]
        public int? MinProximity { get; set; }

        /// <summary>
        /// Properties to include in the API response of search and browse requests<br/>
        /// By default, all response properties are included.<br/>
        /// To reduce the response size, you can select which properties should be included<br/>
        /// An empty list may lead to an empty API response (except properties you can't exclude)<br/>
        /// You can't exclude these properties:<br/>
        /// `message`, `warning`, `cursor`, `abTestVariantID`,<br/>
        /// or any property added by setting `getRankingInfo` to true<br/>
        /// Your search depends on the `hits` field. If you omit this field, searches won't return any results.<br/>
        /// Your UI might also depend on other properties, for example, for pagination.<br/>
        /// Before restricting the response size, check the impact on your search experience.<br/>
        /// Default Value: [*]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseFields")]
        public global::System.Collections.Generic.IList<string>? ResponseFields { get; set; }

        /// <summary>
        /// Maximum number of facet values to return for each facet.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxValuesPerFacet")]
        public int? MaxValuesPerFacet { get; set; }

        /// <summary>
        /// Order in which to retrieve facet values<br/>
        /// - `count`.<br/>
        ///   Facet values are retrieved by decreasing count.<br/>
        ///   The count is the number of matching records containing this facet value<br/>
        /// - `alpha`.<br/>
        ///   Retrieve facet values alphabetically<br/>
        /// This setting doesn't influence how facet values are displayed in your UI (see `renderingContent`).<br/>
        /// For more information, see [facet value display](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/facet-display/js).<br/>
        /// Default Value: count
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortFacetValuesBy")]
        public string? SortFacetValuesBy { get; set; }

        /// <summary>
        /// Whether the best matching attribute should be determined by minimum proximity<br/>
        /// This setting only affects ranking if the Attribute ranking criterion comes before Proximity in the `ranking` setting.<br/>
        /// If true, the best matching attribute is selected based on the minimum proximity of multiple matches.<br/>
        /// Otherwise, the best matching attribute is determined by the order in the `searchableAttributes` setting.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributeCriteriaComputedByMinProximity")]
        public bool? AttributeCriteriaComputedByMinProximity { get; set; }

        /// <summary>
        /// Extra data that can be used in the search UI.<br/>
        /// You can use this to control aspects of your search UI, such as the order of facet names and values<br/>
        /// without changing your frontend code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renderingContent")]
        public global::Algolia.RenderingContent? RenderingContent { get; set; }

        /// <summary>
        /// Whether this search will use [Dynamic Re-Ranking](https://www.algolia.com/doc/guides/algolia-ai/re-ranking)<br/>
        /// This setting only has an effect if you activated Dynamic Re-Ranking for this index in the Algolia dashboard.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableReRanking")]
        public bool? EnableReRanking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reRankingApplyFilter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.OneOfJsonConverter<global::Algolia.ReRankingApplyFilter?, object>))]
        public global::Algolia.OneOf<global::Algolia.ReRankingApplyFilter?, object>? ReRankingApplyFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexSettingsAsSearchParams" /> class.
        /// </summary>
        /// <param name="attributesToRetrieve">
        /// Attributes to include in the API response<br/>
        /// To reduce the size of your response, you can retrieve only some of the attributes.<br/>
        /// Attribute names are case-sensitive<br/>
        /// - `*` retrieves all attributes, except attributes included in the `customRanking` and `unretrievableAttributes` settings.<br/>
        /// - To retrieve all attributes except a specific one, prefix the attribute with a dash and combine it with the `*`: `["*", "-ATTRIBUTE"]`.<br/>
        /// - The `objectID` attribute is always included.<br/>
        /// Default Value: [*]<br/>
        /// Example: [author, title, content]
        /// </param>
        /// <param name="ranking">
        /// Determines the order in which Algolia returns your results.<br/>
        /// By default, each entry corresponds to a [ranking criteria](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria).<br/>
        /// The tie-breaking algorithm sequentially applies each criterion in the order they're specified.<br/>
        /// If you configure a replica index for [sorting by an attribute](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/how-to/sort-by-attribute),<br/>
        /// you put the sorting attribute at the top of the list.<br/>
        /// **Modifiers**<br/>
        /// - `asc("ATTRIBUTE")`.<br/>
        ///   Sort the index by the values of an attribute, in ascending order.<br/>
        /// - `desc("ATTRIBUTE")`.<br/>
        ///   Sort the index by the values of an attribute, in descending order.<br/>
        /// Before you modify the default setting,<br/>
        /// test your changes in the dashboard,<br/>
        /// and by [A/B testing](https://www.algolia.com/doc/guides/ab-testing/what-is-ab-testing).<br/>
        /// Default Value: [typo, geo, words, filters, proximity, attribute, exact, custom]
        /// </param>
        /// <param name="relevancyStrictness">
        /// Relevancy threshold below which less relevant results aren't included in the results<br/>
        /// You can only set `relevancyStrictness` on [virtual replica indices](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/replicas/#what-are-virtual-replicas).<br/>
        /// Use this setting to strike a balance between the relevance and number of returned results.<br/>
        /// Default Value: 100<br/>
        /// Example: 90
        /// </param>
        /// <param name="attributesToHighlight">
        /// Attributes to highlight<br/>
        /// By default, all searchable attributes are highlighted.<br/>
        /// Use `*` to highlight all attributes or use an empty array `[]` to turn off highlighting.<br/>
        /// Attribute names are case-sensitive<br/>
        /// With highlighting, strings that match the search query are surrounded by HTML tags defined by `highlightPreTag` and `highlightPostTag`.<br/>
        /// You can use this to visually highlight matching parts of a search query in your UI<br/>
        /// For more information, see [Highlighting and snippeting](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/highlighting-snippeting/js).<br/>
        /// Example: [author, title, conten, content]
        /// </param>
        /// <param name="attributesToSnippet">
        /// Attributes for which to enable snippets.<br/>
        /// Attribute names are case-sensitive<br/>
        /// Snippets provide additional context to matched words.<br/>
        /// If you enable snippets, they include 10 words, including the matched word.<br/>
        /// The matched word will also be wrapped by HTML tags for highlighting.<br/>
        /// You can adjust the number of words with the following notation: `ATTRIBUTE:NUMBER`,<br/>
        /// where `NUMBER` is the number of words to be extracted.<br/>
        /// Default Value: []<br/>
        /// Example: [content:80, description]
        /// </param>
        /// <param name="highlightPreTag">
        /// HTML tag to insert before the highlighted parts in all highlighted results and snippets.<br/>
        /// Default Value: &lt;em&gt;
        /// </param>
        /// <param name="highlightPostTag">
        /// HTML tag to insert after the highlighted parts in all highlighted results and snippets.<br/>
        /// Default Value: &lt;/em&gt;
        /// </param>
        /// <param name="snippetEllipsisText">
        /// String used as an ellipsis indicator when a snippet is truncated.<br/>
        /// Default Value: …
        /// </param>
        /// <param name="restrictHighlightAndSnippetArrays">
        /// Whether to restrict highlighting and snippeting to items that at least partially matched the search query.<br/>
        /// By default, all items are highlighted and snippeted.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="hitsPerPage">
        /// Number of hits per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="minWordSizefor1Typo">
        /// Minimum number of characters a word in the search query must contain to accept matches with [one typo](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#configuring-word-length-for-typos).<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="minWordSizefor2Typos">
        /// Minimum number of characters a word in the search query must contain to accept matches with [two typos](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#configuring-word-length-for-typos).<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="typoTolerance">
        /// Whether [typo tolerance](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance) is enabled and how it is applied.<br/>
        /// If typo tolerance is true, `min`, or `strict`, [word splitting and concatenation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/splitting-and-concatenation) are also active.
        /// </param>
        /// <param name="allowTyposOnNumericTokens">
        /// Whether to allow typos on numbers in the search query<br/>
        /// Turn off this setting to reduce the number of irrelevant matches<br/>
        /// when searching in large sets of similar numbers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="disableTypoToleranceOnAttributes">
        /// Attributes for which you want to turn off [typo tolerance](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance).<br/>
        /// Attribute names are case-sensitive<br/>
        /// Returning only exact matches can help when<br/>
        /// - [Searching in hyphenated attributes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/how-to/how-to-search-in-hyphenated-attributes).<br/>
        /// - Reducing the number of matches when you have too many.<br/>
        ///   This can happen with attributes that are long blocks of text, such as product descriptions<br/>
        /// Consider alternatives such as `disableTypoToleranceOnWords` or adding synonyms if your attributes have intentional unusual spellings that might look like typos.<br/>
        /// Default Value: []<br/>
        /// Example: [sku]
        /// </param>
        /// <param name="ignorePlurals">
        /// Treat singular, plurals, and other forms of declensions as equivalent.<br/>
        /// Only use this feature for the languages used in your index.<br/>
        /// Example: [ca, es]
        /// </param>
        /// <param name="removeStopWords">
        /// Removes stop words from the search query.<br/>
        /// Stop words are common words like articles, conjunctions, prepositions, or pronouns that have little or no meaning on their own.<br/>
        /// In English, "the", "a", or "and" are stop words.<br/>
        /// Only use this feature for the languages used in your index.<br/>
        /// Example: [ca, es]
        /// </param>
        /// <param name="queryLanguages">
        /// Languages for language-specific query processing steps such as plurals, stop-word removal, and word-detection dictionaries.<br/>
        /// This setting sets a default list of languages used by the `removeStopWords` and `ignorePlurals` settings.<br/>
        /// This setting also sets a dictionary for word detection in the logogram-based [CJK](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/normalization/#normalization-for-logogram-based-languages-cjk) languages.<br/>
        /// To support this, place the CJK language **first**.<br/>
        /// **Always specify a query language.**<br/>
        /// If you don't specify an indexing language, the search engine uses all [supported languages](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages),<br/>
        /// or the languages you specified with the `ignorePlurals` or `removeStopWords` parameters.<br/>
        /// This can lead to unexpected search results.<br/>
        /// For more information, see [Language-specific configuration](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations).<br/>
        /// Default Value: []<br/>
        /// Example: [es]
        /// </param>
        /// <param name="decompoundQuery">
        /// Whether to split compound words in the query into their building blocks<br/>
        /// For more information, see [Word segmentation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations/#splitting-compound-words).<br/>
        /// Word segmentation is supported for these languages: German, Dutch, Finnish, Swedish, and Norwegian.<br/>
        /// Decompounding doesn't work for words with [non-spacing mark Unicode characters](https://www.charactercodes.net/category/non-spacing_mark).<br/>
        /// For example, `Gartenstühle` won't be decompounded if the `ü` consists of `u` (U+0075) and `◌̈` (U+0308).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enableRules">
        /// Whether to enable rules.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enablePersonalization">
        /// Whether to enable Personalization.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="queryType">
        /// Determines if and how query words are interpreted as prefixes.<br/>
        /// By default, only the last query word is treated as a prefix (`prefixLast`).<br/>
        /// To turn off prefix search, use `prefixNone`.<br/>
        /// Avoid `prefixAll`, which treats all query words as prefixes.<br/>
        /// This might lead to counterintuitive results and makes your search slower.<br/>
        /// For more information, see [Prefix searching](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/prefix-searching).<br/>
        /// Default Value: prefixLast
        /// </param>
        /// <param name="removeWordsIfNoResults">
        /// Strategy for removing words from the query when it doesn't return any results.<br/>
        /// This helps to avoid returning empty search results.<br/>
        /// - `none`.<br/>
        ///   No words are removed when a query doesn't return results.<br/>
        /// - `lastWords`.<br/>
        ///   Treat the last (then second to last, then third to last) word as optional,<br/>
        ///   until there are results or at most 5 words have been removed.<br/>
        /// - `firstWords`.<br/>
        ///   Treat the first (then second, then third) word as optional,<br/>
        ///   until there are results or at most 5 words have been removed.<br/>
        /// - `allOptional`.<br/>
        ///   Treat all words as optional.<br/>
        /// For more information, see [Remove words to improve results](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/empty-or-insufficient-results/in-depth/why-use-remove-words-if-no-results).<br/>
        /// Default Value: none<br/>
        /// Example: firstWords
        /// </param>
        /// <param name="mode">
        /// Search mode the index will use to query for results.<br/>
        /// This setting only applies to indices, for which Algolia enabled NeuralSearch for you.<br/>
        /// Default Value: keywordSearch
        /// </param>
        /// <param name="semanticSearch">
        /// Settings for the semantic search part of NeuralSearch.<br/>
        /// Only used when `mode` is `neuralSearch`.
        /// </param>
        /// <param name="advancedSyntax">
        /// Whether to support phrase matching and excluding words from search queries<br/>
        /// Use the `advancedSyntaxFeatures` parameter to control which feature is supported.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="optionalWords">
        /// Words that should be considered optional when found in the query.<br/>
        /// By default, records must match all words in the search query to be included in the search results.<br/>
        /// Adding optional words can increase the number of search results by running an additional search query that doesn't include the optional words.<br/>
        /// For example, if the search query is "action video" and "video" is optional,<br/>
        /// the search engine runs two queries: one for "action video" and one for "action".<br/>
        /// Records that match all words are ranked higher.<br/>
        /// For a search query with 4 or more words **and** all its words are optional,<br/>
        /// the number of matched words required for a record to be included in the search results increases for every 1,000 records:<br/>
        /// - If `optionalWords` has fewer than 10 words, the required number of matched words increases by 1:<br/>
        ///   results 1 to 1,000 require 1 matched word; results 1,001 to 2,000 need 2 matched words.<br/>
        /// - If `optionalWords` has 10 or more words, the required number of matched words increases by the number of optional words divided by 5 (rounded down).<br/>
        ///   Example: with 18 optional words, results 1 to 1,000 require 1 matched word; results 1,001 to 2,000 need 4 matched words.<br/>
        /// For more information, see [Optional words](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/empty-or-insufficient-results/#creating-a-list-of-optional-words).
        /// </param>
        /// <param name="disableExactOnAttributes">
        /// Searchable attributes for which you want to [turn off the Exact ranking criterion](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes).<br/>
        /// Attribute names are case-sensitive<br/>
        /// This can be useful for attributes with long values, where the likelihood of an exact match is high,<br/>
        /// such as product descriptions.<br/>
        /// Turning off the Exact ranking criterion for these attributes favors exact matching on other attributes.<br/>
        /// This reduces the impact of individual attributes with a lot of content on ranking.<br/>
        /// Default Value: []<br/>
        /// Example: [description]
        /// </param>
        /// <param name="exactOnSingleWordQuery">
        /// Determines how the [Exact ranking criterion](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes) is computed when the search query has only one word.<br/>
        /// - `attribute`.<br/>
        ///   The Exact ranking criterion is 1 if the query word and attribute value are the same.<br/>
        ///   For example, a search for "road" will match the value "road", but not "road trip".<br/>
        /// - `none`.<br/>
        ///   The Exact ranking criterion is ignored on single-word searches.<br/>
        /// - `word`.<br/>
        ///   The Exact ranking criterion is 1 if the query word is found in the attribute value.<br/>
        ///   The query word must have at least 3 characters and must not be a stop word.<br/>
        ///   Only exact matches will be highlighted,<br/>
        ///   partial and prefix matches won't.<br/>
        /// Default Value: attribute
        /// </param>
        /// <param name="alternativesAsExact">
        /// Determine which plurals and synonyms should be considered an exact matches<br/>
        /// By default, Algolia treats singular and plural forms of a word, and single-word synonyms, as [exact](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#exact) matches when searching.<br/>
        /// For example<br/>
        /// - "swimsuit" and "swimsuits" are treated the same<br/>
        /// - "swimsuit" and "swimwear" are treated the same (if they are [synonyms](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/#regular-synonyms))<br/>
        /// - `ignorePlurals`.<br/>
        ///   Plurals and similar declensions added by the `ignorePlurals` setting are considered exact matches<br/>
        /// - `singleWordSynonym`.<br/>
        ///   Single-word synonyms, such as "NY" = "NYC", are considered exact matches<br/>
        /// - `multiWordsSynonym`.<br/>
        ///   Multi-word synonyms, such as "NY" = "New York", are considered exact matches.<br/>
        /// Default Value: [ignorePlurals, singleWordSynonym]
        /// </param>
        /// <param name="advancedSyntaxFeatures">
        /// Advanced search syntax features you want to support<br/>
        /// - `exactPhrase`.<br/>
        ///   Phrases in quotes must match exactly.<br/>
        ///   For example, `sparkly blue "iPhone case"` only returns records with the exact string "iPhone case"<br/>
        /// - `excludeWords`.<br/>
        ///   Query words prefixed with a `-` must not occur in a record.<br/>
        ///   For example, `search -engine` matches records that contain "search" but not "engine"<br/>
        /// This setting only has an effect if `advancedSyntax` is true.<br/>
        /// Default Value: [exactPhrase, excludeWords]
        /// </param>
        /// <param name="distinct">
        /// Determines how many records of a group are included in the search results.<br/>
        /// Records with the same value for the `attributeForDistinct` attribute are considered a group.<br/>
        /// The `distinct` setting controls how many members of the group are returned.<br/>
        /// This is useful for [deduplication and grouping](https://www.algolia.com/doc/guides/managing-results/refine-results/grouping/#introducing-algolias-distinct-feature).<br/>
        /// The `distinct` setting is ignored if `attributeForDistinct` is not set.<br/>
        /// Example: 1
        /// </param>
        /// <param name="replaceSynonymsInHighlight">
        /// Whether to replace a highlighted word with the matched synonym<br/>
        /// By default, the original words are highlighted even if a synonym matches.<br/>
        /// For example, with `home` as a synonym for `house` and a search for `home`,<br/>
        /// records matching either "home" or "house" are included in the search results,<br/>
        /// and either "home" or "house" are highlighted<br/>
        /// With `replaceSynonymsInHighlight` set to `true`, a search for `home` still matches the same records,<br/>
        /// but all occurrences of "house" are replaced by "home" in the highlighted response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="minProximity">
        /// Minimum proximity score for two matching words<br/>
        /// This adjusts the [Proximity ranking criterion](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#proximity)<br/>
        /// by equally scoring matches that are farther apart<br/>
        /// For example, if `minProximity` is 2, neighboring matches and matches with one word between them would have the same score.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="responseFields">
        /// Properties to include in the API response of search and browse requests<br/>
        /// By default, all response properties are included.<br/>
        /// To reduce the response size, you can select which properties should be included<br/>
        /// An empty list may lead to an empty API response (except properties you can't exclude)<br/>
        /// You can't exclude these properties:<br/>
        /// `message`, `warning`, `cursor`, `abTestVariantID`,<br/>
        /// or any property added by setting `getRankingInfo` to true<br/>
        /// Your search depends on the `hits` field. If you omit this field, searches won't return any results.<br/>
        /// Your UI might also depend on other properties, for example, for pagination.<br/>
        /// Before restricting the response size, check the impact on your search experience.<br/>
        /// Default Value: [*]
        /// </param>
        /// <param name="maxValuesPerFacet">
        /// Maximum number of facet values to return for each facet.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="sortFacetValuesBy">
        /// Order in which to retrieve facet values<br/>
        /// - `count`.<br/>
        ///   Facet values are retrieved by decreasing count.<br/>
        ///   The count is the number of matching records containing this facet value<br/>
        /// - `alpha`.<br/>
        ///   Retrieve facet values alphabetically<br/>
        /// This setting doesn't influence how facet values are displayed in your UI (see `renderingContent`).<br/>
        /// For more information, see [facet value display](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/facet-display/js).<br/>
        /// Default Value: count
        /// </param>
        /// <param name="attributeCriteriaComputedByMinProximity">
        /// Whether the best matching attribute should be determined by minimum proximity<br/>
        /// This setting only affects ranking if the Attribute ranking criterion comes before Proximity in the `ranking` setting.<br/>
        /// If true, the best matching attribute is selected based on the minimum proximity of multiple matches.<br/>
        /// Otherwise, the best matching attribute is determined by the order in the `searchableAttributes` setting.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="renderingContent">
        /// Extra data that can be used in the search UI.<br/>
        /// You can use this to control aspects of your search UI, such as the order of facet names and values<br/>
        /// without changing your frontend code.
        /// </param>
        /// <param name="enableReRanking">
        /// Whether this search will use [Dynamic Re-Ranking](https://www.algolia.com/doc/guides/algolia-ai/re-ranking)<br/>
        /// This setting only has an effect if you activated Dynamic Re-Ranking for this index in the Algolia dashboard.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="reRankingApplyFilter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexSettingsAsSearchParams(
            global::System.Collections.Generic.IList<string>? attributesToRetrieve,
            global::System.Collections.Generic.IList<string>? ranking,
            int? relevancyStrictness,
            global::System.Collections.Generic.IList<string>? attributesToHighlight,
            global::System.Collections.Generic.IList<string>? attributesToSnippet,
            string? highlightPreTag,
            string? highlightPostTag,
            string? snippetEllipsisText,
            bool? restrictHighlightAndSnippetArrays,
            int? hitsPerPage,
            int? minWordSizefor1Typo,
            int? minWordSizefor2Typos,
            global::Algolia.TypoTolerance? typoTolerance,
            bool? allowTyposOnNumericTokens,
            global::System.Collections.Generic.IList<string>? disableTypoToleranceOnAttributes,
            global::Algolia.IgnorePlurals? ignorePlurals,
            global::Algolia.RemoveStopWords? removeStopWords,
            global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>? queryLanguages,
            bool? decompoundQuery,
            bool? enableRules,
            bool? enablePersonalization,
            global::Algolia.QueryType? queryType,
            global::Algolia.RemoveWordsIfNoResults? removeWordsIfNoResults,
            global::Algolia.Mode? mode,
            global::Algolia.SemanticSearch? semanticSearch,
            bool? advancedSyntax,
            global::Algolia.OptionalWords? optionalWords,
            global::System.Collections.Generic.IList<string>? disableExactOnAttributes,
            global::Algolia.ExactOnSingleWordQuery? exactOnSingleWordQuery,
            global::System.Collections.Generic.IList<global::Algolia.AlternativesAsExact>? alternativesAsExact,
            global::System.Collections.Generic.IList<global::Algolia.AdvancedSyntaxFeatures>? advancedSyntaxFeatures,
            global::Algolia.Distinct? distinct,
            bool? replaceSynonymsInHighlight,
            int? minProximity,
            global::System.Collections.Generic.IList<string>? responseFields,
            int? maxValuesPerFacet,
            string? sortFacetValuesBy,
            bool? attributeCriteriaComputedByMinProximity,
            global::Algolia.RenderingContent? renderingContent,
            bool? enableReRanking,
            global::Algolia.OneOf<global::Algolia.ReRankingApplyFilter?, object>? reRankingApplyFilter)
        {
            this.AttributesToRetrieve = attributesToRetrieve;
            this.Ranking = ranking;
            this.RelevancyStrictness = relevancyStrictness;
            this.AttributesToHighlight = attributesToHighlight;
            this.AttributesToSnippet = attributesToSnippet;
            this.HighlightPreTag = highlightPreTag;
            this.HighlightPostTag = highlightPostTag;
            this.SnippetEllipsisText = snippetEllipsisText;
            this.RestrictHighlightAndSnippetArrays = restrictHighlightAndSnippetArrays;
            this.HitsPerPage = hitsPerPage;
            this.MinWordSizefor1Typo = minWordSizefor1Typo;
            this.MinWordSizefor2Typos = minWordSizefor2Typos;
            this.TypoTolerance = typoTolerance;
            this.AllowTyposOnNumericTokens = allowTyposOnNumericTokens;
            this.DisableTypoToleranceOnAttributes = disableTypoToleranceOnAttributes;
            this.IgnorePlurals = ignorePlurals;
            this.RemoveStopWords = removeStopWords;
            this.QueryLanguages = queryLanguages;
            this.DecompoundQuery = decompoundQuery;
            this.EnableRules = enableRules;
            this.EnablePersonalization = enablePersonalization;
            this.QueryType = queryType;
            this.RemoveWordsIfNoResults = removeWordsIfNoResults;
            this.Mode = mode;
            this.SemanticSearch = semanticSearch;
            this.AdvancedSyntax = advancedSyntax;
            this.OptionalWords = optionalWords;
            this.DisableExactOnAttributes = disableExactOnAttributes;
            this.ExactOnSingleWordQuery = exactOnSingleWordQuery;
            this.AlternativesAsExact = alternativesAsExact;
            this.AdvancedSyntaxFeatures = advancedSyntaxFeatures;
            this.Distinct = distinct;
            this.ReplaceSynonymsInHighlight = replaceSynonymsInHighlight;
            this.MinProximity = minProximity;
            this.ResponseFields = responseFields;
            this.MaxValuesPerFacet = maxValuesPerFacet;
            this.SortFacetValuesBy = sortFacetValuesBy;
            this.AttributeCriteriaComputedByMinProximity = attributeCriteriaComputedByMinProximity;
            this.RenderingContent = renderingContent;
            this.EnableReRanking = enableReRanking;
            this.ReRankingApplyFilter = reRankingApplyFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexSettingsAsSearchParams" /> class.
        /// </summary>
        public IndexSettingsAsSearchParams()
        {
        }
    }
}