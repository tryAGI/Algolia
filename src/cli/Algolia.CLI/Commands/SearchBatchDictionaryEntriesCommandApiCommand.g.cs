#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchBatchDictionaryEntriesCommandApiCommand
{
    private static Argument<global::Algolia.DictionaryType> DictionaryName { get; } = new(
        name: @"dictionary-name")
    {
        Description = @"Dictionary type in which to search.",
    };

    private static Option<bool?> ClearExistingDictionaryEntries { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--clear-existing-dictionary-entries",
        description: @"Whether to replace all custom entries in the dictionary with the ones sent with this request.");

    private static Option<global::System.Collections.Generic.IList<global::Algolia.BatchDictionaryEntriesRequestRequest>> Requests { get; } = new(
        name: @"--requests")
    {
        Description = @"List of additions and deletions to your dictionaries.",
        Required = true,
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
        var command = new Command(@"batch-dictionary-entries", @"Add or delete dictionary entries
Adds or deletes multiple entries from your plurals, segmentation, or stop word dictionaries.");
                        command.Arguments.Add(DictionaryName);
                        command.Options.Add(ClearExistingDictionaryEntries);
                        command.Options.Add(Requests);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.BatchDictionaryEntriesRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var dictionaryName = parseResult.GetRequiredValue(DictionaryName);
                        var clearExistingDictionaryEntries = CliRuntime.WasSpecified(parseResult, ClearExistingDictionaryEntries) ? parseResult.GetValue(ClearExistingDictionaryEntries) : (__requestBase is { } __ClearExistingDictionaryEntriesBaseValue ? __ClearExistingDictionaryEntriesBaseValue.ClearExistingDictionaryEntries : default);
                        var requests = parseResult.GetRequiredValue(Requests);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.BatchDictionaryEntriesAsync(
                                    dictionaryName: dictionaryName,
                                    clearExistingDictionaryEntries: clearExistingDictionaryEntries,
                                    requests: requests,
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