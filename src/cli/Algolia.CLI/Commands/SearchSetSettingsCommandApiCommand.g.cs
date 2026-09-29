#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchSetSettingsCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Option<bool?> ForwardToReplicas { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--forward-to-replicas",
        description: @"Whether changes are applied to replica indices.");

    private static Option<global::System.Collections.Generic.IList<string>?> AttributesForFaceting { get; } = new(
        name: @"--attributes-for-faceting")
    {
        Description = @"Attributes used for [faceting](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting).

Facets are attributes that let you categorize search results.
They can be used for filtering search results.
By default, no attribute is used for faceting.
Attribute names are case-sensitive.

**Modifiers**

- `filterOnly(""ATTRIBUTE"")`.

  Allows the attribute to be used as a filter but doesn't evaluate the facet values.

- `searchable(""ATTRIBUTE"")`.

  Allows searching for facet values.

- `afterDistinct(""ATTRIBUTE"")`.

  Evaluates the facet count _after_ deduplication with `distinct`.
  This ensures accurate facet counts.
  You can apply this modifier to searchable facets: `afterDistinct(searchable(ATTRIBUTE))`.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Replicas { get; } = new(
        name: @"--replicas")
    {
        Description = @"Creates [replica indices](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/replicas).

Replicas are copies of a primary index with the same records but different settings, synonyms, or rules.
If you want to offer a different ranking or sorting of your search results, you'll use replica indices.
All index operations on a primary index are automatically forwarded to its replicas.
To add a replica index, you must provide the complete set of replicas to this parameter.
If you omit a replica from this list, the replica turns into a regular, standalone index that will no longer be synced with the primary index.

**Modifier**

- `virtual(""REPLICA"")`.

  Create a virtual replica,
  Virtual replicas don't increase the number of records and are optimized for [Relevant sorting](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/relevant-sort).
",
    };

    private static Option<long?> PaginationLimitedTo { get; } = new(
        name: @"--pagination-limited-to")
    {
        Description = @"Maximum number of search results that can be obtained through pagination.

Higher pagination limits might slow down your search.
For pagination limits above 1,000, the sorting of results beyond the 1,000th hit can't be guaranteed.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> UnretrievableAttributes { get; } = new(
        name: @"--unretrievable-attributes")
    {
        Description = @"Attributes that can't be retrieved at query time.

This can be useful if you want to use an attribute for ranking or to [restrict access](https://www.algolia.com/doc/guides/security/api-keys/how-to/user-restricted-access-to-data),
but don't want to include it in the search results.
Attribute names are case-sensitive.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> DisableTypoToleranceOnWords { get; } = new(
        name: @"--disable-typo-tolerance-on-words")
    {
        Description = @"Creates a list of [words which require exact matches](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#turn-off-typo-tolerance-for-certain-words).
This also turns off [word splitting and concatenation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/splitting-and-concatenation) for the specified words.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AttributesToTransliterate { get; } = new(
        name: @"--attributes-to-transliterate")
    {
        Description = @"Attributes, for which you want to support [Japanese transliteration](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations/#japanese-transliteration-and-type-ahead).

Transliteration supports searching in any of the Japanese writing systems.
To support transliteration, you must set the indexing language to Japanese.
Attribute names are case-sensitive.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> CamelCaseAttributes { get; } = new(
        name: @"--camel-case-attributes")
    {
        Description = @"Attributes for which to split [camel case](https://wikipedia.org/wiki/Camel_case) words.
Attribute names are case-sensitive.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?> IndexLanguages { get; } = new(
        name: @"--index-languages")
    {
        Description = @"Languages for language-specific processing steps, such as word detection and dictionary settings.

**Always specify an indexing language.**
If you don't specify an indexing language, the search engine uses all [supported languages](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages),
or the languages you specified with the `ignorePlurals` or `removeStopWords` parameters.
This can lead to unexpected search results.
For more information, see [Language-specific configuration](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations).
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> DisablePrefixOnAttributes { get; } = new(
        name: @"--disable-prefix-on-attributes")
    {
        Description = @"Searchable attributes for which you want to turn off [prefix matching](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/#adjusting-prefix-search).
Attribute names are case-sensitive.
",
    };

    private static Option<bool?> AllowCompressionOfIntegerArray { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--allow-compression-of-integer-array",
        description: @"Whether arrays with exclusively non-negative integers should be compressed for better performance.
If true, the compressed arrays may be reordered.
");

    private static Option<global::System.Collections.Generic.IList<string>?> NumericAttributesForFiltering { get; } = new(
        name: @"--numeric-attributes-for-filtering")
    {
        Description = @"Numeric attributes that can be used as [numerical filters](https://www.algolia.com/doc/guides/managing-results/rules/detecting-intent/how-to/applying-a-custom-filter-for-a-specific-query/#numerical-filters).
Attribute names are case-sensitive.

By default, all numeric attributes are available as numerical filters.
For faster indexing, reduce the number of numeric attributes.

To turn off filtering for all numeric attributes, specify an attribute that doesn't exist in your index, such as `NO_NUMERIC_FILTERING`.

**Modifier**

- `equalOnly(""ATTRIBUTE"")`.

  Support only filtering based on equality comparisons `=` and `!=`.
",
    };

    private static Option<string?> SeparatorsToIndex { get; } = new(
        name: @"--separators-to-index")
    {
        Description = @"Control which non-alphanumeric characters are indexed.

By default, Algolia ignores [non-alphanumeric characters](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/how-to/how-to-search-in-hyphenated-attributes/#handling-non-alphanumeric-characters) like hyphen (`-`), plus (`+`), and parentheses (`(`,`)`).
To include such characters, define them with `separatorsToIndex`.

Separators are all non-letter characters except spaces and currency characters, such as $€£¥.

With `separatorsToIndex`, Algolia treats separator characters as separate words.
For example, in a search for ""Disney+"", Algolia considers ""Disney"" and ""+"" as two separate words.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> SearchableAttributes { get; } = new(
        name: @"--searchable-attributes")
    {
        Description = @"Attributes used for searching. Attribute names are case-sensitive.

By default, all attributes are searchable and the [Attribute](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#attribute) ranking criterion is turned off.
With a non-empty list, Algolia only returns results with matches in the selected attributes.
In addition, the Attribute ranking criterion is turned on: matches in attributes that are higher in the list of `searchableAttributes` rank first.
To make matches in two attributes rank equally, include them in a comma-separated string, such as `""title,alternate_title""`.
Attributes with the same priority are always unordered.

For more information, see [Searchable attributes](https://www.algolia.com/doc/guides/sending-and-managing-data/prepare-your-data/how-to/setting-searchable-attributes).

**Modifier**

- `unordered(""ATTRIBUTE"")`.

  Ignore the position of a match within the attribute.

Without a modifier, matches at the beginning of an attribute rank higher than matches at the end.
",
    };

    private static Option<string?> AttributeForDistinct { get; } = new(
        name: @"--attribute-for-distinct")
    {
        Description = @"Attribute that should be used to establish groups of results.
Attribute names are case-sensitive.

All records with the same value for this attribute are considered a group.
You can combine `attributeForDistinct` with the `distinct` search parameter to control
how many items per group are included in the search results.

If you want to use the same attribute also for faceting, use the `afterDistinct` modifier of the `attributesForFaceting` setting.
This applies faceting _after_ deduplication, which will result in accurate facet counts.
",
    };

    private static Option<int?> MaxFacetHits { get; } = new(
        name: @"--max-facet-hits")
    {
        Description = @"Maximum number of facet values to return when [searching for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).",
    };

    private static Option<string?> KeepDiacriticsOnCharacters { get; } = new(
        name: @"--keep-diacritics-on-characters")
    {
        Description = @"Characters for which diacritics should be preserved.

By default, Algolia removes diacritics from letters.
For example, `é` becomes `e`. If this causes issues in your search,
you can specify characters that should keep their diacritics.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> CustomRanking { get; } = new(
        name: @"--custom-ranking")
    {
        Description = @"Attributes to use as [custom ranking](https://www.algolia.com/doc/guides/managing-results/must-do/custom-ranking).
Attribute names are case-sensitive.

The custom ranking attributes decide which items are shown first if the other ranking criteria are equal.

Records with missing values for your selected custom ranking attributes are always sorted last.
Boolean attributes are sorted based on their alphabetical order.

**Modifiers**

- `asc(""ATTRIBUTE"")`.

  Sort the index by the values of an attribute, in ascending order.

- `desc(""ATTRIBUTE"")`.

  Sort the index by the values of an attribute, in descending order.

If you use two or more custom ranking attributes,
[reduce the precision](https://www.algolia.com/doc/guides/managing-results/must-do/custom-ranking/how-to/controlling-custom-ranking-metrics-precision) of your first attributes,
or the other attributes will never be applied.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AttributesToRetrieve { get; } = new(
        name: @"--attributes-to-retrieve")
    {
        Description = @"Attributes to include in the API response.
To reduce the size of your response, you can retrieve only some of the attributes.
Attribute names are case-sensitive
- `*` retrieves all attributes, except attributes included in the `customRanking` and `unretrievableAttributes` settings.
- To retrieve all attributes except a specific one, prefix the attribute with a dash and combine it with the `*`: `[""*"", ""-ATTRIBUTE""]`.
- The `objectID` attribute is always included.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Ranking { get; } = new(
        name: @"--ranking")
    {
        Description = @"Determines the order in which Algolia returns your results.

By default, each entry corresponds to a [ranking criteria](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria).
The tie-breaking algorithm sequentially applies each criterion in the order they're specified.
If you configure a replica index for [sorting by an attribute](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/how-to/sort-by-attribute),
you put the sorting attribute at the top of the list.

**Modifiers**

- `asc(""ATTRIBUTE"")`.

  Sort the index by the values of an attribute, in ascending order.
- `desc(""ATTRIBUTE"")`.

  Sort the index by the values of an attribute, in descending order.

Before you modify the default setting,
test your changes in the dashboard,
and by [A/B testing](https://www.algolia.com/doc/guides/ab-testing/what-is-ab-testing).
",
    };

    private static Option<int?> RelevancyStrictness { get; } = new(
        name: @"--relevancy-strictness")
    {
        Description = @"Relevancy threshold below which less relevant results aren't included in the results.
You can only set `relevancyStrictness` on [virtual replica indices](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/replicas/#what-are-virtual-replicas).
Use this setting to strike a balance between the relevance and number of returned results.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AttributesToHighlight { get; } = new(
        name: @"--attributes-to-highlight")
    {
        Description = @"Attributes to highlight.
By default, all searchable attributes are highlighted.
Use `*` to highlight all attributes or use an empty array `[]` to turn off highlighting.
Attribute names are case-sensitive
With highlighting, strings that match the search query are surrounded by HTML tags defined by `highlightPreTag` and `highlightPostTag`.
You can use this to visually highlight matching parts of a search query in your UI
For more information, see [Highlighting and snippeting](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/highlighting-snippeting/js).
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AttributesToSnippet { get; } = new(
        name: @"--attributes-to-snippet")
    {
        Description = @"Attributes for which to enable snippets.
Attribute names are case-sensitive
Snippets provide additional context to matched words.
If you enable snippets, they include 10 words, including the matched word.
The matched word will also be wrapped by HTML tags for highlighting.
You can adjust the number of words with the following notation: `ATTRIBUTE:NUMBER`,
where `NUMBER` is the number of words to be extracted.
",
    };

    private static Option<string?> HighlightPreTag { get; } = new(
        name: @"--highlight-pre-tag")
    {
        Description = @"HTML tag to insert before the highlighted parts in all highlighted results and snippets.",
    };

    private static Option<string?> HighlightPostTag { get; } = new(
        name: @"--highlight-post-tag")
    {
        Description = @"HTML tag to insert after the highlighted parts in all highlighted results and snippets.",
    };

    private static Option<string?> SnippetEllipsisText { get; } = new(
        name: @"--snippet-ellipsis-text")
    {
        Description = @"String used as an ellipsis indicator when a snippet is truncated.",
    };

    private static Option<bool?> RestrictHighlightAndSnippetArrays { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--restrict-highlight-and-snippet-arrays",
        description: @"Whether to restrict highlighting and snippeting to items that at least partially matched the search query.
By default, all items are highlighted and snippeted.
");

    private static Option<int?> HitsPerPage { get; } = new(
        name: @"--hits-per-page")
    {
        Description = @"Number of hits per page.",
    };

    private static Option<int?> MinWordSizefor1Typo { get; } = new(
        name: @"--min-word-sizefor1-typo")
    {
        Description = @"Minimum number of characters a word in the search query must contain to accept matches with [one typo](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#configuring-word-length-for-typos).",
    };

    private static Option<int?> MinWordSizefor2Typos { get; } = new(
        name: @"--min-word-sizefor2-typos")
    {
        Description = @"Minimum number of characters a word in the search query must contain to accept matches with [two typos](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/in-depth/configuring-typo-tolerance/#configuring-word-length-for-typos).",
    };

    private static Option<bool?> AllowTyposOnNumericTokens { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--allow-typos-on-numeric-tokens",
        description: @"Whether to allow typos on numbers in the search query.
Turn off this setting to reduce the number of irrelevant matches
when searching in large sets of similar numbers.
");

    private static Option<global::System.Collections.Generic.IList<string>?> DisableTypoToleranceOnAttributes { get; } = new(
        name: @"--disable-typo-tolerance-on-attributes")
    {
        Description = @"Attributes for which you want to turn off [typo tolerance](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance).
Attribute names are case-sensitive
Returning only exact matches can help when
- [Searching in hyphenated attributes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/typo-tolerance/how-to/how-to-search-in-hyphenated-attributes).
- Reducing the number of matches when you have too many.

  This can happen with attributes that are long blocks of text, such as product descriptions.
Consider alternatives such as `disableTypoToleranceOnWords` or adding synonyms if your attributes have intentional unusual spellings that might look like typos.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::Algolia.SupportedLanguage>?> QueryLanguages { get; } = new(
        name: @"--query-languages")
    {
        Description = @"Languages for language-specific query processing steps such as plurals, stop-word removal, and word-detection dictionaries.
This setting sets a default list of languages used by the `removeStopWords` and `ignorePlurals` settings.
This setting also sets a dictionary for word detection in the logogram-based [CJK](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/normalization/#normalization-for-logogram-based-languages-cjk) languages.
To support this, place the CJK language **first**.
**Always specify a query language.**
If you don't specify an indexing language, the search engine uses all [supported languages](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages),
or the languages you specified with the `ignorePlurals` or `removeStopWords` parameters.
This can lead to unexpected search results.
For more information, see [Language-specific configuration](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations).
",
    };

    private static Option<bool?> DecompoundQuery { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--decompound-query",
        description: @"Whether to split compound words in the query into their building blocks.
For more information, see [Word segmentation](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/language-specific-configurations/#splitting-compound-words).
Word segmentation is supported for these languages: German, Dutch, Finnish, Swedish, and Norwegian.
Decompounding doesn't work for words with [non-spacing mark Unicode characters](https://www.charactercodes.net/category/non-spacing_mark).
For example, `Gartenstühle` won't be decompounded if the `ü` consists of `u` (U+0075) and `◌̈` (U+0308).
");

    private static Option<bool?> EnableRules { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enable-rules",
        description: @"Whether to enable rules.");

    private static Option<bool?> EnablePersonalization { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enable-personalization",
        description: @"Whether to enable Personalization.");

    private static Option<global::Algolia.QueryType?> QueryType { get; } = new(
        name: @"--query-type")
    {
        Description = @"Determines if and how query words are interpreted as prefixes.

By default, only the last query word is treated as a prefix (`prefixLast`).
To turn off prefix search, use `prefixNone`.
Avoid `prefixAll`, which treats all query words as prefixes.
This might lead to counterintuitive results and makes your search slower.

For more information, see [Prefix searching](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/prefix-searching).
",
    };

    private static Option<global::Algolia.RemoveWordsIfNoResults?> RemoveWordsIfNoResults { get; } = new(
        name: @"--remove-words-if-no-results")
    {
        Description = @"Strategy for removing words from the query when it doesn't return any results.
This helps to avoid returning empty search results.

- `none`.

  No words are removed when a query doesn't return results.

- `lastWords`.

  Treat the last (then second to last, then third to last) word as optional,
  until there are results or at most 5 words have been removed.

- `firstWords`.

  Treat the first (then second, then third) word as optional,
  until there are results or at most 5 words have been removed.

- `allOptional`.

  Treat all words as optional.

For more information, see [Remove words to improve results](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/empty-or-insufficient-results/in-depth/why-use-remove-words-if-no-results).
",
    };

    private static Option<global::Algolia.Mode?> Mode { get; } = new(
        name: @"--mode")
    {
        Description = @"Search mode the index will use to query for results.

This setting only applies to indices, for which Algolia enabled NeuralSearch for you.
",
    };

    private static Option<bool?> AdvancedSyntax { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--advanced-syntax",
        description: @"Whether to support phrase matching and excluding words from search queries.
Use the `advancedSyntaxFeatures` parameter to control which feature is supported.
");

    private static Option<global::System.Collections.Generic.IList<string>?> DisableExactOnAttributes { get; } = new(
        name: @"--disable-exact-on-attributes")
    {
        Description = @"Searchable attributes for which you want to [turn off the Exact ranking criterion](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes).
Attribute names are case-sensitive
This can be useful for attributes with long values, where the likelihood of an exact match is high,
such as product descriptions.
Turning off the Exact ranking criterion for these attributes favors exact matching on other attributes.
This reduces the impact of individual attributes with a lot of content on ranking.
",
    };

    private static Option<global::Algolia.ExactOnSingleWordQuery?> ExactOnSingleWordQuery { get; } = new(
        name: @"--exact-on-single-word-query")
    {
        Description = @"Determines how the [Exact ranking criterion](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes) is computed when the search query has only one word.

- `attribute`.

  The Exact ranking criterion is 1 if the query word and attribute value are the same.
  For example, a search for ""road"" will match the value ""road"", but not ""road trip"".

- `none`.

  The Exact ranking criterion is ignored on single-word searches.

- `word`.

  The Exact ranking criterion is 1 if the query word is found in the attribute value.
  The query word must have at least 3 characters and must not be a stop word.
  Only exact matches will be highlighted,
  partial and prefix matches won't.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::Algolia.AlternativesAsExact>?> AlternativesAsExact { get; } = new(
        name: @"--alternatives-as-exact")
    {
        Description = @"Determine which plurals and synonyms should be considered an exact matches.
By default, Algolia treats singular and plural forms of a word, and single-word synonyms, as [exact](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#exact) matches when searching.
For example:
- ""swimsuit"" and ""swimsuits"" are treated the same.
- ""swimsuit"" and ""swimwear"" are treated the same (if they are [synonyms](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/#regular-synonyms)).
- `ignorePlurals`.

  Plurals and similar declensions added by the `ignorePlurals` setting are considered exact matches.
- `singleWordSynonym`.

  Single-word synonyms, such as ""NY"" = ""NYC"", are considered exact matches.
- `multiWordsSynonym`.

  Multi-word synonyms, such as ""NY"" = ""New York"", are considered exact matches.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::Algolia.AdvancedSyntaxFeatures>?> AdvancedSyntaxFeatures { get; } = new(
        name: @"--advanced-syntax-features")
    {
        Description = @"Advanced search syntax features you want to support.
- `exactPhrase`.
  Phrases in quotes must match exactly.
  For example, `sparkly blue ""iPhone case""` only returns records with the exact string ""iPhone case"".
- `excludeWords`.
  Query words prefixed with a `-` must not occur in a record.
  For example, `search -engine` matches records that contain ""search"" but not ""engine"".
This setting only has an effect if `advancedSyntax` is true.
",
    };

    private static Option<bool?> ReplaceSynonymsInHighlight { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--replace-synonyms-in-highlight",
        description: @"Whether to replace a highlighted word with the matched synonym.
By default, the original words are highlighted even if a synonym matches.
For example, with `home` as a synonym for `house` and a search for `home`,
records matching either ""home"" or ""house"" are included in the search results,
and either ""home"" or ""house"" are highlighted
With `replaceSynonymsInHighlight` set to `true`, a search for `home` still matches the same records,
but all occurrences of ""house"" are replaced by ""home"" in the highlighted response.
");

    private static Option<int?> MinProximity { get; } = new(
        name: @"--min-proximity")
    {
        Description = @"Minimum proximity score for two matching words.
This adjusts the [Proximity ranking criterion](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria/#proximity)
by equally scoring matches that are farther apart
For example, if `minProximity` is 2, neighboring matches and matches with one word between them would have the same score.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ResponseFields { get; } = new(
        name: @"--response-fields")
    {
        Description = @"Properties to include in the API response of search and browse requests.
By default, all response properties are included.
To reduce the response size, you can select which properties should be included
An empty list may lead to an empty API response (except properties you can't exclude)
You can't exclude these properties:
`message`, `warning`, `cursor`, `abTestVariantID`,
or any property added by setting `getRankingInfo` to true
Your search depends on the `hits` field. If you omit this field, searches won't return any results.
Your UI might also depend on other properties, for example, for pagination.
Before restricting the response size, check the impact on your search experience.
",
    };

    private static Option<int?> MaxValuesPerFacet { get; } = new(
        name: @"--max-values-per-facet")
    {
        Description = @"Maximum number of facet values to return for each facet.",
    };

    private static Option<string?> SortFacetValuesBy { get; } = new(
        name: @"--sort-facet-values-by")
    {
        Description = @"Order in which to retrieve facet values.
- `count`.

  Facet values are retrieved by decreasing count.
  The count is the number of matching records containing this facet value.
- `alpha`.

  Retrieve facet values alphabetically.
This setting doesn't influence how facet values are displayed in your UI (see `renderingContent`).
For more information, see [facet value display](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/facet-display/js).
",
    };

    private static Option<bool?> AttributeCriteriaComputedByMinProximity { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--attribute-criteria-computed-by-min-proximity",
        description: @"Whether the best matching attribute should be determined by minimum proximity.
This setting only affects ranking if the Attribute ranking criterion comes before Proximity in the `ranking` setting.
If true, the best matching attribute is selected based on the minimum proximity of multiple matches.
Otherwise, the best matching attribute is determined by the order in the `searchableAttributes` setting.

Prefer `attributeCriteriaComputedBy`, which expresses the same two behaviors and adds the `sum` strategy.
If you set both, `attributeCriteriaComputedBy` takes precedence.
");

    private static Option<global::Algolia.AttributeCriteriaComputedBy?> AttributeCriteriaComputedBy { get; } = new(
        name: @"--attribute-criteria-computed-by")
    {
        Description = @"Strategy for computing the Attribute ranking criterion.
This mainly affects multi-word queries with matches in more than one attribute.

The `ranking` setting decides whether `best` takes effect.
When Attribute comes after Proximity, which is the default order, the engine always uses the `minProximity` strategy and ignores `best`.
To select `best`, move Attribute before Proximity in `ranking`.
The `sum` strategy applies in both orders.

- `minProximity`.

  Pick the best matching attribute from the attributes that form the best proximity score.
  On an ordered attribute, the match position breaks ties.
- `best`.

  Pick the best matching attribute from all attributes that match any query word.
  On an ordered attribute, the match position breaks ties.
- `sum`.

  Add up a score for every query word instead of picking one attribute.
  Each word's score comes from the attribute it matched, and from its position in that attribute when the attribute is ordered.
  A query word that matches nothing adds a large penalty.
  A record with a lower total ranks higher.
  A record therefore cannot rank high only because one word of a multi-word query matched a top attribute.
  Use `sum` with short, relevant attributes, and set long-text attributes to unordered.
",
    };

    private static Option<bool?> EnableReRanking { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enable-re-ranking",
        description: @"Whether this search will use [Dynamic Re-Ranking](https://www.algolia.com/doc/guides/algolia-ai/re-ranking).
This setting only has an effect if you activated Dynamic Re-Ranking for this index in the Algolia dashboard.
");
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.UpdatedAtResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.UpdatedAtResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"set-settings", @"Update index settings
Update the specified index settings.

Index settings that you don't specify are left unchanged.
Specify `null` to reset a setting to its default value.

For best performance, update the index settings before you add new records to your index.
");
                        command.Arguments.Add(IndexName);
                        command.Options.Add(ForwardToReplicas);
                        command.Options.Add(AttributesForFaceting);
                        command.Options.Add(Replicas);
                        command.Options.Add(PaginationLimitedTo);
                        command.Options.Add(UnretrievableAttributes);
                        command.Options.Add(DisableTypoToleranceOnWords);
                        command.Options.Add(AttributesToTransliterate);
                        command.Options.Add(CamelCaseAttributes);
                        command.Options.Add(IndexLanguages);
                        command.Options.Add(DisablePrefixOnAttributes);
                        command.Options.Add(AllowCompressionOfIntegerArray);
                        command.Options.Add(NumericAttributesForFiltering);
                        command.Options.Add(SeparatorsToIndex);
                        command.Options.Add(SearchableAttributes);
                        command.Options.Add(AttributeForDistinct);
                        command.Options.Add(MaxFacetHits);
                        command.Options.Add(KeepDiacriticsOnCharacters);
                        command.Options.Add(CustomRanking);
                        command.Options.Add(AttributesToRetrieve);
                        command.Options.Add(Ranking);
                        command.Options.Add(RelevancyStrictness);
                        command.Options.Add(AttributesToHighlight);
                        command.Options.Add(AttributesToSnippet);
                        command.Options.Add(HighlightPreTag);
                        command.Options.Add(HighlightPostTag);
                        command.Options.Add(SnippetEllipsisText);
                        command.Options.Add(RestrictHighlightAndSnippetArrays);
                        command.Options.Add(HitsPerPage);
                        command.Options.Add(MinWordSizefor1Typo);
                        command.Options.Add(MinWordSizefor2Typos);
                        command.Options.Add(AllowTyposOnNumericTokens);
                        command.Options.Add(DisableTypoToleranceOnAttributes);
                        command.Options.Add(QueryLanguages);
                        command.Options.Add(DecompoundQuery);
                        command.Options.Add(EnableRules);
                        command.Options.Add(EnablePersonalization);
                        command.Options.Add(QueryType);
                        command.Options.Add(RemoveWordsIfNoResults);
                        command.Options.Add(Mode);
                        command.Options.Add(AdvancedSyntax);
                        command.Options.Add(DisableExactOnAttributes);
                        command.Options.Add(ExactOnSingleWordQuery);
                        command.Options.Add(AlternativesAsExact);
                        command.Options.Add(AdvancedSyntaxFeatures);
                        command.Options.Add(ReplaceSynonymsInHighlight);
                        command.Options.Add(MinProximity);
                        command.Options.Add(ResponseFields);
                        command.Options.Add(MaxValuesPerFacet);
                        command.Options.Add(SortFacetValuesBy);
                        command.Options.Add(AttributeCriteriaComputedByMinProximity);
                        command.Options.Add(AttributeCriteriaComputedBy);
                        command.Options.Add(EnableReRanking);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.IndexSettings>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var forwardToReplicas = parseResult.GetValue(ForwardToReplicas);
                        var attributesForFaceting = CliRuntime.WasSpecified(parseResult, AttributesForFaceting) ? parseResult.GetValue(AttributesForFaceting) : (__requestBase is { } __AttributesForFacetingBaseValue ? __AttributesForFacetingBaseValue.Value1?.AttributesForFaceting : default);
                        var replicas = CliRuntime.WasSpecified(parseResult, Replicas) ? parseResult.GetValue(Replicas) : (__requestBase is { } __ReplicasBaseValue ? __ReplicasBaseValue.Value1?.Replicas : default);
                        var paginationLimitedTo = CliRuntime.WasSpecified(parseResult, PaginationLimitedTo) ? parseResult.GetValue(PaginationLimitedTo) : (__requestBase is { } __PaginationLimitedToBaseValue ? __PaginationLimitedToBaseValue.Value1?.PaginationLimitedTo : default);
                        var unretrievableAttributes = CliRuntime.WasSpecified(parseResult, UnretrievableAttributes) ? parseResult.GetValue(UnretrievableAttributes) : (__requestBase is { } __UnretrievableAttributesBaseValue ? __UnretrievableAttributesBaseValue.Value1?.UnretrievableAttributes : default);
                        var disableTypoToleranceOnWords = CliRuntime.WasSpecified(parseResult, DisableTypoToleranceOnWords) ? parseResult.GetValue(DisableTypoToleranceOnWords) : (__requestBase is { } __DisableTypoToleranceOnWordsBaseValue ? __DisableTypoToleranceOnWordsBaseValue.Value1?.DisableTypoToleranceOnWords : default);
                        var attributesToTransliterate = CliRuntime.WasSpecified(parseResult, AttributesToTransliterate) ? parseResult.GetValue(AttributesToTransliterate) : (__requestBase is { } __AttributesToTransliterateBaseValue ? __AttributesToTransliterateBaseValue.Value1?.AttributesToTransliterate : default);
                        var camelCaseAttributes = CliRuntime.WasSpecified(parseResult, CamelCaseAttributes) ? parseResult.GetValue(CamelCaseAttributes) : (__requestBase is { } __CamelCaseAttributesBaseValue ? __CamelCaseAttributesBaseValue.Value1?.CamelCaseAttributes : default);
                        var indexLanguages = CliRuntime.WasSpecified(parseResult, IndexLanguages) ? parseResult.GetValue(IndexLanguages) : (__requestBase is { } __IndexLanguagesBaseValue ? __IndexLanguagesBaseValue.Value1?.IndexLanguages : default);
                        var disablePrefixOnAttributes = CliRuntime.WasSpecified(parseResult, DisablePrefixOnAttributes) ? parseResult.GetValue(DisablePrefixOnAttributes) : (__requestBase is { } __DisablePrefixOnAttributesBaseValue ? __DisablePrefixOnAttributesBaseValue.Value1?.DisablePrefixOnAttributes : default);
                        var allowCompressionOfIntegerArray = CliRuntime.WasSpecified(parseResult, AllowCompressionOfIntegerArray) ? parseResult.GetValue(AllowCompressionOfIntegerArray) : (__requestBase is { } __AllowCompressionOfIntegerArrayBaseValue ? __AllowCompressionOfIntegerArrayBaseValue.Value1?.AllowCompressionOfIntegerArray : default);
                        var numericAttributesForFiltering = CliRuntime.WasSpecified(parseResult, NumericAttributesForFiltering) ? parseResult.GetValue(NumericAttributesForFiltering) : (__requestBase is { } __NumericAttributesForFilteringBaseValue ? __NumericAttributesForFilteringBaseValue.Value1?.NumericAttributesForFiltering : default);
                        var separatorsToIndex = CliRuntime.WasSpecified(parseResult, SeparatorsToIndex) ? parseResult.GetValue(SeparatorsToIndex) : (__requestBase is { } __SeparatorsToIndexBaseValue ? __SeparatorsToIndexBaseValue.Value1?.SeparatorsToIndex : default);
                        var searchableAttributes = CliRuntime.WasSpecified(parseResult, SearchableAttributes) ? parseResult.GetValue(SearchableAttributes) : (__requestBase is { } __SearchableAttributesBaseValue ? __SearchableAttributesBaseValue.Value1?.SearchableAttributes : default);
                        var attributeForDistinct = CliRuntime.WasSpecified(parseResult, AttributeForDistinct) ? parseResult.GetValue(AttributeForDistinct) : (__requestBase is { } __AttributeForDistinctBaseValue ? __AttributeForDistinctBaseValue.Value1?.AttributeForDistinct : default);
                        var maxFacetHits = CliRuntime.WasSpecified(parseResult, MaxFacetHits) ? parseResult.GetValue(MaxFacetHits) : (__requestBase is { } __MaxFacetHitsBaseValue ? __MaxFacetHitsBaseValue.Value1?.MaxFacetHits : default);
                        var keepDiacriticsOnCharacters = CliRuntime.WasSpecified(parseResult, KeepDiacriticsOnCharacters) ? parseResult.GetValue(KeepDiacriticsOnCharacters) : (__requestBase is { } __KeepDiacriticsOnCharactersBaseValue ? __KeepDiacriticsOnCharactersBaseValue.Value1?.KeepDiacriticsOnCharacters : default);
                        var customRanking = CliRuntime.WasSpecified(parseResult, CustomRanking) ? parseResult.GetValue(CustomRanking) : (__requestBase is { } __CustomRankingBaseValue ? __CustomRankingBaseValue.Value1?.CustomRanking : default);
                        var attributesToRetrieve = CliRuntime.WasSpecified(parseResult, AttributesToRetrieve) ? parseResult.GetValue(AttributesToRetrieve) : (__requestBase is { } __AttributesToRetrieveBaseValue ? __AttributesToRetrieveBaseValue.Value2?.AttributesToRetrieve : default);
                        var ranking = CliRuntime.WasSpecified(parseResult, Ranking) ? parseResult.GetValue(Ranking) : (__requestBase is { } __RankingBaseValue ? __RankingBaseValue.Value2?.Ranking : default);
                        var relevancyStrictness = CliRuntime.WasSpecified(parseResult, RelevancyStrictness) ? parseResult.GetValue(RelevancyStrictness) : (__requestBase is { } __RelevancyStrictnessBaseValue ? __RelevancyStrictnessBaseValue.Value2?.RelevancyStrictness : default);
                        var attributesToHighlight = CliRuntime.WasSpecified(parseResult, AttributesToHighlight) ? parseResult.GetValue(AttributesToHighlight) : (__requestBase is { } __AttributesToHighlightBaseValue ? __AttributesToHighlightBaseValue.Value2?.AttributesToHighlight : default);
                        var attributesToSnippet = CliRuntime.WasSpecified(parseResult, AttributesToSnippet) ? parseResult.GetValue(AttributesToSnippet) : (__requestBase is { } __AttributesToSnippetBaseValue ? __AttributesToSnippetBaseValue.Value2?.AttributesToSnippet : default);
                        var highlightPreTag = CliRuntime.WasSpecified(parseResult, HighlightPreTag) ? parseResult.GetValue(HighlightPreTag) : (__requestBase is { } __HighlightPreTagBaseValue ? __HighlightPreTagBaseValue.Value2?.HighlightPreTag : default);
                        var highlightPostTag = CliRuntime.WasSpecified(parseResult, HighlightPostTag) ? parseResult.GetValue(HighlightPostTag) : (__requestBase is { } __HighlightPostTagBaseValue ? __HighlightPostTagBaseValue.Value2?.HighlightPostTag : default);
                        var snippetEllipsisText = CliRuntime.WasSpecified(parseResult, SnippetEllipsisText) ? parseResult.GetValue(SnippetEllipsisText) : (__requestBase is { } __SnippetEllipsisTextBaseValue ? __SnippetEllipsisTextBaseValue.Value2?.SnippetEllipsisText : default);
                        var restrictHighlightAndSnippetArrays = CliRuntime.WasSpecified(parseResult, RestrictHighlightAndSnippetArrays) ? parseResult.GetValue(RestrictHighlightAndSnippetArrays) : (__requestBase is { } __RestrictHighlightAndSnippetArraysBaseValue ? __RestrictHighlightAndSnippetArraysBaseValue.Value2?.RestrictHighlightAndSnippetArrays : default);
                        var hitsPerPage = CliRuntime.WasSpecified(parseResult, HitsPerPage) ? parseResult.GetValue(HitsPerPage) : (__requestBase is { } __HitsPerPageBaseValue ? __HitsPerPageBaseValue.Value2?.HitsPerPage : default);
                        var minWordSizefor1Typo = CliRuntime.WasSpecified(parseResult, MinWordSizefor1Typo) ? parseResult.GetValue(MinWordSizefor1Typo) : (__requestBase is { } __MinWordSizefor1TypoBaseValue ? __MinWordSizefor1TypoBaseValue.Value2?.MinWordSizefor1Typo : default);
                        var minWordSizefor2Typos = CliRuntime.WasSpecified(parseResult, MinWordSizefor2Typos) ? parseResult.GetValue(MinWordSizefor2Typos) : (__requestBase is { } __MinWordSizefor2TyposBaseValue ? __MinWordSizefor2TyposBaseValue.Value2?.MinWordSizefor2Typos : default);
                        var allowTyposOnNumericTokens = CliRuntime.WasSpecified(parseResult, AllowTyposOnNumericTokens) ? parseResult.GetValue(AllowTyposOnNumericTokens) : (__requestBase is { } __AllowTyposOnNumericTokensBaseValue ? __AllowTyposOnNumericTokensBaseValue.Value2?.AllowTyposOnNumericTokens : default);
                        var disableTypoToleranceOnAttributes = CliRuntime.WasSpecified(parseResult, DisableTypoToleranceOnAttributes) ? parseResult.GetValue(DisableTypoToleranceOnAttributes) : (__requestBase is { } __DisableTypoToleranceOnAttributesBaseValue ? __DisableTypoToleranceOnAttributesBaseValue.Value2?.DisableTypoToleranceOnAttributes : default);
                        var queryLanguages = CliRuntime.WasSpecified(parseResult, QueryLanguages) ? parseResult.GetValue(QueryLanguages) : (__requestBase is { } __QueryLanguagesBaseValue ? __QueryLanguagesBaseValue.Value2?.QueryLanguages : default);
                        var decompoundQuery = CliRuntime.WasSpecified(parseResult, DecompoundQuery) ? parseResult.GetValue(DecompoundQuery) : (__requestBase is { } __DecompoundQueryBaseValue ? __DecompoundQueryBaseValue.Value2?.DecompoundQuery : default);
                        var enableRules = CliRuntime.WasSpecified(parseResult, EnableRules) ? parseResult.GetValue(EnableRules) : (__requestBase is { } __EnableRulesBaseValue ? __EnableRulesBaseValue.Value2?.EnableRules : default);
                        var enablePersonalization = CliRuntime.WasSpecified(parseResult, EnablePersonalization) ? parseResult.GetValue(EnablePersonalization) : (__requestBase is { } __EnablePersonalizationBaseValue ? __EnablePersonalizationBaseValue.Value2?.EnablePersonalization : default);
                        var queryType = CliRuntime.WasSpecified(parseResult, QueryType) ? parseResult.GetValue(QueryType) : (__requestBase is { } __QueryTypeBaseValue ? __QueryTypeBaseValue.Value2?.QueryType : default);
                        var removeWordsIfNoResults = CliRuntime.WasSpecified(parseResult, RemoveWordsIfNoResults) ? parseResult.GetValue(RemoveWordsIfNoResults) : (__requestBase is { } __RemoveWordsIfNoResultsBaseValue ? __RemoveWordsIfNoResultsBaseValue.Value2?.RemoveWordsIfNoResults : default);
                        var mode = CliRuntime.WasSpecified(parseResult, Mode) ? parseResult.GetValue(Mode) : (__requestBase is { } __ModeBaseValue ? __ModeBaseValue.Value2?.Mode : default);
                        var advancedSyntax = CliRuntime.WasSpecified(parseResult, AdvancedSyntax) ? parseResult.GetValue(AdvancedSyntax) : (__requestBase is { } __AdvancedSyntaxBaseValue ? __AdvancedSyntaxBaseValue.Value2?.AdvancedSyntax : default);
                        var disableExactOnAttributes = CliRuntime.WasSpecified(parseResult, DisableExactOnAttributes) ? parseResult.GetValue(DisableExactOnAttributes) : (__requestBase is { } __DisableExactOnAttributesBaseValue ? __DisableExactOnAttributesBaseValue.Value2?.DisableExactOnAttributes : default);
                        var exactOnSingleWordQuery = CliRuntime.WasSpecified(parseResult, ExactOnSingleWordQuery) ? parseResult.GetValue(ExactOnSingleWordQuery) : (__requestBase is { } __ExactOnSingleWordQueryBaseValue ? __ExactOnSingleWordQueryBaseValue.Value2?.ExactOnSingleWordQuery : default);
                        var alternativesAsExact = CliRuntime.WasSpecified(parseResult, AlternativesAsExact) ? parseResult.GetValue(AlternativesAsExact) : (__requestBase is { } __AlternativesAsExactBaseValue ? __AlternativesAsExactBaseValue.Value2?.AlternativesAsExact : default);
                        var advancedSyntaxFeatures = CliRuntime.WasSpecified(parseResult, AdvancedSyntaxFeatures) ? parseResult.GetValue(AdvancedSyntaxFeatures) : (__requestBase is { } __AdvancedSyntaxFeaturesBaseValue ? __AdvancedSyntaxFeaturesBaseValue.Value2?.AdvancedSyntaxFeatures : default);
                        var replaceSynonymsInHighlight = CliRuntime.WasSpecified(parseResult, ReplaceSynonymsInHighlight) ? parseResult.GetValue(ReplaceSynonymsInHighlight) : (__requestBase is { } __ReplaceSynonymsInHighlightBaseValue ? __ReplaceSynonymsInHighlightBaseValue.Value2?.ReplaceSynonymsInHighlight : default);
                        var minProximity = CliRuntime.WasSpecified(parseResult, MinProximity) ? parseResult.GetValue(MinProximity) : (__requestBase is { } __MinProximityBaseValue ? __MinProximityBaseValue.Value2?.MinProximity : default);
                        var responseFields = CliRuntime.WasSpecified(parseResult, ResponseFields) ? parseResult.GetValue(ResponseFields) : (__requestBase is { } __ResponseFieldsBaseValue ? __ResponseFieldsBaseValue.Value2?.ResponseFields : default);
                        var maxValuesPerFacet = CliRuntime.WasSpecified(parseResult, MaxValuesPerFacet) ? parseResult.GetValue(MaxValuesPerFacet) : (__requestBase is { } __MaxValuesPerFacetBaseValue ? __MaxValuesPerFacetBaseValue.Value2?.MaxValuesPerFacet : default);
                        var sortFacetValuesBy = CliRuntime.WasSpecified(parseResult, SortFacetValuesBy) ? parseResult.GetValue(SortFacetValuesBy) : (__requestBase is { } __SortFacetValuesByBaseValue ? __SortFacetValuesByBaseValue.Value2?.SortFacetValuesBy : default);
                        var attributeCriteriaComputedByMinProximity = CliRuntime.WasSpecified(parseResult, AttributeCriteriaComputedByMinProximity) ? parseResult.GetValue(AttributeCriteriaComputedByMinProximity) : (__requestBase is { } __AttributeCriteriaComputedByMinProximityBaseValue ? __AttributeCriteriaComputedByMinProximityBaseValue.Value2?.AttributeCriteriaComputedByMinProximity : default);
                        var attributeCriteriaComputedBy = CliRuntime.WasSpecified(parseResult, AttributeCriteriaComputedBy) ? parseResult.GetValue(AttributeCriteriaComputedBy) : (__requestBase is { } __AttributeCriteriaComputedByBaseValue ? __AttributeCriteriaComputedByBaseValue.Value2?.AttributeCriteriaComputedBy : default);
                        var enableReRanking = CliRuntime.WasSpecified(parseResult, EnableReRanking) ? parseResult.GetValue(EnableReRanking) : (__requestBase is { } __EnableReRankingBaseValue ? __EnableReRankingBaseValue.Value2?.EnableReRanking : default);
                        var __component1 = __requestBase.Value1 ?? new global::Algolia.BaseIndexSettings();
                        __component1.AttributesForFaceting = attributesForFaceting;
                        __component1.Replicas = replicas;
                        __component1.PaginationLimitedTo = paginationLimitedTo;
                        __component1.UnretrievableAttributes = unretrievableAttributes;
                        __component1.DisableTypoToleranceOnWords = disableTypoToleranceOnWords;
                        __component1.AttributesToTransliterate = attributesToTransliterate;
                        __component1.CamelCaseAttributes = camelCaseAttributes;
                        __component1.IndexLanguages = indexLanguages;
                        __component1.DisablePrefixOnAttributes = disablePrefixOnAttributes;
                        __component1.AllowCompressionOfIntegerArray = allowCompressionOfIntegerArray;
                        __component1.NumericAttributesForFiltering = numericAttributesForFiltering;
                        __component1.SeparatorsToIndex = separatorsToIndex;
                        __component1.SearchableAttributes = searchableAttributes;
                        __component1.AttributeForDistinct = attributeForDistinct;
                        __component1.MaxFacetHits = maxFacetHits;
                        __component1.KeepDiacriticsOnCharacters = keepDiacriticsOnCharacters;
                        __component1.CustomRanking = customRanking;

                        var __component2 = __requestBase.Value2 ?? new global::Algolia.IndexSettingsAsSearchParams();
                        __component2.AttributesToRetrieve = attributesToRetrieve;
                        __component2.Ranking = ranking;
                        __component2.RelevancyStrictness = relevancyStrictness;
                        __component2.AttributesToHighlight = attributesToHighlight;
                        __component2.AttributesToSnippet = attributesToSnippet;
                        __component2.HighlightPreTag = highlightPreTag;
                        __component2.HighlightPostTag = highlightPostTag;
                        __component2.SnippetEllipsisText = snippetEllipsisText;
                        __component2.RestrictHighlightAndSnippetArrays = restrictHighlightAndSnippetArrays;
                        __component2.HitsPerPage = hitsPerPage;
                        __component2.MinWordSizefor1Typo = minWordSizefor1Typo;
                        __component2.MinWordSizefor2Typos = minWordSizefor2Typos;
                        __component2.AllowTyposOnNumericTokens = allowTyposOnNumericTokens;
                        __component2.DisableTypoToleranceOnAttributes = disableTypoToleranceOnAttributes;
                        __component2.QueryLanguages = queryLanguages;
                        __component2.DecompoundQuery = decompoundQuery;
                        __component2.EnableRules = enableRules;
                        __component2.EnablePersonalization = enablePersonalization;
                        __component2.QueryType = queryType;
                        __component2.RemoveWordsIfNoResults = removeWordsIfNoResults;
                        __component2.Mode = mode;
                        __component2.AdvancedSyntax = advancedSyntax;
                        __component2.DisableExactOnAttributes = disableExactOnAttributes;
                        __component2.ExactOnSingleWordQuery = exactOnSingleWordQuery;
                        __component2.AlternativesAsExact = alternativesAsExact;
                        __component2.AdvancedSyntaxFeatures = advancedSyntaxFeatures;
                        __component2.ReplaceSynonymsInHighlight = replaceSynonymsInHighlight;
                        __component2.MinProximity = minProximity;
                        __component2.ResponseFields = responseFields;
                        __component2.MaxValuesPerFacet = maxValuesPerFacet;
                        __component2.SortFacetValuesBy = sortFacetValuesBy;
                        __component2.AttributeCriteriaComputedByMinProximity = attributeCriteriaComputedByMinProximity;
                        __component2.AttributeCriteriaComputedBy = attributeCriteriaComputedBy;
                        __component2.EnableReRanking = enableReRanking;

                        if (CliRuntime.WasSpecified(parseResult, AttributesToRetrieve))
                        {
                            __component1.AdditionalProperties?.Remove(@"attributesToRetrieve");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Ranking))
                        {
                            __component1.AdditionalProperties?.Remove(@"ranking");
                        }
                        if (CliRuntime.WasSpecified(parseResult, RelevancyStrictness))
                        {
                            __component1.AdditionalProperties?.Remove(@"relevancyStrictness");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AttributesToHighlight))
                        {
                            __component1.AdditionalProperties?.Remove(@"attributesToHighlight");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AttributesToSnippet))
                        {
                            __component1.AdditionalProperties?.Remove(@"attributesToSnippet");
                        }
                        if (CliRuntime.WasSpecified(parseResult, HighlightPreTag))
                        {
                            __component1.AdditionalProperties?.Remove(@"highlightPreTag");
                        }
                        if (CliRuntime.WasSpecified(parseResult, HighlightPostTag))
                        {
                            __component1.AdditionalProperties?.Remove(@"highlightPostTag");
                        }
                        if (CliRuntime.WasSpecified(parseResult, SnippetEllipsisText))
                        {
                            __component1.AdditionalProperties?.Remove(@"snippetEllipsisText");
                        }
                        if (CliRuntime.WasSpecified(parseResult, RestrictHighlightAndSnippetArrays))
                        {
                            __component1.AdditionalProperties?.Remove(@"restrictHighlightAndSnippetArrays");
                        }
                        if (CliRuntime.WasSpecified(parseResult, HitsPerPage))
                        {
                            __component1.AdditionalProperties?.Remove(@"hitsPerPage");
                        }
                        if (CliRuntime.WasSpecified(parseResult, MinWordSizefor1Typo))
                        {
                            __component1.AdditionalProperties?.Remove(@"minWordSizefor1Typo");
                        }
                        if (CliRuntime.WasSpecified(parseResult, MinWordSizefor2Typos))
                        {
                            __component1.AdditionalProperties?.Remove(@"minWordSizefor2Typos");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AllowTyposOnNumericTokens))
                        {
                            __component1.AdditionalProperties?.Remove(@"allowTyposOnNumericTokens");
                        }
                        if (CliRuntime.WasSpecified(parseResult, DisableTypoToleranceOnAttributes))
                        {
                            __component1.AdditionalProperties?.Remove(@"disableTypoToleranceOnAttributes");
                        }
                        if (CliRuntime.WasSpecified(parseResult, QueryLanguages))
                        {
                            __component1.AdditionalProperties?.Remove(@"queryLanguages");
                        }
                        if (CliRuntime.WasSpecified(parseResult, DecompoundQuery))
                        {
                            __component1.AdditionalProperties?.Remove(@"decompoundQuery");
                        }
                        if (CliRuntime.WasSpecified(parseResult, EnableRules))
                        {
                            __component1.AdditionalProperties?.Remove(@"enableRules");
                        }
                        if (CliRuntime.WasSpecified(parseResult, EnablePersonalization))
                        {
                            __component1.AdditionalProperties?.Remove(@"enablePersonalization");
                        }
                        if (CliRuntime.WasSpecified(parseResult, QueryType))
                        {
                            __component1.AdditionalProperties?.Remove(@"queryType");
                        }
                        if (CliRuntime.WasSpecified(parseResult, RemoveWordsIfNoResults))
                        {
                            __component1.AdditionalProperties?.Remove(@"removeWordsIfNoResults");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Mode))
                        {
                            __component1.AdditionalProperties?.Remove(@"mode");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AdvancedSyntax))
                        {
                            __component1.AdditionalProperties?.Remove(@"advancedSyntax");
                        }
                        if (CliRuntime.WasSpecified(parseResult, DisableExactOnAttributes))
                        {
                            __component1.AdditionalProperties?.Remove(@"disableExactOnAttributes");
                        }
                        if (CliRuntime.WasSpecified(parseResult, ExactOnSingleWordQuery))
                        {
                            __component1.AdditionalProperties?.Remove(@"exactOnSingleWordQuery");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AlternativesAsExact))
                        {
                            __component1.AdditionalProperties?.Remove(@"alternativesAsExact");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AdvancedSyntaxFeatures))
                        {
                            __component1.AdditionalProperties?.Remove(@"advancedSyntaxFeatures");
                        }
                        if (CliRuntime.WasSpecified(parseResult, ReplaceSynonymsInHighlight))
                        {
                            __component1.AdditionalProperties?.Remove(@"replaceSynonymsInHighlight");
                        }
                        if (CliRuntime.WasSpecified(parseResult, MinProximity))
                        {
                            __component1.AdditionalProperties?.Remove(@"minProximity");
                        }
                        if (CliRuntime.WasSpecified(parseResult, ResponseFields))
                        {
                            __component1.AdditionalProperties?.Remove(@"responseFields");
                        }
                        if (CliRuntime.WasSpecified(parseResult, MaxValuesPerFacet))
                        {
                            __component1.AdditionalProperties?.Remove(@"maxValuesPerFacet");
                        }
                        if (CliRuntime.WasSpecified(parseResult, SortFacetValuesBy))
                        {
                            __component1.AdditionalProperties?.Remove(@"sortFacetValuesBy");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AttributeCriteriaComputedByMinProximity))
                        {
                            __component1.AdditionalProperties?.Remove(@"attributeCriteriaComputedByMinProximity");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AttributeCriteriaComputedBy))
                        {
                            __component1.AdditionalProperties?.Remove(@"attributeCriteriaComputedBy");
                        }
                        if (CliRuntime.WasSpecified(parseResult, EnableReRanking))
                        {
                            __component1.AdditionalProperties?.Remove(@"enableReRanking");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AttributesForFaceting))
                        {
                            __component2.AdditionalProperties?.Remove(@"attributesForFaceting");
                        }
                        if (CliRuntime.WasSpecified(parseResult, Replicas))
                        {
                            __component2.AdditionalProperties?.Remove(@"replicas");
                        }
                        if (CliRuntime.WasSpecified(parseResult, PaginationLimitedTo))
                        {
                            __component2.AdditionalProperties?.Remove(@"paginationLimitedTo");
                        }
                        if (CliRuntime.WasSpecified(parseResult, UnretrievableAttributes))
                        {
                            __component2.AdditionalProperties?.Remove(@"unretrievableAttributes");
                        }
                        if (CliRuntime.WasSpecified(parseResult, DisableTypoToleranceOnWords))
                        {
                            __component2.AdditionalProperties?.Remove(@"disableTypoToleranceOnWords");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AttributesToTransliterate))
                        {
                            __component2.AdditionalProperties?.Remove(@"attributesToTransliterate");
                        }
                        if (CliRuntime.WasSpecified(parseResult, CamelCaseAttributes))
                        {
                            __component2.AdditionalProperties?.Remove(@"camelCaseAttributes");
                        }
                        if (CliRuntime.WasSpecified(parseResult, IndexLanguages))
                        {
                            __component2.AdditionalProperties?.Remove(@"indexLanguages");
                        }
                        if (CliRuntime.WasSpecified(parseResult, DisablePrefixOnAttributes))
                        {
                            __component2.AdditionalProperties?.Remove(@"disablePrefixOnAttributes");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AllowCompressionOfIntegerArray))
                        {
                            __component2.AdditionalProperties?.Remove(@"allowCompressionOfIntegerArray");
                        }
                        if (CliRuntime.WasSpecified(parseResult, NumericAttributesForFiltering))
                        {
                            __component2.AdditionalProperties?.Remove(@"numericAttributesForFiltering");
                        }
                        if (CliRuntime.WasSpecified(parseResult, SeparatorsToIndex))
                        {
                            __component2.AdditionalProperties?.Remove(@"separatorsToIndex");
                        }
                        if (CliRuntime.WasSpecified(parseResult, SearchableAttributes))
                        {
                            __component2.AdditionalProperties?.Remove(@"searchableAttributes");
                        }
                        if (CliRuntime.WasSpecified(parseResult, AttributeForDistinct))
                        {
                            __component2.AdditionalProperties?.Remove(@"attributeForDistinct");
                        }
                        if (CliRuntime.WasSpecified(parseResult, MaxFacetHits))
                        {
                            __component2.AdditionalProperties?.Remove(@"maxFacetHits");
                        }
                        if (CliRuntime.WasSpecified(parseResult, KeepDiacriticsOnCharacters))
                        {
                            __component2.AdditionalProperties?.Remove(@"keepDiacriticsOnCharacters");
                        }
                        if (CliRuntime.WasSpecified(parseResult, CustomRanking))
                        {
                            __component2.AdditionalProperties?.Remove(@"customRanking");
                        }
                        var request = new global::Algolia.IndexSettings(
                            __component1, __component2);

                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.SetSettingsAsync(
                                    indexName: indexName,
                                    forwardToReplicas: forwardToReplicas,
                                    request: request,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Algolia.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}