#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static partial class SearchSaveRuleCommandApiCommand
{
    private static Argument<string> IndexName { get; } = new(
        name: @"index-name")
    {
        Description = @"Name of the index on which to perform the operation.",
    };

    private static Argument<string> ObjectID { get; } = new(
        name: @"object-id")
    {
        Description = @"Unique identifier of a rule object.",
    };

    private static Option<bool?> ForwardToReplicas { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--forward-to-replicas",
        description: @"Whether changes are applied to replica indices.");

    private static Option<string> RequestObjectID { get; } = new(
        name: @"--object-id")
    {
        Description = @"Unique identifier of a rule object.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Algolia.Condition>?> Conditions { get; } = new(
        name: @"--conditions")
    {
        Description = @"Conditions that trigger a rule.

Some consequences require specific conditions or don't require any condition.
For more information, see [Conditions](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#conditions).
",
    };

    private static Option<global::Algolia.Consequence> Consequence { get; } = new(
        name: @"--consequence")
    {
        Description = @"Effect of the rule.

For more information, see [Consequences](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/#consequences).
",
        Required = true,
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"Description of the rule's purpose to help you distinguish between different rules.",
    };

    private static Option<bool?> Enabled { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enabled",
        description: @"Whether the rule is active.");

    private static Option<global::System.Collections.Generic.IList<global::Algolia.TimeRange>?> Validity { get; } = new(
        name: @"--validity")
    {
        Description = @"Time periods when the rule is active.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"",
    };

    private static Option<string?> Scope { get; } = new(
        name: @"--scope")
    {
        Description = @"",
    };

    private static Option<global::Algolia.Condition?> Condition { get; } = new(
        name: @"--condition")
    {
        Description = @"",
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
        var command = new Command(@"save-rule", @"Create or replace a rule
If a rule with the specified object ID doesn't exist, it's created.
Otherwise, the existing rule is replaced.

To create or update more than one rule, use the [`batch` operation](https://www.algolia.com/doc/rest-api/search/save-rules).
");
                        command.Arguments.Add(IndexName);
                        command.Arguments.Add(ObjectID);
                        command.Options.Add(ForwardToReplicas);
                        command.Options.Add(RequestObjectID);
                        command.Options.Add(Conditions);
                        command.Options.Add(Consequence);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Enabled);
                        command.Options.Add(Validity);
                        command.Options.Add(Tags);
                        command.Options.Add(Scope);
                        command.Options.Add(Condition);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Algolia.Rule>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Algolia.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var indexName = parseResult.GetRequiredValue(IndexName);
                        var objectID = parseResult.GetRequiredValue(ObjectID);
                        var forwardToReplicas = parseResult.GetValue(ForwardToReplicas);
                        var requestObjectID = parseResult.GetRequiredValue(RequestObjectID);
                        var conditions = CliRuntime.WasSpecified(parseResult, Conditions) ? parseResult.GetValue(Conditions) : (__requestBase is { } __ConditionsBaseValue ? __ConditionsBaseValue.Conditions : default);
                        var consequence = parseResult.GetRequiredValue(Consequence);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var enabled = CliRuntime.WasSpecified(parseResult, Enabled) ? parseResult.GetValue(Enabled) : (__requestBase is { } __EnabledBaseValue ? __EnabledBaseValue.Enabled : default);
                        var validity = CliRuntime.WasSpecified(parseResult, Validity) ? parseResult.GetValue(Validity) : (__requestBase is { } __ValidityBaseValue ? __ValidityBaseValue.Validity : default);
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : (__requestBase is { } __TagsBaseValue ? __TagsBaseValue.Tags : default);
                        var scope = CliRuntime.WasSpecified(parseResult, Scope) ? parseResult.GetValue(Scope) : (__requestBase is { } __ScopeBaseValue ? __ScopeBaseValue.Scope : default);
                        var condition = CliRuntime.WasSpecified(parseResult, Condition) ? parseResult.GetValue(Condition) : (__requestBase is { } __ConditionBaseValue ? __ConditionBaseValue.Condition : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Search.SaveRuleAsync(
                                    indexName: indexName,
                                    objectID: objectID,
                                    forwardToReplicas: forwardToReplicas,
                                    requestObjectID: requestObjectID,
                                    conditions: conditions,
                                    consequence: consequence,
                                    description: description,
                                    enabled: enabled,
                                    validity: validity,
                                    tags: tags,
                                    scope: scope,
                                    condition: condition,
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