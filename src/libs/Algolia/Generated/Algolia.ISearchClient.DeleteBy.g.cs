#nullable enable

namespace Algolia
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Delete records matching a filter<br/>
        /// This operation doesn't accept empty filters.<br/>
        /// This operation is resource-intensive.<br/>
        /// Use it only if you can't get the object IDs of the records you want to delete.<br/>
        /// It's more efficient to get a list of object IDs with the [`browse` operation](https://www.algolia.com/doc/rest-api/search/browse),<br/>
        /// and then delete the records using the [`batch` operation](https://www.algolia.com/doc/rest-api/search/batch).<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Algolia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> DeleteByAsync(
            string indexName,

            global::Algolia.DeleteByParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete records matching a filter<br/>
        /// This operation doesn't accept empty filters.<br/>
        /// This operation is resource-intensive.<br/>
        /// Use it only if you can't get the object IDs of the records you want to delete.<br/>
        /// It's more efficient to get a list of object IDs with the [`browse` operation](https://www.algolia.com/doc/rest-api/search/browse),<br/>
        /// and then delete the records using the [`batch` operation](https://www.algolia.com/doc/rest-api/search/batch).<br/>
        /// This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
        /// </summary>
        /// <param name="indexName">
        /// Example: ALGOLIA_INDEX_NAME
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Algolia.UpdatedAtResponse> DeleteByAsync(
            string indexName,
            global::Algolia.FacetFilters? facetFilters = default,
            string? filters = default,
            global::Algolia.NumericFilters? numericFilters = default,
            global::Algolia.TagFilters? tagFilters = default,
            string? aroundLatLng = default,
            global::Algolia.AroundRadius? aroundRadius = default,
            global::Algolia.InsideBoundingBox? insideBoundingBox = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? insidePolygon = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}