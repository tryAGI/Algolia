#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchReplaceAllObjectsCommandApiCommand
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

    private static Option<int?> BatchSize { get; } = new(
        name: @"--batch-size")
    {
        Description = @"The size of the chunk of `objects`. The number of `batch` calls will be equal to `length(objects) / batchSize`. Defaults to 1,000.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Algolia.ScopeType>?> Scopes { get; } = new(
        name: @"--scopes")
    {
        Description = @"List of scopes to keep in the index. Defaults to `settings`, `synonyms`, and `rules`.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.ReplaceAllObjectsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.ReplaceAllObjectsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"replace-all-objects", @"Replace all records in an index
This method replaces all records in an index without interrupting ongoing searches.

It combines [batch](https://www.algolia.com/doc/rest-api/search/batch) and [copy/move](https://www.algolia.com/doc/rest-api/search/operation-index) index operations:
1. Copy settings, synonyms, and rules to a temporary index.
2. Add the records from the `objects` parameter to the temporary index.
3. Replace the original index with the temporary one.

Notes:
- If there's an error during one of these steps, the temporary index is deleted if your API key has the `deleteIndex` ACL.
- If your API key restricts access to specific indices, make sure it also grants access to the temporary index `INDEX_NAME_tmp_*` (replace `INDEX_NAME` with the name of your original index).
- This method is subject to [indexing rate limits](https://support.algolia.com/hc/en-us/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
- The response includes the results of the individual API requests.
- This method creates a temporary index, which temporarily doubles your record count.
- Algolia doesn't count the three days with the highest number of records toward your monthly usage.
");
                        command.Options.Add(IndexName);
                        command.Options.Add(Objects);
                        command.Options.Add(BatchSize);
                        command.Options.Add(Scopes);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var objects = parseResult.GetRequiredValue(Objects);
                        var batchSize = parseResult.GetValue(BatchSize);
                        var scopes = parseResult.GetValue(Scopes);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.ReplaceAllObjectsAsync(
                                    indexName: indexName,
                                    objects: objects,
                                    batchSize: batchSize,
                                    scopes: scopes,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Algolia.SourceGenerationContext.Default,
                                        @"BatchResponses",
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