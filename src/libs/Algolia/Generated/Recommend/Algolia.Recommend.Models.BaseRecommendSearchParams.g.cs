
#nullable enable

namespace Algolia.Recommend
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseRecommendSearchParams
    {
        /// <summary>
        /// Keywords to be used instead of the search query to conduct a more broader search<br/>
        /// Using the `similarQuery` parameter changes other settings<br/>
        /// - `queryType` is set to `prefixNone`.<br/>
        /// - `removeStopWords` is set to true.<br/>
        /// - `words` is set as the first ranking criterion.<br/>
        /// - All remaining words are treated as `optionalWords`<br/>
        /// Since the `similarQuery` is supposed to do a broad search, they usually return many results.<br/>
        /// Combine it with `filters` to narrow down the list of results.<br/>
        /// Example: comedy drama crime Macy Buscemi
        /// </summary>
        /// <example>comedy drama crime Macy Buscemi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarQuery")]
        public string? SimilarQuery { get; set; }

        /// <summary>
        /// Filter expression to only include items that match the filter criteria in the response.<br/>
        /// You can use these filter expressions:<br/>
        /// - **Numeric filters.** `&lt;facet&gt; &lt;op&gt; &lt;number&gt;`, where `&lt;op&gt;` is one of `&lt;`, `&lt;=`, `=`, `!=`, `&gt;`, `&gt;=`.<br/>
        /// - **Ranges.** `&lt;facet&gt;:&lt;lower&gt; TO &lt;upper&gt;`, where `&lt;lower&gt;` and `&lt;upper&gt;` are the lower and upper limits of the range (inclusive).<br/>
        /// - **Facet filters.** `&lt;facet&gt;:&lt;value&gt;`, where `&lt;facet&gt;` is a facet attribute (case-sensitive) and `&lt;value&gt;` a facet value.<br/>
        /// - **Tag filters.** `_tags:&lt;value&gt;` or just `&lt;value&gt;` (case-sensitive).<br/>
        /// - **Boolean filters.** `&lt;facet&gt;: true | false`.<br/>
        /// You can combine filters with `AND`, `OR`, and `NOT` operators with the following restrictions:<br/>
        /// - You can only combine filters of the same type with `OR`.<br/>
        ///   **Not supported:** `facet:value OR num &gt; 3`.<br/>
        /// - You can't use `NOT` with combinations of filters.<br/>
        ///   **Not supported:** `NOT(facet:value OR facet:value)`<br/>
        /// - You can't combine conjunctions (`AND`) with `OR`.<br/>
        ///   **Not supported:** `facet:value OR (facet:value AND facet:value)`<br/>
        /// Use quotes if the facet attribute name or facet value contains spaces, keywords (`OR`, `AND`, `NOT`), or quotes.<br/>
        /// If a facet attribute is an array, the filter matches if it matches at least one element of the array.<br/>
        /// For more information, see [Filters](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering).<br/>
        /// Example: (category:Book OR category:Ebook) AND _tags:published
        /// </summary>
        /// <example>(category:Book OR category:Ebook) AND _tags:published</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public string? Filters { get; set; }

        /// <summary>
        /// Filter the search by facet values, so that only records with the same facet values are retrieved.<br/>
        /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
        /// - `[filter1, filter2]` is interpreted as `filter1 AND filter2`.<br/>
        /// - `[[filter1, filter2], filter3]` is interpreted as `filter1 OR filter2 AND filter3`.<br/>
        /// - `facet:-value` is interpreted as `NOT facet:value`.<br/>
        /// While it's best to avoid attributes that start with a `-`, you can still filter them by escaping with a backslash:<br/>
        /// `facet:\-value`.<br/>
        /// Example: [[category:Book, category:-Movie], author:John Doe]
        /// </summary>
        /// <example>[[category:Book, category:-Movie], author:John Doe]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetFilters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.FacetFiltersJsonConverter))]
        public global::Algolia.Recommend.FacetFilters? FacetFilters { get; set; }

        /// <summary>
        /// Filters to promote or demote records in the search results.<br/>
        /// Optional filters work like facet filters, but they don't exclude records from the search results.<br/>
        /// Records that match the optional filter rank before records that don't match.<br/>
        /// If you're using a negative filter `facet:-value`, matching records rank after records that don't match.<br/>
        /// - Optional filters are applied _after_ sort-by attributes.<br/>
        /// - Optional filters are applied _before_ custom ranking attributes (in the default [ranking](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria)).<br/>
        /// - Optional filters don't work with numeric attributes.<br/>
        /// - On virtual replicas, optional filters are applied _after_ the replica's [relevant sort](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/relevant-sort).<br/>
        /// Example: [category:Book, author:John Doe]
        /// </summary>
        /// <example>[category:Book, author:John Doe]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionalFilters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.OptionalFiltersJsonConverter))]
        public global::Algolia.Recommend.OptionalFilters? OptionalFilters { get; set; }

        /// <summary>
        /// Filter by numeric facets.<br/>
        /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
        /// You can use numeric comparison operators: `&lt;`, `&lt;=`, `=`, `!=`, `&gt;`, `&gt;=`.<br/>
        /// Comparisons are precise up to 3 decimals.<br/>
        /// You can also provide ranges: `facet:&lt;lower&gt; TO &lt;upper&gt;`. The range includes the lower and upper boundaries.<br/>
        /// The same combination rules apply as for `facetFilters`.<br/>
        /// Example: [[inStock = 1, deliveryDate &lt; 1441755506], price &lt; 1000]
        /// </summary>
        /// <example>[[inStock = 1, deliveryDate &lt; 1441755506], price &lt; 1000]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numericFilters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.NumericFiltersJsonConverter))]
        public global::Algolia.Recommend.NumericFilters? NumericFilters { get; set; }

        /// <summary>
        /// Filter the search by values of the special `_tags` attribute.<br/>
        /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
        /// Different from regular facets, `_tags` can only be used for filtering (including or excluding records).<br/>
        /// You won't get a facet count.<br/>
        /// The same combination and escaping rules apply as for `facetFilters`.<br/>
        /// Example: [[Book, Movie], SciFi]
        /// </summary>
        /// <example>[[Book, Movie], SciFi]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagFilters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.TagFiltersJsonConverter))]
        public global::Algolia.Recommend.TagFilters? TagFilters { get; set; }

        /// <summary>
        /// Whether to sum all filter scores<br/>
        /// If true, all filter scores are summed.<br/>
        /// Otherwise, the maximum filter score is kept.<br/>
        /// For more information, see [filter scores](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering/in-depth/filter-scoring/#accumulating-scores-with-sumorfiltersscores).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sumOrFiltersScores")]
        public bool? SumOrFiltersScores { get; set; }

        /// <summary>
        /// Restricts a search to a subset of your searchable attributes.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Default Value: []<br/>
        /// Example: [title, author]
        /// </summary>
        /// <example>[title, author]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictSearchableAttributes")]
        public global::System.Collections.Generic.IList<string>? RestrictSearchableAttributes { get; set; }

        /// <summary>
        /// Facets for which to retrieve facet values that match the search criteria and the number of matching facet values<br/>
        /// To retrieve all facets, use the wildcard character `*`.<br/>
        /// For more information, see [facets](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#contextual-facet-values-and-counts).<br/>
        /// Default Value: []<br/>
        /// Example: [*]
        /// </summary>
        /// <example>[*]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets")]
        public global::System.Collections.Generic.IList<string>? Facets { get; set; }

        /// <summary>
        /// Whether faceting should be applied after deduplication with `distinct`<br/>
        /// This leads to accurate facet counts when using faceting in combination with `distinct`.<br/>
        /// It's usually better to use `afterDistinct` modifiers in the `attributesForFaceting` setting,<br/>
        /// as `facetingAfterDistinct` only computes correct facet counts if all records have the same facet values for the `attributeForDistinct`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facetingAfterDistinct")]
        public bool? FacetingAfterDistinct { get; set; }

        /// <summary>
        /// Coordinates for the center of a circle, expressed as a comma-separated string of latitude and longitude.<br/>
        /// Only records included within a circle around this central location are included in the results.<br/>
        /// The radius of the circle is determined by the `aroundRadius` and `minimumAroundRadius` settings.<br/>
        /// This parameter is ignored if you also specify `insidePolygon` or `insideBoundingBox`.<br/>
        /// Example: 40.71,-74.01
        /// </summary>
        /// <example>40.71,-74.01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aroundLatLng")]
        public string? AroundLatLng { get; set; }

        /// <summary>
        /// Whether to obtain the coordinates from the request's IP address.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aroundLatLngViaIP")]
        public bool? AroundLatLngViaIP { get; set; }

        /// <summary>
        /// Maximum radius for a search around a central location.<br/>
        /// This parameter works in combination with the `aroundLatLng` and `aroundLatLngViaIP` parameters.<br/>
        /// By default, the search radius is determined automatically from the density of hits around the central location.<br/>
        /// The search radius is small if there are many hits close to the central coordinates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aroundRadius")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.AroundRadiusJsonConverter))]
        public global::Algolia.Recommend.AroundRadius? AroundRadius { get; set; }

        /// <summary>
        /// Precision of a coordinate-based search in meters to group results with similar distances.<br/>
        /// The Geo ranking criterion considers all matches within the same range of distances to be equal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aroundPrecision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.AroundPrecisionJsonConverter))]
        public global::Algolia.Recommend.AroundPrecision? AroundPrecision { get; set; }

        /// <summary>
        /// Minimum radius (in meters) for a search around a location when `aroundRadius` isn't set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumAroundRadius")]
        public int? MinimumAroundRadius { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insideBoundingBox")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.Recommend.JsonConverters.InsideBoundingBoxJsonConverter))]
        public global::Algolia.Recommend.InsideBoundingBox? InsideBoundingBox { get; set; }

        /// <summary>
        /// Coordinates of a polygon in which to search.<br/>
        /// Polygons are defined by 3 to 10,000 points. Each point is represented by its latitude and longitude.<br/>
        /// Provide multiple polygons as nested arrays.<br/>
        /// For more information, see [filtering inside polygons](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas).<br/>
        /// This parameter is ignored if you also specify `insideBoundingBox`.<br/>
        /// Example: [[47.3165, 4.9665, 47.3424, 5.0201, 47.32, 4.9], [40.9234, 2.1185, 38.643, 1.9916, 39.2587, 2.0104]]
        /// </summary>
        /// <example>[[47.3165, 4.9665, 47.3424, 5.0201, 47.32, 4.9], [40.9234, 2.1185, 38.643, 1.9916, 39.2587, 2.0104]]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("insidePolygon")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? InsidePolygon { get; set; }

        /// <summary>
        /// ISO language codes that adjust settings that are useful for processing natural language queries (as opposed to keyword searches)<br/>
        /// - Sets `removeStopWords` and `ignorePlurals` to the list of provided languages.<br/>
        /// - Sets `removeWordsIfNoResults` to `allOptional`.<br/>
        /// - Adds a `natural_language` attribute to `ruleContexts` and `analyticsTags`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("naturalLanguages")]
        public global::System.Collections.Generic.IList<global::Algolia.Recommend.SupportedLanguage>? NaturalLanguages { get; set; }

        /// <summary>
        /// Assigns a rule context to the search query<br/>
        /// [Rule contexts](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/how-to/customize-search-results-by-platform/#whats-a-context) are strings that you can use to trigger matching rules.<br/>
        /// Default Value: []<br/>
        /// Example: [mobile]
        /// </summary>
        /// <example>[mobile]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleContexts")]
        public global::System.Collections.Generic.IList<string>? RuleContexts { get; set; }

        /// <summary>
        /// Impact that Personalization should have on this search<br/>
        /// The higher this value is, the more Personalization determines the ranking compared to other factors.<br/>
        /// For more information, see [Understanding Personalization impact](https://www.algolia.com/doc/guides/personalization/personalizing-results/in-depth/configuring-personalization/#understanding-personalization-impact).<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personalizationImpact")]
        public int? PersonalizationImpact { get; set; }

        /// <summary>
        /// Unique pseudonymous or anonymous user identifier.<br/>
        /// This helps with analytics and click and conversion events.<br/>
        /// For more information, see [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken).<br/>
        /// Example: test-user-123
        /// </summary>
        /// <example>test-user-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userToken")]
        public string? UserToken { get; set; }

        /// <summary>
        /// Whether the search response should include detailed ranking information.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("getRankingInfo")]
        public bool? GetRankingInfo { get; set; }

        /// <summary>
        /// Whether to take into account an index's synonyms for this search.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synonyms")]
        public bool? Synonyms { get; set; }

        /// <summary>
        /// Whether to include a `queryID` attribute in the response<br/>
        /// The query ID is a unique identifier for a search query and is required for tracking [click and conversion events](https://www.algolia.com/doc/guides/sending-events/getting-started).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clickAnalytics")]
        public bool? ClickAnalytics { get; set; }

        /// <summary>
        /// Whether this search will be included in Analytics.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analytics")]
        public bool? Analytics { get; set; }

        /// <summary>
        /// Tags to apply to the query for [segmenting analytics data](https://www.algolia.com/doc/guides/search-analytics/guides/segments).<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyticsTags")]
        public global::System.Collections.Generic.IList<string>? AnalyticsTags { get; set; }

        /// <summary>
        /// Whether to include this search when calculating processing-time percentiles.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentileComputation")]
        public bool? PercentileComputation { get; set; }

        /// <summary>
        /// Whether to enable A/B testing for this search.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableABTest")]
        public bool? EnableABTest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRecommendSearchParams" /> class.
        /// </summary>
        /// <param name="similarQuery">
        /// Keywords to be used instead of the search query to conduct a more broader search<br/>
        /// Using the `similarQuery` parameter changes other settings<br/>
        /// - `queryType` is set to `prefixNone`.<br/>
        /// - `removeStopWords` is set to true.<br/>
        /// - `words` is set as the first ranking criterion.<br/>
        /// - All remaining words are treated as `optionalWords`<br/>
        /// Since the `similarQuery` is supposed to do a broad search, they usually return many results.<br/>
        /// Combine it with `filters` to narrow down the list of results.<br/>
        /// Example: comedy drama crime Macy Buscemi
        /// </param>
        /// <param name="filters">
        /// Filter expression to only include items that match the filter criteria in the response.<br/>
        /// You can use these filter expressions:<br/>
        /// - **Numeric filters.** `&lt;facet&gt; &lt;op&gt; &lt;number&gt;`, where `&lt;op&gt;` is one of `&lt;`, `&lt;=`, `=`, `!=`, `&gt;`, `&gt;=`.<br/>
        /// - **Ranges.** `&lt;facet&gt;:&lt;lower&gt; TO &lt;upper&gt;`, where `&lt;lower&gt;` and `&lt;upper&gt;` are the lower and upper limits of the range (inclusive).<br/>
        /// - **Facet filters.** `&lt;facet&gt;:&lt;value&gt;`, where `&lt;facet&gt;` is a facet attribute (case-sensitive) and `&lt;value&gt;` a facet value.<br/>
        /// - **Tag filters.** `_tags:&lt;value&gt;` or just `&lt;value&gt;` (case-sensitive).<br/>
        /// - **Boolean filters.** `&lt;facet&gt;: true | false`.<br/>
        /// You can combine filters with `AND`, `OR`, and `NOT` operators with the following restrictions:<br/>
        /// - You can only combine filters of the same type with `OR`.<br/>
        ///   **Not supported:** `facet:value OR num &gt; 3`.<br/>
        /// - You can't use `NOT` with combinations of filters.<br/>
        ///   **Not supported:** `NOT(facet:value OR facet:value)`<br/>
        /// - You can't combine conjunctions (`AND`) with `OR`.<br/>
        ///   **Not supported:** `facet:value OR (facet:value AND facet:value)`<br/>
        /// Use quotes if the facet attribute name or facet value contains spaces, keywords (`OR`, `AND`, `NOT`), or quotes.<br/>
        /// If a facet attribute is an array, the filter matches if it matches at least one element of the array.<br/>
        /// For more information, see [Filters](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering).<br/>
        /// Example: (category:Book OR category:Ebook) AND _tags:published
        /// </param>
        /// <param name="facetFilters">
        /// Filter the search by facet values, so that only records with the same facet values are retrieved.<br/>
        /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
        /// - `[filter1, filter2]` is interpreted as `filter1 AND filter2`.<br/>
        /// - `[[filter1, filter2], filter3]` is interpreted as `filter1 OR filter2 AND filter3`.<br/>
        /// - `facet:-value` is interpreted as `NOT facet:value`.<br/>
        /// While it's best to avoid attributes that start with a `-`, you can still filter them by escaping with a backslash:<br/>
        /// `facet:\-value`.<br/>
        /// Example: [[category:Book, category:-Movie], author:John Doe]
        /// </param>
        /// <param name="optionalFilters">
        /// Filters to promote or demote records in the search results.<br/>
        /// Optional filters work like facet filters, but they don't exclude records from the search results.<br/>
        /// Records that match the optional filter rank before records that don't match.<br/>
        /// If you're using a negative filter `facet:-value`, matching records rank after records that don't match.<br/>
        /// - Optional filters are applied _after_ sort-by attributes.<br/>
        /// - Optional filters are applied _before_ custom ranking attributes (in the default [ranking](https://www.algolia.com/doc/guides/managing-results/relevance-overview/in-depth/ranking-criteria)).<br/>
        /// - Optional filters don't work with numeric attributes.<br/>
        /// - On virtual replicas, optional filters are applied _after_ the replica's [relevant sort](https://www.algolia.com/doc/guides/managing-results/refine-results/sorting/in-depth/relevant-sort).<br/>
        /// Example: [category:Book, author:John Doe]
        /// </param>
        /// <param name="numericFilters">
        /// Filter by numeric facets.<br/>
        /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
        /// You can use numeric comparison operators: `&lt;`, `&lt;=`, `=`, `!=`, `&gt;`, `&gt;=`.<br/>
        /// Comparisons are precise up to 3 decimals.<br/>
        /// You can also provide ranges: `facet:&lt;lower&gt; TO &lt;upper&gt;`. The range includes the lower and upper boundaries.<br/>
        /// The same combination rules apply as for `facetFilters`.<br/>
        /// Example: [[inStock = 1, deliveryDate &lt; 1441755506], price &lt; 1000]
        /// </param>
        /// <param name="tagFilters">
        /// Filter the search by values of the special `_tags` attribute.<br/>
        /// **Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**<br/>
        /// Different from regular facets, `_tags` can only be used for filtering (including or excluding records).<br/>
        /// You won't get a facet count.<br/>
        /// The same combination and escaping rules apply as for `facetFilters`.<br/>
        /// Example: [[Book, Movie], SciFi]
        /// </param>
        /// <param name="sumOrFiltersScores">
        /// Whether to sum all filter scores<br/>
        /// If true, all filter scores are summed.<br/>
        /// Otherwise, the maximum filter score is kept.<br/>
        /// For more information, see [filter scores](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering/in-depth/filter-scoring/#accumulating-scores-with-sumorfiltersscores).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="restrictSearchableAttributes">
        /// Restricts a search to a subset of your searchable attributes.<br/>
        /// Attribute names are case-sensitive.<br/>
        /// Default Value: []<br/>
        /// Example: [title, author]
        /// </param>
        /// <param name="facets">
        /// Facets for which to retrieve facet values that match the search criteria and the number of matching facet values<br/>
        /// To retrieve all facets, use the wildcard character `*`.<br/>
        /// For more information, see [facets](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#contextual-facet-values-and-counts).<br/>
        /// Default Value: []<br/>
        /// Example: [*]
        /// </param>
        /// <param name="facetingAfterDistinct">
        /// Whether faceting should be applied after deduplication with `distinct`<br/>
        /// This leads to accurate facet counts when using faceting in combination with `distinct`.<br/>
        /// It's usually better to use `afterDistinct` modifiers in the `attributesForFaceting` setting,<br/>
        /// as `facetingAfterDistinct` only computes correct facet counts if all records have the same facet values for the `attributeForDistinct`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="aroundLatLng">
        /// Coordinates for the center of a circle, expressed as a comma-separated string of latitude and longitude.<br/>
        /// Only records included within a circle around this central location are included in the results.<br/>
        /// The radius of the circle is determined by the `aroundRadius` and `minimumAroundRadius` settings.<br/>
        /// This parameter is ignored if you also specify `insidePolygon` or `insideBoundingBox`.<br/>
        /// Example: 40.71,-74.01
        /// </param>
        /// <param name="aroundLatLngViaIP">
        /// Whether to obtain the coordinates from the request's IP address.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="aroundRadius">
        /// Maximum radius for a search around a central location.<br/>
        /// This parameter works in combination with the `aroundLatLng` and `aroundLatLngViaIP` parameters.<br/>
        /// By default, the search radius is determined automatically from the density of hits around the central location.<br/>
        /// The search radius is small if there are many hits close to the central coordinates.
        /// </param>
        /// <param name="aroundPrecision">
        /// Precision of a coordinate-based search in meters to group results with similar distances.<br/>
        /// The Geo ranking criterion considers all matches within the same range of distances to be equal.
        /// </param>
        /// <param name="minimumAroundRadius">
        /// Minimum radius (in meters) for a search around a location when `aroundRadius` isn't set.
        /// </param>
        /// <param name="insideBoundingBox"></param>
        /// <param name="insidePolygon">
        /// Coordinates of a polygon in which to search.<br/>
        /// Polygons are defined by 3 to 10,000 points. Each point is represented by its latitude and longitude.<br/>
        /// Provide multiple polygons as nested arrays.<br/>
        /// For more information, see [filtering inside polygons](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas).<br/>
        /// This parameter is ignored if you also specify `insideBoundingBox`.<br/>
        /// Example: [[47.3165, 4.9665, 47.3424, 5.0201, 47.32, 4.9], [40.9234, 2.1185, 38.643, 1.9916, 39.2587, 2.0104]]
        /// </param>
        /// <param name="naturalLanguages">
        /// ISO language codes that adjust settings that are useful for processing natural language queries (as opposed to keyword searches)<br/>
        /// - Sets `removeStopWords` and `ignorePlurals` to the list of provided languages.<br/>
        /// - Sets `removeWordsIfNoResults` to `allOptional`.<br/>
        /// - Adds a `natural_language` attribute to `ruleContexts` and `analyticsTags`.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="ruleContexts">
        /// Assigns a rule context to the search query<br/>
        /// [Rule contexts](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/how-to/customize-search-results-by-platform/#whats-a-context) are strings that you can use to trigger matching rules.<br/>
        /// Default Value: []<br/>
        /// Example: [mobile]
        /// </param>
        /// <param name="personalizationImpact">
        /// Impact that Personalization should have on this search<br/>
        /// The higher this value is, the more Personalization determines the ranking compared to other factors.<br/>
        /// For more information, see [Understanding Personalization impact](https://www.algolia.com/doc/guides/personalization/personalizing-results/in-depth/configuring-personalization/#understanding-personalization-impact).<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="userToken">
        /// Unique pseudonymous or anonymous user identifier.<br/>
        /// This helps with analytics and click and conversion events.<br/>
        /// For more information, see [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken).<br/>
        /// Example: test-user-123
        /// </param>
        /// <param name="getRankingInfo">
        /// Whether the search response should include detailed ranking information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="synonyms">
        /// Whether to take into account an index's synonyms for this search.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="clickAnalytics">
        /// Whether to include a `queryID` attribute in the response<br/>
        /// The query ID is a unique identifier for a search query and is required for tracking [click and conversion events](https://www.algolia.com/doc/guides/sending-events/getting-started).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="analytics">
        /// Whether this search will be included in Analytics.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="analyticsTags">
        /// Tags to apply to the query for [segmenting analytics data](https://www.algolia.com/doc/guides/search-analytics/guides/segments).<br/>
        /// Default Value: []
        /// </param>
        /// <param name="percentileComputation">
        /// Whether to include this search when calculating processing-time percentiles.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enableABTest">
        /// Whether to enable A/B testing for this search.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseRecommendSearchParams(
            string? similarQuery,
            string? filters,
            global::Algolia.Recommend.FacetFilters? facetFilters,
            global::Algolia.Recommend.OptionalFilters? optionalFilters,
            global::Algolia.Recommend.NumericFilters? numericFilters,
            global::Algolia.Recommend.TagFilters? tagFilters,
            bool? sumOrFiltersScores,
            global::System.Collections.Generic.IList<string>? restrictSearchableAttributes,
            global::System.Collections.Generic.IList<string>? facets,
            bool? facetingAfterDistinct,
            string? aroundLatLng,
            bool? aroundLatLngViaIP,
            global::Algolia.Recommend.AroundRadius? aroundRadius,
            global::Algolia.Recommend.AroundPrecision? aroundPrecision,
            int? minimumAroundRadius,
            global::Algolia.Recommend.InsideBoundingBox? insideBoundingBox,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? insidePolygon,
            global::System.Collections.Generic.IList<global::Algolia.Recommend.SupportedLanguage>? naturalLanguages,
            global::System.Collections.Generic.IList<string>? ruleContexts,
            int? personalizationImpact,
            string? userToken,
            bool? getRankingInfo,
            bool? synonyms,
            bool? clickAnalytics,
            bool? analytics,
            global::System.Collections.Generic.IList<string>? analyticsTags,
            bool? percentileComputation,
            bool? enableABTest)
        {
            this.SimilarQuery = similarQuery;
            this.Filters = filters;
            this.FacetFilters = facetFilters;
            this.OptionalFilters = optionalFilters;
            this.NumericFilters = numericFilters;
            this.TagFilters = tagFilters;
            this.SumOrFiltersScores = sumOrFiltersScores;
            this.RestrictSearchableAttributes = restrictSearchableAttributes;
            this.Facets = facets;
            this.FacetingAfterDistinct = facetingAfterDistinct;
            this.AroundLatLng = aroundLatLng;
            this.AroundLatLngViaIP = aroundLatLngViaIP;
            this.AroundRadius = aroundRadius;
            this.AroundPrecision = aroundPrecision;
            this.MinimumAroundRadius = minimumAroundRadius;
            this.InsideBoundingBox = insideBoundingBox;
            this.InsidePolygon = insidePolygon;
            this.NaturalLanguages = naturalLanguages;
            this.RuleContexts = ruleContexts;
            this.PersonalizationImpact = personalizationImpact;
            this.UserToken = userToken;
            this.GetRankingInfo = getRankingInfo;
            this.Synonyms = synonyms;
            this.ClickAnalytics = clickAnalytics;
            this.Analytics = analytics;
            this.AnalyticsTags = analyticsTags;
            this.PercentileComputation = percentileComputation;
            this.EnableABTest = enableABTest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRecommendSearchParams" /> class.
        /// </summary>
        public BaseRecommendSearchParams()
        {
        }
    }
}