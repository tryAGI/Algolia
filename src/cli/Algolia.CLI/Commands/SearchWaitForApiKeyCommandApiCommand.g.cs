#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchWaitForApiKeyCommandApiCommand
{
    private static Option<string> Key { get; } = new(
        name: @"--key")
    {
        Description = @"API key to wait for.",
        Required = true,
    };

    private static Option<global::Algolia.ApiKeyOperation> Operation { get; } = new(
        name: @"--operation")
    {
        Description = @"Whether the API key was created, updated, or deleted.",
        Required = true,
    };

    private static Option<global::Algolia.ApiKey?> ApiKey { get; } = new(
        name: @"--api-key")
    {
        Description = @"Used to compare fields of the `getApiKey` response on an `update` operation, to check if the `key` has been updated.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.GetApiKeyResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.GetApiKeyResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"wait-for-api-key", @"Wait for an API key operation
Waits for an API key to be added, updated, or deleted.");
                        command.Options.Add(Key);
                        command.Options.Add(Operation);
                        command.Options.Add(ApiKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var key = parseResult.GetRequiredValue(Key);
                        var operation = parseResult.GetRequiredValue(Operation);
                        var apiKey = parseResult.GetValue(ApiKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.WaitForApiKeyAsync(
                                    key: key,
                                    operation: operation,
                                    apiKey: apiKey,
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