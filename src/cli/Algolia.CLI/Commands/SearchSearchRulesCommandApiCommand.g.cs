#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchSearchRulesCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Option<string?> Query { get; } = new(
        name: @"--query")
    {
        Description = @"Search query for rules.",
    };

    private static Option<global::Algolia.Anchoring?> Anchoring { get; } = new(
        name: @"--anchoring")
    {
        Description = @"Which part of the search query the pattern should match:

- `startsWith`. The pattern must match the beginning of the query.
- `endsWith`. The pattern must match the end of the query.
- `is`. The pattern must match the query exactly.
- `contains`. The pattern must match anywhere in the query.

Empty queries are only allowed as patterns with `anchoring: is`.
",
    };

    private static Option<string?> Context { get; } = new(
        name: @"--context")
    {
        Description = @"Only return rules that match the context (exact match).",
    };

    private static Option<int?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"Requested page of the API response.

Algolia uses `page` and `hitsPerPage` to control how search results are displayed ([paginated](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js)).

- `hitsPerPage`: sets the number of search results (_hits_) displayed per page.
- `page`: specifies the page number of the search results you want to retrieve. Page numbering starts at 0, so the first page is `page=0`, the second is `page=1`, and so on.

For example, to display 10 results per page starting from the third page, set `hitsPerPage` to 10 and `page` to 2.
",
    };

    private static Option<int?> HitsPerPage { get; } = new(
        name: @"--hits-per-page")
    {
        Description = @"Maximum number of hits per page.

Algolia uses `page` and `hitsPerPage` to control how search results are displayed ([paginated](https://www.algolia.com/doc/guides/building-search-ui/ui-and-ux-patterns/pagination/js)).

- `hitsPerPage`: sets the number of search results (_hits_) displayed per page.
- `page`: specifies the page number of the search results you want to retrieve. Page numbering starts at 0, so the first page is `page=0`, the second is `page=1`, and so on.

For example, to display 10 results per page starting from the third page, set `hitsPerPage` to 10 and `page` to 2.
",
    };

    private static Option<global::Algolia.OneOf<bool?, object>?> Enabled { get; } = new(
        name: @"--enabled")
    {
        Description = @"",
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

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.SearchRulesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.SearchRulesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"rules", @"Search for rules
Searches for rules in your index.");
                        command.Arguments.Add(IndexName);
                        command.Options.Add(Query);
                        command.Options.Add(Anchoring);
                        command.Options.Add(Context);
                        command.Options.Add(Page);
                        command.Options.Add(HitsPerPage);
                        command.Options.Add(Enabled);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.SearchRulesRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var query = CliRuntime.WasSpecified(parseResult, Query) ? parseResult.GetValue(Query) : (__requestBase is { } __QueryBaseValue ? __QueryBaseValue.Query : default);
                        var anchoring = CliRuntime.WasSpecified(parseResult, Anchoring) ? parseResult.GetValue(Anchoring) : (__requestBase is { } __AnchoringBaseValue ? __AnchoringBaseValue.Anchoring : default);
                        var context = CliRuntime.WasSpecified(parseResult, Context) ? parseResult.GetValue(Context) : (__requestBase is { } __ContextBaseValue ? __ContextBaseValue.Context : default);
                        var page = CliRuntime.WasSpecified(parseResult, Page) ? parseResult.GetValue(Page) : (__requestBase is { } __PageBaseValue ? __PageBaseValue.Page : default);
                        var hitsPerPage = CliRuntime.WasSpecified(parseResult, HitsPerPage) ? parseResult.GetValue(HitsPerPage) : (__requestBase is { } __HitsPerPageBaseValue ? __HitsPerPageBaseValue.HitsPerPage : default);
                        var enabled = CliRuntime.WasSpecified(parseResult, Enabled) ? parseResult.GetValue(Enabled) : (__requestBase is { } __EnabledBaseValue ? __EnabledBaseValue.Enabled : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.SearchRulesAsync(
                                    indexName: indexName,
                                    query: query,
                                    anchoring: anchoring,
                                    context: context,
                                    page: page,
                                    hitsPerPage: hitsPerPage,
                                    enabled: enabled,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Algolia.SourceGenerationContext.Default,
                                        @"Hits",
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