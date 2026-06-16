#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchGetLogsCommandApiCommand
{
    private static Option<int?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"First log entry to retrieve. The most recent entries are listed first.",
    };

    private static Option<int?> Length { get; } = new(
        name: @"--length")
    {
        Description = @"Maximum number of entries to retrieve.",
    };

    private static Option<global::Algolia.OneOf<string, object>?> IndexName { get; } = new(
        name: @"--index-name")
    {
        Description = @"Index for which to retrieve log entries.
By default, log entries are retrieved for all indices.
",
    };

    private static Option<global::Algolia.LogType?> Type { get; } = new(
        name: @"--type")
    {
        Description = @"Type of log entries to retrieve.
By default, all log entries are retrieved.
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.GetLogsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.GetLogsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-logs", @"Retrieve log entries
The request must be authenticated by an API key with the [`logs` ACL](https://www.algolia.com/doc/guides/security/api-keys/#access-control-list-acl).

- Logs are held for the last seven days.
- Up to 1,000 API requests per server are logged.
- This request counts towards your [operations quota](https://support.algolia.com/hc/articles/17245378392977-How-does-Algolia-count-records-and-operations) but doesn't appear in the logs itself.
");
                        command.Options.Add(Offset);
                        command.Options.Add(Length);
                        command.Options.Add(IndexName);
                        command.Options.Add(Type);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var offset = parseResult.GetValue(Offset);
                        var length = parseResult.GetValue(Length);
                        var indexName = parseResult.GetValue(IndexName);
                        var type = parseResult.GetValue(Type);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.GetLogsAsync(
                                    offset: offset,
                                    length: length,
                                    indexName: indexName,
                                    type: type,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Algolia.SourceGenerationContext.Default,
                                        @"Logs",
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