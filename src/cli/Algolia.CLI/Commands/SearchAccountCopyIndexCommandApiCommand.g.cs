#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchAccountCopyIndexCommandApiCommand
{
    private static Option<string> SourceIndexName { get; } = new(
        name: @"--source-index-name")
    {
        Description = @"The name of the index to copy.",
        Required = true,
    };

    private static Option<string> DestinationAppID { get; } = new(
        name: @"--destination-app-id")
    {
        Description = @"The application ID to write the index to.",
        Required = true,
    };

    private static Option<string> DestinationApiKey { get; } = new(
        name: @"--destination-api-key")
    {
        Description = @"The API Key of the `destinationAppID` to write the index to, must have write ACLs.",
        Required = true,
    };

    private static Option<string> DestinationIndexName { get; } = new(
        name: @"--destination-index-name")
    {
        Description = @"The name of the index to write the copied index to.",
        Required = true,
    };

    private static Option<int?> BatchSize { get; } = new(
        name: @"--batch-size")
    {
        Description = @"The size of the chunk of `objects`. Defaults to 1,000.",
    };

    public static Command Create()
    {
        var command = new Command(@"account-copy-index", @"Copies the given `sourceIndexName` records, rules and synonyms to an other Algolia application for the given `destinationIndexName`
Copies the given `sourceIndexName` records, rules and synonyms to an other Algolia application for the given `destinationIndexName`.
");
                        command.Options.Add(SourceIndexName);
                        command.Options.Add(DestinationAppID);
                        command.Options.Add(DestinationApiKey);
                        command.Options.Add(DestinationIndexName);
                        command.Options.Add(BatchSize);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sourceIndexName = parseResult.GetRequiredValue(SourceIndexName);
                        var destinationAppID = parseResult.GetRequiredValue(DestinationAppID);
                        var destinationApiKey = parseResult.GetRequiredValue(DestinationApiKey);
                        var destinationIndexName = parseResult.GetRequiredValue(DestinationIndexName);
                        var batchSize = parseResult.GetValue(BatchSize);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Search.AccountCopyIndexAsync(
                                    sourceIndexName: sourceIndexName,
                                    destinationAppID: destinationAppID,
                                    destinationApiKey: destinationApiKey,
                                    destinationIndexName: destinationIndexName,
                                    batchSize: batchSize,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}