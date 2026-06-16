#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchChunkedBatchCommandApiCommand
{
    private static Option<string> IndexName { get; } = new(
        name: @"--index-name")
    {
        Description = @"The `indexName` to replace `objects` in.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<object>> Objects { get; } = new(
        name: @"--objects")
    {
        Description = @"List of objects to replace the current objects with.",
        Required = true,
    };

    private static Option<global::Algolia.Action?> ActionOption { get; } = new(
        name: @"--action")
    {
        Description = @"The `batch` `action` to perform on the given array of `objects`, defaults to `addObject`.",
    };

    private static Option<bool?> WaitForTasks { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--wait-for-tasks",
        description: @"Whether to wait until every `batch` task has been processed. This may take longer but is more reliable.");

    private static Option<int?> BatchSize { get; } = new(
        name: @"--batch-size")
    {
        Description = @"The size of the chunk of `objects`. The number of `batch` calls will be equal to `length(objects) / batchSize`. Defaults to 1,000.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::System.Collections.Generic.IList<global::Algolia.BatchResponse> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::System.Collections.Generic.IList<global::Algolia.BatchResponse> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"chunked-batch", @"Replace all records in an index
Helper: Chunks the given `objects` list in subset of 1000 elements max in order to make it fit in `batch` requests.
");
                        command.Options.Add(IndexName);
                        command.Options.Add(Objects);
                        command.Options.Add(ActionOption);
                        command.Options.Add(WaitForTasks);
                        command.Options.Add(BatchSize);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var objects = parseResult.GetRequiredValue(Objects);
                        var action = parseResult.GetValue(ActionOption);
                        var waitForTasks = parseResult.GetValue(WaitForTasks);
                        var batchSize = parseResult.GetValue(BatchSize);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.ChunkedBatchAsync(
                                    indexName: indexName,
                                    objects: objects,
                                    action: action,
                                    waitForTasks: waitForTasks,
                                    batchSize: batchSize,
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