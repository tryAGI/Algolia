#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchSearchSynonymsCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Option<string?> Query { get; } = new(
        name: @"--query")
    {
        Description = @"Search query.",
    };

    private static Option<global::Algolia.SynonymType?> Type { get; } = new(
        name: @"--type")
    {
        Description = @"Synonym type.",
    };

    private static Option<int?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"Page of search results to retrieve.",
    };

    private static Option<int?> HitsPerPage { get; } = new(
        name: @"--hits-per-page")
    {
        Description = @"Number of hits per page.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.SearchSynonymsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.SearchSynonymsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"synonyms", @"Search for synonyms
Searches for synonyms in your index.");
                        command.Arguments.Add(IndexName);
                        command.Options.Add(Query);
                        command.Options.Add(Type);
                        command.Options.Add(Page);
                        command.Options.Add(HitsPerPage);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.SearchSynonymsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var query = CliRuntime.WasSpecified(parseResult, Query) ? parseResult.GetValue(Query) : (__requestBase is { } __QueryBaseValue ? __QueryBaseValue.Query : default);
                        var type = CliRuntime.WasSpecified(parseResult, Type) ? parseResult.GetValue(Type) : (__requestBase is { } __TypeBaseValue ? __TypeBaseValue.Type : default);
                        var page = CliRuntime.WasSpecified(parseResult, Page) ? parseResult.GetValue(Page) : (__requestBase is { } __PageBaseValue ? __PageBaseValue.Page : default);
                        var hitsPerPage = CliRuntime.WasSpecified(parseResult, HitsPerPage) ? parseResult.GetValue(HitsPerPage) : (__requestBase is { } __HitsPerPageBaseValue ? __HitsPerPageBaseValue.HitsPerPage : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.SearchSynonymsAsync(
                                    indexName: indexName,
                                    query: query,
                                    type: type,
                                    page: page,
                                    hitsPerPage: hitsPerPage,
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