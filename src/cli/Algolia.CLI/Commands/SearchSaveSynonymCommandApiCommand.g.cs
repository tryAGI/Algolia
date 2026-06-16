#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchSaveSynonymCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Argument<string> ObjectID { get; } = new(
        name: @"object-id")
    {
        Description = @"Unique identifier of a synonym object.",
    };

    private static Option<bool?> ForwardToReplicas { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--forward-to-replicas",
        description: @"Whether changes are applied to replica indices.");

    private static Option<string> RequestObjectID { get; } = new(
        name: @"--object-id")
    {
        Description = @"Unique identifier of a synonym object.",
        Required = true,
    };

    private static Option<global::Algolia.SynonymType> Type { get; } = new(
        name: @"--type")
    {
        Description = @"Synonym type.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Synonyms { get; } = new(
        name: @"--synonyms")
    {
        Description = @"Words or phrases considered equivalent.",
    };

    private static Option<string?> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Word or phrase to appear in query strings (for [`onewaysynonym`s](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/one-way-synonyms)).",
    };

    private static Option<string?> Word { get; } = new(
        name: @"--word")
    {
        Description = @"Word or phrase to appear in query strings (for [`altcorrection1` and `altcorrection2`](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-alternative-corrections)).",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Corrections { get; } = new(
        name: @"--corrections")
    {
        Description = @"Words to be matched in records.",
    };

    private static Option<string?> Placeholder { get; } = new(
        name: @"--placeholder")
    {
        Description = @"[Placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders) to be put inside records.
",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Replacements { get; } = new(
        name: @"--replacements")
    {
        Description = @"Query words that will match the [placeholder token](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/adding-synonyms/in-depth/synonyms-placeholders).",
    };
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
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

                    private static string FormatResponse(ParseResult parseResult, global::Algolia.SaveSynonymResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Algolia.SaveSynonymResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"save-synonym", @"Create or replace a synonym
If a synonym with the specified object ID doesn't exist, Algolia adds a new one.
Otherwise, the existing synonym is replaced.
To add multiple synonyms in a single API request, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/save-synonyms).
");
                        command.Arguments.Add(IndexName);
                        command.Arguments.Add(ObjectID);
                        command.Options.Add(ForwardToReplicas);
                        command.Options.Add(RequestObjectID);
                        command.Options.Add(Type);
                        command.Options.Add(Synonyms);
                        command.Options.Add(InputOption);
                        command.Options.Add(Word);
                        command.Options.Add(Corrections);
                        command.Options.Add(Placeholder);
                        command.Options.Add(Replacements);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.SynonymHit>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var objectID = parseResult.GetRequiredValue(ObjectID);
                        var forwardToReplicas = parseResult.GetValue(ForwardToReplicas);
                        var requestObjectID = parseResult.GetRequiredValue(RequestObjectID);
                        var type = parseResult.GetRequiredValue(Type);
                        var synonyms = CliRuntime.WasSpecified(parseResult, Synonyms) ? parseResult.GetValue(Synonyms) : (__requestBase is { } __SynonymsBaseValue ? __SynonymsBaseValue.Synonyms : default);
                        var input = CliRuntime.WasSpecified(parseResult, InputOption) ? parseResult.GetValue(InputOption) : (__requestBase is { } __InputBaseValue ? __InputBaseValue.Input : default);
                        var word = CliRuntime.WasSpecified(parseResult, Word) ? parseResult.GetValue(Word) : (__requestBase is { } __WordBaseValue ? __WordBaseValue.Word : default);
                        var corrections = CliRuntime.WasSpecified(parseResult, Corrections) ? parseResult.GetValue(Corrections) : (__requestBase is { } __CorrectionsBaseValue ? __CorrectionsBaseValue.Corrections : default);
                        var placeholder = CliRuntime.WasSpecified(parseResult, Placeholder) ? parseResult.GetValue(Placeholder) : (__requestBase is { } __PlaceholderBaseValue ? __PlaceholderBaseValue.Placeholder : default);
                        var replacements = CliRuntime.WasSpecified(parseResult, Replacements) ? parseResult.GetValue(Replacements) : (__requestBase is { } __ReplacementsBaseValue ? __ReplacementsBaseValue.Replacements : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.SaveSynonymAsync(
                                    indexName: indexName,
                                    objectID: objectID,
                                    forwardToReplicas: forwardToReplicas,
                                    requestObjectID: requestObjectID,
                                    type: type,
                                    synonyms: synonyms,
                                    input: input,
                                    word: word,
                                    corrections: corrections,
                                    placeholder: placeholder,
                                    replacements: replacements,
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