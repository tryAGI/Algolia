#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchSearchDictionaryEntriesCommandApiCommand
{
    private static Argument<global::Algolia.DictionaryType> DictionaryName { get; } = new(
        name: @"dictionary-name")
    {
        Description = @"Dictionary type in which to search.",
    };

    private static Option<string> Query { get; } = new(
        name: @"--query")
    {
        Description = @"Search query.",
        Required = true,
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

    private static Option<global::Algolia.SupportedLanguage?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"ISO code for a supported language.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.SearchDictionaryEntriesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.SearchDictionaryEntriesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"dictionary-entries", @"Search dictionary entries
Searches for standard and custom dictionary entries.");
                        command.Arguments.Add(DictionaryName);
                        command.Options.Add(Query);
                        command.Options.Add(Page);
                        command.Options.Add(HitsPerPage);
                        command.Options.Add(Language);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.SearchDictionaryEntriesRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var dictionaryName = parseResult.GetRequiredValue(DictionaryName);
                        var query = parseResult.GetRequiredValue(Query);
                        var page = CliRuntime.WasSpecified(parseResult, Page) ? parseResult.GetValue(Page) : (__requestBase is { } __PageBaseValue ? __PageBaseValue.Page : default);
                        var hitsPerPage = CliRuntime.WasSpecified(parseResult, HitsPerPage) ? parseResult.GetValue(HitsPerPage) : (__requestBase is { } __HitsPerPageBaseValue ? __HitsPerPageBaseValue.HitsPerPage : default);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.SearchDictionaryEntriesAsync(
                                    dictionaryName: dictionaryName,
                                    query: query,
                                    page: page,
                                    hitsPerPage: hitsPerPage,
                                    language: language,
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