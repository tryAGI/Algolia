#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchGetObjectCommandApiCommand
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

    private static Option<global::System.Collections.Generic.IList<string>?> AttributesToRetrieve { get; } = new(
        name: @"--attributes-to-retrieve")
    {
        Description = @"Attributes to include with the records in the response.
This is useful to reduce the size of the API response.
By default, all retrievable attributes are returned.

`objectID` is always retrieved.

Attributes included in `unretrievableAttributes`
won't be retrieved unless the request is authenticated with the admin API key.
",
    };

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-object", @"Retrieve a record
Retrieves one record by its object ID.

To retrieve more than one record, use the [`objects` operation](https://www.algolia.com/doc/rest-api/search/get-objects).
");
                        command.Arguments.Add(IndexName);
                        command.Arguments.Add(ObjectID);
                        command.Options.Add(AttributesToRetrieve);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var objectID = parseResult.GetRequiredValue(ObjectID);
                        var attributesToRetrieve = parseResult.GetValue(AttributesToRetrieve);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.GetObjectAsync(
                                    indexName: indexName,
                                    objectID: objectID,
                                    attributesToRetrieve: attributesToRetrieve,
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