#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchDeleteByCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Option<global::Algolia.FacetFilters?> FacetFilters { get; } = new(
        name: @"--facet-filters")
    {
        Description = @"Filter the search by facet values, so that only records with the same facet values are retrieved.

**Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**

- `[filter1, filter2]` is interpreted as `filter1 AND filter2`.
- `[[filter1, filter2], filter3]` is interpreted as `filter1 OR filter2 AND filter3`.
- `facet:-value` is interpreted as `NOT facet:value`.

While it's best to avoid attributes that start with a `-`, you can still filter them by escaping with a backslash:
`facet:\-value`.
",
    };

    private static Option<string?> Filters { get; } = new(
        name: @"--filters")
    {
        Description = @"Filter expression to only include items that match the filter criteria in the response.

You can use these filter expressions:

- **Numeric filters.** `<facet> <op> <number>`, where `<op>` is one of `<`, `<=`, `=`, `!=`, `>`, `>=`.
- **Ranges.** `<facet>:<lower> TO <upper>`, where `<lower>` and `<upper>` are the lower and upper limits of the range (inclusive).
- **Facet filters.** `<facet>:<value>`, where `<facet>` is a facet attribute (case-sensitive) and `<value>` a facet value.
- **Tag filters.** `_tags:<value>` or just `<value>` (case-sensitive).
- **Boolean filters.** `<facet>: true | false`.

You can combine filters with `AND`, `OR`, and `NOT` operators with the following restrictions:

- You can only combine filters of the same type with `OR`.

  **Not supported:** `facet:value OR num > 3`.
- You can't use `NOT` with combinations of filters.

  **Not supported:** `NOT(facet:value OR facet:value)`
- You can't combine conjunctions (`AND`) with `OR`.

  **Not supported:** `facet:value OR (facet:value AND facet:value)`

Use quotes if the facet attribute name or facet value contains spaces, keywords (`OR`, `AND`, `NOT`), or quotes.
If a facet attribute is an array, the filter matches if it matches at least one element of the array.

For more information, see [Filters](https://www.algolia.com/doc/guides/managing-results/refine-results/filtering).
",
    };

    private static Option<global::Algolia.NumericFilters?> NumericFilters { get; } = new(
        name: @"--numeric-filters")
    {
        Description = @"Filter by numeric facets.

**Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**

You can use numeric comparison operators: `<`, `<=`, `=`, `!=`, `>`, `>=`.
Comparisons are precise up to 3 decimals.
You can also provide ranges: `facet:<lower> TO <upper>`. The range includes the lower and upper boundaries.
The same combination rules apply as for `facetFilters`.
",
    };

    private static Option<global::Algolia.TagFilters?> TagFilters { get; } = new(
        name: @"--tag-filters")
    {
        Description = @"Filter the search by values of the special `_tags` attribute.

**Prefer using the `filters` parameter, which supports all filter types and combinations with boolean operators.**

Different from regular facets, `_tags` can only be used for filtering (including or excluding records).
You won't get a facet count.
The same combination and escaping rules apply as for `facetFilters`.
",
    };

    private static Option<string?> AroundLatLng { get; } = new(
        name: @"--around-lat-lng")
    {
        Description = @"Coordinates for the center of a circle, expressed as a comma-separated string of latitude and longitude.

Only records included within a circle around this central location are included in the results.
The radius of the circle is determined by the `aroundRadius` and `minimumAroundRadius` settings.
This parameter is ignored if you also specify `insidePolygon` or `insideBoundingBox`.
",
    };

    private static Option<global::Algolia.AroundRadius?> AroundRadius { get; } = new(
        name: @"--around-radius")
    {
        Description = @"Maximum radius for a search around a central location.

This parameter works in combination with the `aroundLatLng` and `aroundLatLngViaIP` parameters.
By default, the search radius is determined automatically from the density of hits around the central location.
The search radius is small if there are many hits close to the central coordinates.
",
    };

    private static Option<global::Algolia.InsideBoundingBox?> InsideBoundingBox { get; } = new(
        name: @"--inside-bounding-box")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>?> InsidePolygon { get; } = new(
        name: @"--inside-polygon")
    {
        Description = @"Coordinates of a polygon in which to search.

Polygons are defined by 3 to 10,000 points. Each point is represented by its latitude and longitude.
Provide multiple polygons as nested arrays.
For more information, see [filtering inside polygons](https://www.algolia.com/doc/guides/managing-results/refine-results/geolocation/#filtering-inside-rectangular-or-polygonal-areas).
This parameter is ignored if you also specify `insideBoundingBox`.
",
    };
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


    public static Command Create()
    {
        var command = new Command(@"delete-by", @"Delete records matching a filter
This operation doesn't accept empty filters.

This operation is resource-intensive.
Use it only if you can't get the object IDs of the records you want to delete.
It's more efficient to get a list of object IDs with the [`browse` operation](https://www.algolia.com/doc/rest-api/search/browse),
and then delete the records using the [`batch` operation](https://www.algolia.com/doc/rest-api/search/batch).

This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
");
                        command.Arguments.Add(IndexName);
                        command.Options.Add(FacetFilters);
                        command.Options.Add(Filters);
                        command.Options.Add(NumericFilters);
                        command.Options.Add(TagFilters);
                        command.Options.Add(AroundLatLng);
                        command.Options.Add(AroundRadius);
                        command.Options.Add(InsideBoundingBox);
                        command.Options.Add(InsidePolygon);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.DeleteByParams>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var facetFilters = CliRuntime.WasSpecified(parseResult, FacetFilters) ? parseResult.GetValue(FacetFilters) : (__requestBase is { } __FacetFiltersBaseValue ? __FacetFiltersBaseValue.FacetFilters : default);
                        var filters = CliRuntime.WasSpecified(parseResult, Filters) ? parseResult.GetValue(Filters) : (__requestBase is { } __FiltersBaseValue ? __FiltersBaseValue.Filters : default);
                        var numericFilters = CliRuntime.WasSpecified(parseResult, NumericFilters) ? parseResult.GetValue(NumericFilters) : (__requestBase is { } __NumericFiltersBaseValue ? __NumericFiltersBaseValue.NumericFilters : default);
                        var tagFilters = CliRuntime.WasSpecified(parseResult, TagFilters) ? parseResult.GetValue(TagFilters) : (__requestBase is { } __TagFiltersBaseValue ? __TagFiltersBaseValue.TagFilters : default);
                        var aroundLatLng = CliRuntime.WasSpecified(parseResult, AroundLatLng) ? parseResult.GetValue(AroundLatLng) : (__requestBase is { } __AroundLatLngBaseValue ? __AroundLatLngBaseValue.AroundLatLng : default);
                        var aroundRadius = CliRuntime.WasSpecified(parseResult, AroundRadius) ? parseResult.GetValue(AroundRadius) : (__requestBase is { } __AroundRadiusBaseValue ? __AroundRadiusBaseValue.AroundRadius : default);
                        var insideBoundingBox = CliRuntime.WasSpecified(parseResult, InsideBoundingBox) ? parseResult.GetValue(InsideBoundingBox) : (__requestBase is { } __InsideBoundingBoxBaseValue ? __InsideBoundingBoxBaseValue.InsideBoundingBox : default);
                        var insidePolygon = CliRuntime.WasSpecified(parseResult, InsidePolygon) ? parseResult.GetValue(InsidePolygon) : (__requestBase is { } __InsidePolygonBaseValue ? __InsidePolygonBaseValue.InsidePolygon : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.DeleteByAsync(
                                    indexName: indexName,
                                    facetFilters: facetFilters,
                                    filters: filters,
                                    numericFilters: numericFilters,
                                    tagFilters: tagFilters,
                                    aroundLatLng: aroundLatLng,
                                    aroundRadius: aroundRadius,
                                    insideBoundingBox: insideBoundingBox,
                                    insidePolygon: insidePolygon,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Algolia.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}