
#nullable enable

namespace Algolia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteByParams
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.FacetFiltersJsonConverter))]
        public global::Algolia.FacetFilters? FacetFilters { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.NumericFiltersJsonConverter))]
        public global::Algolia.NumericFilters? NumericFilters { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.TagFiltersJsonConverter))]
        public global::Algolia.TagFilters? TagFilters { get; set; }

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
        /// Maximum radius for a search around a central location.<br/>
        /// This parameter works in combination with the `aroundLatLng` and `aroundLatLngViaIP` parameters.<br/>
        /// By default, the search radius is determined automatically from the density of hits around the central location.<br/>
        /// The search radius is small if there are many hits close to the central coordinates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aroundRadius")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.AroundRadiusJsonConverter))]
        public global::Algolia.AroundRadius? AroundRadius { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insideBoundingBox")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Algolia.JsonConverters.InsideBoundingBoxJsonConverter))]
        public global::Algolia.InsideBoundingBox? InsideBoundingBox { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteByParams" /> class.
        /// </summary>
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
        /// <param name="aroundLatLng">
        /// Coordinates for the center of a circle, expressed as a comma-separated string of latitude and longitude.<br/>
        /// Only records included within a circle around this central location are included in the results.<br/>
        /// The radius of the circle is determined by the `aroundRadius` and `minimumAroundRadius` settings.<br/>
        /// This parameter is ignored if you also specify `insidePolygon` or `insideBoundingBox`.<br/>
        /// Example: 40.71,-74.01
        /// </param>
        /// <param name="aroundRadius">
        /// Maximum radius for a search around a central location.<br/>
        /// This parameter works in combination with the `aroundLatLng` and `aroundLatLngViaIP` parameters.<br/>
        /// By default, the search radius is determined automatically from the density of hits around the central location.<br/>
        /// The search radius is small if there are many hits close to the central coordinates.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteByParams(
            global::Algolia.FacetFilters? facetFilters,
            string? filters,
            global::Algolia.NumericFilters? numericFilters,
            global::Algolia.TagFilters? tagFilters,
            string? aroundLatLng,
            global::Algolia.AroundRadius? aroundRadius,
            global::Algolia.InsideBoundingBox? insideBoundingBox,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? insidePolygon)
        {
            this.FacetFilters = facetFilters;
            this.Filters = filters;
            this.NumericFilters = numericFilters;
            this.TagFilters = tagFilters;
            this.AroundLatLng = aroundLatLng;
            this.AroundRadius = aroundRadius;
            this.InsideBoundingBox = insideBoundingBox;
            this.InsidePolygon = insidePolygon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteByParams" /> class.
        /// </summary>
        public DeleteByParams()
        {
        }

    }
}