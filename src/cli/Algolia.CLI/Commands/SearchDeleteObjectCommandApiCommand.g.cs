#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchDeleteObjectCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Argument<string> ObjectID { get; } = new(
        name: @"object-id")
    {
        Description = @"Unique record identifier.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.DeleteObjectResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.DeleteObjectResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-object", @"Delete a record
Deletes a record by its object ID.

To delete more than one record, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/batch).
To delete records matching a query, use the [`deleteBy` operation](https://www.algolia.com/doc/rest-api/search/delete-by).
");
                        command.Arguments.Add(IndexName);
                        command.Arguments.Add(ObjectID);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var objectID = parseResult.GetRequiredValue(ObjectID);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.DeleteObjectAsync(
                                    indexName: indexName,
                                    objectID: objectID,
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