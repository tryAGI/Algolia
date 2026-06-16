#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchSetClientApiKeyCommandApiCommand
{
    private static Option<string> ApiKey { get; } = new(
        name: @"--api-key")
    {
        Description = @"API key to use for subsequent requests.",
        Required = true,
    };

    public static Command Create()
    {
        var command = new Command(@"set-client-api-key", @"Switch the API key used to authenticate requests
Switch the API key used to authenticate requests.
");
                        command.Options.Add(ApiKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var apiKey = parseResult.GetRequiredValue(ApiKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Search.SetClientApiKeyAsync(
                                    apiKey: apiKey,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}