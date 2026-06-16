#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchBrowseObjectsCommandApiCommand
{
    private static Option<string> IndexName { get; } = new(
        name: @"--index-name")
    {
        Description = @"The name of the index on which the operation was performed.",
        Required = true,
    };

    private static Option<global::Algolia.BrowseParamsConfig> BrowseParams { get; } = new(
        name: @"--browse-params")
    {
        Description = @"Browse parameters.",
        Required = true,
    };

    public static Command Create()
    {
        var command = new Command(@"browse-objects", @"Get all records from an index
You can use the browse method to get records from an index—for example, to export your index as a backup. To export all records, use an empty query.

Use browse instead of search when exporting records from your index, when ranking, or analytics, isn't important. The Analytics API doesn't collect data when using browse.

Don't use this method for building a search UI. Use search instead.
");
                        command.Options.Add(IndexName);
                        command.Options.Add(BrowseParams);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var browseParams = parseResult.GetRequiredValue(BrowseParams);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Search.BrowseObjectsAsync(
                                    indexName: indexName,
                                    browseParams: browseParams,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}