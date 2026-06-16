#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchSearchForFacetValuesCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Argument<string> FacetName { get; } = new(
        name: @"facet-name")
    {
        Description = @"Facet attribute in which to search for values.

This attribute must be included in the `attributesForFaceting` index setting with the `searchable()` modifier.
",
    };

    private static Option<string?> Params { get; } = new(
        name: @"--params")
    {
        Description = @"Search parameters as a URL-encoded query string.",
    };

    private static Option<string?> FacetQuery { get; } = new(
        name: @"--facet-query")
    {
        Description = @"Text to search inside the facet's values.",
    };

    private static Option<int?> MaxFacetHits { get; } = new(
        name: @"--max-facet-hits")
    {
        Description = @"Maximum number of facet values to return when [searching for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).",
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

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.SearchForFacetValuesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.SearchForFacetValuesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"for-facet-values", @"Search for facet values
Searches for values of a specified facet attribute.

- By default, facet values are sorted by decreasing count.

  You can adjust this with the `sortFacetValueBy` parameter.
- Searching for facet values doesn't work if you have **more than 65 searchable facets and searchable attributes combined**.
");
                        command.Arguments.Add(IndexName);
                        command.Arguments.Add(FacetName);
                        command.Options.Add(Params);
                        command.Options.Add(FacetQuery);
                        command.Options.Add(MaxFacetHits);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.SearchForFacetValuesRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var facetName = parseResult.GetRequiredValue(FacetName);
                        var @params = CliRuntime.WasSpecified(parseResult, Params) ? parseResult.GetValue(Params) : (__requestBase is { } __ParamsBaseValue ? __ParamsBaseValue.Params : default);
                        var facetQuery = CliRuntime.WasSpecified(parseResult, FacetQuery) ? parseResult.GetValue(FacetQuery) : (__requestBase is { } __FacetQueryBaseValue ? __FacetQueryBaseValue.FacetQuery : default);
                        var maxFacetHits = CliRuntime.WasSpecified(parseResult, MaxFacetHits) ? parseResult.GetValue(MaxFacetHits) : (__requestBase is { } __MaxFacetHitsBaseValue ? __MaxFacetHitsBaseValue.MaxFacetHits : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.SearchForFacetValuesAsync(
                                    indexName: indexName,
                                    facetName: facetName,
                                    @params: @params,
                                    facetQuery: facetQuery,
                                    maxFacetHits: maxFacetHits,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Algolia.SourceGenerationContext.Default,
                                        @"FacetHits",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Algolia.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}