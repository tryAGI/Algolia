#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchPartialUpdateObjectCommandApiCommand
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

    private static Option<bool?> CreateIfNotExists { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--create-if-not-exists",
        description: @"Whether to create a new record if it doesn't exist.");
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

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.PartialUpdateObjectResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.PartialUpdateObjectResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"partial-update-object", @"Add or update attributes
Adds new attributes to a record, or updates existing ones.

- If a record with the specified object ID doesn't exist,

  a new record is added to the index **if** `createIfNotExists` is true.
- If the index doesn't exist yet, this method creates a new index.
- Use first-level attributes only. Nested attributes aren't supported.

  If you specify a nested attribute, this operation replaces its first-level ancestor.

To update attributes without replacing the full record, use these built-in operations.
These operations are useful when the initial data isn't available.

- `Increment`: increment a numeric attribute.
- `Decrement`: decrement a numeric attribute.
- `Add`: append a number or string element to an array attribute.
- `Remove`: remove all matching number or string elements from an array attribute made of numbers or strings.
- `AddUnique`: add a number or string element to an array attribute made of numbers or strings only if it's not already present.
- `IncrementFrom`: increment a numeric integer attribute only if the provided value matches the current value. Otherwise, the update is ignored.

  Example: If you pass an `IncrementFrom` value of 2 for the `version` attribute but the current value is 1, the API ignores the update.
  If the object doesn't exist, the API only creates it if you pass an `IncrementFrom` value of 0.
- `IncrementSet`: increment a numeric integer attribute only if the provided value is greater than the current value. Otherwise, the update is ignored.

  Example: If you pass an `IncrementSet` value of 2 for the `version` attribute and the current value is 1, the API updates the object.
  If the object doesn't exist yet, the API only creates it if you pass an `IncrementSet` value greater than 0.

Specify an operation by providing an object with the attribute to update as the key and its value as an object with these properties:

- `_operation`: the operation to apply on the attribute.
- `value`: the right-hand side argument to the operation, for example, increment or decrement step, or a value to add or remove.

When updating multiple attributes or using multiple operations targeting the same record, use a single partial update for faster processing.

This operation is subject to [indexing rate limits](https://support.algolia.com/hc/articles/4406975251089-Is-there-a-rate-limit-for-indexing-on-Algolia).
");
                        command.Arguments.Add(IndexName);
                        command.Arguments.Add(ObjectID);
                        command.Options.Add(CreateIfNotExists);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount != 1)
              {
                  result.AddError(@"Specify exactly one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var objectID = parseResult.GetRequiredValue(ObjectID);
                        var createIfNotExists = parseResult.GetValue(CreateIfNotExists);
                        var request = await CliRuntime.ReadRequestAsync<object>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.PartialUpdateObjectAsync(
                                    indexName: indexName,
                                    objectID: objectID,
                                    createIfNotExists: createIfNotExists,
                                    request: request,
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