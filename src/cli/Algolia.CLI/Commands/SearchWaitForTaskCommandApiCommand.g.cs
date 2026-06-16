#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchWaitForTaskCommandApiCommand
{
    private static Option<string> IndexName { get; } = new(
        name: @"--index-name")
    {
        Description = @"The name of the index on which the operation was performed.",
        Required = true,
    };

    private static Option<long> TaskID { get; } = new(
        name: @"--task-id")
    {
        Description = @"The taskID returned by the operation.",
        Required = true,
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
        var command = new Command(@"wait-for-task", @"Wait for operation to complete
Wait for a task to complete to ensure synchronized index updates.

All Algolia write operations are asynchronous. When you make a request for a write operation, for example, to add or update records in your index, Algolia creates a task on a queue and returns a taskID. The task itself runs separately, depending on the server load.
");
                        command.Options.Add(IndexName);
                        command.Options.Add(TaskID);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var taskID = parseResult.GetRequiredValue(TaskID);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.WaitForTaskAsync(
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