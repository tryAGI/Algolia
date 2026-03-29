
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseSearchResponse
    {
        /// <summary>
        /// A/B test ID. This is only included in the response for indices that are part of an A/B test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abTestID")]
        public int? AbTestID { get; set; }

        /// <summary>
        /// Variant ID. This is only included in the response for indices that are part of an A/B test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abTestVariantID")]
        public int? AbTestVariantID { get; set; }

        /// <summary>
        /// Computed geographical location.<br/>
        /// Example: 40.71,-74.01
        /// </summary>
        /// <example>40.71,-74.01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aroundLatLng")]
        public string? AroundLatLng { get; set; }

        /// <summary>
        /// Distance from a central coordinate provided by `aroundLatLng`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticRadius")]
        public string? AutomaticRadius { get; set; }

        /// <summary>
        /// Whether certain properties of the search response are calculated exhaustive (exact) or approximated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exhaustive")]
        public global::Algolia.BaseSearchResponseExhaustive? Exhaustive { get; set; }

        /// <summary>
        /// Rules applied to the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedRules")]
        public global::System.Collections.Generic.IList<object>? AppliedRules { get; set; }

        /// <summary>
        /// See the `facetsCount` field of the `exhaustive` object in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exhaustiveFacetsCount")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ExhaustiveFacetsCount { get; set; }

        /// <summary>
        /// See the `nbHits` field of the `exhaustive` object in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exhaustiveNbHits")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ExhaustiveNbHits { get; set; }

        /// <summary>
        /// See the `typo` field of the `exhaustive` object in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exhaustiveTypo")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ExhaustiveTypo { get; set; }

        /// <summary>
        /// Facet counts.<br/>
        /// Example: {"category":{"food":1,"tech":42}}
        /// </summary>
        /// <example>{"category":{"food":1,"tech":42}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>>? Facets { get; set; }

        /// <summary>
        /// Statistics for numerical facets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets_stats")]
        public global::System.Collections.Generic.Dictionary<string, global::Algolia.BaseSearchResponseFacetsStats2>? FacetsStats { get; set; }

        /// <summary>
        /// Index name used for the query.<br/>
        /// Example: indexName
        /// </summary>
        /// <example>indexName</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public string? Index { get; set; }

        /// <summary>
        /// Index name used for the query. During A/B testing, the targeted index isn't always the index used by the query.<br/>
        /// Example: indexNameAlt
        /// </summary>
        /// <example>indexNameAlt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexUsed")]
        public string? IndexUsed { get; set; }

        /// <summary>
        /// Warnings about the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Number of hits selected and sorted by the relevant sort algorithm.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nbSortedHits")]
        public int? NbSortedHits { get; set; }

        /// <summary>
        /// Post-[normalization](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/#what-does-normalization-mean) query string that will be searched.<br/>
        /// Example: george clo
        /// </summary>
        /// <example>george clo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsedQuery")]
        public string? ParsedQuery { get; set; }

        /// <summary>
        /// Time the server took to process the request, in milliseconds.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("processingTimeMS")]
        public int? ProcessingTimeMS { get; set; }

        /// <summary>
        /// Experimental. List of processing steps and their times, in milliseconds. You can use this list to investigate performance issues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processingTimingsMS")]
        public object? ProcessingTimingsMS { get; set; }

        /// <summary>
        /// Markup text indicating which parts of the original query have been removed to retrieve a non-empty result set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryAfterRemoval")]
        public string? QueryAfterRemoval { get; set; }

        /// <summary>
        /// [Redirect results to a URL](https://www.algolia.com/doc/guides/managing-results/rules/merchandising-and-promoting/how-to/redirects), this this parameter is for internal use only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Algolia.BaseSearchResponseRedirect? Redirect { get; set; }

        /// <summary>
        /// Extra data that can be used in the search UI.<br/>
        /// You can use this to control aspects of your search UI, such as the order of facet names and values<br/>
        /// without changing your frontend code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renderingContent")]
        public global::Algolia.RenderingContent? RenderingContent { get; set; }

        /// <summary>
        /// Time the server took to process the request, in milliseconds.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverTimeMS")]
        public int? ServerTimeMS { get; set; }

        /// <summary>
        /// Host name of the server that processed the request.<br/>
        /// Example: c2-uk-3.algolia.net
        /// </summary>
        /// <example>c2-uk-3.algolia.net</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverUsed")]
        public string? ServerUsed { get; set; }

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
        /// Unique identifier for the query. This is used for [click analytics](https://www.algolia.com/doc/guides/analytics/click-analytics).<br/>
        /// Example: a00dbc80a8d13c4565a442e7e2dca80a
        /// </summary>
        /// <example>a00dbc80a8d13c4565a442e7e2dca80a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryID")]
        public string? QueryID { get; set; }

        /// <summary>
        /// Whether automatic events collection is enabled for the application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_automaticInsights")]
        public bool? AutomaticInsights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchResponse" /> class.
        /// </summary>
        /// <param name="abTestID">
        /// A/B test ID. This is only included in the response for indices that are part of an A/B test.
        /// </param>
        /// <param name="abTestVariantID">
        /// Variant ID. This is only included in the response for indices that are part of an A/B test.
        /// </param>
        /// <param name="aroundLatLng">
        /// Computed geographical location.<br/>
        /// Example: 40.71,-74.01
        /// </param>
        /// <param name="automaticRadius">
        /// Distance from a central coordinate provided by `aroundLatLng`.
        /// </param>
        /// <param name="exhaustive">
        /// Whether certain properties of the search response are calculated exhaustive (exact) or approximated.
        /// </param>
        /// <param name="appliedRules">
        /// Rules applied to the query.
        /// </param>
        /// <param name="facets">
        /// Facet counts.<br/>
        /// Example: {"category":{"food":1,"tech":42}}
        /// </param>
        /// <param name="facetsStats">
        /// Statistics for numerical facets.
        /// </param>
        /// <param name="index">
        /// Index name used for the query.<br/>
        /// Example: indexName
        /// </param>
        /// <param name="indexUsed">
        /// Index name used for the query. During A/B testing, the targeted index isn't always the index used by the query.<br/>
        /// Example: indexNameAlt
        /// </param>
        /// <param name="message">
        /// Warnings about the query.
        /// </param>
        /// <param name="nbSortedHits">
        /// Number of hits selected and sorted by the relevant sort algorithm.<br/>
        /// Example: 20
        /// </param>
        /// <param name="parsedQuery">
        /// Post-[normalization](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/#what-does-normalization-mean) query string that will be searched.<br/>
        /// Example: george clo
        /// </param>
        /// <param name="processingTimeMS">
        /// Time the server took to process the request, in milliseconds.<br/>
        /// Example: 20
        /// </param>
        /// <param name="processingTimingsMS">
        /// Experimental. List of processing steps and their times, in milliseconds. You can use this list to investigate performance issues.
        /// </param>
        /// <param name="queryAfterRemoval">
        /// Markup text indicating which parts of the original query have been removed to retrieve a non-empty result set.
        /// </param>
        /// <param name="redirect">
        /// [Redirect results to a URL](https://www.algolia.com/doc/guides/managing-results/rules/merchandising-and-promoting/how-to/redirects), this this parameter is for internal use only.
        /// </param>
        /// <param name="renderingContent">
        /// Extra data that can be used in the search UI.<br/>
        /// You can use this to control aspects of your search UI, such as the order of facet names and values<br/>
        /// without changing your frontend code.
        /// </param>
        /// <param name="serverTimeMS">
        /// Time the server took to process the request, in milliseconds.<br/>
        /// Example: 20
        /// </param>
        /// <param name="serverUsed">
        /// Host name of the server that processed the request.<br/>
        /// Example: c2-uk-3.algolia.net
        /// </param>
        /// <param name="userData">
        /// An object with custom data.<br/>
        /// You can store up to 32kB as custom data.<br/>
        /// Default Value: {}<br/>
        /// Example: {"settingID":"f2a7b51e3503acc6a39b3784ffb84300","pluginVersion":"1.6.0"}
        /// </param>
        /// <param name="queryID">
        /// Unique identifier for the query. This is used for [click analytics](https://www.algolia.com/doc/guides/analytics/click-analytics).<br/>
        /// Example: a00dbc80a8d13c4565a442e7e2dca80a
        /// </param>
        /// <param name="automaticInsights">
        /// Whether automatic events collection is enabled for the application.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseSearchResponse(
            int? abTestID,
            int? abTestVariantID,
            string? aroundLatLng,
            string? automaticRadius,
            global::Algolia.BaseSearchResponseExhaustive? exhaustive,
            global::System.Collections.Generic.IList<object>? appliedRules,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>>? facets,
            global::System.Collections.Generic.Dictionary<string, global::Algolia.BaseSearchResponseFacetsStats2>? facetsStats,
            string? index,
            string? indexUsed,
            string? message,
            int? nbSortedHits,
            string? parsedQuery,
            int? processingTimeMS,
            object? processingTimingsMS,
            string? queryAfterRemoval,
            global::Algolia.BaseSearchResponseRedirect? redirect,
            global::Algolia.RenderingContent? renderingContent,
            int? serverTimeMS,
            string? serverUsed,
            global::Algolia.UserData? userData,
            string? queryID,
            bool? automaticInsights)
        {
            this.AbTestID = abTestID;
            this.AbTestVariantID = abTestVariantID;
            this.AroundLatLng = aroundLatLng;
            this.AutomaticRadius = automaticRadius;
            this.Exhaustive = exhaustive;
            this.AppliedRules = appliedRules;
            this.Facets = facets;
            this.FacetsStats = facetsStats;
            this.Index = index;
            this.IndexUsed = indexUsed;
            this.Message = message;
            this.NbSortedHits = nbSortedHits;
            this.ParsedQuery = parsedQuery;
            this.ProcessingTimeMS = processingTimeMS;
            this.ProcessingTimingsMS = processingTimingsMS;
            this.QueryAfterRemoval = queryAfterRemoval;
            this.Redirect = redirect;
            this.RenderingContent = renderingContent;
            this.ServerTimeMS = serverTimeMS;
            this.ServerUsed = serverUsed;
            this.UserData = userData;
            this.QueryID = queryID;
            this.AutomaticInsights = automaticInsights;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchResponse" /> class.
        /// </summary>
        public BaseSearchResponse()
        {
        }
    }
}