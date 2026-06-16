#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchPartialUpdateObjectsWithTransformationCommandApiCommand
{
    private static Option<string> IndexName { get; } = new(
        name: @"--index-name")
    {
        Description = @"The `indexName` where to update `objects`.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<object>> Objects { get; } = new(
        name: @"--objects")
    {
        Description = @"The objects to update.",
        Required = true,
    };

    private static Option<bool?> CreateIfNotExists { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--create-if-not-exists",
        description: @"To be provided if non-existing objects are passed, otherwise, the call will fail.");

    private static Option<bool?> WaitForTasks { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--wait-for-tasks",
        description: @"Whether to wait until every `batch` task has been processed. This may take longer but is more reliable.");

    private static Option<int?> BatchSize { get; } = new(
        name: @"--batch-size")
    {
        Description = @"The size of the chunk of `objects`. The number of `batch` calls will be equal to `length(objects) / batchSize`. Defaults to 1,000.",
    };

    private static Option<object?> AlgoliaRequestOptions { get; } = new(
        name: @"--algolia-request-options")
    {
        Description = @"The request options to pass to the `batch` method.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::System.Collections.Generic.IList<global::Algolia.WatchResponse> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::System.Collections.Generic.IList<global::Algolia.WatchResponse> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"partial-update-objects-with-transformation", @"Save objects to an Algolia index by leveraging the Transformation pipeline setup using the Push connector (https://www.algolia.com/doc/guides/sending-and-managing-data/send-and-update-your-data/connectors/push)
Helper: Similar to the `partialUpdateObjects` method but requires a Push connector (https://www.algolia.com/doc/guides/sending-and-managing-data/send-and-update-your-data/connectors/push) to be created first, in order to transform records before indexing them to Algolia. The `region` must have been passed to the client instantiation method.
");
                        command.Options.Add(IndexName);
                        command.Options.Add(Objects);
                        command.Options.Add(CreateIfNotExists);
                        command.Options.Add(WaitForTasks);
                        command.Options.Add(BatchSize);
                        command.Options.Add(AlgoliaRequestOptions);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var objects = parseResult.GetRequiredValue(Objects);
                        var createIfNotExists = parseResult.GetValue(CreateIfNotExists);
                        var waitForTasks = parseResult.GetValue(WaitForTasks);
                        var batchSize = parseResult.GetValue(BatchSize);
                        var algoliaRequestOptions = parseResult.GetValue(AlgoliaRequestOptions);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.PartialUpdateObjectsWithTransformationAsync(
                                    indexName: indexName,
                                    objects: objects,
                                    createIfNotExists: createIfNotExists,
                                    waitForTasks: waitForTasks,
                                    batchSize: batchSize,
                                    algoliaRequestOptions: algoliaRequestOptions,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Algolia.SourceGenerationContext.Default,
                                        @"$self",
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