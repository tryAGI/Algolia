#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchGetSettingsCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Option<int?> GetVersion { get; } = new(
        name: @"--get-version")
    {
        Description = @"When set to 2, the endpoint will not include `synonyms` in the response. This parameter is here for backward compatibility.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.SettingsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.SettingsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-settings", @"Retrieve index settings
Retrieves an object with non-null index settings.");
                        command.Arguments.Add(IndexName);
                        command.Options.Add(GetVersion);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var getVersion = parseResult.GetValue(GetVersion);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.GetSettingsAsync(
                                    indexName: indexName,
                                    getVersion: getVersion,
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