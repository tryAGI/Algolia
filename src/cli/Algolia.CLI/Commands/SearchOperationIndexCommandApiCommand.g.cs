#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchOperationIndexCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Option<global::Algolia.OperationType> Operation { get; } = new(
        name: @"--operation")
    {
        Description = @"Operation to perform on the index.",
        Required = true,
    };

    private static Option<string> Destination { get; } = new(
        name: @"--destination")
    {
        Description = @"Index name (case-sensitive).",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Algolia.ScopeType>?> Scope { get; } = new(
        name: @"--scope")
    {
        Description = @"**Only for copying.**

If you specify a scope, only the selected scopes are copied. Records and the other scopes are left unchanged.
If you omit the `scope` parameter, everything is copied: records, settings, synonyms, and rules.
",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.UpdatedAtResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.UpdatedAtResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"operation-index", @"Copy or move an index
Copies or moves (renames) an index within the same Algolia application.

Notes:
- Existing destination indices are overwritten, except for their analytics data.
- If the destination index doesn't exist yet, it's created.
- This operation is resource-intensive.

**Copy**

- If the source index doesn't exist, copying creates a new index with 0 records and default settings.
- API keys from the source index are merged with the existing keys in the destination index.
- You can't copy the `enableReRanking`, `mode`, and `replicas` settings.
- You can't copy to a destination index that already has replicas.
- Be aware of the [size limits](https://www.algolia.com/doc/guides/scaling/algolia-service-limits/#application-record-and-index-limits).
- For more information, see [Copy indices](https://www.algolia.com/doc/guides/sending-and-managing-data/manage-indices-and-apps/manage-indices/how-to/copy-indices).

**Move**

- If the source index doesn't exist, moving is ignored without returning an error.
- When moving an index, the analytics data keeps its original name, and a new set of analytics data is started for the new name.

  To access the original analytics in the dashboard, create an index with the original name.
- If the destination index has replicas, moving will overwrite the existing index and copy the data to the replica indices.
- For more information, see [Move indices](https://www.algolia.com/doc/guides/sending-and-managing-data/manage-indices-and-apps/manage-indices/how-to/move-indices).

This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
");
                        command.Arguments.Add(IndexName);
                        command.Options.Add(Operation);
                        command.Options.Add(Destination);
                        command.Options.Add(Scope);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.OperationIndexRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var operation = parseResult.GetRequiredValue(Operation);
                        var destination = parseResult.GetRequiredValue(Destination);
                        var scope = CliRuntime.WasSpecified(parseResult, Scope) ? parseResult.GetValue(Scope) : (__requestBase is { } __ScopeBaseValue ? __ScopeBaseValue.Scope : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.OperationIndexAsync(
                                    indexName: indexName,
                                    operation: operation,
                                    destination: destination,
                                    scope: scope,
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