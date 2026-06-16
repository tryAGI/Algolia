#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchReplaceAllObjectsWithTransformationCommandApiCommand
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

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.ReplaceAllObjectsWithTransformationResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.ReplaceAllObjectsWithTransformationResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"replace-all-objects-with-transformation", @"Replace all records in an index
Replace all records in your index with a new set of records by using the Transformation pipeline in the Push connector (https://www.algolia.com/doc/guides/sending-and-managing-data/send-and-update-your-data/connectors/push).

This method replaces all records without downtime. It performs these operations:

  1. Copy settings, synonyms, and rules from your original index to a temporary index.
  2. Add your new records to the temporary index.
  3. Replace your original index with the temporary index.

Notes:
- Use the `safe` parameter to run these (asynchronous) operations in sequence.
- If there's an error during one of these steps, the temporary index isn't deleted.
- This operation is rate-limited.
- This method creates a temporary index, which temporarily doubles your record count.
- Algolia doesn't count the three days with the highest number of records toward your monthly usage.
- If you're on a legacy plan (before July 2020), this method counts two operations toward your usage (in addition to the number of records): `copySettings` and `moveIndex`.
- The API key you use for this operation must have access to the index `YourIndex` and the temporary index `YourIndex_tmp`.
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


                                var response = await client.Search.ReplaceAllObjectsWithTransformationAsync(
                                    indexName: indexName,
                                    objects: objects,
                                    batchSize: batchSize,
                                    scopes: scopes,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Algolia.SourceGenerationContext.Default,
                                        @"WatchResponses",
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