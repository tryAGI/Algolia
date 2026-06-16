#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchGetTaskCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Argument<long> TaskID { get; } = new(
        name: @"task-id")
    {
        Description = @"Unique task identifier.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.GetTaskResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.GetTaskResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-task", @"Check task status
Checks the status of a given task.

Indexing tasks are asynchronous.
When you add, update, or delete records or indices,
a task is created on a queue and completed depending on the load on the server.

The indexing tasks' responses include a task ID that you can use to check the status.
");
                        command.Arguments.Add(IndexName);
                        command.Arguments.Add(TaskID);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var taskID = parseResult.GetRequiredValue(TaskID);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.GetTaskAsync(
                                    indexName: indexName,
                                    taskID: taskID,
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